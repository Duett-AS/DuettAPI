# coding: utf-8

"""
    OpenApi

     ## ![N|Solid](https://duett.no/wp-content/uploads/2018/10/cropped-Duett-favicon-32x32.png)  _How to take the Duett api in use_  To be able to use the API, you must have an interaction key and a client key.  Eksample curl: ```swift    curl -X 'GET' \\   'https://api.duett.no/article/v1 \\   -H 'accept: application/json' \\   -H 'X-Api-Integration-Key: 89ff1c42-9d90-435a-8a94-20207bc06e1a' \\   -H 'X-Api-Client-Key: 7896feb3-aaa2-4fd2-aaa2-c69de5fd1e5f' ``` ##### [Metode description][1] ##### [Filtering data in openApi][2]   ### Use a code generator as to auto-generate api client:  ##### [NSwagStudio](https://github.com/RicoSuter/NSwag/wiki/NSwagStudio) ##### [Visual studio add-in](https://marketplace.visualstudio.com/items?itemName=ChristianResmaHelle.ApiClientCodeGenerator) \\ ##### [Online code generator for many languages and versions](https://github.com/swagger-api/swagger-codegen)  *** [1]: ../metods-help.html [2]: ../query-help.html  # noqa: E501

    OpenAPI spec version: 1.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class WageType(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'id': 'int',
        'type_id': 'int',
        'type_name': 'str'
    }

    attribute_map = {
        'id': 'id',
        'type_id': 'typeId',
        'type_name': 'typeName'
    }

    def __init__(self, id=None, type_id=None, type_name=None):  # noqa: E501
        """WageType - a model defined in Swagger"""  # noqa: E501
        self._id = None
        self._type_id = None
        self._type_name = None
        self.discriminator = None
        if id is not None:
            self.id = id
        if type_id is not None:
            self.type_id = type_id
        if type_name is not None:
            self.type_name = type_name

    @property
    def id(self):
        """Gets the id of this WageType.  # noqa: E501


        :return: The id of this WageType.  # noqa: E501
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this WageType.


        :param id: The id of this WageType.  # noqa: E501
        :type: int
        """

        self._id = id

    @property
    def type_id(self):
        """Gets the type_id of this WageType.  # noqa: E501


        :return: The type_id of this WageType.  # noqa: E501
        :rtype: int
        """
        return self._type_id

    @type_id.setter
    def type_id(self, type_id):
        """Sets the type_id of this WageType.


        :param type_id: The type_id of this WageType.  # noqa: E501
        :type: int
        """

        self._type_id = type_id

    @property
    def type_name(self):
        """Gets the type_name of this WageType.  # noqa: E501


        :return: The type_name of this WageType.  # noqa: E501
        :rtype: str
        """
        return self._type_name

    @type_name.setter
    def type_name(self, type_name):
        """Sets the type_name of this WageType.


        :param type_name: The type_name of this WageType.  # noqa: E501
        :type: str
        """

        self._type_name = type_name

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(WageType, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, WageType):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
