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

class ProjectCreate(object):
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
        'start_date': 'datetime',
        'end_date': 'datetime',
        'actual_end_date': 'datetime',
        'contract_sum': 'float',
        'description': 'str',
        'customer_id': 'int',
        'project_leader_carrier_id': 'int',
        'carrier': 'ProjectCarrierCreate'
    }

    attribute_map = {
        'start_date': 'startDate',
        'end_date': 'endDate',
        'actual_end_date': 'actualEndDate',
        'contract_sum': 'contractSum',
        'description': 'description',
        'customer_id': 'customerId',
        'project_leader_carrier_id': 'projectLeaderCarrierId',
        'carrier': 'carrier'
    }

    def __init__(self, start_date=None, end_date=None, actual_end_date=None, contract_sum=None, description=None, customer_id=None, project_leader_carrier_id=None, carrier=None):  # noqa: E501
        """ProjectCreate - a model defined in Swagger"""  # noqa: E501
        self._start_date = None
        self._end_date = None
        self._actual_end_date = None
        self._contract_sum = None
        self._description = None
        self._customer_id = None
        self._project_leader_carrier_id = None
        self._carrier = None
        self.discriminator = None
        self.start_date = start_date
        if end_date is not None:
            self.end_date = end_date
        if actual_end_date is not None:
            self.actual_end_date = actual_end_date
        if contract_sum is not None:
            self.contract_sum = contract_sum
        if description is not None:
            self.description = description
        if customer_id is not None:
            self.customer_id = customer_id
        if project_leader_carrier_id is not None:
            self.project_leader_carrier_id = project_leader_carrier_id
        if carrier is not None:
            self.carrier = carrier

    @property
    def start_date(self):
        """Gets the start_date of this ProjectCreate.  # noqa: E501


        :return: The start_date of this ProjectCreate.  # noqa: E501
        :rtype: datetime
        """
        return self._start_date

    @start_date.setter
    def start_date(self, start_date):
        """Sets the start_date of this ProjectCreate.


        :param start_date: The start_date of this ProjectCreate.  # noqa: E501
        :type: datetime
        """
        if start_date is None:
            raise ValueError("Invalid value for `start_date`, must not be `None`")  # noqa: E501

        self._start_date = start_date

    @property
    def end_date(self):
        """Gets the end_date of this ProjectCreate.  # noqa: E501


        :return: The end_date of this ProjectCreate.  # noqa: E501
        :rtype: datetime
        """
        return self._end_date

    @end_date.setter
    def end_date(self, end_date):
        """Sets the end_date of this ProjectCreate.


        :param end_date: The end_date of this ProjectCreate.  # noqa: E501
        :type: datetime
        """

        self._end_date = end_date

    @property
    def actual_end_date(self):
        """Gets the actual_end_date of this ProjectCreate.  # noqa: E501


        :return: The actual_end_date of this ProjectCreate.  # noqa: E501
        :rtype: datetime
        """
        return self._actual_end_date

    @actual_end_date.setter
    def actual_end_date(self, actual_end_date):
        """Sets the actual_end_date of this ProjectCreate.


        :param actual_end_date: The actual_end_date of this ProjectCreate.  # noqa: E501
        :type: datetime
        """

        self._actual_end_date = actual_end_date

    @property
    def contract_sum(self):
        """Gets the contract_sum of this ProjectCreate.  # noqa: E501


        :return: The contract_sum of this ProjectCreate.  # noqa: E501
        :rtype: float
        """
        return self._contract_sum

    @contract_sum.setter
    def contract_sum(self, contract_sum):
        """Sets the contract_sum of this ProjectCreate.


        :param contract_sum: The contract_sum of this ProjectCreate.  # noqa: E501
        :type: float
        """

        self._contract_sum = contract_sum

    @property
    def description(self):
        """Gets the description of this ProjectCreate.  # noqa: E501


        :return: The description of this ProjectCreate.  # noqa: E501
        :rtype: str
        """
        return self._description

    @description.setter
    def description(self, description):
        """Sets the description of this ProjectCreate.


        :param description: The description of this ProjectCreate.  # noqa: E501
        :type: str
        """

        self._description = description

    @property
    def customer_id(self):
        """Gets the customer_id of this ProjectCreate.  # noqa: E501


        :return: The customer_id of this ProjectCreate.  # noqa: E501
        :rtype: int
        """
        return self._customer_id

    @customer_id.setter
    def customer_id(self, customer_id):
        """Sets the customer_id of this ProjectCreate.


        :param customer_id: The customer_id of this ProjectCreate.  # noqa: E501
        :type: int
        """

        self._customer_id = customer_id

    @property
    def project_leader_carrier_id(self):
        """Gets the project_leader_carrier_id of this ProjectCreate.  # noqa: E501


        :return: The project_leader_carrier_id of this ProjectCreate.  # noqa: E501
        :rtype: int
        """
        return self._project_leader_carrier_id

    @project_leader_carrier_id.setter
    def project_leader_carrier_id(self, project_leader_carrier_id):
        """Sets the project_leader_carrier_id of this ProjectCreate.


        :param project_leader_carrier_id: The project_leader_carrier_id of this ProjectCreate.  # noqa: E501
        :type: int
        """

        self._project_leader_carrier_id = project_leader_carrier_id

    @property
    def carrier(self):
        """Gets the carrier of this ProjectCreate.  # noqa: E501


        :return: The carrier of this ProjectCreate.  # noqa: E501
        :rtype: ProjectCarrierCreate
        """
        return self._carrier

    @carrier.setter
    def carrier(self, carrier):
        """Sets the carrier of this ProjectCreate.


        :param carrier: The carrier of this ProjectCreate.  # noqa: E501
        :type: ProjectCarrierCreate
        """

        self._carrier = carrier

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
        if issubclass(ProjectCreate, dict):
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
        if not isinstance(other, ProjectCreate):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
