# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.service_client import ServiceClient
from msrest import Serializer, Deserializer
from msrestazure import AzureConfiguration
from .version import VERSION
from .operations.duration_operations import DurationOperations
from . import models


class AutoRestDurationTestServiceConfiguration(AzureConfiguration):
    """Configuration for AutoRestDurationTestService
    Note that all parameters used to create this instance are saved as instance
    attributes.

    :param credentials: Credentials needed for the client to connect to Azure.
    :type credentials: :mod:`A msrestazure Credentials
     object<msrestazure.azure_active_directory>`
    :param accept_language: Gets or sets the preferred language for the
     response.
    :type accept_language: str
    :param long_running_operation_retry_timeout: Gets or sets the retry
     timeout in seconds for Long Running Operations. Default value is 30.
    :type long_running_operation_retry_timeout: int
    :param generate_client_request_id: When set to true a unique
     x-ms-client-request-id value is generated and included in each request.
     Default is true.
    :type generate_client_request_id: bool
    :param thread_daemon: Whether the operation polling thread is a daemon
     thread. Default value is true.
    :type thread_daemon: bool
    :param str base_url: Service URL
    :param str filepath: Existing config
    """

    def __init__(
            self, credentials, accept_language='en-US', long_running_operation_retry_timeout=30, generate_client_request_id=True, thread_daemon=True, base_url=None, filepath=None):

        if credentials is None:
            raise ValueError("Parameter 'credentials' must not be None.")
        if accept_language is not None and not isinstance(accept_language, str):
            raise TypeError("Optional parameter 'accept_language' must be str.")
        if not base_url:
            base_url = 'https://localhost'

        super(AutoRestDurationTestServiceConfiguration, self).__init__(base_url, filepath)

        self.add_user_agent('autorestdurationtestservice/{}'.format(VERSION))
        self.add_user_agent('Azure-SDK-For-Python')

        self.credentials = credentials
        self.accept_language = accept_language
        self.long_running_operation_retry_timeout = long_running_operation_retry_timeout
        self.generate_client_request_id = generate_client_request_id
        self.thread_daemon = thread_daemon


class AutoRestDurationTestService(object):
    """Test Infrastructure for AutoRest

    :ivar config: Configuration for client.
    :vartype config: AutoRestDurationTestServiceConfiguration

    :ivar duration: Duration operations
    :vartype duration: .operations.DurationOperations

    :param credentials: Credentials needed for the client to connect to Azure.
    :type credentials: :mod:`A msrestazure Credentials
     object<msrestazure.azure_active_directory>`
    :param accept_language: Gets or sets the preferred language for the
     response.
    :type accept_language: str
    :param long_running_operation_retry_timeout: Gets or sets the retry
     timeout in seconds for Long Running Operations. Default value is 30.
    :type long_running_operation_retry_timeout: int
    :param generate_client_request_id: When set to true a unique
     x-ms-client-request-id value is generated and included in each request.
     Default is true.
    :type generate_client_request_id: bool
    :param thread_daemon: Whether the operation polling thread is a daemon
     thread. Default value is true.
    :type thread_daemon: bool
    :param str base_url: Service URL
    :param str filepath: Existing config
    """

    def __init__(
            self, credentials, accept_language='en-US', long_running_operation_retry_timeout=30, generate_client_request_id=True, thread_daemon=True, base_url=None, filepath=None):

        self.config = AutoRestDurationTestServiceConfiguration(credentials, accept_language, long_running_operation_retry_timeout, generate_client_request_id, thread_daemon, base_url, filepath)
        self._client = ServiceClient(self.config.credentials, self.config)

        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}
        self._serialize = Serializer(client_models)
        self._deserialize = Deserializer(client_models)

        self.duration = DurationOperations(
            self._client, self.config, self._serialize, self._deserialize)
