# coding: utf-8

"""
    OpenApi

     ## ![N|Solid](https://duett.no/wp-content/uploads/2018/10/cropped-Duett-favicon-32x32.png)  _How to take the Duett api in use_  To be able to use the API, you must have an interaction key and a client key.  Eksample curl: ```swift    curl -X 'GET' \\   'https://api.duett.no/article/v1 \\   -H 'accept: application/json' \\   -H 'X-Api-Integration-Key: 89ff1c42-9d90-435a-8a94-20207bc06e1a' \\   -H 'X-Api-Client-Key: 7896feb3-aaa2-4fd2-aaa2-c69de5fd1e5f' ``` ##### [Metode description][1] ##### [Filtering data in openApi][2]   ### Use a code generator as to auto-generate api client:  ##### [NSwagStudio](https://github.com/RicoSuter/NSwag/wiki/NSwagStudio) ##### [Visual studio add-in](https://marketplace.visualstudio.com/items?itemName=ChristianResmaHelle.ApiClientCodeGenerator) \\ ##### [Online code generator for many languages and versions](https://github.com/swagger-api/swagger-codegen)  *** [1]: ../metods-help.html [2]: ../query-help.html  # noqa: E501

    OpenAPI spec version: 1.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

from __future__ import absolute_import

import re  # noqa: F401

# python 2 and python 3 compatibility library
import six

from swagger_client.api_client import ApiClient


class ArticleApi(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    Ref: https://github.com/swagger-api/swagger-codegen
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client

    def article_v1_get(self, **kwargs):  # noqa: E501
        """Gets all existing Article.  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.article_v1_get(async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param list[str] extend: A list of keys on which to extend the Article, e.g. HourRegistrations, Metadata.
        :param object filter: Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE], [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.
        :return: list[Article]
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.article_v1_get_with_http_info(**kwargs)  # noqa: E501
        else:
            (data) = self.article_v1_get_with_http_info(**kwargs)  # noqa: E501
            return data

    def article_v1_get_with_http_info(self, **kwargs):  # noqa: E501
        """Gets all existing Article.  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.article_v1_get_with_http_info(async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param list[str] extend: A list of keys on which to extend the Article, e.g. HourRegistrations, Metadata.
        :param object filter: Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE], [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.
        :return: list[Article]
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['extend', 'filter']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method article_v1_get" % key
                )
            params[key] = val
        del params['kwargs']

        collection_formats = {}

        path_params = {}

        query_params = []
        if 'extend' in params:
            query_params.append(('extend', params['extend']))  # noqa: E501
            collection_formats['extend'] = 'multi'  # noqa: E501
        if 'filter' in params:
            query_params.append(('filter', params['filter']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['text/plain', 'application/json', 'text/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['ApiKeyClientAuthentication', 'ApiKeyIntegrationAuthentication', 'UserAuthentication']  # noqa: E501

        return self.api_client.call_api(
            '/Article/v1', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='list[Article]',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def article_v1_id_delete(self, id, **kwargs):  # noqa: E501
        """Deletes an existing Article given the specified Id.  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.article_v1_id_delete(id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param int id: The Id of the Article to delete. (required)
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.article_v1_id_delete_with_http_info(id, **kwargs)  # noqa: E501
        else:
            (data) = self.article_v1_id_delete_with_http_info(id, **kwargs)  # noqa: E501
            return data

    def article_v1_id_delete_with_http_info(self, id, **kwargs):  # noqa: E501
        """Deletes an existing Article given the specified Id.  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.article_v1_id_delete_with_http_info(id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param int id: The Id of the Article to delete. (required)
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['id']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method article_v1_id_delete" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'id' is set
        if ('id' not in params or
                params['id'] is None):
            raise ValueError("Missing the required parameter `id` when calling `article_v1_id_delete`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'id' in params:
            path_params['id'] = params['id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['text/plain', 'application/json', 'text/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['ApiKeyClientAuthentication', 'ApiKeyIntegrationAuthentication', 'UserAuthentication']  # noqa: E501

        return self.api_client.call_api(
            '/Article/v1/{id}', 'DELETE',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type=None,  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def article_v1_id_patch(self, id, **kwargs):  # noqa: E501
        """Patches an existing Article given the specified Id.  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.article_v1_id_patch(id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param int id: The Id of the Article to patch. (required)
        :param list[JsonPatchOperation] body: The operations to perform on ArticleCreate.
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.article_v1_id_patch_with_http_info(id, **kwargs)  # noqa: E501
        else:
            (data) = self.article_v1_id_patch_with_http_info(id, **kwargs)  # noqa: E501
            return data

    def article_v1_id_patch_with_http_info(self, id, **kwargs):  # noqa: E501
        """Patches an existing Article given the specified Id.  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.article_v1_id_patch_with_http_info(id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param int id: The Id of the Article to patch. (required)
        :param list[JsonPatchOperation] body: The operations to perform on ArticleCreate.
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['id', 'body']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method article_v1_id_patch" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'id' is set
        if ('id' not in params or
                params['id'] is None):
            raise ValueError("Missing the required parameter `id` when calling `article_v1_id_patch`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'id' in params:
            path_params['id'] = params['id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'body' in params:
            body_params = params['body']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['text/plain', 'application/json', 'text/json'])  # noqa: E501

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.select_header_content_type(  # noqa: E501
            ['application/json-patch+json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['ApiKeyClientAuthentication', 'ApiKeyIntegrationAuthentication', 'UserAuthentication']  # noqa: E501

        return self.api_client.call_api(
            '/Article/v1/{id}', 'PATCH',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type=None,  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def article_v1_id_put(self, id, **kwargs):  # noqa: E501
        """Replaces an existing Article given the specified Id.  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.article_v1_id_put(id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param int id: The Id of the Article to replace. (required)
        :param ArticleCreate body: The ArticleCreate to replace the old Article from.
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.article_v1_id_put_with_http_info(id, **kwargs)  # noqa: E501
        else:
            (data) = self.article_v1_id_put_with_http_info(id, **kwargs)  # noqa: E501
            return data

    def article_v1_id_put_with_http_info(self, id, **kwargs):  # noqa: E501
        """Replaces an existing Article given the specified Id.  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.article_v1_id_put_with_http_info(id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param int id: The Id of the Article to replace. (required)
        :param ArticleCreate body: The ArticleCreate to replace the old Article from.
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['id', 'body']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method article_v1_id_put" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'id' is set
        if ('id' not in params or
                params['id'] is None):
            raise ValueError("Missing the required parameter `id` when calling `article_v1_id_put`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'id' in params:
            path_params['id'] = params['id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'body' in params:
            body_params = params['body']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['text/plain', 'application/json', 'text/json'])  # noqa: E501

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.select_header_content_type(  # noqa: E501
            ['application/json-patch+json', 'application/json', 'text/json', 'application/*+json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['ApiKeyClientAuthentication', 'ApiKeyIntegrationAuthentication', 'UserAuthentication']  # noqa: E501

        return self.api_client.call_api(
            '/Article/v1/{id}', 'PUT',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type=None,  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def article_v1_post(self, **kwargs):  # noqa: E501
        """Creates a new Article.  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.article_v1_post(async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param ArticleCreate body: The ArticleCreate to create a new Article from.
        :return: Article
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.article_v1_post_with_http_info(**kwargs)  # noqa: E501
        else:
            (data) = self.article_v1_post_with_http_info(**kwargs)  # noqa: E501
            return data

    def article_v1_post_with_http_info(self, **kwargs):  # noqa: E501
        """Creates a new Article.  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.article_v1_post_with_http_info(async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param ArticleCreate body: The ArticleCreate to create a new Article from.
        :return: Article
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['body']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method article_v1_post" % key
                )
            params[key] = val
        del params['kwargs']

        collection_formats = {}

        path_params = {}

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'body' in params:
            body_params = params['body']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['text/plain', 'application/json', 'text/json'])  # noqa: E501

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.select_header_content_type(  # noqa: E501
            ['application/json-patch+json', 'application/json', 'text/json', 'application/*+json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['ApiKeyClientAuthentication', 'ApiKeyIntegrationAuthentication', 'UserAuthentication']  # noqa: E501

        return self.api_client.call_api(
            '/Article/v1', 'POST',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='Article',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)
