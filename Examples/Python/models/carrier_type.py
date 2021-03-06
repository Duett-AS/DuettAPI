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

class CarrierType(object):
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
        'carrier_type_kind': 'CarrierTypeKind',
        'name': 'str',
        'used_in_accounting': 'bool',
        'used_in_hour': 'bool',
        'used_in_invoice': 'bool',
        'used_in_ledger': 'bool',
        'used_in_salary': 'bool',
        'carriers': 'list[Carrier]',
        'rowversion': 'int'
    }

    attribute_map = {
        'id': 'id',
        'carrier_type_kind': 'carrierTypeKind',
        'name': 'name',
        'used_in_accounting': 'usedInAccounting',
        'used_in_hour': 'usedInHour',
        'used_in_invoice': 'usedInInvoice',
        'used_in_ledger': 'usedInLedger',
        'used_in_salary': 'usedInSalary',
        'carriers': 'carriers',
        'rowversion': 'rowversion'
    }

    def __init__(self, id=None, carrier_type_kind=None, name=None, used_in_accounting=None, used_in_hour=None, used_in_invoice=None, used_in_ledger=None, used_in_salary=None, carriers=None, rowversion=None):  # noqa: E501
        """CarrierType - a model defined in Swagger"""  # noqa: E501
        self._id = None
        self._carrier_type_kind = None
        self._name = None
        self._used_in_accounting = None
        self._used_in_hour = None
        self._used_in_invoice = None
        self._used_in_ledger = None
        self._used_in_salary = None
        self._carriers = None
        self._rowversion = None
        self.discriminator = None
        self.id = id
        self.carrier_type_kind = carrier_type_kind
        self.name = name
        self.used_in_accounting = used_in_accounting
        self.used_in_hour = used_in_hour
        self.used_in_invoice = used_in_invoice
        self.used_in_ledger = used_in_ledger
        self.used_in_salary = used_in_salary
        if carriers is not None:
            self.carriers = carriers
        if rowversion is not None:
            self.rowversion = rowversion

    @property
    def id(self):
        """Gets the id of this CarrierType.  # noqa: E501


        :return: The id of this CarrierType.  # noqa: E501
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this CarrierType.


        :param id: The id of this CarrierType.  # noqa: E501
        :type: int
        """
        if id is None:
            raise ValueError("Invalid value for `id`, must not be `None`")  # noqa: E501

        self._id = id

    @property
    def carrier_type_kind(self):
        """Gets the carrier_type_kind of this CarrierType.  # noqa: E501


        :return: The carrier_type_kind of this CarrierType.  # noqa: E501
        :rtype: CarrierTypeKind
        """
        return self._carrier_type_kind

    @carrier_type_kind.setter
    def carrier_type_kind(self, carrier_type_kind):
        """Sets the carrier_type_kind of this CarrierType.


        :param carrier_type_kind: The carrier_type_kind of this CarrierType.  # noqa: E501
        :type: CarrierTypeKind
        """
        if carrier_type_kind is None:
            raise ValueError("Invalid value for `carrier_type_kind`, must not be `None`")  # noqa: E501

        self._carrier_type_kind = carrier_type_kind

    @property
    def name(self):
        """Gets the name of this CarrierType.  # noqa: E501


        :return: The name of this CarrierType.  # noqa: E501
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this CarrierType.


        :param name: The name of this CarrierType.  # noqa: E501
        :type: str
        """
        if name is None:
            raise ValueError("Invalid value for `name`, must not be `None`")  # noqa: E501

        self._name = name

    @property
    def used_in_accounting(self):
        """Gets the used_in_accounting of this CarrierType.  # noqa: E501


        :return: The used_in_accounting of this CarrierType.  # noqa: E501
        :rtype: bool
        """
        return self._used_in_accounting

    @used_in_accounting.setter
    def used_in_accounting(self, used_in_accounting):
        """Sets the used_in_accounting of this CarrierType.


        :param used_in_accounting: The used_in_accounting of this CarrierType.  # noqa: E501
        :type: bool
        """
        if used_in_accounting is None:
            raise ValueError("Invalid value for `used_in_accounting`, must not be `None`")  # noqa: E501

        self._used_in_accounting = used_in_accounting

    @property
    def used_in_hour(self):
        """Gets the used_in_hour of this CarrierType.  # noqa: E501


        :return: The used_in_hour of this CarrierType.  # noqa: E501
        :rtype: bool
        """
        return self._used_in_hour

    @used_in_hour.setter
    def used_in_hour(self, used_in_hour):
        """Sets the used_in_hour of this CarrierType.


        :param used_in_hour: The used_in_hour of this CarrierType.  # noqa: E501
        :type: bool
        """
        if used_in_hour is None:
            raise ValueError("Invalid value for `used_in_hour`, must not be `None`")  # noqa: E501

        self._used_in_hour = used_in_hour

    @property
    def used_in_invoice(self):
        """Gets the used_in_invoice of this CarrierType.  # noqa: E501


        :return: The used_in_invoice of this CarrierType.  # noqa: E501
        :rtype: bool
        """
        return self._used_in_invoice

    @used_in_invoice.setter
    def used_in_invoice(self, used_in_invoice):
        """Sets the used_in_invoice of this CarrierType.


        :param used_in_invoice: The used_in_invoice of this CarrierType.  # noqa: E501
        :type: bool
        """
        if used_in_invoice is None:
            raise ValueError("Invalid value for `used_in_invoice`, must not be `None`")  # noqa: E501

        self._used_in_invoice = used_in_invoice

    @property
    def used_in_ledger(self):
        """Gets the used_in_ledger of this CarrierType.  # noqa: E501


        :return: The used_in_ledger of this CarrierType.  # noqa: E501
        :rtype: bool
        """
        return self._used_in_ledger

    @used_in_ledger.setter
    def used_in_ledger(self, used_in_ledger):
        """Sets the used_in_ledger of this CarrierType.


        :param used_in_ledger: The used_in_ledger of this CarrierType.  # noqa: E501
        :type: bool
        """
        if used_in_ledger is None:
            raise ValueError("Invalid value for `used_in_ledger`, must not be `None`")  # noqa: E501

        self._used_in_ledger = used_in_ledger

    @property
    def used_in_salary(self):
        """Gets the used_in_salary of this CarrierType.  # noqa: E501


        :return: The used_in_salary of this CarrierType.  # noqa: E501
        :rtype: bool
        """
        return self._used_in_salary

    @used_in_salary.setter
    def used_in_salary(self, used_in_salary):
        """Sets the used_in_salary of this CarrierType.


        :param used_in_salary: The used_in_salary of this CarrierType.  # noqa: E501
        :type: bool
        """
        if used_in_salary is None:
            raise ValueError("Invalid value for `used_in_salary`, must not be `None`")  # noqa: E501

        self._used_in_salary = used_in_salary

    @property
    def carriers(self):
        """Gets the carriers of this CarrierType.  # noqa: E501


        :return: The carriers of this CarrierType.  # noqa: E501
        :rtype: list[Carrier]
        """
        return self._carriers

    @carriers.setter
    def carriers(self, carriers):
        """Sets the carriers of this CarrierType.


        :param carriers: The carriers of this CarrierType.  # noqa: E501
        :type: list[Carrier]
        """

        self._carriers = carriers

    @property
    def rowversion(self):
        """Gets the rowversion of this CarrierType.  # noqa: E501


        :return: The rowversion of this CarrierType.  # noqa: E501
        :rtype: int
        """
        return self._rowversion

    @rowversion.setter
    def rowversion(self, rowversion):
        """Sets the rowversion of this CarrierType.


        :param rowversion: The rowversion of this CarrierType.  # noqa: E501
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
        if issubclass(CarrierType, dict):
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
        if not isinstance(other, CarrierType):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
