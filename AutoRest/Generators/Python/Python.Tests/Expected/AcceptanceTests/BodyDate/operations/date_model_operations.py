#--------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
# 
# Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
#--------------------------------------------------------------------------

import sys

from datetime import *

from msrest.service_client import ServiceClient
from msrest.serialization import Serializer, Deserializer
from msrest.exceptions import (
    SerializationError,
    DeserializationError,
    TokenExpiredError,
    ClientRequestError,
    ServerError)

from ..models import *

class DateModelOperations(object):

    def __init__(self, client, config, serializer, derserializer):

        self._client = client
        self._serialize = serializer
        self._deserialize = derserializer

        self.config = config

    def _parse_url(self, name, value, datatype):

        try:
            value = self._serialize.serialize_data(value, str(datatype))

        except ValueError:
            raise ValueError("{} must not be None.".format(name))

        except DeserializationError:
            raise TypeError("{} must be type {}.".format(name, datatype))

        else:
            return value

    @ServiceClient.async_request
    def get_null(self, custom_headers = {}, raw = False, callback = None):
        """

        Get null date value
        """

        # Construct URL
        url = '/date/null'

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
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('date', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get_invalid_date(self, custom_headers = {}, raw = False, callback = None):
        """

        Get invalid date value
        """

        # Construct URL
        url = '/date/invaliddate'

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
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('date', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get_overflow_date(self, custom_headers = {}, raw = False, callback = None):
        """

        Get overflow date value
        """

        # Construct URL
        url = '/date/overflowdate'

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
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('date', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get_underflow_date(self, custom_headers = {}, raw = False, callback = None):
        """

        Get underflow date value
        """

        # Construct URL
        url = '/date/underflowdate'

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
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('date', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def put_max_date(self, date_body, custom_headers = {}, raw = False, callback = None):
        """

        Put max date value 9999-12-31
        """

        # Construct URL
        url = '/date/max'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(date_body)

        # Construct and send request
        request = self._client.put(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [200]:
            raise ErrorException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get_max_date(self, custom_headers = {}, raw = False, callback = None):
        """

        Get max date value 9999-12-31
        """

        # Construct URL
        url = '/date/max'

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
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('date', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def put_min_date(self, date_body, custom_headers = {}, raw = False, callback = None):
        """

        Put min date value 0000-01-01
        """

        # Construct URL
        url = '/date/min'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(date_body)

        # Construct and send request
        request = self._client.put(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [200]:
            raise ErrorException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get_min_date(self, custom_headers = {}, raw = False, callback = None):
        """

        Get min date value 0000-01-01
        """

        # Construct URL
        url = '/date/min'

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
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('date', response)

        if raw:
            return deserialized, response

        return deserialized
