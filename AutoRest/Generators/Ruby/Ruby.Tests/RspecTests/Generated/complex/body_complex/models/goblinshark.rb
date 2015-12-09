# encoding: utf-8
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
# 
# Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module ComplexModule
  module Models
    #
    # Model object.
    #
    class Goblinshark < Shark
      # @return [Integer]
      attr_accessor :jawsize

      #
      # Validate the object. Throws ValidationError if validation fails.
      #
      def validate
        # Nothing to validate
      end

      #
      # Serializes given Model object into Ruby Hash.
      # @param object Model object to serialize.
      # @return [Hash] Serialized object in form of Ruby Hash.
      #
      def self.serialize_object(object)
        object.validate
        output_object = {}

        unless object.fishtype.nil? or object.fishtype == "goblin"
          class_name = @@discriminatorMap[object.fishtype].capitalize
          class_instance = Models.const_get(class_name)
          output_object = class_instance.serialize_object(object)
        else
          output_object['fishtype'] = object.fishtype
        end

        serialized_property = object.length
        output_object['length'] = serialized_property unless serialized_property.nil?

        serialized_property = object.birthday
        serialized_property = serialized_property.new_offset(0).strftime('%FT%TZ')
        output_object['birthday'] = serialized_property unless serialized_property.nil?

        serialized_property = object.species
        output_object['species'] = serialized_property unless serialized_property.nil?

        serialized_property = object.siblings
        unless serialized_property.nil?
          serializedArray = []
          serialized_property.each do |element|
            unless element.nil?
              element = Fish.serialize_object(element)
            end
            serializedArray.push(element)
          end
          serialized_property = serializedArray
        end
        output_object['siblings'] = serialized_property unless serialized_property.nil?

        serialized_property = object.age
        output_object['age'] = serialized_property unless serialized_property.nil?

        serialized_property = object.jawsize
        output_object['jawsize'] = serialized_property unless serialized_property.nil?

        output_object
      end

      #
      # Deserializes given Ruby Hash into Model object.
      # @param object [Hash] Ruby Hash object to deserialize.
      # @return [Goblinshark] Deserialized object.
      #
      def self.deserialize_object(object)
        return if object.nil?
        output_object = Goblinshark.new

        unless object['fishtype'].nil? or object['fishtype'] == "goblin"
          class_name = @@discriminatorMap[object['fishtype']].capitalize
          class_instance = Models.const_get(class_name)
          output_object = class_instance.deserialize_object(object)
        else
          output_object.fishtype = object['fishtype']
        end

        deserialized_property = object['length']
        deserialized_property = Float(deserialized_property) unless deserialized_property.to_s.empty?
        output_object.length = deserialized_property

        deserialized_property = object['birthday']
        deserialized_property = DateTime.parse(deserialized_property) unless deserialized_property.to_s.empty?
        output_object.birthday = deserialized_property

        deserialized_property = object['species']
        output_object.species = deserialized_property

        deserialized_property = object['siblings']
        unless deserialized_property.nil?
          deserializedArray = [];
          deserialized_property.each do |element1|
            unless element1.nil?
              element1 = Fish.deserialize_object(element1)
            end
            deserializedArray.push(element1);
          end
          deserialized_property = deserializedArray;
        end
        output_object.siblings = deserialized_property

        deserialized_property = object['age']
        deserialized_property = Integer(deserialized_property) unless deserialized_property.to_s.empty?
        output_object.age = deserialized_property

        deserialized_property = object['jawsize']
        deserialized_property = Integer(deserialized_property) unless deserialized_property.to_s.empty?
        output_object.jawsize = deserialized_property

        output_object.validate

        output_object
      end

      def initialize
        @fishtype = "goblin"
      end

      attr_accessor :fishtype
    end
  end
end
