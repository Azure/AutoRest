# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from .pet import Pet


class Cat(Pet):
    """Cat

    :param str color
    :param list hates
    """

    _required = []

    _attribute_map = {
        'color': {'key': 'color', 'type': 'str'},
        'hates': {'key': 'hates', 'type': '[Dog]'},
    }

    def __init__(self, *args, **kwargs):
        self.color = None
        self.hates = None

        super(Cat, self).__init__(*args, **kwargs)
