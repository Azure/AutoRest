# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class DoubleWrapper(Model):

    _required = []

    _attribute_map = {
        'field1': {'key': 'field1', 'type': 'float'},
        'field_56_zeros_after_the_dot_and_negative_zero_before_dot_and_this_is_a_long_field_name_on_purpose': {'key': 'field_56_zeros_after_the_dot_and_negative_zero_before_dot_and_this_is_a_long_field_name_on_purpose', 'type': 'float'},
    }

    def __init__(self, *args, **kwargs):

        self.field1 = None
        self.field_56_zeros_after_the_dot_and_negative_zero_before_dot_and_this_is_a_long_field_name_on_purpose = None

        super(DoubleWrapper, self).__init__(*args, **kwargs)
