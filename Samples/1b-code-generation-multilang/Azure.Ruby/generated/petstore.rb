# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

require 'uri'
require 'cgi'
require 'date'
require 'json'
require 'base64'
require 'erb'
require 'securerandom'
require 'time'
require 'timeliness'
require 'faraday'
require 'faraday-cookie_jar'
require 'concurrent'
require 'ms_rest'
require 'generated/petstore/module_definition'
require 'ms_rest_azure'

module Petstore
  autoload :SwaggerPetstore,                                    'generated/petstore/swagger_petstore.rb'

  module Models
    autoload :Error,                                              'generated/petstore/models/error.rb'
    autoload :Pet,                                                'generated/petstore/models/pet.rb'
  end
end
