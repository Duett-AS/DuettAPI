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

class CustomerCreate(object):
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
        'external_id': 'str',
        'vat_number': 'str',
        'bank_account_number': 'str',
        'invoice_email': 'str',
        'hour_attestation_mobile': 'str',
        'address': 'StreetAddress',
        'contact_info': 'Contact',
        'contact_person': 'ContactPerson'
    }

    attribute_map = {
        'external_id': 'externalId',
        'vat_number': 'vatNumber',
        'bank_account_number': 'bankAccountNumber',
        'invoice_email': 'invoiceEmail',
        'hour_attestation_mobile': 'hourAttestationMobile',
        'address': 'address',
        'contact_info': 'contactInfo',
        'contact_person': 'contactPerson'
    }

    def __init__(self, external_id=None, vat_number=None, bank_account_number=None, invoice_email=None, hour_attestation_mobile=None, address=None, contact_info=None, contact_person=None):  # noqa: E501
        """CustomerCreate - a model defined in Swagger"""  # noqa: E501
        self._external_id = None
        self._vat_number = None
        self._bank_account_number = None
        self._invoice_email = None
        self._hour_attestation_mobile = None
        self._address = None
        self._contact_info = None
        self._contact_person = None
        self.discriminator = None
        self.external_id = external_id
        if vat_number is not None:
            self.vat_number = vat_number
        if bank_account_number is not None:
            self.bank_account_number = bank_account_number
        if invoice_email is not None:
            self.invoice_email = invoice_email
        if hour_attestation_mobile is not None:
            self.hour_attestation_mobile = hour_attestation_mobile
        self.address = address
        self.contact_info = contact_info
        if contact_person is not None:
            self.contact_person = contact_person

    @property
    def external_id(self):
        """Gets the external_id of this CustomerCreate.  # noqa: E501


        :return: The external_id of this CustomerCreate.  # noqa: E501
        :rtype: str
        """
        return self._external_id

    @external_id.setter
    def external_id(self, external_id):
        """Sets the external_id of this CustomerCreate.


        :param external_id: The external_id of this CustomerCreate.  # noqa: E501
        :type: str
        """
        if external_id is None:
            raise ValueError("Invalid value for `external_id`, must not be `None`")  # noqa: E501

        self._external_id = external_id

    @property
    def vat_number(self):
        """Gets the vat_number of this CustomerCreate.  # noqa: E501


        :return: The vat_number of this CustomerCreate.  # noqa: E501
        :rtype: str
        """
        return self._vat_number

    @vat_number.setter
    def vat_number(self, vat_number):
        """Sets the vat_number of this CustomerCreate.


        :param vat_number: The vat_number of this CustomerCreate.  # noqa: E501
        :type: str
        """

        self._vat_number = vat_number

    @property
    def bank_account_number(self):
        """Gets the bank_account_number of this CustomerCreate.  # noqa: E501


        :return: The bank_account_number of this CustomerCreate.  # noqa: E501
        :rtype: str
        """
        return self._bank_account_number

    @bank_account_number.setter
    def bank_account_number(self, bank_account_number):
        """Sets the bank_account_number of this CustomerCreate.


        :param bank_account_number: The bank_account_number of this CustomerCreate.  # noqa: E501
        :type: str
        """

        self._bank_account_number = bank_account_number

    @property
    def invoice_email(self):
        """Gets the invoice_email of this CustomerCreate.  # noqa: E501


        :return: The invoice_email of this CustomerCreate.  # noqa: E501
        :rtype: str
        """
        return self._invoice_email

    @invoice_email.setter
    def invoice_email(self, invoice_email):
        """Sets the invoice_email of this CustomerCreate.


        :param invoice_email: The invoice_email of this CustomerCreate.  # noqa: E501
        :type: str
        """

        self._invoice_email = invoice_email

    @property
    def hour_attestation_mobile(self):
        """Gets the hour_attestation_mobile of this CustomerCreate.  # noqa: E501


        :return: The hour_attestation_mobile of this CustomerCreate.  # noqa: E501
        :rtype: str
        """
        return self._hour_attestation_mobile

    @hour_attestation_mobile.setter
    def hour_attestation_mobile(self, hour_attestation_mobile):
        """Sets the hour_attestation_mobile of this CustomerCreate.


        :param hour_attestation_mobile: The hour_attestation_mobile of this CustomerCreate.  # noqa: E501
        :type: str
        """

        self._hour_attestation_mobile = hour_attestation_mobile

    @property
    def address(self):
        """Gets the address of this CustomerCreate.  # noqa: E501


        :return: The address of this CustomerCreate.  # noqa: E501
        :rtype: StreetAddress
        """
        return self._address

    @address.setter
    def address(self, address):
        """Sets the address of this CustomerCreate.


        :param address: The address of this CustomerCreate.  # noqa: E501
        :type: StreetAddress
        """
        if address is None:
            raise ValueError("Invalid value for `address`, must not be `None`")  # noqa: E501

        self._address = address

    @property
    def contact_info(self):
        """Gets the contact_info of this CustomerCreate.  # noqa: E501


        :return: The contact_info of this CustomerCreate.  # noqa: E501
        :rtype: Contact
        """
        return self._contact_info

    @contact_info.setter
    def contact_info(self, contact_info):
        """Sets the contact_info of this CustomerCreate.


        :param contact_info: The contact_info of this CustomerCreate.  # noqa: E501
        :type: Contact
        """
        if contact_info is None:
            raise ValueError("Invalid value for `contact_info`, must not be `None`")  # noqa: E501

        self._contact_info = contact_info

    @property
    def contact_person(self):
        """Gets the contact_person of this CustomerCreate.  # noqa: E501


        :return: The contact_person of this CustomerCreate.  # noqa: E501
        :rtype: ContactPerson
        """
        return self._contact_person

    @contact_person.setter
    def contact_person(self, contact_person):
        """Sets the contact_person of this CustomerCreate.


        :param contact_person: The contact_person of this CustomerCreate.  # noqa: E501
        :type: ContactPerson
        """

        self._contact_person = contact_person

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
        if issubclass(CustomerCreate, dict):
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
        if not isinstance(other, CustomerCreate):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
