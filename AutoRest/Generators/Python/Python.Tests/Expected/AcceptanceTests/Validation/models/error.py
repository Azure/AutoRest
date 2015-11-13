#--------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
# 
# Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
#--------------------------------------------------------------------------

from msrest.exceptions import ServerException

class Error(object):

    _required = []

    _attribute_map = {
        'code':{'key':'code', 'type':'int'},
        'message':{'key':'message', 'type':'str'},
        'fields':{'key':'fields', 'type':'str'},
    }

    def __init__(self, *args, **kwargs):

        self.code = None
        self.message = None
        self.fields = None

        for k in kwargs:
            if hasattr(self, k):
                setattr(self, k, kwargs[k])

class ErrorException(ServerException):

    def __init__(self, response, *args):

        super(ErrorException, self).__init__(response, 'Error', *args)
