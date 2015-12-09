# encoding: utf-8
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
# 
# Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module LroModule
  module Models
    #
    # Model object.
    #
    class OperationResult

      include MsRestAzure

      # @return The status of the request. Possible values for this property
      # include: 'Succeeded', 'Failed', 'canceled', 'Accepted', 'Creating',
      # 'Created', 'Updating', 'Updated', 'Deleting', 'Deleted', 'OK'.
      attr_accessor :status

      # @return [OperationResultError]
      attr_accessor :error

      #
      # Validate the object. Throws ValidationError if validation fails.
      #
      def validate
        @error.validate unless @error.nil?
      end

      #
      # Serializes given Model object into Ruby Hash.
      # @param object Model object to serialize.
      # @return [Hash] Serialized object in form of Ruby Hash.
      #
      def self.serialize_object(object)
        object.validate
        output_object = {}

        serialized_property = object.status
        output_object['status'] = serialized_property unless serialized_property.nil?

        serialized_property = object.error
        unless serialized_property.nil?
          serialized_property = OperationResultError.serialize_object(serialized_property)
        end
        output_object['error'] = serialized_property unless serialized_property.nil?

        output_object
      end

      #
      # Deserializes given Ruby Hash into Model object.
      # @param object [Hash] Ruby Hash object to deserialize.
      # @return [OperationResult] Deserialized object.
      #
      def self.deserialize_object(object)
        return if object.nil?
        output_object = OperationResult.new

        deserialized_property = object['status']
        output_object.status = deserialized_property

        deserialized_property = object['error']
        unless deserialized_property.nil?
          deserialized_property = OperationResultError.deserialize_object(deserialized_property)
        end
        output_object.error = deserialized_property

        output_object.validate

        output_object
      end
    end
  end
end
