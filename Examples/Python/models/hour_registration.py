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

class HourRegistration(object):
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
        'external_id': 'str',
        'master_ref_id': 'int',
        'hour_date': 'datetime',
        'hour_count': 'float',
        'hour_price': 'float',
        'hours_invoiced': 'float',
        'total_price': 'float',
        'description': 'str',
        'attestation_status': 'AttestationStatus',
        'invoice_status': 'InvoiceStatus',
        'salary_status': 'SalaryStatus',
        'article_id': 'int',
        'article': 'Article',
        'carriers': 'list[HourRegistrationCarrier]',
        'customer_id': 'int',
        'customer': 'Customer',
        'documentation_ids': 'list[str]',
        'rowversion': 'int'
    }

    attribute_map = {
        'id': 'id',
        'external_id': 'externalId',
        'master_ref_id': 'masterRefId',
        'hour_date': 'hourDate',
        'hour_count': 'hourCount',
        'hour_price': 'hourPrice',
        'hours_invoiced': 'hoursInvoiced',
        'total_price': 'totalPrice',
        'description': 'description',
        'attestation_status': 'attestationStatus',
        'invoice_status': 'invoiceStatus',
        'salary_status': 'salaryStatus',
        'article_id': 'articleId',
        'article': 'article',
        'carriers': 'carriers',
        'customer_id': 'customerId',
        'customer': 'customer',
        'documentation_ids': 'documentationIds',
        'rowversion': 'rowversion'
    }

    def __init__(self, id=None, external_id=None, master_ref_id=None, hour_date=None, hour_count=None, hour_price=None, hours_invoiced=None, total_price=None, description=None, attestation_status=None, invoice_status=None, salary_status=None, article_id=None, article=None, carriers=None, customer_id=None, customer=None, documentation_ids=None, rowversion=None):  # noqa: E501
        """HourRegistration - a model defined in Swagger"""  # noqa: E501
        self._id = None
        self._external_id = None
        self._master_ref_id = None
        self._hour_date = None
        self._hour_count = None
        self._hour_price = None
        self._hours_invoiced = None
        self._total_price = None
        self._description = None
        self._attestation_status = None
        self._invoice_status = None
        self._salary_status = None
        self._article_id = None
        self._article = None
        self._carriers = None
        self._customer_id = None
        self._customer = None
        self._documentation_ids = None
        self._rowversion = None
        self.discriminator = None
        self.id = id
        if external_id is not None:
            self.external_id = external_id
        if master_ref_id is not None:
            self.master_ref_id = master_ref_id
        self.hour_date = hour_date
        if hour_count is not None:
            self.hour_count = hour_count
        if hour_price is not None:
            self.hour_price = hour_price
        if hours_invoiced is not None:
            self.hours_invoiced = hours_invoiced
        if total_price is not None:
            self.total_price = total_price
        if description is not None:
            self.description = description
        self.attestation_status = attestation_status
        self.invoice_status = invoice_status
        self.salary_status = salary_status
        if article_id is not None:
            self.article_id = article_id
        if article is not None:
            self.article = article
        if carriers is not None:
            self.carriers = carriers
        if customer_id is not None:
            self.customer_id = customer_id
        if customer is not None:
            self.customer = customer
        if documentation_ids is not None:
            self.documentation_ids = documentation_ids
        if rowversion is not None:
            self.rowversion = rowversion

    @property
    def id(self):
        """Gets the id of this HourRegistration.  # noqa: E501


        :return: The id of this HourRegistration.  # noqa: E501
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this HourRegistration.


        :param id: The id of this HourRegistration.  # noqa: E501
        :type: int
        """
        if id is None:
            raise ValueError("Invalid value for `id`, must not be `None`")  # noqa: E501

        self._id = id

    @property
    def external_id(self):
        """Gets the external_id of this HourRegistration.  # noqa: E501

        Your reference  # noqa: E501

        :return: The external_id of this HourRegistration.  # noqa: E501
        :rtype: str
        """
        return self._external_id

    @external_id.setter
    def external_id(self, external_id):
        """Sets the external_id of this HourRegistration.

        Your reference  # noqa: E501

        :param external_id: The external_id of this HourRegistration.  # noqa: E501
        :type: str
        """

        self._external_id = external_id

    @property
    def master_ref_id(self):
        """Gets the master_ref_id of this HourRegistration.  # noqa: E501

        The reference to the master hourRegistration in a group  # noqa: E501

        :return: The master_ref_id of this HourRegistration.  # noqa: E501
        :rtype: int
        """
        return self._master_ref_id

    @master_ref_id.setter
    def master_ref_id(self, master_ref_id):
        """Sets the master_ref_id of this HourRegistration.

        The reference to the master hourRegistration in a group  # noqa: E501

        :param master_ref_id: The master_ref_id of this HourRegistration.  # noqa: E501
        :type: int
        """

        self._master_ref_id = master_ref_id

    @property
    def hour_date(self):
        """Gets the hour_date of this HourRegistration.  # noqa: E501


        :return: The hour_date of this HourRegistration.  # noqa: E501
        :rtype: datetime
        """
        return self._hour_date

    @hour_date.setter
    def hour_date(self, hour_date):
        """Sets the hour_date of this HourRegistration.


        :param hour_date: The hour_date of this HourRegistration.  # noqa: E501
        :type: datetime
        """
        if hour_date is None:
            raise ValueError("Invalid value for `hour_date`, must not be `None`")  # noqa: E501

        self._hour_date = hour_date

    @property
    def hour_count(self):
        """Gets the hour_count of this HourRegistration.  # noqa: E501


        :return: The hour_count of this HourRegistration.  # noqa: E501
        :rtype: float
        """
        return self._hour_count

    @hour_count.setter
    def hour_count(self, hour_count):
        """Sets the hour_count of this HourRegistration.


        :param hour_count: The hour_count of this HourRegistration.  # noqa: E501
        :type: float
        """

        self._hour_count = hour_count

    @property
    def hour_price(self):
        """Gets the hour_price of this HourRegistration.  # noqa: E501


        :return: The hour_price of this HourRegistration.  # noqa: E501
        :rtype: float
        """
        return self._hour_price

    @hour_price.setter
    def hour_price(self, hour_price):
        """Sets the hour_price of this HourRegistration.


        :param hour_price: The hour_price of this HourRegistration.  # noqa: E501
        :type: float
        """

        self._hour_price = hour_price

    @property
    def hours_invoiced(self):
        """Gets the hours_invoiced of this HourRegistration.  # noqa: E501


        :return: The hours_invoiced of this HourRegistration.  # noqa: E501
        :rtype: float
        """
        return self._hours_invoiced

    @hours_invoiced.setter
    def hours_invoiced(self, hours_invoiced):
        """Sets the hours_invoiced of this HourRegistration.


        :param hours_invoiced: The hours_invoiced of this HourRegistration.  # noqa: E501
        :type: float
        """

        self._hours_invoiced = hours_invoiced

    @property
    def total_price(self):
        """Gets the total_price of this HourRegistration.  # noqa: E501


        :return: The total_price of this HourRegistration.  # noqa: E501
        :rtype: float
        """
        return self._total_price

    @total_price.setter
    def total_price(self, total_price):
        """Sets the total_price of this HourRegistration.


        :param total_price: The total_price of this HourRegistration.  # noqa: E501
        :type: float
        """

        self._total_price = total_price

    @property
    def description(self):
        """Gets the description of this HourRegistration.  # noqa: E501


        :return: The description of this HourRegistration.  # noqa: E501
        :rtype: str
        """
        return self._description

    @description.setter
    def description(self, description):
        """Sets the description of this HourRegistration.


        :param description: The description of this HourRegistration.  # noqa: E501
        :type: str
        """

        self._description = description

    @property
    def attestation_status(self):
        """Gets the attestation_status of this HourRegistration.  # noqa: E501


        :return: The attestation_status of this HourRegistration.  # noqa: E501
        :rtype: AttestationStatus
        """
        return self._attestation_status

    @attestation_status.setter
    def attestation_status(self, attestation_status):
        """Sets the attestation_status of this HourRegistration.


        :param attestation_status: The attestation_status of this HourRegistration.  # noqa: E501
        :type: AttestationStatus
        """
        if attestation_status is None:
            raise ValueError("Invalid value for `attestation_status`, must not be `None`")  # noqa: E501

        self._attestation_status = attestation_status

    @property
    def invoice_status(self):
        """Gets the invoice_status of this HourRegistration.  # noqa: E501


        :return: The invoice_status of this HourRegistration.  # noqa: E501
        :rtype: InvoiceStatus
        """
        return self._invoice_status

    @invoice_status.setter
    def invoice_status(self, invoice_status):
        """Sets the invoice_status of this HourRegistration.


        :param invoice_status: The invoice_status of this HourRegistration.  # noqa: E501
        :type: InvoiceStatus
        """
        if invoice_status is None:
            raise ValueError("Invalid value for `invoice_status`, must not be `None`")  # noqa: E501

        self._invoice_status = invoice_status

    @property
    def salary_status(self):
        """Gets the salary_status of this HourRegistration.  # noqa: E501


        :return: The salary_status of this HourRegistration.  # noqa: E501
        :rtype: SalaryStatus
        """
        return self._salary_status

    @salary_status.setter
    def salary_status(self, salary_status):
        """Sets the salary_status of this HourRegistration.


        :param salary_status: The salary_status of this HourRegistration.  # noqa: E501
        :type: SalaryStatus
        """
        if salary_status is None:
            raise ValueError("Invalid value for `salary_status`, must not be `None`")  # noqa: E501

        self._salary_status = salary_status

    @property
    def article_id(self):
        """Gets the article_id of this HourRegistration.  # noqa: E501


        :return: The article_id of this HourRegistration.  # noqa: E501
        :rtype: int
        """
        return self._article_id

    @article_id.setter
    def article_id(self, article_id):
        """Sets the article_id of this HourRegistration.


        :param article_id: The article_id of this HourRegistration.  # noqa: E501
        :type: int
        """

        self._article_id = article_id

    @property
    def article(self):
        """Gets the article of this HourRegistration.  # noqa: E501


        :return: The article of this HourRegistration.  # noqa: E501
        :rtype: Article
        """
        return self._article

    @article.setter
    def article(self, article):
        """Sets the article of this HourRegistration.


        :param article: The article of this HourRegistration.  # noqa: E501
        :type: Article
        """

        self._article = article

    @property
    def carriers(self):
        """Gets the carriers of this HourRegistration.  # noqa: E501


        :return: The carriers of this HourRegistration.  # noqa: E501
        :rtype: list[HourRegistrationCarrier]
        """
        return self._carriers

    @carriers.setter
    def carriers(self, carriers):
        """Sets the carriers of this HourRegistration.


        :param carriers: The carriers of this HourRegistration.  # noqa: E501
        :type: list[HourRegistrationCarrier]
        """

        self._carriers = carriers

    @property
    def customer_id(self):
        """Gets the customer_id of this HourRegistration.  # noqa: E501


        :return: The customer_id of this HourRegistration.  # noqa: E501
        :rtype: int
        """
        return self._customer_id

    @customer_id.setter
    def customer_id(self, customer_id):
        """Sets the customer_id of this HourRegistration.


        :param customer_id: The customer_id of this HourRegistration.  # noqa: E501
        :type: int
        """

        self._customer_id = customer_id

    @property
    def customer(self):
        """Gets the customer of this HourRegistration.  # noqa: E501


        :return: The customer of this HourRegistration.  # noqa: E501
        :rtype: Customer
        """
        return self._customer

    @customer.setter
    def customer(self, customer):
        """Sets the customer of this HourRegistration.


        :param customer: The customer of this HourRegistration.  # noqa: E501
        :type: Customer
        """

        self._customer = customer

    @property
    def documentation_ids(self):
        """Gets the documentation_ids of this HourRegistration.  # noqa: E501


        :return: The documentation_ids of this HourRegistration.  # noqa: E501
        :rtype: list[str]
        """
        return self._documentation_ids

    @documentation_ids.setter
    def documentation_ids(self, documentation_ids):
        """Sets the documentation_ids of this HourRegistration.


        :param documentation_ids: The documentation_ids of this HourRegistration.  # noqa: E501
        :type: list[str]
        """

        self._documentation_ids = documentation_ids

    @property
    def rowversion(self):
        """Gets the rowversion of this HourRegistration.  # noqa: E501


        :return: The rowversion of this HourRegistration.  # noqa: E501
        :rtype: int
        """
        return self._rowversion

    @rowversion.setter
    def rowversion(self, rowversion):
        """Sets the rowversion of this HourRegistration.


        :param rowversion: The rowversion of this HourRegistration.  # noqa: E501
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
        if issubclass(HourRegistration, dict):
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
        if not isinstance(other, HourRegistration):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other