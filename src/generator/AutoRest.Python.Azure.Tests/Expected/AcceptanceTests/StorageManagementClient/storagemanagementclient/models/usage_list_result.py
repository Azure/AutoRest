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

from msrest.serialization import Model


class UsageListResult(Model):
    """The List Usages operation response.

    :param value: Gets or sets the list Storage Resource Usages.
    :type value: list of :class:`Usage
     <fixtures.acceptancetestsstoragemanagementclient.models.Usage>`
    """ 

    _attribute_map = {
        'value': {'key': 'value', 'type': '[Usage]'},
    }

    def __init__(self, value=None):
        self.value = value
