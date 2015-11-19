# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from datetime import *

from msrest.service_client import ServiceClient, async_request
from msrest import Configuration, Serializer, Deserializer
from .operations.datetimerfc1123 import datetimerfc1123
from . import models


class AutoRestRFC1123DateTimeTestServiceConfiguration(Configuration):

    def __init__(self, base_url=None, filepath=None):

        if not base_url:
            base_url = 'https://localhost'

        super(AutoRestRFC1123DateTimeTestServiceConfiguration, self).__init__(base_url, filepath)


class AutoRestRFC1123DateTimeTestService(object):

    def __init__(self, config):

        self._client = ServiceClient(None, config)

        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}
        self._serialize = Serializer()
        self._deserialize = Deserializer(client_models)

        self.config = config
        self.datetimerfc1123 = datetimerfc1123(self._client, self.config, self._serialize, self._deserialize)
