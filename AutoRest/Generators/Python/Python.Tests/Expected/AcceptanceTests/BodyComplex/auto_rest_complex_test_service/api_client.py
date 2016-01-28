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
from msrest import Configuration, Serializer, Deserializer
from .operations.basic_operations import BasicOperations
from .operations.primitive import Primitive
from .operations.array import Array
from .operations.dictionary import Dictionary
from .operations.inheritance import Inheritance
from .operations.polymorphism import Polymorphism
from .operations.polymorphicrecursive import Polymorphicrecursive
from . import models


class AutoRestComplexTestServiceConfiguration(Configuration):
    """Configuration for AutoRestComplexTestService

    :param str base_url: Service URL
    :param str filepath: Existing config
    """

    def __init__(
            self, base_url=None, filepath=None):

        if not base_url:
            base_url = 'http://localhost'

        super(AutoRestComplexTestServiceConfiguration, self).__init__(base_url, filepath)

        self.user_agent = 'auto_rest_complex_test_service/1.0.0'


class AutoRestComplexTestService(object):
    """Test Infrastructure for AutoRest

    :param config: Configuration for client.
    :type config: AutoRestComplexTestServiceConfiguration
    """

    def __init__(self, config):

        self._client = ServiceClient(None, config)

        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}
        self._serialize = Serializer()
        self._deserialize = Deserializer(client_models)

        self.config = config
        self.basic_operations = BasicOperations(
            self._client, self.config, self._serialize, self._deserialize)
        self.primitive = Primitive(
            self._client, self.config, self._serialize, self._deserialize)
        self.array = Array(
            self._client, self.config, self._serialize, self._deserialize)
        self.dictionary = Dictionary(
            self._client, self.config, self._serialize, self._deserialize)
        self.inheritance = Inheritance(
            self._client, self.config, self._serialize, self._deserialize)
        self.polymorphism = Polymorphism(
            self._client, self.config, self._serialize, self._deserialize)
        self.polymorphicrecursive = Polymorphicrecursive(
            self._client, self.config, self._serialize, self._deserialize)
