# encoding: utf-8
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
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

module HeaderModule
  autoload :Header,                                             'header/header.rb'
  autoload :AutoRestSwaggerBATHeaderService,                    'header/auto_rest_swagger_batheader_service.rb'

  module Models
    autoload :Error,                                              'header/models/error.rb'
    autoload :GreyscaleColors,                                    'header/models/greyscale_colors.rb'
  end
end
