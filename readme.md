# <img align="center" src="./docs/images/logo.png"> AutoRest

The **AutoRest** tool generates client libraries for accessing RESTful web services. Input to *AutoRest* is a spec that describes the REST API using the [OpenAPI Specification](https://github.com/OAI/OpenAPI-Specification) format.

## Packages
| Name                                            | Latest                                                       | Next                                                              |
| ----------------------------------------------- | ------------------------------------------------------------ | ----------------------------------------------------------------- |
| Core functionality                              |
| [autorest][autorest_src]                        | ![](https://img.shields.io/npm/v/autorest)                   | ![](https://img.shields.io/npm/v/autorest/next)                   |
| [@autorest/core][core_src]                      | ![](https://img.shields.io/npm/v/@autorest/core)             | ![](https://img.shields.io/npm/v/@autorest/core/next)             |
| [@autorest/modelerfour][modelerfour_src]        | ![](https://img.shields.io/npm/v/@autorest/modelerfour)      | ![](https://img.shields.io/npm/v/@autorest/modelerfour/next)      |
| Language generators                             |
| [@autorest/csharp][csharp_src]                  | ![](https://img.shields.io/npm/v/@autorest/csharp)           | ![](https://img.shields.io/npm/v/@autorest/csharp/next)           |
| [@autorest/go][go_src]                          | ![](https://img.shields.io/npm/v/@autorest/go)               | ![](https://img.shields.io/npm/v/@autorest/go/next)               |
| [@autorest/java][java_src]                      | ![](https://img.shields.io/npm/v/@autorest/java)             | ![](https://img.shields.io/npm/v/@autorest/java/next)             |
| [@autorest/python][python_src]                  | ![](https://img.shields.io/npm/v/@autorest/python)           | ![](https://img.shields.io/npm/v/@autorest/python/next)           |
| [@autorest/swift][swift_src]                    | ![](https://img.shields.io/npm/v/@autorest/swift)            | ![](https://img.shields.io/npm/v/@autorest/swift/next)            |
| [@autorest/typescript][typescript_src]          | ![](https://img.shields.io/npm/v/@autorest/typescript)       | ![](https://img.shields.io/npm/v/@autorest/typescript/next)       |
| Internal packages                               |
| [@autorest/codemodel][codemodel_src]            | ![](https://img.shields.io/npm/v/@autorest/codemodel)        | ![](https://img.shields.io/npm/v/@autorest/codemodel/next)        |
| [@autorest/common][common_src]                  | ![](https://img.shields.io/npm/v/@autorest/common)           | ![](https://img.shields.io/npm/v/@autorest/common/next)           |
| [@autorest/configuration][configuration_src]    | ![](https://img.shields.io/npm/v/@autorest/configuration)    | ![](https://img.shields.io/npm/v/@autorest/configuration/next)    |
| [@autorest/extension-base][extension_base_src]  | ![](https://img.shields.io/npm/v/@autorest/extension-base)   | ![](https://img.shields.io/npm/v/@autorest/extension-base/next)   |
| [@azure-tools/extension][extension_src]         | ![](https://img.shields.io/npm/v/@azure-tools/extension)     | ![](https://img.shields.io/npm/v/@azure-tools/extension/next)     |
| [@azure-tools/codegen][codegen_src]             | ![](https://img.shields.io/npm/v/@azure-tools/codegen)       | ![](https://img.shields.io/npm/v/@azure-tools/codegen/next)       |
| [@azure-tools/openapi][openapi_src]             | ![](https://img.shields.io/npm/v/@azure-tools/openapi)       | ![](https://img.shields.io/npm/v/@azure-tools/openapi/next)       |
| [@azure-tools/deduplication][deduplication_src] | ![](https://img.shields.io/npm/v/@azure-tools/deduplication) | ![](https://img.shields.io/npm/v/@azure-tools/deduplication/next) |
| [@azure-tools/datastore][datastore_src]         | ![](https://img.shields.io/npm/v/@azure-tools/datastore)     | ![](https://img.shields.io/npm/v/@azure-tools/datastore/next)     |
| [@azure-tools/oai2-to-oai3][oai2-to-oai3_src]   | ![](https://img.shields.io/npm/v/@azure-tools/oai2-to-oai3)  | ![](https://img.shields.io/npm/v/@azure-tools/oai2-to-oai3/next)  |

[autorest_src]: packages/apps/autorest
[core_src]: packages/extensions/core
[modelerfour_src]: packages/extensions/modelerfour
[csharp_src]: https://github.com/Azure/autorest.csharp
[python_src]: https://github.com/Azure/autorest.python
[go_src]: https://github.com/Azure/autorest.go
[java_src]: https://github.com/Azure/autorest.java
[swift_src]: https://github.com/Azure/autorest.swift
[typescript_src]: https://github.com/Azure/autorest.typescript
[codemodel_src]: packages/libs/codemodel
[common_src]: packages/libs/common
[configuration_src]: packages/libs/configuration
[extension_base_src]: packages/libs/extension-base
[extension_src]: packages/libs/extension
[codegen_src]: packages/libs/codegen
[openapi_src]: packages/libs/openapi
[deduplication_src]: packages/libs/deduplication
[datastore_src]: packages/libs/datastore
[oai2-to-oai3_src]: packages/libs/oai2-to-oai3


## Support Policy

AutoRest is an open source tool -- if you need assistance, first check the documentation. If you find a bug or need some help, feel free to submit an [issue](https://github.com/Azure/autorest/issues)

## Getting Started using AutoRest ![image](./docs/images/normal.png)

View our [docs readme][docs_readme] as a starting point to find both general information and language-generator specific information

## Contributing

### Contributing guide

Check our [internal developer docs](./docs/internal/readme.md) to learn about our development process, how to propose bugfixes and improvements, and how to build and test your changes to Autorest.

### Code of Conduct

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

<!--LINKS-->
[docs_readme]: docs/readme.md

