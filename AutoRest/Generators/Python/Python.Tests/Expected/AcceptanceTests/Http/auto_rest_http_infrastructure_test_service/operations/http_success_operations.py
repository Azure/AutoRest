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
    HttpOperationError)

from ..models import *

class HttpSuccessOperations(object):

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
    def head200(self, custom_headers = {}, raw = False, callback = None):
        """

        Return 200 status code if successful

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/200'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.head(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def get200(self, custom_headers = {}, raw = False, callback = None):
        """

        Get 200 success

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: bool or (bool, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/200'

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
            deserialized = self._deserialize('bool', response)

        if raw:
            return deserialized, response

        return deserialized

    @ServiceClient.async_request
    def put200(self, boolean_value, custom_headers = {}, raw = False, callback = None):
        """

        Put boolean value true returning 200 success

        :param boolean_value: Simple boolean value true
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type boolean_value: bool or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/200'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(boolean_value, 'bool')

        # Construct and send request
        request = self._client.put(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def patch200(self, boolean_value, custom_headers = {}, raw = False, callback = None):
        """

        Patch true Boolean value in request returning 200

        :param boolean_value: Simple boolean value true
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type boolean_value: bool or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/200'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(boolean_value, 'bool')

        # Construct and send request
        request = self._client.patch(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def post200(self, boolean_value, custom_headers = {}, raw = False, callback = None):
        """

        Post bollean value true in request that returns a 200

        :param boolean_value: Simple boolean value true
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type boolean_value: bool or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/200'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(boolean_value, 'bool')

        # Construct and send request
        request = self._client.post(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def delete200(self, boolean_value, custom_headers = {}, raw = False, callback = None):
        """

        Delete simple boolean value true returns 200

        :param boolean_value: Simple boolean value true
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type boolean_value: bool or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/200'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(boolean_value, 'bool')

        # Construct and send request
        request = self._client.delete(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def put201(self, boolean_value, custom_headers = {}, raw = False, callback = None):
        """

        Put true Boolean value in request returns 201

        :param boolean_value: Simple boolean value true
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type boolean_value: bool or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/201'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(boolean_value, 'bool')

        # Construct and send request
        request = self._client.put(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [201]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def post201(self, boolean_value, custom_headers = {}, raw = False, callback = None):
        """

        Post true Boolean value in request returns 201 (Created)

        :param boolean_value: Simple boolean value true
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type boolean_value: bool or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/201'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(boolean_value, 'bool')

        # Construct and send request
        request = self._client.post(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [201]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def put202(self, boolean_value, custom_headers = {}, raw = False, callback = None):
        """

        Put true Boolean value in request returns 202 (Accepted)

        :param boolean_value: Simple boolean value true
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type boolean_value: bool or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/202'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(boolean_value, 'bool')

        # Construct and send request
        request = self._client.put(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [202]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def patch202(self, boolean_value, custom_headers = {}, raw = False, callback = None):
        """

        Patch true Boolean value in request returns 202

        :param boolean_value: Simple boolean value true
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type boolean_value: bool or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/202'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(boolean_value, 'bool')

        # Construct and send request
        request = self._client.patch(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [202]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def post202(self, boolean_value, custom_headers = {}, raw = False, callback = None):
        """

        Post true Boolean value in request returns 202 (Accepted)

        :param boolean_value: Simple boolean value true
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type boolean_value: bool or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/202'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(boolean_value, 'bool')

        # Construct and send request
        request = self._client.post(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [202]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def delete202(self, boolean_value, custom_headers = {}, raw = False, callback = None):
        """

        Delete true Boolean value in request returns 202 (accepted)

        :param boolean_value: Simple boolean value true
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type boolean_value: bool or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/202'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(boolean_value, 'bool')

        # Construct and send request
        request = self._client.delete(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [202]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def head204(self, custom_headers = {}, raw = False, callback = None):
        """

        Return 204 status code if successful

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/204'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.head(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [204]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def put204(self, boolean_value, custom_headers = {}, raw = False, callback = None):
        """

        Put true Boolean value in request returns 204 (no content)

        :param boolean_value: Simple boolean value true
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type boolean_value: bool or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/204'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(boolean_value, 'bool')

        # Construct and send request
        request = self._client.put(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [204]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def patch204(self, boolean_value, custom_headers = {}, raw = False, callback = None):
        """

        Patch true Boolean value in request returns 204 (no content)

        :param boolean_value: Simple boolean value true
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type boolean_value: bool or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/204'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(boolean_value, 'bool')

        # Construct and send request
        request = self._client.patch(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [204]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def post204(self, boolean_value, custom_headers = {}, raw = False, callback = None):
        """

        Post true Boolean value in request returns 204 (no content)

        :param boolean_value: Simple boolean value true
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type boolean_value: bool or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/204'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(boolean_value, 'bool')

        # Construct and send request
        request = self._client.post(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [204]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def delete204(self, boolean_value, custom_headers = {}, raw = False, callback = None):
        """

        Delete true Boolean value in request returns 204 (no content)

        :param boolean_value: Simple boolean value true
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type boolean_value: bool or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/204'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(boolean_value, 'bool')

        # Construct and send request
        request = self._client.delete(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [204]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @ServiceClient.async_request
    def head404(self, custom_headers = {}, raw = False, callback = None):
        """

        Return 404 status code

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/http/success/404'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.head(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [204 , 404]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response
