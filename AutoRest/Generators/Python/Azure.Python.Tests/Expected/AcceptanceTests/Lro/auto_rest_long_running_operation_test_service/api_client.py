# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------


from msrest.service_client import ServiceClient, async_request
from msrest import Configuration, Serializer, Deserializer
from msrest.exceptions import (
    SerializationError,
    DeserializationError,
    TokenExpiredError,
    ClientRequestError,
    HttpOperationError)
from .operations.lr_os import lr_os
from .operations.lro_retrys import lro_retrys
from .operations.lrosa_ds import lrosa_ds
from .operations.lr_os_custom_header import lr_os_custom_header
from . import models


class AutoRestLongRunningOperationTestServiceConfiguration(Configuration):

    def __init__(self, base_url=None, filepath=None):

        if not base_url:
            base_url = 'http://localhost'

        super(AutoRestLongRunningOperationTestServiceConfiguration, self).__init__(base_url, filepath)


class AutoRestLongRunningOperationTestService(object):

    def __init__(self, config):

        self._client = ServiceClient(None, config)

        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}
        self._serialize = Serializer()
        self._deserialize = Deserializer(client_models)

        self.config = config
        self.lr_os = lr_os(self._client, self.config, self._serialize, self._deserialize)
        self.lro_retrys = lro_retrys(self._client, self.config, self._serialize, self._deserialize)
        self.lrosa_ds = lrosa_ds(self._client, self.config, self._serialize, self._deserialize)
        self.lr_os_custom_header = lr_os_custom_header(self._client, self.config, self._serialize, self._deserialize)
