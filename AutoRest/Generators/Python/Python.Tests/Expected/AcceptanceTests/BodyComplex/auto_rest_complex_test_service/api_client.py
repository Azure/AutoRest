#--------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
# 
# Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
#--------------------------------------------------------------------------


from msrest.service_client import ServiceClient, async_request
from msrest import Configuration, Serializer, Deserializer
from msrest.exceptions import (
    SerializationError,
    DeserializationError,
    TokenExpiredError,
    ClientRequestError,
    HttpOperationError)
from .operations.basic_operations import basicOperations
from .operations.primitive import primitive
from .operations.array import array
from .operations.dictionary import dictionary
from .operations.inheritance import inheritance
from .operations.polymorphism import polymorphism
from .operations.polymorphicrecursive import polymorphicrecursive
from . import models

class AutoRestComplexTestServiceConfiguration(Configuration):

    def __init__(self, base_url=None, filepath=None):

        if not base_url:
            base_url = 'http://localhost'

        super(AutoRestComplexTestServiceConfiguration, self).__init__(base_url, filepath)



class AutoRestComplexTestService(object):

    def __init__(self, config):

        self._client = ServiceClient(None, config) 

        client_models = {k:v for k,v in models.__dict__.items() if isinstance(v, type)}
        self._serialize = Serializer()
        self._deserialize = Deserializer(client_models)

        self.config = config
        self.basicOperations = basicOperations(self._client, self.config, self._serialize, self._deserialize)
        self.primitive = primitive(self._client, self.config, self._serialize, self._deserialize)
        self.array = array(self._client, self.config, self._serialize, self._deserialize)
        self.dictionary = dictionary(self._client, self.config, self._serialize, self._deserialize)
        self.inheritance = inheritance(self._client, self.config, self._serialize, self._deserialize)
        self.polymorphism = polymorphism(self._client, self.config, self._serialize, self._deserialize)
        self.polymorphicrecursive = polymorphicrecursive(self._client, self.config, self._serialize, self._deserialize)

