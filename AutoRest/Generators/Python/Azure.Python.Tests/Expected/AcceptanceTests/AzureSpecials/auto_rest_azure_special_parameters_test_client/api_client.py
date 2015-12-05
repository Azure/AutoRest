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
from .operations.xms_client_request_id_operations import xms_client_request_idOperations
from .operations.subscription_in_credentials_operations import subscription_in_credentialsOperations
from .operations.subscription_in_method_operations import subscription_in_methodOperations
from .operations.api_version_default_operations import api_version_defaultOperations
from .operations.api_version_local_operations import api_version_localOperations
from .operations.skip_url_encoding_operations import skip_url_encodingOperations
from .operations.header_operations import headerOperations
from . import models


class AutoRestAzureSpecialParametersTestClientConfiguration(AzureConfiguration):

    def __init__(
            self, credentials, subscription_id, api_version='2015-07-01-preview', accept_language='en-US', long_running_operation_retry_timeout=None, base_url=None, filepath=None):

        if credentials is None:
            raise ValueError('credentials must not be None.')
        if subscription_id is None:
            raise ValueError('subscription_id must not be None.')
        if not base_url:
            base_url = 'http://localhost'

        super(AutoRestAzureSpecialParametersTestClientConfiguration, self).__init__(base_url, filepath)

        self.user_agent = 'auto_rest_azure_special_parameters_test_client/2015-07-01-preview'

        self.credentials = credentials
        self.subscription_id = subscription_id
        self.api_version = api_version
        self.accept_language = accept_language
        self.long_running_operation_retry_timeout = long_running_operation_retry_timeout


class AutoRestAzureSpecialParametersTestClient(object):

    def __init__(self, config):

        self._client = ServiceClient(config.credentials, config)

        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}
        self._serialize = Serializer()
        self._deserialize = Deserializer(client_models)

        self.config = config
        self.xms_client_request_id = xms_client_request_idOperations(
            self._client, self.config, self._serialize, self._deserialize)
        self.subscription_in_credentials = subscription_in_credentialsOperations(
            self._client, self.config, self._serialize, self._deserialize)
        self.subscription_in_method = subscription_in_methodOperations(
            self._client, self.config, self._serialize, self._deserialize)
        self.api_version_default = api_version_defaultOperations(
            self._client, self.config, self._serialize, self._deserialize)
        self.api_version_local = api_version_localOperations(
            self._client, self.config, self._serialize, self._deserialize)
        self.skip_url_encoding = skip_url_encodingOperations(
            self._client, self.config, self._serialize, self._deserialize)
        self.header = headerOperations(
            self._client, self.config, self._serialize, self._deserialize)
