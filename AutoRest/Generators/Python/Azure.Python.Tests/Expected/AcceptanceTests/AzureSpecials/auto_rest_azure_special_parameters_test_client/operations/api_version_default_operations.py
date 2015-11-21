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


class api_version_defaultOperations(object):

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
    def get_method_global_valid(self, custom_headers={}, raw=False, callback=None):
        """

        GET method with api-version modeled in global settings.

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
        url = '/azurespecials/apiVersion/method/string/none/query/global/2015-07-01-preview'

        # Construct parameters
        query = {}
        query['api-version'] = self._serialize_data("self.config.api_version", self.config.api_version, 'str')

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
    def get_method_global_not_provided_valid(self, custom_headers={}, raw=False, callback=None):
        """

        GET method with api-version modeled in global settings.

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
        url = '/azurespecials/apiVersion/method/string/none/query/globalNotProvided/2015-07-01-preview'

        # Construct parameters
        query = {}
        query['api-version'] = self._serialize_data("self.config.api_version", self.config.api_version, 'str')

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
    def get_path_global_valid(self, custom_headers={}, raw=False, callback=None):
        """

        GET method with api-version modeled in global settings.

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
        url = '/azurespecials/apiVersion/path/string/none/query/global/2015-07-01-preview'

        # Construct parameters
        query = {}
        query['api-version'] = self._serialize_data("self.config.api_version", self.config.api_version, 'str')

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
    def get_swagger_global_valid(self, custom_headers={}, raw=False, callback=None):
        """

        GET method with api-version modeled in global settings.

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
        url = '/azurespecials/apiVersion/swagger/string/none/query/global/2015-07-01-preview'

        # Construct parameters
        query = {}
        query['api-version'] = self._serialize_data("self.config.api_version", self.config.api_version, 'str')

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
