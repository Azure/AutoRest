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
from . import models


class AutoRestResourceFlatteningTestServiceConfiguration(Configuration):
    """Configuration for AutoRestResourceFlatteningTestService
    Note that all parameters used to create this instance are saved as instance
    attributes.

    :param str base_url: Service URL
    :param str filepath: Existing config
    """

    def __init__(
            self, base_url=None, filepath=None):

        if not base_url:
            base_url = 'http://localhost'

        super(AutoRestResourceFlatteningTestServiceConfiguration, self).__init__(base_url, filepath)

        self.add_user_agent('autorestresourceflatteningtestservice/{}'.format(VERSION))


class AutoRestResourceFlatteningTestService(object):
    """Resource Flattening for AutoRest

    :ivar config: Configuration for client.
    :vartype config: AutoRestResourceFlatteningTestServiceConfiguration

    :param str base_url: Service URL
    :param str filepath: Existing config
    """

    def __init__(
            self, base_url=None, filepath=None):

        self.config = AutoRestResourceFlatteningTestServiceConfiguration(base_url, filepath)
        self._client = ServiceClient(None, self.config)

        client_models = {k: v for k, v in models.__dict__.items() if isinstance(v, type)}
        self._serialize = Serializer(client_models)
        self._deserialize = Deserializer(client_models)


    def put_array(
            self, resource_array=None, custom_headers=None, raw=False, **operation_config):
        """Put External Resource as an Array.

        :param resource_array: External Resource as an Array to put
        :type resource_array: list of :class:`Resource
         <Fixtures.AcceptanceTestsModelFlattening.models.Resource>`
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :rtype: None
        :rtype: :class:`ClientRawResponse<msrest.pipeline.ClientRawResponse>`
         if raw=true
        """
        # Construct URL
        url = '/model-flatten/array'

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct body
        if resource_array is not None:
            body_content = self._serialize.body(resource_array, '[Resource]')
        else:
            body_content = None

        # Construct and send request
        request = self._client.put(url, query_parameters)
        response = self._client.send(
            request, header_parameters, body_content, **operation_config)

        if response.status_code not in [200]:
            raise models.ErrorException(self._deserialize, response)

        if raw:
            client_raw_response = ClientRawResponse(None, response)
            return client_raw_response

    def get_array(
            self, custom_headers=None, raw=False, **operation_config):
        """Get External Resource as an Array.

        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :rtype: list of :class:`FlattenedProduct
         <Fixtures.AcceptanceTestsModelFlattening.models.FlattenedProduct>`
        :rtype: :class:`ClientRawResponse<msrest.pipeline.ClientRawResponse>`
         if raw=true
        """
        # Construct URL
        url = '/model-flatten/array'

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
            raise models.ErrorException(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('[FlattenedProduct]', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized

    def put_dictionary(
            self, resource_dictionary=None, custom_headers=None, raw=False, **operation_config):
        """Put External Resource as a Dictionary.

        :param resource_dictionary: External Resource as a Dictionary to put
        :type resource_dictionary: dict
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :rtype: None
        :rtype: :class:`ClientRawResponse<msrest.pipeline.ClientRawResponse>`
         if raw=true
        """
        # Construct URL
        url = '/model-flatten/dictionary'

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct body
        if resource_dictionary is not None:
            body_content = self._serialize.body(resource_dictionary, '{FlattenedProduct}')
        else:
            body_content = None

        # Construct and send request
        request = self._client.put(url, query_parameters)
        response = self._client.send(
            request, header_parameters, body_content, **operation_config)

        if response.status_code not in [200]:
            raise models.ErrorException(self._deserialize, response)

        if raw:
            client_raw_response = ClientRawResponse(None, response)
            return client_raw_response

    def get_dictionary(
            self, custom_headers=None, raw=False, **operation_config):
        """Get External Resource as a Dictionary.

        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :rtype: dict
        :rtype: :class:`ClientRawResponse<msrest.pipeline.ClientRawResponse>`
         if raw=true
        """
        # Construct URL
        url = '/model-flatten/dictionary'

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
            raise models.ErrorException(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('{FlattenedProduct}', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized

    def put_resource_collection(
            self, resource_complex_object=None, custom_headers=None, raw=False, **operation_config):
        """Put External Resource as a ResourceCollection.

        :param resource_complex_object: External Resource as a
         ResourceCollection to put
        :type resource_complex_object: :class:`ResourceCollection
         <Fixtures.AcceptanceTestsModelFlattening.models.ResourceCollection>`
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :rtype: None
        :rtype: :class:`ClientRawResponse<msrest.pipeline.ClientRawResponse>`
         if raw=true
        """
        # Construct URL
        url = '/model-flatten/resourcecollection'

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct body
        if resource_complex_object is not None:
            body_content = self._serialize.body(resource_complex_object, 'ResourceCollection')
        else:
            body_content = None

        # Construct and send request
        request = self._client.put(url, query_parameters)
        response = self._client.send(
            request, header_parameters, body_content, **operation_config)

        if response.status_code not in [200]:
            raise models.ErrorException(self._deserialize, response)

        if raw:
            client_raw_response = ClientRawResponse(None, response)
            return client_raw_response

    def get_resource_collection(
            self, custom_headers=None, raw=False, **operation_config):
        """Get External Resource as a ResourceCollection.

        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :rtype: :class:`ResourceCollection
         <Fixtures.AcceptanceTestsModelFlattening.models.ResourceCollection>`
        :rtype: :class:`ClientRawResponse<msrest.pipeline.ClientRawResponse>`
         if raw=true
        """
        # Construct URL
        url = '/model-flatten/resourcecollection'

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
            raise models.ErrorException(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('ResourceCollection', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized

    def put_simple_product(
            self, simple_body_product=None, custom_headers=None, raw=False, **operation_config):
        """Put Simple Product with client flattening true on the model.

        :param simple_body_product: Simple body product to put
        :type simple_body_product: :class:`SimpleProduct
         <Fixtures.AcceptanceTestsModelFlattening.models.SimpleProduct>`
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :rtype: :class:`SimpleProduct
         <Fixtures.AcceptanceTestsModelFlattening.models.SimpleProduct>`
        :rtype: :class:`ClientRawResponse<msrest.pipeline.ClientRawResponse>`
         if raw=true
        """
        # Construct URL
        url = '/model-flatten/customFlattening'

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct body
        if simple_body_product is not None:
            body_content = self._serialize.body(simple_body_product, 'SimpleProduct')
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
            deserialized = self._deserialize('SimpleProduct', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized

    def post_flattened_simple_product(
            self, product_id, max_product_display_name, description=None, generic_value=None, odatavalue=None, custom_headers=None, raw=False, **operation_config):
        """Put Flattened Simple Product with client flattening true on the
        parameter.

        :param product_id: Unique identifier representing a specific product
         for a given latitude & longitude. For example, uberX in San
         Francisco will have a different product_id than uberX in Los Angeles.
        :type product_id: str
        :param max_product_display_name: Display name of product.
        :type max_product_display_name: str
        :param description: Description of product.
        :type description: str
        :param generic_value: Generic URL value.
        :type generic_value: str
        :param odatavalue: URL value.
        :type odatavalue: str
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :rtype: :class:`SimpleProduct
         <Fixtures.AcceptanceTestsModelFlattening.models.SimpleProduct>`
        :rtype: :class:`ClientRawResponse<msrest.pipeline.ClientRawResponse>`
         if raw=true
        """
        simple_body_product = None
        if product_id is not None or description is not None or max_product_display_name is not None or generic_value is not None or odatavalue is not None:
            simple_body_product = models.SimpleProduct(product_id=product_id, description=description, max_product_display_name=max_product_display_name, generic_value=generic_value, odatavalue=odatavalue)

        # Construct URL
        url = '/model-flatten/customFlattening'

        # Construct parameters
        query_parameters = {}

        # Construct headers
        header_parameters = {}
        header_parameters['Content-Type'] = 'application/json; charset=utf-8'
        if custom_headers:
            header_parameters.update(custom_headers)

        # Construct body
        if simple_body_product is not None:
            body_content = self._serialize.body(simple_body_product, 'SimpleProduct')
        else:
            body_content = None

        # Construct and send request
        request = self._client.post(url, query_parameters)
        response = self._client.send(
            request, header_parameters, body_content, **operation_config)

        if response.status_code not in [200]:
            raise models.ErrorException(self._deserialize, response)

        deserialized = None

        if response.status_code == 200:
            deserialized = self._deserialize('SimpleProduct', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized

    def put_simple_product_with_grouping(
            self, flatten_parameter_group, custom_headers=None, raw=False, **operation_config):
        """Put Simple Product with client flattening true on the model.

        :param flatten_parameter_group: Additional parameters for the
         operation
        :type flatten_parameter_group: :class:`FlattenParameterGroup
         <Fixtures.AcceptanceTestsModelFlattening.models.FlattenParameterGroup>`
        :param dict custom_headers: headers that will be added to the request
        :param bool raw: returns the direct response alongside the
         deserialized response
        :param operation_config: :ref:`Operation configuration
         overrides<msrest:optionsforoperations>`.
        :rtype: :class:`SimpleProduct
         <Fixtures.AcceptanceTestsModelFlattening.models.SimpleProduct>`
        :rtype: :class:`ClientRawResponse<msrest.pipeline.ClientRawResponse>`
         if raw=true
        """
        name = None
        if flatten_parameter_group is not None:
            name = flatten_parameter_group.name
        product_id = None
        if flatten_parameter_group is not None:
            product_id = flatten_parameter_group.product_id
        description = None
        if flatten_parameter_group is not None:
            description = flatten_parameter_group.description
        max_product_display_name = None
        if flatten_parameter_group is not None:
            max_product_display_name = flatten_parameter_group.max_product_display_name
        generic_value = None
        if flatten_parameter_group is not None:
            generic_value = flatten_parameter_group.generic_value
        odatavalue = None
        if flatten_parameter_group is not None:
            odatavalue = flatten_parameter_group.odatavalue
        simple_body_product = None
        if product_id is not None or description is not None or max_product_display_name is not None or generic_value is not None or odatavalue is not None:
            simple_body_product = models.SimpleProduct(product_id=product_id, description=description, max_product_display_name=max_product_display_name, generic_value=generic_value, odatavalue=odatavalue)

        # Construct URL
        url = '/model-flatten/customFlattening/parametergrouping/{name}/'
        path_format_arguments = {
            'name': self._serialize.url("name", name, 'str')
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
        if simple_body_product is not None:
            body_content = self._serialize.body(simple_body_product, 'SimpleProduct')
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
            deserialized = self._deserialize('SimpleProduct', response)

        if raw:
            client_raw_response = ClientRawResponse(deserialized, response)
            return client_raw_response

        return deserialized
