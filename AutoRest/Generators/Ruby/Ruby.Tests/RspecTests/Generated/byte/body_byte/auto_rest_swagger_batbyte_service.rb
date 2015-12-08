# encoding: utf-8
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module ByteModule
  #
  # A service client - single point of access to the REST API.
  #
  class AutoRestSwaggerBATByteService < MsRest::ServiceClient
    include ByteModule::Models

    # @return [String] the base URI of the service.
    attr_accessor :base_url

    # @return byte
    attr_reader :byte

    #
    # Creates initializes a new instance of the AutoRestSwaggerBATByteService class.
    # @param credentials [MsRest::ServiceClientCredentials] credentials to authorize HTTP requests made by the service client.
    # @param base_url [String] the base URI of the service.
    # @param options [Array] filters to be applied to the HTTP requests.
    #
    def initialize(credentials, base_url = nil, options = nil)
      super(credentials, options)
      @base_url = base_url || 'http://localhost'

      fail ArgumentError, 'credentials is nil' if credentials.nil?
      fail ArgumentError, 'invalid type of credentials input parameter' unless credentials.is_a?(MsRest::ServiceClientCredentials)
      @credentials = credentials

      @byte = Byte.new(self)
    end

  end
end
