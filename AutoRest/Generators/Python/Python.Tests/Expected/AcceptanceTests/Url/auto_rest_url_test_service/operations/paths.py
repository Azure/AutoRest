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

from ..models import *


class paths(object):

    def __init__(self, client, config, serializer, derserializer):

        self._client = client
        self._serialize = serializer
        self._deserialize = derserializer

        self.config = config

    @async_request
    def get_boolean_true(self, bool_path, custom_headers={}, raw=False, callback=None):
        """

        Get true Boolean value on path

        :param bool_path: true boolean value
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type bool_path: bool
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/bool/true/{boolPath}'
        path_format_arguments = {
            'boolPath': self._serialize.url("bool_path", bool_path, 'bool')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_boolean_false(self, bool_path, custom_headers={}, raw=False, callback=None):
        """

        Get false Boolean value on path

        :param bool_path: false boolean value
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type bool_path: bool
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/bool/false/{boolPath}'
        path_format_arguments = {
            'boolPath': self._serialize.url("bool_path", bool_path, 'bool')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_int_one_million(self, int_path, custom_headers={}, raw=False, callback=None):
        """

        Get '1000000' integer value

        :param int_path: '1000000' integer value
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type int_path: int
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/int/1000000/{intPath}'
        path_format_arguments = {
            'intPath': self._serialize.url("int_path", int_path, 'int')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_int_negative_one_million(self, int_path, custom_headers={}, raw=False, callback=None):
        """

        Get '-1000000' integer value

        :param int_path: '-1000000' integer value
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type int_path: int
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/int/-1000000/{intPath}'
        path_format_arguments = {
            'intPath': self._serialize.url("int_path", int_path, 'int')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_ten_billion(self, long_path, custom_headers={}, raw=False, callback=None):
        """

        Get '10000000000' 64 bit integer value

        :param long_path: '10000000000' 64 bit integer value
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type long_path: long
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/long/10000000000/{longPath}'
        path_format_arguments = {
            'longPath': self._serialize.url("long_path", long_path, 'long')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_negative_ten_billion(self, long_path, custom_headers={}, raw=False, callback=None):
        """

        Get '-10000000000' 64 bit integer value

        :param long_path: '-10000000000' 64 bit integer value
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type long_path: long
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/long/-10000000000/{longPath}'
        path_format_arguments = {
            'longPath': self._serialize.url("long_path", long_path, 'long')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def float_scientific_positive(self, float_path, custom_headers={}, raw=False, callback=None):
        """

        Get '1.034E+20' numeric value

        :param float_path: '1.034E+20'numeric value
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type float_path: float
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/float/1.034E+20/{floatPath}'
        path_format_arguments = {
            'floatPath': self._serialize.url("float_path", float_path, 'float')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def float_scientific_negative(self, float_path, custom_headers={}, raw=False, callback=None):
        """

        Get '-1.034E-20' numeric value

        :param float_path: '-1.034E-20'numeric value
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type float_path: float
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/float/-1.034E-20/{floatPath}'
        path_format_arguments = {
            'floatPath': self._serialize.url("float_path", float_path, 'float')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def double_decimal_positive(self, double_path, custom_headers={}, raw=False, callback=None):
        """

        Get '9999999.999' numeric value

        :param double_path: '9999999.999'numeric value
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type double_path: float
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/double/9999999.999/{doublePath}'
        path_format_arguments = {
            'doublePath': self._serialize.url("double_path", double_path, 'float')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def double_decimal_negative(self, double_path, custom_headers={}, raw=False, callback=None):
        """

        Get '-9999999.999' numeric value

        :param double_path: '-9999999.999'numeric value
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type double_path: float
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/double/-9999999.999/{doublePath}'
        path_format_arguments = {
            'doublePath': self._serialize.url("double_path", double_path, 'float')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def string_unicode(self, string_path, custom_headers={}, raw=False, callback=None):
        """

        Get '啊齄丂狛狜隣郎隣兀﨩' multi-byte string value

        :param string_path: '啊齄丂狛狜隣郎隣兀﨩'multi-byte string value. Possible
        values for this parameter include: '啊齄丂狛狜隣郎隣兀﨩'
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type string_path: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/string/unicode/{stringPath}'
        path_format_arguments = {
            'stringPath': self._serialize.url("string_path", string_path, 'str')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def string_url_encoded(self, string_path, custom_headers={}, raw=False, callback=None):
        """

        Get 'begin!*'();:@ &=+$,/?#[]end

        :param string_path: 'begin!*'();:@ &=+$,/?#[]end' url encoded string
        value. Possible values for this parameter include: 'begin!*'();:@
        &=+$,/?#[]end'
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type string_path: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/string/begin%21%2A%27%28%29%3B%3A%40%20%26%3D%2B%24%2C%2F%3F%23%5B%5Dend/{stringPath}'
        path_format_arguments = {
            'stringPath': self._serialize.url("string_path", string_path, 'str')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def string_empty(self, string_path, custom_headers={}, raw=False, callback=None):
        """

        Get ''

        :param string_path: '' string value. Possible values for this
        parameter include: ''
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type string_path: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/string/empty/{stringPath}'
        path_format_arguments = {
            'stringPath': self._serialize.url("string_path", string_path, 'str')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def string_null(self, string_path, custom_headers={}, raw=False, callback=None):
        """

        Get null (should throw)

        :param string_path: null string value
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type string_path: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/string/null/{stringPath}'
        path_format_arguments = {
            'stringPath': self._serialize.url("string_path", string_path, 'str')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [400]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def enum_valid(self, enum_path, custom_headers={}, raw=False, callback=None):
        """

        Get using uri with 'green color' in path parameter

        :param enum_path: send the value green. Possible values for this
        parameter include: 'red color', 'green color', 'blue color'
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type enum_path: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/enum/green%20color/{enumPath}'
        path_format_arguments = {
            'enumPath': self._serialize.url("enum_path", enum_path, 'UriColor')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def enum_null(self, enum_path, custom_headers={}, raw=False, callback=None):
        """

        Get null (should throw on the client before the request is sent on
        wire)

        :param enum_path: send null should throw. Possible values for this
        parameter include: 'red color', 'green color', 'blue color'
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type enum_path: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/string/null/{enumPath}'
        path_format_arguments = {
            'enumPath': self._serialize.url("enum_path", enum_path, 'UriColor')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [400]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def byte_multi_byte(self, byte_path, custom_headers={}, raw=False, callback=None):
        """

        Get '啊齄丂狛狜隣郎隣兀﨩' multibyte value as utf-8 encoded byte array

        :param byte_path: '啊齄丂狛狜隣郎隣兀﨩' multibyte value as utf-8 encoded byte
        array
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type byte_path: bytearray
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/byte/multibyte/{bytePath}'
        path_format_arguments = {
            'bytePath': self._serialize.url("byte_path", byte_path, 'bytearray')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def byte_empty(self, byte_path, custom_headers={}, raw=False, callback=None):
        """

        Get '' as byte array

        :param byte_path: '' as byte array
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type byte_path: bytearray
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/byte/empty/{bytePath}'
        path_format_arguments = {
            'bytePath': self._serialize.url("byte_path", byte_path, 'bytearray')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def byte_null(self, byte_path, custom_headers={}, raw=False, callback=None):
        """

        Get null as byte array (should throw)

        :param byte_path: null as byte array (should throw)
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type byte_path: bytearray
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/byte/null/{bytePath}'
        path_format_arguments = {
            'bytePath': self._serialize.url("byte_path", byte_path, 'bytearray')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [400]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def date_valid(self, date_path, custom_headers={}, raw=False, callback=None):
        """

        Get '2012-01-01' as date

        :param date_path: '2012-01-01' as date
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type date_path: date
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/date/2012-01-01/{datePath}'
        path_format_arguments = {
            'datePath': self._serialize.url("date_path", date_path, 'date')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def date_null(self, date_path, custom_headers={}, raw=False, callback=None):
        """

        Get null as date - this should throw or be unusable on the client
        side, depending on date representation

        :param date_path: null as date (should throw)
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type date_path: date
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/date/null/{datePath}'
        path_format_arguments = {
            'datePath': self._serialize.url("date_path", date_path, 'date')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [400]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def date_time_valid(self, date_time_path, custom_headers={}, raw=False, callback=None):
        """

        Get '2012-01-01T01:01:01Z' as date-time

        :param date_time_path: '2012-01-01T01:01:01Z' as date-time
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type date_time_path: datetime
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/datetime/2012-01-01T01%3A01%3A01Z/{dateTimePath}'
        path_format_arguments = {
            'dateTimePath': self._serialize.url("date_time_path", date_time_path, 'iso-8601')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def date_time_null(self, date_time_path, custom_headers={}, raw=False, callback=None):
        """

        Get null as date-time, should be disallowed or throw depending on
        representation of date-time

        :param date_time_path: null as date-time
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type date_time_path: datetime
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/paths/datetime/null/{dateTimePath}'
        path_format_arguments = {
            'dateTimePath': self._serialize.url("date_time_path", date_time_path, 'iso-8601')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [400]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response
