# set the base folder of this project
global.basefolder = "#{__dirname}"

# use our tweaked version of gulp with iced coffee.
require './src/gulp_modules/gulp.iced'

# tasks required for this build 
Tasks "dotnet",  # compiling dotnet
  "typescript",  # compiling typescript
  "test",        # running tests
  "regeneration" # regenerating expected files
  "publishing"   # signing/publishing binaries to github and npm registry

# Settings
Import
  solution: "#{basefolder}/AutoRest.sln"
  packages: "#{basefolder}/packages"
  release_name: if argv.nightly then "#{version}-#{today}-2300-nightly"              else if argv.preview then "#{version}-#{now}-preview"              else "#{version}"
  package_name: if argv.nightly then "autorest-#{version}-#{today}-2300-nightly.zip" else if argv.preview then "autorest-#{version}-#{now}-preview.zip" else "autorest-#{version}.zip"
  autorest: (args,done) ->
    # Run AutoRest from the original current directory.
    echo info "AutoRest #{args.join(' ')}"
    execute "dotnet #{basefolder}/src/core/AutoRest/bin/#{configuration}/netcoreapp1.0/AutoRest.dll #{args.join(' ')}" , {silent:true}, (code,stdout,stderr) ->
      return done()

  # which projects to care about
  projects:() ->
    source 'src/**/*.csproj'
      .pipe except /preview/ig

  # test projects 
  tests:() ->
    source 'src/**/*[Tt]ests.csproj'
      .pipe except /AutoRest.Tests/ig #not used yet.
      .pipe except /AutoRest.AzureResourceSchema.Tests/ig
      #.pipe except /AutoRest.Swagger.Tests/ig
    
  # assemblies that we sign
  assemblies: () -> 
    source "src/core/AutoRest/bin/#{configuration}/netcoreapp1.0/publish/**/AutoRest*"
      .pipe except /pdb$/i
      .pipe except /json$/i
      .pipe except /so$/i
      .pipe onlyFiles()

  packagefiles: () -> 
    source "src/core/AutoRest/bin/#{configuration}/netcoreapp1.0/publish/**"
      .pipe except /pdb$/i
      .pipe onlyFiles()
  
  typescriptProjectFolders: ()->
    source ["src/autorest-core", "src/autorest" ,"src/vscode-autorest/server","src/vscode-autorest"]

  typescriptProjects: () -> 
    typescriptProjectFolders()
      .pipe foreach (each,next,more)=>
        source "#{each.path}/tsconfig.json"
          .on 'end', -> 
            next null
          .pipe foreach (e,n)->
            more.push e
            n null

  generatedFiles: () -> 
    typescriptProjectFolders()
      .pipe foreach (each,next,more)=>
        source(["#{each.path}/**/*.js","#{each.path}/**/*.d.ts" ,"#{each.path}/**/*.js.map", "!#{each.path}/node_modules/**"])
          .on 'end', -> 
            next null
          .pipe foreach (e,n)->
            more.push e
            n null
        
  typescriptFiles: () -> 
    typescriptProjectFolders()
      .pipe foreach (each,next,more)=>
        source(["#{each.path}/**/*.ts", "#{each.path}/**/*.json", "!#{each.path}/node_modules/**"])
          .on 'end', -> 
            next null
          .pipe foreach (e,n)->
            e.base = each.base
            more.push e
            n null

task 'install-binaries', '', (done)->
  mkdir "-p", "#{os.homedir()}/.autorest/plugins/autorest/#{version}-#{now}-private"
  source "src/core/AutoRest/bin/#{configuration}/netcoreapp1.0/publish/**"
    .pipe destination "#{os.homedir()}/.autorest/plugins/autorest/#{version}-#{now}-private" 

task 'install', 'build and install the dev version of autorest',(done)->
  run [ 'build/typescript', 'build/dotnet/binaries' ],
    'install-node-files',
    'install-binaries',
    -> done()

task 'autorestcli', '', ['build/typescript'],(done)->
  require "#{basefolder}/src/autorest/app.js"

task 'autorest', 'Runs AutoRest', (done) ->
  args = process.argv.slice(3)
  exec "dotnet #{basefolder}/src/core/AutoRest/bin/#{configuration}/netcoreapp1.0/AutoRest.dll #{args.join(' ')}" , {cwd: process.env.INIT_CWD}, (code,stdout,stderr) ->
    return done()

task 'autorest-cli', "Runs AutoRest (via node)" ,(done)->
  args = process.argv.slice(3)
  exec "node #{basefolder}/src/core/AutoRest/bin/#{configuration}/netcoreapp1.0/node_modules/autorest-core/index.js #{args.join(' ')}" , {cwd: process.env.INIT_CWD}, (code,stdout,stderr) ->
    return done()


task 'init', "" ,(done)->
  # is the main node_modules out of date?
  doit = true if (newer "#{basefolder}/package.json",  "#{basefolder}/node_modules") or (! test '-d', "#{basefolder}/src/autorest/node_modules/autorest-core") or (! test '-d', "#{basefolder}/src/vscode-autorest/server/node_modules/autorest")

  typescriptProjectFolders()
    .on 'end', -> 
      if doit
        echo warning "\n#{ info 'NOTE:' } 'node_modules' may be out of date - running 'npm install' for you.\n"
        exec "npm install",{silent:false},(c,o,e)->
          # after npm, hookup symlinks/junctions for dependent packages in projects
          if ! test '-d', "#{basefolder}/src/autorest/node_modules/autorest-core"
            fs.symlinkSync "#{basefolder}/src/autorest-core", "#{basefolder}/src/autorest/node_modules/autorest-core",'junction' 

          if ! test '-d', "#{basefolder}/src/vscode-autorest/server/node_modules/autorest"        
            fs.symlinkSync "#{basefolder}/src/autorest", "#{basefolder}/src/vscode-autorest/server/node_modules/autorest",'junction'         

          done null
      else 
        done null

    .pipe foreach (each,next) -> 
      # is any of the TS projects node_modules out of date?
      doit = true if (! test "-d", "#{each.path}/node_modules") or (newer "#{each.path}/package.json",  "#{each.path}/node_modules")
      next null

  return null
