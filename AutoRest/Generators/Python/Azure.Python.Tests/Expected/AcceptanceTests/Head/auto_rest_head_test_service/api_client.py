# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.service_client import ServiceClient
from msrest import Serializer, Deserializer
from msrestazure import AzureConfiguration
from .operations.http_success_operations import http_successOperations


class AutoRestHeadTestServiceConfiguration(AzureConfiguration):

    def __init__(
            self, credentials, accept_language='en-US', long_running_operation_retry_timeout=None, base_url=None, filepath=None):

        if not base_url:
            base_url = 'http://localhost'

        super(AutoRestHeadTestServiceConfiguration, self).__init__(base_url, filepath)

        self.credentials = credentials
        self.accept_language = accept_language
        self.long_running_operation_retry_timeout = long_running_operation_retry_timeout


class AutoRestHeadTestService(object):

    def __init__(self, config):

        self._client = ServiceClient(config.credentials, config)

        client_models = {}
        self._serialize = Serializer()
        self._deserialize = Deserializer(client_models)

        self.config = config
        self.http_success = http_successOperations(
            self._client, self.config, self._serialize, self._deserialize)
