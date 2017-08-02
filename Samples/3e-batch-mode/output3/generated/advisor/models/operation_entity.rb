# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator.
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module Advisor
  module Models
    #
    # The operation supported by Advisor.
    #
    class OperationEntity
      # @return [String] Operation name: {provider}/{resource}/{operation}.
      attr_accessor :name

      # @return [OperationDisplayInfo] The operation supported by Advisor.
      attr_accessor :display


      #
      # Mapper for OperationEntity class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          required: false,
          serialized_name: 'OperationEntity',
          type: {
            name: 'Composite',
            class_name: 'OperationEntity',
            model_properties: {
              name: {
                required: false,
                serialized_name: 'name',
                type: {
                  name: 'String'
                }
              },
              display: {
                required: false,
                serialized_name: 'display',
                type: {
                  name: 'Composite',
                  class_name: 'OperationDisplayInfo'
                }
              }
            }
          }
        }
      end
    end
  end
end
