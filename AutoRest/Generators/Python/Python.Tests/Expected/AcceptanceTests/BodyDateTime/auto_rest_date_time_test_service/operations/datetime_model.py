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


class datetime_model(object):

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
    def get_null(self, custom_headers={}, raw=False, callback=None):
        """

        Get null datetime value

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: datetime or (datetime, requests.response) or
        concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/null'

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
            deserialized = self._deserialize('iso-8601', response)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_invalid(self, custom_headers={}, raw=False, callback=None):
        """

        Get invalid datetime value

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: datetime or (datetime, requests.response) or
        concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/invalid'

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
            deserialized = self._deserialize('iso-8601', response)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_overflow(self, custom_headers={}, raw=False, callback=None):
        """

        Get overflow datetime value

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: datetime or (datetime, requests.response) or
        concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/overflow'

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
            deserialized = self._deserialize('iso-8601', response)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_underflow(self, custom_headers={}, raw=False, callback=None):
        """

        Get underflow datetime value

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: datetime or (datetime, requests.response) or
        concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/underflow'

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
            deserialized = self._deserialize('iso-8601', response)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def put_utc_max_date_time(self, datetime_body, custom_headers={}, raw=False, callback=None):
        """

        Put max datetime value 9999-12-31T23:59:59.9999999Z

        :param datetime_body:
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type datetime_body: datetime
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/max/utc'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(datetime_body, 'iso-8601')

        # Construct and send request
        request = self._client.put(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_utc_lowercase_max_date_time(self, custom_headers={}, raw=False, callback=None):
        """

        Get max datetime value 9999-12-31t23:59:59.9999999z

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: datetime or (datetime, requests.response) or
        concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/max/utc/lowercase'

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
            deserialized = self._deserialize('iso-8601', response)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_utc_uppercase_max_date_time(self, custom_headers={}, raw=False, callback=None):
        """

        Get max datetime value 9999-12-31T23:59:59.9999999Z

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: datetime or (datetime, requests.response) or
        concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/max/utc/uppercase'

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
            deserialized = self._deserialize('iso-8601', response)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def put_local_positive_offset_max_date_time(self, datetime_body, custom_headers={}, raw=False, callback=None):
        """

        Put max datetime value with positive numoffset
        9999-12-31t23:59:59.9999999+14:00

        :param datetime_body:
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type datetime_body: datetime
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/max/localpositiveoffset'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(datetime_body, 'iso-8601')

        # Construct and send request
        request = self._client.put(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_local_positive_offset_lowercase_max_date_time(self, custom_headers={}, raw=False, callback=None):
        """

        Get max datetime value with positive num offset
        9999-12-31t23:59:59.9999999+14:00

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: datetime or (datetime, requests.response) or
        concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/max/localpositiveoffset/lowercase'

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
            deserialized = self._deserialize('iso-8601', response)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_local_positive_offset_uppercase_max_date_time(self, custom_headers={}, raw=False, callback=None):
        """

        Get max datetime value with positive num offset
        9999-12-31T23:59:59.9999999+14:00

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: datetime or (datetime, requests.response) or
        concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/max/localpositiveoffset/uppercase'

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
            deserialized = self._deserialize('iso-8601', response)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def put_local_negative_offset_max_date_time(self, datetime_body, custom_headers={}, raw=False, callback=None):
        """

        Put max datetime value with positive numoffset
        9999-12-31t23:59:59.9999999-14:00

        :param datetime_body:
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type datetime_body: datetime
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/max/localnegativeoffset'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(datetime_body, 'iso-8601')

        # Construct and send request
        request = self._client.put(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_local_negative_offset_uppercase_max_date_time(self, custom_headers={}, raw=False, callback=None):
        """

        Get max datetime value with positive num offset
        9999-12-31T23:59:59.9999999-14:00

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: datetime or (datetime, requests.response) or
        concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/max/localnegativeoffset/uppercase'

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
            deserialized = self._deserialize('iso-8601', response)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_local_negative_offset_lowercase_max_date_time(self, custom_headers={}, raw=False, callback=None):
        """

        Get max datetime value with positive num offset
        9999-12-31t23:59:59.9999999-14:00

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: datetime or (datetime, requests.response) or
        concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/max/localnegativeoffset/lowercase'

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
            deserialized = self._deserialize('iso-8601', response)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def put_utc_min_date_time(self, datetime_body, custom_headers={}, raw=False, callback=None):
        """

        Put min datetime value 0001-01-01T00:00:00Z

        :param datetime_body:
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type datetime_body: datetime
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/min/utc'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(datetime_body, 'iso-8601')

        # Construct and send request
        request = self._client.put(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_utc_min_date_time(self, custom_headers={}, raw=False, callback=None):
        """

        Get min datetime value 0001-01-01T00:00:00Z

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: datetime or (datetime, requests.response) or
        concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/min/utc'

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
            deserialized = self._deserialize('iso-8601', response)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def put_local_positive_offset_min_date_time(self, datetime_body, custom_headers={}, raw=False, callback=None):
        """

        Put min datetime value 0001-01-01T00:00:00+14:00

        :param datetime_body:
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type datetime_body: datetime
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/min/localpositiveoffset'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(datetime_body, 'iso-8601')

        # Construct and send request
        request = self._client.put(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_local_positive_offset_min_date_time(self, custom_headers={}, raw=False, callback=None):
        """

        Get min datetime value 0001-01-01T00:00:00+14:00

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: datetime or (datetime, requests.response) or
        concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/min/localpositiveoffset'

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
            deserialized = self._deserialize('iso-8601', response)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def put_local_negative_offset_min_date_time(self, datetime_body, custom_headers={}, raw=False, callback=None):
        """

        Put min datetime value 0001-01-01T00:00:00-14:00

        :param datetime_body:
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type datetime_body: datetime
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/min/localnegativeoffset'

        # Construct parameters
        query = {}

        # Construct headers
        headers = {}
        headers.update(custom_headers)
        headers['Content-Type'] = 'application/json; charset=utf-8'

        # Construct body
        content = self._serialize(datetime_body, 'iso-8601')

        # Construct and send request
        request = self._client.put(url, query)
        response = self._client.send(request, headers, content)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def get_local_negative_offset_min_date_time(self, custom_headers={}, raw=False, callback=None):
        """

        Get min datetime value 0001-01-01T00:00:00-14:00

        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: datetime or (datetime, requests.response) or
        concurrent.futures.Future
        """

        # Construct URL
        url = '/datetime/min/localnegativeoffset'

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
            deserialized = self._deserialize('iso-8601', response)

        if raw:
            return deserialized, response

        return deserialized
