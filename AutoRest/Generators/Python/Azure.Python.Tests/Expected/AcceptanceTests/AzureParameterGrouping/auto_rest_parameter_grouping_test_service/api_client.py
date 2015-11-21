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
from .operations.parameter_grouping_operations import parameter_groupingOperations
from . import models


class AutoRestParameterGroupingTestServiceConfiguration(AzureConfiguration):

    def __init__(self, credentials, base_url=None, filepath=None):

        if not base_url:
            base_url = 'https://localhost'

        super(AutoRestParameterGroupingTestServiceConfiguration, self).__init__(base_url, filepath)

        self.credentials = credentials

        if self.accept_language is None:
            self.accept_language = 'en-US'


class AutoRestParameterGroupingTestService(object):

    def __init__(self, config):

        self._client = ServiceClient(config.credentials, config)

        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}
        self._serialize = Serializer()
        self._deserialize = Deserializer(client_models)

        self.config = config
        self.parameter_grouping = parameter_groupingOperations(self._client, self.config, self._serialize, self._deserialize)
