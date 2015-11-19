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


class StorageAccountProperties(Model):

    _required = []

    _attribute_map = {
        'provisioning_state': {'key': 'provisioningState', 'type': 'ProvisioningState'},
        'account_type': {'key': 'accountType', 'type': 'AccountType'},
        'primary_endpoints': {'key': 'primaryEndpoints', 'type': 'Endpoints'},
        'primary_location': {'key': 'primaryLocation', 'type': 'str'},
        'status_of_primary': {'key': 'statusOfPrimary', 'type': 'AccountStatus'},
        'last_geo_failover_time': {'key': 'lastGeoFailoverTime', 'type': 'iso-11'},
        'secondary_location': {'key': 'secondaryLocation', 'type': 'str'},
        'status_of_secondary': {'key': 'statusOfSecondary', 'type': 'AccountStatus'},
        'creation_time': {'key': 'creationTime', 'type': 'iso-11'},
        'custom_domain': {'key': 'customDomain', 'type': 'CustomDomain'},
        'secondary_endpoints': {'key': 'secondaryEndpoints', 'type': 'Endpoints'},
    }

    def __init__(self, *args, **kwargs):

        self.provisioning_state = None
        self.account_type = None
        self.primary_endpoints = None
        self.primary_location = None
        self.status_of_primary = None
        self.last_geo_failover_time = None
        self.secondary_location = None
        self.status_of_secondary = None
        self.creation_time = None
        self.custom_domain = None
        self.secondary_endpoints = None

        super(StorageAccountProperties, self).__init__(*args, **kwargs)
