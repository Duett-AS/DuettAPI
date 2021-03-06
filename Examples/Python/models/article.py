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

class Article(object):
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
        'article_number': 'str',
        'name': 'str',
        'article_type': 'ArticleType',
        'sales_price': 'float',
        'invoice_status': 'InvoiceStatus',
        'metadata': 'ArticleMetadata',
        'unit': 'str',
        'hour_registrations': 'list[HourRegistration]',
        'show': 'bool',
        'rowversion': 'int'
    }

    attribute_map = {
        'id': 'id',
        'article_number': 'articleNumber',
        'name': 'name',
        'article_type': 'articleType',
        'sales_price': 'salesPrice',
        'invoice_status': 'invoiceStatus',
        'metadata': 'metadata',
        'unit': 'unit',
        'hour_registrations': 'hourRegistrations',
        'show': 'show',
        'rowversion': 'rowversion'
    }

    def __init__(self, id=None, article_number=None, name=None, article_type=None, sales_price=None, invoice_status=None, metadata=None, unit=None, hour_registrations=None, show=None, rowversion=None):  # noqa: E501
        """Article - a model defined in Swagger"""  # noqa: E501
        self._id = None
        self._article_number = None
        self._name = None
        self._article_type = None
        self._sales_price = None
        self._invoice_status = None
        self._metadata = None
        self._unit = None
        self._hour_registrations = None
        self._show = None
        self._rowversion = None
        self.discriminator = None
        self.id = id
        self.article_number = article_number
        self.name = name
        self.article_type = article_type
        if sales_price is not None:
            self.sales_price = sales_price
        if invoice_status is not None:
            self.invoice_status = invoice_status
        if metadata is not None:
            self.metadata = metadata
        if unit is not None:
            self.unit = unit
        if hour_registrations is not None:
            self.hour_registrations = hour_registrations
        if show is not None:
            self.show = show
        if rowversion is not None:
            self.rowversion = rowversion

    @property
    def id(self):
        """Gets the id of this Article.  # noqa: E501


        :return: The id of this Article.  # noqa: E501
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this Article.


        :param id: The id of this Article.  # noqa: E501
        :type: int
        """
        if id is None:
            raise ValueError("Invalid value for `id`, must not be `None`")  # noqa: E501

        self._id = id

    @property
    def article_number(self):
        """Gets the article_number of this Article.  # noqa: E501


        :return: The article_number of this Article.  # noqa: E501
        :rtype: str
        """
        return self._article_number

    @article_number.setter
    def article_number(self, article_number):
        """Sets the article_number of this Article.


        :param article_number: The article_number of this Article.  # noqa: E501
        :type: str
        """
        if article_number is None:
            raise ValueError("Invalid value for `article_number`, must not be `None`")  # noqa: E501

        self._article_number = article_number

    @property
    def name(self):
        """Gets the name of this Article.  # noqa: E501


        :return: The name of this Article.  # noqa: E501
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this Article.


        :param name: The name of this Article.  # noqa: E501
        :type: str
        """
        if name is None:
            raise ValueError("Invalid value for `name`, must not be `None`")  # noqa: E501

        self._name = name

    @property
    def article_type(self):
        """Gets the article_type of this Article.  # noqa: E501


        :return: The article_type of this Article.  # noqa: E501
        :rtype: ArticleType
        """
        return self._article_type

    @article_type.setter
    def article_type(self, article_type):
        """Sets the article_type of this Article.


        :param article_type: The article_type of this Article.  # noqa: E501
        :type: ArticleType
        """
        if article_type is None:
            raise ValueError("Invalid value for `article_type`, must not be `None`")  # noqa: E501

        self._article_type = article_type

    @property
    def sales_price(self):
        """Gets the sales_price of this Article.  # noqa: E501


        :return: The sales_price of this Article.  # noqa: E501
        :rtype: float
        """
        return self._sales_price

    @sales_price.setter
    def sales_price(self, sales_price):
        """Sets the sales_price of this Article.


        :param sales_price: The sales_price of this Article.  # noqa: E501
        :type: float
        """

        self._sales_price = sales_price

    @property
    def invoice_status(self):
        """Gets the invoice_status of this Article.  # noqa: E501


        :return: The invoice_status of this Article.  # noqa: E501
        :rtype: InvoiceStatus
        """
        return self._invoice_status

    @invoice_status.setter
    def invoice_status(self, invoice_status):
        """Sets the invoice_status of this Article.


        :param invoice_status: The invoice_status of this Article.  # noqa: E501
        :type: InvoiceStatus
        """

        self._invoice_status = invoice_status

    @property
    def metadata(self):
        """Gets the metadata of this Article.  # noqa: E501


        :return: The metadata of this Article.  # noqa: E501
        :rtype: ArticleMetadata
        """
        return self._metadata

    @metadata.setter
    def metadata(self, metadata):
        """Sets the metadata of this Article.


        :param metadata: The metadata of this Article.  # noqa: E501
        :type: ArticleMetadata
        """

        self._metadata = metadata

    @property
    def unit(self):
        """Gets the unit of this Article.  # noqa: E501


        :return: The unit of this Article.  # noqa: E501
        :rtype: str
        """
        return self._unit

    @unit.setter
    def unit(self, unit):
        """Sets the unit of this Article.


        :param unit: The unit of this Article.  # noqa: E501
        :type: str
        """

        self._unit = unit

    @property
    def hour_registrations(self):
        """Gets the hour_registrations of this Article.  # noqa: E501


        :return: The hour_registrations of this Article.  # noqa: E501
        :rtype: list[HourRegistration]
        """
        return self._hour_registrations

    @hour_registrations.setter
    def hour_registrations(self, hour_registrations):
        """Sets the hour_registrations of this Article.


        :param hour_registrations: The hour_registrations of this Article.  # noqa: E501
        :type: list[HourRegistration]
        """

        self._hour_registrations = hour_registrations

    @property
    def show(self):
        """Gets the show of this Article.  # noqa: E501

        false if soft deleted  # noqa: E501

        :return: The show of this Article.  # noqa: E501
        :rtype: bool
        """
        return self._show

    @show.setter
    def show(self, show):
        """Sets the show of this Article.

        false if soft deleted  # noqa: E501

        :param show: The show of this Article.  # noqa: E501
        :type: bool
        """

        self._show = show

    @property
    def rowversion(self):
        """Gets the rowversion of this Article.  # noqa: E501


        :return: The rowversion of this Article.  # noqa: E501
        :rtype: int
        """
        return self._rowversion

    @rowversion.setter
    def rowversion(self, rowversion):
        """Sets the rowversion of this Article.


        :param rowversion: The rowversion of this Article.  # noqa: E501
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
        if issubclass(Article, dict):
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
        if not isinstance(other, Article):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
