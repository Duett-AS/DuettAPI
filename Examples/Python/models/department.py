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

class Department(object):
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
        'address1': 'str',
        'address2': 'str',
        'organization_number': 'str',
        'cadastral_number': 'str',
        'rowversion': 'int'
    }

    attribute_map = {
        'id': 'id',
        'address1': 'address1',
        'address2': 'address2',
        'organization_number': 'organizationNumber',
        'cadastral_number': 'cadastralNumber',
        'rowversion': 'rowversion'
    }

    def __init__(self, id=None, address1=None, address2=None, organization_number=None, cadastral_number=None, rowversion=None):  # noqa: E501
        """Department - a model defined in Swagger"""  # noqa: E501
        self._id = None
        self._address1 = None
        self._address2 = None
        self._organization_number = None
        self._cadastral_number = None
        self._rowversion = None
        self.discriminator = None
        if id is not None:
            self.id = id
        if address1 is not None:
            self.address1 = address1
        if address2 is not None:
            self.address2 = address2
        if organization_number is not None:
            self.organization_number = organization_number
        if cadastral_number is not None:
            self.cadastral_number = cadastral_number
        if rowversion is not None:
            self.rowversion = rowversion

    @property
    def id(self):
        """Gets the id of this Department.  # noqa: E501


        :return: The id of this Department.  # noqa: E501
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this Department.


        :param id: The id of this Department.  # noqa: E501
        :type: int
        """

        self._id = id

    @property
    def address1(self):
        """Gets the address1 of this Department.  # noqa: E501


        :return: The address1 of this Department.  # noqa: E501
        :rtype: str
        """
        return self._address1

    @address1.setter
    def address1(self, address1):
        """Sets the address1 of this Department.


        :param address1: The address1 of this Department.  # noqa: E501
        :type: str
        """

        self._address1 = address1

    @property
    def address2(self):
        """Gets the address2 of this Department.  # noqa: E501


        :return: The address2 of this Department.  # noqa: E501
        :rtype: str
        """
        return self._address2

    @address2.setter
    def address2(self, address2):
        """Sets the address2 of this Department.


        :param address2: The address2 of this Department.  # noqa: E501
        :type: str
        """

        self._address2 = address2

    @property
    def organization_number(self):
        """Gets the organization_number of this Department.  # noqa: E501


        :return: The organization_number of this Department.  # noqa: E501
        :rtype: str
        """
        return self._organization_number

    @organization_number.setter
    def organization_number(self, organization_number):
        """Sets the organization_number of this Department.


        :param organization_number: The organization_number of this Department.  # noqa: E501
        :type: str
        """

        self._organization_number = organization_number

    @property
    def cadastral_number(self):
        """Gets the cadastral_number of this Department.  # noqa: E501


        :return: The cadastral_number of this Department.  # noqa: E501
        :rtype: str
        """
        return self._cadastral_number

    @cadastral_number.setter
    def cadastral_number(self, cadastral_number):
        """Sets the cadastral_number of this Department.


        :param cadastral_number: The cadastral_number of this Department.  # noqa: E501
        :type: str
        """

        self._cadastral_number = cadastral_number

    @property
    def rowversion(self):
        """Gets the rowversion of this Department.  # noqa: E501


        :return: The rowversion of this Department.  # noqa: E501
        :rtype: int
        """
        return self._rowversion

    @rowversion.setter
    def rowversion(self, rowversion):
        """Sets the rowversion of this Department.


        :param rowversion: The rowversion of this Department.  # noqa: E501
        :type: int
        """

        self._rowversion = rowversion

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
        if issubclass(Department, dict):
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
        if not isinstance(other, Department):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
