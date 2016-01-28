# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.service_client import ServiceClient
from msrest import Serializer, Deserializer
from msrestazure import AzureConfiguration
from .operations.group_operations import GroupOperations
from . import models


class MicrosoftAzureTestUrlConfiguration(AzureConfiguration):
    """Configuration for MicrosoftAzureTestUrl

    :param credentials: Gets Azure subscription credentials.
    :type credentials: credentials
    :param subscription_id: Subscription Id.
    :type subscription_id: str
    :param api_version: API Version with value '2014-04-01-preview'.
    :type api_version: str or None
    :param accept_language: Gets or sets the preferred language for the
     response.
    :type accept_language: str or None
    :param long_running_operation_retry_timeout: Gets or sets the retry
     timeout in seconds for Long Running Operations. Default value is 30.
    :type long_running_operation_retry_timeout: int or None
    :param generate_client_request_id: When set to true a unique
     x-ms-client-request-id value is generated and included in each request.
     Default is true.
    :type generate_client_request_id: bool or None
    :param str base_url: Service URL
    :param str filepath: Existing config
    """

    def __init__(
            self, credentials, subscription_id, api_version='2014-04-01-preview', accept_language='en-US', long_running_operation_retry_timeout=30, generate_client_request_id=True, base_url=None, filepath=None):

        if credentials is None:
            raise ValueError('credentials must not be None.')
        if subscription_id is None:
            raise ValueError('subscription_id must not be None.')
        if not base_url:
            base_url = 'https://management.azure.com/'

        super(MicrosoftAzureTestUrlConfiguration, self).__init__(base_url, filepath)

        self.user_agent = 'microsoft_azure_test_url/2014-04-01-preview'

        self.credentials = credentials
        self.subscription_id = subscription_id
        self.api_version = api_version
        self.accept_language = accept_language
        self.long_running_operation_retry_timeout = long_running_operation_retry_timeout
        self.generate_client_request_id = generate_client_request_id


class MicrosoftAzureTestUrl(object):
    """Some cool documentation.

    :param config: Configuration for client.
    :type config: MicrosoftAzureTestUrlConfiguration
    """

    def __init__(self, config):

        self._client = ServiceClient(config.credentials, config)

        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}
        self._serialize = Serializer()
        self._deserialize = Deserializer(client_models)

        self.config = config
        self.group = GroupOperations(
            self._client, self.config, self._serialize, self._deserialize)
