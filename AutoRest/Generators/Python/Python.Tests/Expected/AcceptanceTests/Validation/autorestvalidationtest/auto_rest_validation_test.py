# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.service_client import ServiceClient
from msrest import Configuration, Serializer, Deserializer
from .version import VERSION
from msrest.pipeline import ClientRawResponse
from msrest.exceptions import HttpOperationError
from . import models


class AutoRestValidationTestConfiguration(Configuration):
    """Configuration for AutoRestValidationTest
    Note that all parameters used to create this instance are saved as instance
    attributes.

    :param subscription_id: Subscription ID.
    :type subscription_id: str
    :param api_version: Required string following pattern \\d{2}-\\d{2}-\\d{4}
    :type api_version: str
    :param str base_url: Service URL
    :param str filepath: Existing config
    """

    def __init__(
            self, subscription_id, api_version, base_url=None, filepath=None):

        if subscription_id is None:
            raise ValueError('subscription_id must not be None.')
        if api_version is None:
            raise ValueError('api_version must not be None.')
        if not base_url:
            base_url = 'http://localhost'

        super(AutoRestValidationTestConfiguration, self).__init__(base_url, filepath)

        self.add_user_agent('autorestvalidationtest/{}'.format(VERSION))

        self.subscription_id = subscription_id
        self.api_version = api_version


class AutoRestValidationTest(object):
    """Test Infrastructure for AutoRest. No server backend exists for these tests.

    :param config: Configuration for client.
    :type config: AutoRestValidationTestConfiguration
    """

    def __init__(self, config):

        self._client = ServiceClient(None, config)

        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}
        self._serialize = Serializer()
        self._deserialize = Deserializer(client_models)

        self.config = config

    def validation_of_method_parameters(
            self, resource_group_name, id, custom_headers={}, raw=False, **operation_config):
        """
        Validates input parameters on the method. See swagger for details.

        :param resource_group_name: Required string between 3 and 10 chars
         with pattern [a-zA-Z0-9]+.
        :type resource_group_name: str
        :param id: Required int multiple of 10 from 100 to 1000.
        :type id: int
        :param dict custom_headers: headers that will be added to the request
        :param boolean raw: returns the direct response alongside the
         deserialized response
        :rtype: Product
        :rtype: msrest.pipeline.ClientRawResponse if raw=True
        """
        # Construct URL
        url = '/fakepath/{subscriptionId}/{resourceGroupName}/{id}'
        path_format_arguments = {
            'subscriptionId': self._serialize.url("self.config.subscription_id", self.config.subscription_id, 'str'),
            'resourceGroupName': self._serialize.url("resource_group_name", resource_group_name, 'str', max_length=10, min_length=3, pattern='[a-zA-Z0-9]+'),
            'id': self._serialize.url("id", id, 'int', maximum=1000, minimum=100, multiple=10)
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}
        query_parameters['apiVersion'] = self._serialize.query("self.config.api_version", self.config.api_version, 'str', pattern='\d{2}-\d{2}-\d{4}')

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters, **operation_config)

        if response.status_code not in [200]:
            raise models.ErrorException(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('Product', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized

    def validation_of_body(
            self, resource_group_name, id, body=None, custom_headers={}, raw=False, **operation_config):
        """
        Validates body parameters on the method. See swagger for details.

        :param resource_group_name: Required string between 3 and 10 chars
         with pattern [a-zA-Z0-9]+.
        :type resource_group_name: str
        :param id: Required int multiple of 10 from 100 to 1000.
        :type id: int
        :param body:
        :type body: Product
        :param dict custom_headers: headers that will be added to the request
        :param boolean raw: returns the direct response alongside the
         deserialized response
        :rtype: Product
        :rtype: msrest.pipeline.ClientRawResponse if raw=True
        """
        # Construct URL
        url = '/fakepath/{subscriptionId}/{resourceGroupName}/{id}'
        path_format_arguments = {
            'subscriptionId': self._serialize.url("self.config.subscription_id", self.config.subscription_id, 'str'),
            'resourceGroupName': self._serialize.url("resource_group_name", resource_group_name, 'str', max_length=10, min_length=3, pattern='[a-zA-Z0-9]+'),
            'id': self._serialize.url("id", id, 'int', maximum=1000, minimum=100, multiple=10)
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}
        query_parameters['apiVersion'] = self._serialize.query("self.config.api_version", self.config.api_version, 'str', pattern='\d{2}-\d{2}-\d{4}')

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct body
        if body is not None:
            body_content = self._serialize.body(body, 'Product')
        else:
            body_content = None

        # Construct and send request
        request = self._client.put(url, query_parameters)
        response = self._client.send(
            request, header_parameters, body_content, **operation_config)

        if response.status_code not in [200]:
            raise models.ErrorException(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('Product', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized

    def get_with_constant_in_path(
            self, constant_param="constant", custom_headers={}, raw=False, **operation_config):
        """

        :param constant_param: Possible values include: 'constant'
        :type constant_param: str
        :param dict custom_headers: headers that will be added to the request
        :param boolean raw: returns the direct response alongside the
         deserialized response
        :rtype: None
        :rtype: msrest.pipeline.ClientRawResponse if raw=True
        """
        # Construct URL
        url = '/validation/constantsInPath/{constantParam}/value'
        path_format_arguments = {
            'constantParam': self._serialize.url("constant_param", constant_param, 'str')
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct and send request
        request = self._client.get(url, query_parameters)
        response = self._client.send(request, header_parameters, **operation_config)

        if response.status_code not in [200]:
            raise HttpOperationError(self._deserialize, response)

        if raw:
            client_raw_response = ClientRawResponse(None, response)
            return client_raw_response

    def post_with_constant_in_body(
            self, constant_param="constant", body=None, custom_headers={}, raw=False, **operation_config):
        """

        :param constant_param: Possible values include: 'constant'
        :type constant_param: str
        :param body:
        :type body: Product
        :param dict custom_headers: headers that will be added to the request
        :param boolean raw: returns the direct response alongside the
         deserialized response
        :rtype: Product
        :rtype: msrest.pipeline.ClientRawResponse if raw=True
        """
        # Construct URL
        url = '/validation/constantsInPath/{constantParam}/value'
        path_format_arguments = {
            'constantParam': self._serialize.url("constant_param", constant_param, 'str')
        }
        url = self._client.format_url(url, **path_format_arguments)

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct body
        if body is not None:
            body_content = self._serialize.body(body, 'Product')
        else:
            body_content = None

        # Construct and send request
        request = self._client.post(url, query_parameters)
        response = self._client.send(
            request, header_parameters, body_content, **operation_config)

        if response.status_code not in [200]:
            raise HttpOperationError(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('Product', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized
