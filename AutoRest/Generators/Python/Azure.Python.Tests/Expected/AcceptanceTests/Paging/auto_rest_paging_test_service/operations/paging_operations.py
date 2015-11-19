# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

import sys


from msrest.service_client import ServiceClient, async_request
from msrest.serialization import Serializer, Deserializer
from msrest.exceptions import (
    SerializationError,
    DeserializationError,
    TokenExpiredError,
    ClientRequestError,
    HttpOperationError)
import uuid

from ..models import *


class pagingOperations(object):

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

    @async_request
    def get_single_pages(self, custom_headers={}, raw=False, callback=None):
        """

        A paging operation that finishes on the first call without a nextlink

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

        def paging(next_link=None, raw=False):

            if next_link is None:
                # Construct URL
                url = '/paging/single'

                # Construct parameters
                query = {}

            else:
                url = next_link
                query = {}

            # Construct headers
            headers = {}
            if self.config.acceptlanguage is not None:
                query['accept-language'] = self.config.acceptlanguage
            headers.update(custom_headers)
            headers['x-ms-client-request-id'] = str(uuid.uuid1())
            headers['Content-Type'] = 'application/json; charset=utf-8'

            # Construct and send request
            request = self._client.get(url, query)
            response = self._client.send(request, headers)

            if response.status_code not in [200]:
                raise CloudException(self._deserialize, response)

            return response

        response = paging()

        # Deserialize response
        deserialized = ProductPaged(response, paging, self._deserialize.dependencies)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_multiple_pages(self, clientrequestid, custom_headers={}, raw=False, callback=None):
        """

        A paging operation that includes a nextLink that has 10 pages

        :param clientrequestid:
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type clientrequestid: str or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: object or (object, requests.response) or
        concurrent.futures.Future
        """

        def paging(next_link=None, raw=False):

            if next_link is None:
                # Construct URL
                url = '/paging/multiple'

                # Construct parameters
                query = {}

            else:
                url = next_link
                query = {}

            # Construct headers
            headers = {}
            if clientrequestid is not None:
                query['client-request-id'] = clientrequestid
                if self.config.acceptlanguage is not None:
                    query['accept-language'] = self.config.acceptlanguage
            headers.update(custom_headers)
            headers['x-ms-client-request-id'] = str(uuid.uuid1())
            headers['Content-Type'] = 'application/json; charset=utf-8'

            # Construct and send request
            request = self._client.get(url, query)
            response = self._client.send(request, headers)

            if response.status_code not in [200]:
                raise CloudException(self._deserialize, response)

            return response

        response = paging()

        # Deserialize response
        deserialized = ProductPaged(response, paging, self._deserialize.dependencies)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_multiple_pages_retry_first(self, custom_headers={}, raw=False, callback=None):
        """

        A paging operation that fails on the first call with 500 and then
        retries and then get a response including a nextLink that has 10 pages

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

        def paging(next_link=None, raw=False):

            if next_link is None:
                # Construct URL
                url = '/paging/multiple/retryfirst'

                # Construct parameters
                query = {}

            else:
                url = next_link
                query = {}

            # Construct headers
            headers = {}
            if self.config.acceptlanguage is not None:
                query['accept-language'] = self.config.acceptlanguage
            headers.update(custom_headers)
            headers['x-ms-client-request-id'] = str(uuid.uuid1())
            headers['Content-Type'] = 'application/json; charset=utf-8'

            # Construct and send request
            request = self._client.get(url, query)
            response = self._client.send(request, headers)

            if response.status_code not in [200]:
                raise CloudException(self._deserialize, response)

            return response

        response = paging()

        # Deserialize response
        deserialized = ProductPaged(response, paging, self._deserialize.dependencies)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_multiple_pages_retry_second(self, custom_headers={}, raw=False, callback=None):
        """

        A paging operation that includes a nextLink that has 10 pages, of
        which the 2nd call fails first with 500. The client should retry and
        finish all 10 pages eventually.

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

        def paging(next_link=None, raw=False):

            if next_link is None:
                # Construct URL
                url = '/paging/multiple/retrysecond'

                # Construct parameters
                query = {}

            else:
                url = next_link
                query = {}

            # Construct headers
            headers = {}
            if self.config.acceptlanguage is not None:
                query['accept-language'] = self.config.acceptlanguage
            headers.update(custom_headers)
            headers['x-ms-client-request-id'] = str(uuid.uuid1())
            headers['Content-Type'] = 'application/json; charset=utf-8'

            # Construct and send request
            request = self._client.get(url, query)
            response = self._client.send(request, headers)

            if response.status_code not in [200]:
                raise CloudException(self._deserialize, response)

            return response

        response = paging()

        # Deserialize response
        deserialized = ProductPaged(response, paging, self._deserialize.dependencies)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_single_pages_failure(self, custom_headers={}, raw=False, callback=None):
        """

        A paging operation that receives a 400 on the first call

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

        def paging(next_link=None, raw=False):

            if next_link is None:
                # Construct URL
                url = '/paging/single/failure'

                # Construct parameters
                query = {}

            else:
                url = next_link
                query = {}

            # Construct headers
            headers = {}
            if self.config.acceptlanguage is not None:
                query['accept-language'] = self.config.acceptlanguage
            headers.update(custom_headers)
            headers['x-ms-client-request-id'] = str(uuid.uuid1())
            headers['Content-Type'] = 'application/json; charset=utf-8'

            # Construct and send request
            request = self._client.get(url, query)
            response = self._client.send(request, headers)

            if response.status_code not in [200]:
                raise CloudException(self._deserialize, response)

            return response

        response = paging()

        # Deserialize response
        deserialized = ProductPaged(response, paging, self._deserialize.dependencies)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_multiple_pages_failure(self, custom_headers={}, raw=False, callback=None):
        """

        A paging operation that receives a 400 on the second call

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

        def paging(next_link=None, raw=False):

            if next_link is None:
                # Construct URL
                url = '/paging/multiple/failure'

                # Construct parameters
                query = {}

            else:
                url = next_link
                query = {}

            # Construct headers
            headers = {}
            if self.config.acceptlanguage is not None:
                query['accept-language'] = self.config.acceptlanguage
            headers.update(custom_headers)
            headers['x-ms-client-request-id'] = str(uuid.uuid1())
            headers['Content-Type'] = 'application/json; charset=utf-8'

            # Construct and send request
            request = self._client.get(url, query)
            response = self._client.send(request, headers)

            if response.status_code not in [200]:
                raise CloudException(self._deserialize, response)

            return response

        response = paging()

        # Deserialize response
        deserialized = ProductPaged(response, paging, self._deserialize.dependencies)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_multiple_pages_failure_uri(self, custom_headers={}, raw=False, callback=None):
        """

        A paging operation that receives an invalid nextLink

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

        def paging(next_link=None, raw=False):

            if next_link is None:
                # Construct URL
                url = '/paging/multiple/failureuri'

                # Construct parameters
                query = {}

            else:
                url = next_link
                query = {}

            # Construct headers
            headers = {}
            if self.config.acceptlanguage is not None:
                query['accept-language'] = self.config.acceptlanguage
            headers.update(custom_headers)
            headers['x-ms-client-request-id'] = str(uuid.uuid1())
            headers['Content-Type'] = 'application/json; charset=utf-8'

            # Construct and send request
            request = self._client.get(url, query)
            response = self._client.send(request, headers)

            if response.status_code not in [200]:
                raise CloudException(self._deserialize, response)

            return response

        response = paging()

        # Deserialize response
        deserialized = ProductPaged(response, paging, self._deserialize.dependencies)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_single_pages_next(self, next_page_link, custom_headers={}, raw=False, callback=None):
        """

        A paging operation that finishes on the first call without a nextlink

        :param next_page_link: The NextLink from the previous successful call
        to List operation.
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type next_page_link: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: object or (object, requests.response) or
        concurrent.futures.Future
        """

        def paging(next_link=None, raw=False):

            if next_link is None:
                # Construct URL
                url = '{nextLink}'
                path_format_arguments = {
                    'nextLink': self._parse_url("next_page_link", next_page_link, 'str', True)}
                url = url.format(**path_format_arguments)

                # Construct parameters
                query = {}

            else:
                url = next_link
                query = {}

            # Construct headers
            headers = {}
            if self.config.acceptlanguage is not None:
                query['accept-language'] = self.config.acceptlanguage
            headers.update(custom_headers)
            headers['x-ms-client-request-id'] = str(uuid.uuid1())
            headers['Content-Type'] = 'application/json; charset=utf-8'

            # Construct and send request
            request = self._client.get(url, query)
            response = self._client.send(request, headers)

            if response.status_code not in [200]:
                raise CloudException(self._deserialize, response)

            return response

        response = paging()

        # Deserialize response
        deserialized = ProductPaged(response, paging, self._deserialize.dependencies)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_multiple_pages_next(self, next_page_link, clientrequestid, custom_headers={}, raw=False, callback=None):
        """

        A paging operation that includes a nextLink that has 10 pages

        :param next_page_link: The NextLink from the previous successful call
        to List operation.
        :param clientrequestid:
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type next_page_link: str
        :type clientrequestid: str or none
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: object or (object, requests.response) or
        concurrent.futures.Future
        """

        def paging(next_link=None, raw=False):

            if next_link is None:
                # Construct URL
                url = '{nextLink}'
                path_format_arguments = {
                    'nextLink': self._parse_url("next_page_link", next_page_link, 'str', True)}
                url = url.format(**path_format_arguments)

                # Construct parameters
                query = {}

            else:
                url = next_link
                query = {}

            # Construct headers
            headers = {}
            if clientrequestid is not None:
                query['client-request-id'] = clientrequestid
                if self.config.acceptlanguage is not None:
                    query['accept-language'] = self.config.acceptlanguage
            headers.update(custom_headers)
            headers['x-ms-client-request-id'] = str(uuid.uuid1())
            headers['Content-Type'] = 'application/json; charset=utf-8'

            # Construct and send request
            request = self._client.get(url, query)
            response = self._client.send(request, headers)

            if response.status_code not in [200]:
                raise CloudException(self._deserialize, response)

            return response

        response = paging()

        # Deserialize response
        deserialized = ProductPaged(response, paging, self._deserialize.dependencies)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_multiple_pages_retry_first_next(self, next_page_link, custom_headers={}, raw=False, callback=None):
        """

        A paging operation that fails on the first call with 500 and then
        retries and then get a response including a nextLink that has 10 pages

        :param next_page_link: The NextLink from the previous successful call
        to List operation.
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type next_page_link: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: object or (object, requests.response) or
        concurrent.futures.Future
        """

        def paging(next_link=None, raw=False):

            if next_link is None:
                # Construct URL
                url = '{nextLink}'
                path_format_arguments = {
                    'nextLink': self._parse_url("next_page_link", next_page_link, 'str', True)}
                url = url.format(**path_format_arguments)

                # Construct parameters
                query = {}

            else:
                url = next_link
                query = {}

            # Construct headers
            headers = {}
            if self.config.acceptlanguage is not None:
                query['accept-language'] = self.config.acceptlanguage
            headers.update(custom_headers)
            headers['x-ms-client-request-id'] = str(uuid.uuid1())
            headers['Content-Type'] = 'application/json; charset=utf-8'

            # Construct and send request
            request = self._client.get(url, query)
            response = self._client.send(request, headers)

            if response.status_code not in [200]:
                raise CloudException(self._deserialize, response)

            return response

        response = paging()

        # Deserialize response
        deserialized = ProductPaged(response, paging, self._deserialize.dependencies)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_multiple_pages_retry_second_next(self, next_page_link, custom_headers={}, raw=False, callback=None):
        """

        A paging operation that includes a nextLink that has 10 pages, of
        which the 2nd call fails first with 500. The client should retry and
        finish all 10 pages eventually.

        :param next_page_link: The NextLink from the previous successful call
        to List operation.
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type next_page_link: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: object or (object, requests.response) or
        concurrent.futures.Future
        """

        def paging(next_link=None, raw=False):

            if next_link is None:
                # Construct URL
                url = '{nextLink}'
                path_format_arguments = {
                    'nextLink': self._parse_url("next_page_link", next_page_link, 'str', True)}
                url = url.format(**path_format_arguments)

                # Construct parameters
                query = {}

            else:
                url = next_link
                query = {}

            # Construct headers
            headers = {}
            if self.config.acceptlanguage is not None:
                query['accept-language'] = self.config.acceptlanguage
            headers.update(custom_headers)
            headers['x-ms-client-request-id'] = str(uuid.uuid1())
            headers['Content-Type'] = 'application/json; charset=utf-8'

            # Construct and send request
            request = self._client.get(url, query)
            response = self._client.send(request, headers)

            if response.status_code not in [200]:
                raise CloudException(self._deserialize, response)

            return response

        response = paging()

        # Deserialize response
        deserialized = ProductPaged(response, paging, self._deserialize.dependencies)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_single_pages_failure_next(self, next_page_link, custom_headers={}, raw=False, callback=None):
        """

        A paging operation that receives a 400 on the first call

        :param next_page_link: The NextLink from the previous successful call
        to List operation.
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type next_page_link: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: object or (object, requests.response) or
        concurrent.futures.Future
        """

        def paging(next_link=None, raw=False):

            if next_link is None:
                # Construct URL
                url = '{nextLink}'
                path_format_arguments = {
                    'nextLink': self._parse_url("next_page_link", next_page_link, 'str', True)}
                url = url.format(**path_format_arguments)

                # Construct parameters
                query = {}

            else:
                url = next_link
                query = {}

            # Construct headers
            headers = {}
            if self.config.acceptlanguage is not None:
                query['accept-language'] = self.config.acceptlanguage
            headers.update(custom_headers)
            headers['x-ms-client-request-id'] = str(uuid.uuid1())
            headers['Content-Type'] = 'application/json; charset=utf-8'

            # Construct and send request
            request = self._client.get(url, query)
            response = self._client.send(request, headers)

            if response.status_code not in [200]:
                raise CloudException(self._deserialize, response)

            return response

        response = paging()

        # Deserialize response
        deserialized = ProductPaged(response, paging, self._deserialize.dependencies)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_multiple_pages_failure_next(self, next_page_link, custom_headers={}, raw=False, callback=None):
        """

        A paging operation that receives a 400 on the second call

        :param next_page_link: The NextLink from the previous successful call
        to List operation.
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type next_page_link: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: object or (object, requests.response) or
        concurrent.futures.Future
        """

        def paging(next_link=None, raw=False):

            if next_link is None:
                # Construct URL
                url = '{nextLink}'
                path_format_arguments = {
                    'nextLink': self._parse_url("next_page_link", next_page_link, 'str', True)}
                url = url.format(**path_format_arguments)

                # Construct parameters
                query = {}

            else:
                url = next_link
                query = {}

            # Construct headers
            headers = {}
            if self.config.acceptlanguage is not None:
                query['accept-language'] = self.config.acceptlanguage
            headers.update(custom_headers)
            headers['x-ms-client-request-id'] = str(uuid.uuid1())
            headers['Content-Type'] = 'application/json; charset=utf-8'

            # Construct and send request
            request = self._client.get(url, query)
            response = self._client.send(request, headers)

            if response.status_code not in [200]:
                raise CloudException(self._deserialize, response)

            return response

        response = paging()

        # Deserialize response
        deserialized = ProductPaged(response, paging, self._deserialize.dependencies)

        if raw:
            return deserialized, response

        return deserialized

    @async_request
    def get_multiple_pages_failure_uri_next(self, next_page_link, custom_headers={}, raw=False, callback=None):
        """

        A paging operation that receives an invalid nextLink

        :param next_page_link: The NextLink from the previous successful call
        to List operation.
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type next_page_link: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: object or (object, requests.response) or
        concurrent.futures.Future
        """

        def paging(next_link=None, raw=False):

            if next_link is None:
                # Construct URL
                url = '{nextLink}'
                path_format_arguments = {
                    'nextLink': self._parse_url("next_page_link", next_page_link, 'str', True)}
                url = url.format(**path_format_arguments)

                # Construct parameters
                query = {}

            else:
                url = next_link
                query = {}

            # Construct headers
            headers = {}
            if self.config.acceptlanguage is not None:
                query['accept-language'] = self.config.acceptlanguage
            headers.update(custom_headers)
            headers['x-ms-client-request-id'] = str(uuid.uuid1())
            headers['Content-Type'] = 'application/json; charset=utf-8'

            # Construct and send request
            request = self._client.get(url, query)
            response = self._client.send(request, headers)

            if response.status_code not in [200]:
                raise CloudException(self._deserialize, response)

            return response

        response = paging()

        # Deserialize response
        deserialized = ProductPaged(response, paging, self._deserialize.dependencies)

        if raw:
            return deserialized, response

        return deserialized
