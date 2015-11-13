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


from msrest.service_client import ServiceClient
from msrest.serialization import Serializer, Deserializer
from msrest.exceptions import (
    SerializationError,
    DeserializationError,
    TokenExpiredError,
    ClientRequestError,
    ServerError)

from ..models import *

class MultipleResponsesOperations(object):

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
    def get200_model204_no_model_default_error200_valid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 200 response with valid payload: {'statusCode': '200'}
        """

        # Construct URL
        url = '/http/payloads/200/A/204/none/default/Error/response/200/valid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200 , 204]:
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model204_no_model_default_error204_valid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 204 response with no payload
        """

        # Construct URL
        url = '/http/payloads/200/A/204/none/default/Error/response/204/none'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200 , 204]:
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model204_no_model_default_error201_invalid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 201 response with valid payload: {'statusCode': '201'}
        """

        # Construct URL
        url = '/http/payloads/200/A/204/none/default/Error/response/201/valid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200 , 204]:
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model204_no_model_default_error202_none(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 202 response with no payload:
        """

        # Construct URL
        url = '/http/payloads/200/A/204/none/default/Error/response/202/none'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200 , 204]:
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model204_no_model_default_error400_valid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 400 response with valid error payload: {'status': 400,
        'message': 'client error'}
        """

        # Construct URL
        url = '/http/payloads/200/A/204/none/default/Error/response/400/valid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200 , 204]:
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model201_model_default_error200_valid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 200 response with valid payload: {'statusCode': '200'}
        """

        # Construct URL
        url = '/http/payloads/200/A/201/B/default/Error/response/200/valid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200 , 201]:
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)
        if response.status_code == 201:
            deserialized = self._deserialize('B', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model201_model_default_error201_valid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 201 response with valid payload: {'statusCode': '201',
        'textStatusCode': 'Created'}
        """

        # Construct URL
        url = '/http/payloads/200/A/201/B/default/Error/response/201/valid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200 , 201]:
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)
        if response.status_code == 201:
            deserialized = self._deserialize('B', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model201_model_default_error400_valid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 400 response with valid payload: {'code': '400', 'message':
        'client error'}
        """

        # Construct URL
        url = '/http/payloads/200/A/201/B/default/Error/response/400/valid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200 , 201]:
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)
        if response.status_code == 201:
            deserialized = self._deserialize('B', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model_a201_model_c404_model_ddefault_error200_valid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 200 response with valid payload: {'statusCode': '200'}
        """

        # Construct URL
        url = '/http/payloads/200/A/201/C/404/D/default/Error/response/200/valid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200 , 201 , 404]:
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)
        if response.status_code == 201:
            deserialized = self._deserialize('C', response)
        if response.status_code == 404:
            deserialized = self._deserialize('D', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model_a201_model_c404_model_ddefault_error201_valid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 200 response with valid payload: {'httpCode': '201'}
        """

        # Construct URL
        url = '/http/payloads/200/A/201/C/404/D/default/Error/response/201/valid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200 , 201 , 404]:
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)
        if response.status_code == 201:
            deserialized = self._deserialize('C', response)
        if response.status_code == 404:
            deserialized = self._deserialize('D', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model_a201_model_c404_model_ddefault_error404_valid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 200 response with valid payload: {'httpStatusCode': '404'}
        """

        # Construct URL
        url = '/http/payloads/200/A/201/C/404/D/default/Error/response/404/valid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200 , 201 , 404]:
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)
        if response.status_code == 201:
            deserialized = self._deserialize('C', response)
        if response.status_code == 404:
            deserialized = self._deserialize('D', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model_a201_model_c404_model_ddefault_error400_valid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 400 response with valid payload: {'code': '400', 'message':
        'client error'}
        """

        # Construct URL
        url = '/http/payloads/200/A/201/C/404/D/default/Error/response/400/valid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200 , 201 , 404]:
            raise ErrorException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)
        if response.status_code == 201:
            deserialized = self._deserialize('C', response)
        if response.status_code == 404:
            deserialized = self._deserialize('D', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get202_none204_none_default_error202_none(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 202 response with no payload
        """

        # Construct URL
        url = '/http/payloads/202/none/204/none/default/Error/response/202/none'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [202 , 204]:
            raise ErrorException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get202_none204_none_default_error204_none(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 204 response with no payload
        """

        # Construct URL
        url = '/http/payloads/202/none/204/none/default/Error/response/204/none'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [202 , 204]:
            raise ErrorException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get202_none204_none_default_error400_valid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 400 response with valid payload: {'code': '400', 'message':
        'client error'}
        """

        # Construct URL
        url = '/http/payloads/202/none/204/none/default/Error/response/400/valid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [202 , 204]:
            raise ErrorException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get202_none204_none_default_none202_invalid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 202 response with an unexpected payload {'property': 'value'}
        """

        # Construct URL
        url = '/http/payloads/202/none/204/none/default/none/response/202/invalid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [202 , 204]:
            raise ServerException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get202_none204_none_default_none204_none(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 204 response with no payload
        """

        # Construct URL
        url = '/http/payloads/202/none/204/none/default/none/response/204/none'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [202 , 204]:
            raise ServerException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get202_none204_none_default_none400_none(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 400 response with no payload
        """

        # Construct URL
        url = '/http/payloads/202/none/204/none/default/none/response/400/none'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [202 , 204]:
            raise ServerException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get202_none204_none_default_none400_invalid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 400 response with an unexpected payload {'property': 'value'}
        """

        # Construct URL
        url = '/http/payloads/202/none/204/none/default/none/response/400/invalid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [202 , 204]:
            raise ServerException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get_default_model_a200_valid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 200 response with valid payload: {'statusCode': '200'}
        """

        # Construct URL
        url = '/http/payloads/default/A/response/200/valid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if reponse.status_code < 200 or reponse.status_code >= 300:
            raise AException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get_default_model_a200_none(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 200 response with no payload
        """

        # Construct URL
        url = '/http/payloads/default/A/response/200/none'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if reponse.status_code < 200 or reponse.status_code >= 300:
            raise AException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get_default_model_a400_valid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 400 response with valid payload: {'statusCode': '400'}
        """

        # Construct URL
        url = '/http/payloads/default/A/response/400/valid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if reponse.status_code < 200 or reponse.status_code >= 300:
            raise AException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get_default_model_a400_none(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 400 response with no payload
        """

        # Construct URL
        url = '/http/payloads/default/A/response/400/none'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if reponse.status_code < 200 or reponse.status_code >= 300:
            raise AException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get_default_none200_invalid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 200 response with invalid payload: {'statusCode': '200'}
        """

        # Construct URL
        url = '/http/payloads/default/none/response/200/invalid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if reponse.status_code < 200 or reponse.status_code >= 300:
            raise ServerException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get_default_none200_none(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 200 response with no payload
        """

        # Construct URL
        url = '/http/payloads/default/none/response/200/none'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if reponse.status_code < 200 or reponse.status_code >= 300:
            raise ServerException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get_default_none400_invalid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 400 response with valid payload: {'statusCode': '400'}
        """

        # Construct URL
        url = '/http/payloads/default/none/response/400/invalid'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if reponse.status_code < 200 or reponse.status_code >= 300:
            raise ServerException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get_default_none400_none(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 400 response with no payload
        """

        # Construct URL
        url = '/http/payloads/default/none/response/400/none'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if reponse.status_code < 200 or reponse.status_code >= 300:
            raise ServerException(response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get200_model_a200_none(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 200 response with no payload, when a payload is expected -
        client should return a null object of thde type for model A
        """

        # Construct URL
        url = '/http/payloads/200/A/response/200/none'

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
            raise ServerException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model_a200_valid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 200 response with payload {'statusCode': '200'}
        """

        # Construct URL
        url = '/http/payloads/200/A/response/200/valid'

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
            raise ServerException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model_a200_invalid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 200 response with invalid payload {'statusCodeInvalid': '200'}
        """

        # Construct URL
        url = '/http/payloads/200/A/response/200/invalid'

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
            raise ServerException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model_a400_none(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 400 response with no payload client should treat as an http
        error with no error model
        """

        # Construct URL
        url = '/http/payloads/200/A/response/400/none'

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
            raise ServerException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model_a400_valid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 200 response with payload {'statusCode': '400'}
        """

        # Construct URL
        url = '/http/payloads/200/A/response/400/valid'

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
            raise ServerException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model_a400_invalid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 200 response with invalid payload {'statusCodeInvalid': '400'}
        """

        # Construct URL
        url = '/http/payloads/200/A/response/400/invalid'

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
            raise ServerException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def get200_model_a202_valid(self, custom_headers = {}, raw = False, callback = None):
        """

        Send a 202 response with payload {'statusCode': '202'}
        """

        # Construct URL
        url = '/http/payloads/200/A/response/202/valid'

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
            raise ServerException(response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('A', response)

        if raw:
            return deserialized, response

        return deserialized
