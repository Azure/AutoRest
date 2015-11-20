# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Serializer, Deserializer
from msrest.service_client import async_request
from msrest.exceptions import (
    DeserializationError,
    HttpOperationError)

from ..models import *


class polymorphicrecursive(object):

    def __init__(self, client, config, serializer, derserializer):

        self._client = client
        self._serialize = serializer
        self._deserialize = derserializer

        self.config = config

    def _parse_url(self, name, value, datatype):

        try:
            value = self._serialize.serialize_data(value, datatype)

        except ValueError:
            raise ValueError("{} must not be None.".format(name))

        except DeserializationError:
            raise TypeError("{} must be type {}.".format(name, datatype))

        else:
            return value

    @async_request
    def get_valid(self, custom_headers={}, raw=False, callback=None):
        """

        Get complex types that are polymorphic and have recursive references

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: object or (object, requests.response) or
        concurrent.futures.Future
        """

        # Construct URL
        url = '/complex/polymorphicrecursive/valid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('Fish', response)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def put_valid(self, complex_body, custom_headers={}, raw=False, callback=None):
        """

        Put complex types that are polymorphic and have recursive references

        :param complex_body: Please put a salmon that looks like this:
        {
        "fishtype": "salmon",
        "species": "king",
        "length": 1,
        "age": 1,
        "location": "alaska",
        "iswild": true,
        "siblings": [
        {
        "fishtype": "shark",
        "species": "predator",
        "length": 20,
        "age": 6,
        "siblings": [
        {
        "fishtype": "salmon",
        "species": "coho",
        "length": 2,
        "age": 2,
        "location": "atlantic",
        "iswild": true,
        "siblings": [
        {
        "fishtype": "shark",
        "species": "predator",
        "length": 20,
        "age": 6
        },
        {
        "fishtype": "sawshark",
        "species": "dangerous",
        "length": 10,
        "age": 105
        }
        ]
        },
        {
        "fishtype": "sawshark",
        "species": "dangerous",
        "length": 10,
        "age": 105
        }
        ]
        },
        {
        "fishtype": "sawshark",
        "species": "dangerous",
        "length": 10,
        "age": 105
        }
        ]
        }
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type complex_body: object
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/complex/polymorphicrecursive/valid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(complex_body, 'Fish')

        # Construct and send request
        request = self._client.put(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response
