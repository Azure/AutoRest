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
from msrestazure.azure_exceptions import CloudError
import uuid

from ..models import *


class subscription_in_methodOperations(object):

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
    def post_method_local_valid(self, subscription_id, custom_headers={}, raw=False, callback=None):
        """

        POST method with subscriptionId modeled in the method.  pass in
        subscription id = '1234-5678-9012-3456' to succeed

        :param subscription_id: This should appear as a method parameter, use
        value '1234-5678-9012-3456'
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type subscription_id: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/azurespecials/subscriptionId/method/string/none/path/local/1234-5678-9012-3456/{subscriptionId}'
        path_format_arguments = {
            'subscriptionId': self._serialize_data("subscription_id", subscription_id, 'str')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters['x-ms-client-request-id'] = str(uuid.uuid1())
        header_parameters.update(custom_headers)
        if self.config.accept_language is not None:
            header_parameters['accept-language'] = self._serialize_data("self.config.accept_language", self.config.accept_language, 'str')

        # Construct and send request
        request = self._client.post(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def post_method_local_null(self, subscription_id, custom_headers={}, raw=False, callback=None):
        """

        POST method with subscriptionId modeled in the method.  pass in
        subscription id = null, client-side validation should prevent you
        from making this call

        :param subscription_id: This should appear as a method parameter, use
        value null, client-side validation should prvenet the call
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type subscription_id: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/azurespecials/subscriptionId/method/string/none/path/local/null/{subscriptionId}'
        path_format_arguments = {
            'subscriptionId': self._serialize_data("subscription_id", subscription_id, 'str')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters['x-ms-client-request-id'] = str(uuid.uuid1())
        header_parameters.update(custom_headers)
        if self.config.accept_language is not None:
            header_parameters['accept-language'] = self._serialize_data("self.config.accept_language", self.config.accept_language, 'str')

        # Construct and send request
        request = self._client.post(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def post_path_local_valid(self, subscription_id, custom_headers={}, raw=False, callback=None):
        """

        POST method with subscriptionId modeled in the method.  pass in
        subscription id = '1234-5678-9012-3456' to succeed

        :param subscription_id: Should appear as a method parameter -use value
        '1234-5678-9012-3456'
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type subscription_id: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/azurespecials/subscriptionId/path/string/none/path/local/1234-5678-9012-3456/{subscriptionId}'
        path_format_arguments = {
            'subscriptionId': self._serialize_data("subscription_id", subscription_id, 'str')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters['x-ms-client-request-id'] = str(uuid.uuid1())
        header_parameters.update(custom_headers)
        if self.config.accept_language is not None:
            header_parameters['accept-language'] = self._serialize_data("self.config.accept_language", self.config.accept_language, 'str')

        # Construct and send request
        request = self._client.post(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response

    @async_request
    def post_swagger_local_valid(self, subscription_id, custom_headers={}, raw=False, callback=None):
        """

        POST method with subscriptionId modeled in the method.  pass in
        subscription id = '1234-5678-9012-3456' to succeed

        :param subscription_id: The subscriptionId, which appears in the path,
        the value is always '1234-5678-9012-3456'
        :param custom_headers: headers that will be added to the request
        :param raw: returns the direct response alongside the deserialized
        response
        :param callback: if provided, the call will run asynchronously and
        call the callback when complete.  When specified the function returns
        a concurrent.futures.Future
        :type subscription_id: str
        :type custom_headers: dict
        :type raw: boolean
        :type callback: Callable[[concurrent.futures.Future], None] or None
        :rtype: None or (None, requests.response) or concurrent.futures.Future
        """

        # Construct URL
        url = '/azurespecials/subscriptionId/swagger/string/none/path/local/1234-5678-9012-3456/{subscriptionId}'
        path_format_arguments = {
            'subscriptionId': self._serialize_data("subscription_id", subscription_id, 'str')
        }
        url = url.format(**path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        header_parameters['x-ms-client-request-id'] = str(uuid.uuid1())
        header_parameters.update(custom_headers)
        if self.config.accept_language is not None:
            header_parameters['accept-language'] = self._serialize_data("self.config.accept_language", self.config.accept_language, 'str')

        # Construct and send request
        request = self._client.post(url, query_parameters)
        response = self._client.send(request, header_parameters)

        if response.status_code not in [200]:
            raise ErrorException(self._deserialize, response)

        if raw:
            return None, response
