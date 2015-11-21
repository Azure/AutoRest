# coding=utf-8
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
from msrest.exceptions import DeserializationError, HttpOperationError
from msrestazure.exceptions import CloudException
import uuid

from ..models import *


class skip_url_encodingOperations(object):

    def __init__(self, client, config, serializer, derserializer):

        self._client = client
        self._serialize = serializer
        self._deserialize = derserializer

        self.config = config

    def _serialize_data(self, name, value, datatype, **kwargs):

        try:
            value = self._serialize.serialize_data(value, datatype, **kwargs)

        except ValueError:
            raise ValueError("{} must not be None.".format(name))

        except DeserializationError:
            raise TypeError("{} must be type {}.".format(name, datatype))

        else:
            return value

    @async_request
    def get_method_path_valid(self, unencoded_path_param, custom_headers={}, raw=False, callback=None):
        """

        Get method with unencoded path parameter with value 'path1/path2/path3'

        :param unencoded_path_param: Unencoded path parameter with value
        'path1/path2/path3'
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type unencoded_path_param: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/azurespecials/skipUrlEncoding/method/path/valid/{unencodedPathParam}'
        path_format_arguments = {
            'unencodedPathParam': self._serialize_data("unencoded_path_param", unencoded_path_param, 'str', skip_quote=True)
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        if self.config.accept_language is not None:
            headers['accept-language'] = self._serialize_data("self.config.accept_language", self.config.accept_language, 'str')
        headers.update(custom_headers)
        headers['x-ms-client-request-id'] = str(uuid.uuid1())
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_path_path_valid(self, unencoded_path_param, custom_headers={}, raw=False, callback=None):
        """

        Get method with unencoded path parameter with value 'path1/path2/path3'

        :param unencoded_path_param: Unencoded path parameter with value
        'path1/path2/path3'
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type unencoded_path_param: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/azurespecials/skipUrlEncoding/path/path/valid/{unencodedPathParam}'
        path_format_arguments = {
            'unencodedPathParam': self._serialize_data("unencoded_path_param", unencoded_path_param, 'str', skip_quote=True)
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        if self.config.accept_language is not None:
            headers['accept-language'] = self._serialize_data("self.config.accept_language", self.config.accept_language, 'str')
        headers.update(custom_headers)
        headers['x-ms-client-request-id'] = str(uuid.uuid1())
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_swagger_path_valid(self, unencoded_path_param, custom_headers={}, raw=False, callback=None):
        """

        Get method with unencoded path parameter with value 'path1/path2/path3'

        :param unencoded_path_param: An unencoded path parameter with value
        'path1/path2/path3'. Possible values for this parameter include:
        'path1/path2/path3'
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type unencoded_path_param: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/azurespecials/skipUrlEncoding/swagger/path/valid/{unencodedPathParam}'
        path_format_arguments = {
            'unencodedPathParam': self._serialize_data("unencoded_path_param", unencoded_path_param, 'str', skip_quote=True)
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        if self.config.accept_language is not None:
            headers['accept-language'] = self._serialize_data("self.config.accept_language", self.config.accept_language, 'str')
        headers.update(custom_headers)
        headers['x-ms-client-request-id'] = str(uuid.uuid1())
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_method_query_valid(self, q1, custom_headers={}, raw=False, callback=None):
        """

        Get method with unencoded query parameter with value
        'value1&q2=value2&q3=value3'

        :param q1: Unencoded query parameter with value
        'value1&q2=value2&q3=value3'
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type q1: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/azurespecials/skipUrlEncoding/method/query/valid'

        # Construct parameters
        query = {}
        query['q1'] = self._serialize_data("q1", q1, 'str', skip_quote=True)

        # Construct headers
        headers = {}
        if self.config.accept_language is not None:
            headers['accept-language'] = self._serialize_data("self.config.accept_language", self.config.accept_language, 'str')
        headers.update(custom_headers)
        headers['x-ms-client-request-id'] = str(uuid.uuid1())
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_method_query_null(self, q1, custom_headers={}, raw=False, callback=None):
        """

        Get method with unencoded query parameter with value null

        :param q1: Unencoded query parameter with value null
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type q1: str or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/azurespecials/skipUrlEncoding/method/query/null'

        # Construct parameters
        query = {}
        if q1 is not None:
            query['q1'] = self._serialize_data("q1", q1, 'str', skip_quote=True)

        # Construct headers
        headers = {}
        if self.config.accept_language is not None:
            headers['accept-language'] = self._serialize_data("self.config.accept_language", self.config.accept_language, 'str')
        headers.update(custom_headers)
        headers['x-ms-client-request-id'] = str(uuid.uuid1())
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_path_query_valid(self, q1, custom_headers={}, raw=False, callback=None):
        """

        Get method with unencoded query parameter with value
        'value1&q2=value2&q3=value3'

        :param q1: Unencoded query parameter with value
        'value1&q2=value2&q3=value3'
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type q1: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/azurespecials/skipUrlEncoding/path/query/valid'

        # Construct parameters
        query = {}
        query['q1'] = self._serialize_data("q1", q1, 'str', skip_quote=True)

        # Construct headers
        headers = {}
        if self.config.accept_language is not None:
            headers['accept-language'] = self._serialize_data("self.config.accept_language", self.config.accept_language, 'str')
        headers.update(custom_headers)
        headers['x-ms-client-request-id'] = str(uuid.uuid1())
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_swagger_query_valid(self, q1, custom_headers={}, raw=False, callback=None):
        """

        Get method with unencoded query parameter with value
        'value1&q2=value2&q3=value3'

        :param q1: An unencoded query parameter with value
        'value1&q2=value2&q3=value3'. Possible values for this parameter
        include: 'value1&q2=value2&q3=value3'
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type q1: str or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/azurespecials/skipUrlEncoding/swagger/query/valid'

        # Construct parameters
        query = {}
        if q1 is not None:
            query['q1'] = self._serialize_data("q1", q1, 'str', skip_quote=True)

        # Construct headers
        headers = {}
        if self.config.accept_language is not None:
            headers['accept-language'] = self._serialize_data("self.config.accept_language", self.config.accept_language, 'str')
        headers.update(custom_headers)
        headers['x-ms-client-request-id'] = str(uuid.uuid1())
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct and send request
        request = self._client.get(url, query)
        response = self._client.send(request, headers)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response
