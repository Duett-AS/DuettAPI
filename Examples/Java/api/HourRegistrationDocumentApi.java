/*
 * OpenApi
 *  ## ![N|Solid](https://duett.no/wp-content/uploads/2018/10/cropped-Duett-favicon-32x32.png)  _How to take the Duett api in use_  To be able to use the API, you must have an interaction key and a client key.  Eksample curl: ```swift    curl -X 'GET' \\   'https://api.duett.no/article/v1 \\   -H 'accept: application/json' \\   -H 'X-Api-Integration-Key: 89ff1c42-9d90-435a-8a94-20207bc06e1a' \\   -H 'X-Api-Client-Key: 7896feb3-aaa2-4fd2-aaa2-c69de5fd1e5f' ``` ##### [Metode description][1] ##### [Filtering data in openApi][2]   ### Use a code generator as to auto-generate api client:  ##### [NSwagStudio](https://github.com/RicoSuter/NSwag/wiki/NSwagStudio) ##### [Visual studio add-in](https://marketplace.visualstudio.com/items?itemName=ChristianResmaHelle.ApiClientCodeGenerator) \\ ##### [Online code generator for many languages and versions](https://github.com/swagger-api/swagger-codegen)  *** [1]: ../metods-help.html [2]: ../query-help.html
 *
 * OpenAPI spec version: 1.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.api;

import io.swagger.client.ApiCallback;
import io.swagger.client.ApiClient;
import io.swagger.client.ApiException;
import io.swagger.client.ApiResponse;
import io.swagger.client.Configuration;
import io.swagger.client.Pair;
import io.swagger.client.ProgressRequestBody;
import io.swagger.client.ProgressResponseBody;

import com.google.gson.reflect.TypeToken;

import java.io.IOException;


import io.swagger.client.model.HourRegistrationDocument;
import io.swagger.client.model.HourRegistrationDocumentCreate;
import io.swagger.client.model.ProblemDetails;
import java.util.UUID;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class HourRegistrationDocumentApi {
    private ApiClient apiClient;

    public HourRegistrationDocumentApi() {
        this(Configuration.getDefaultApiClient());
    }

    public HourRegistrationDocumentApi(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return apiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    /**
     * Build call for hourRegistrationDocumentV1IdGet
     * @param id The Id to get HourRegistrationDocument for. (required)
     * @param extend A list of keys on which to extend the Customer, e.g. Orders (not implemented). (optional)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call hourRegistrationDocumentV1IdGetCall(UUID id, List<String> extend, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/HourRegistrationDocument/v1/{id}"
            .replaceAll("\\{" + "id" + "\\}", apiClient.escapeString(id.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        if (extend != null)
        localVarCollectionQueryParams.addAll(apiClient.parameterToPairs("multi", "extend", extend));

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "text/plain", "application/json", "text/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "ApiKeyClientAuthentication", "ApiKeyIntegrationAuthentication", "UserAuthentication" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call hourRegistrationDocumentV1IdGetValidateBeforeCall(UUID id, List<String> extend, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'id' is set
        if (id == null) {
            throw new ApiException("Missing the required parameter 'id' when calling hourRegistrationDocumentV1IdGet(Async)");
        }
        
        com.squareup.okhttp.Call call = hourRegistrationDocumentV1IdGetCall(id, extend, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Gets an existing HourRegistrationDocument given the specified Id.
     * 
     * @param id The Id to get HourRegistrationDocument for. (required)
     * @param extend A list of keys on which to extend the Customer, e.g. Orders (not implemented). (optional)
     * @return HourRegistrationDocument
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public HourRegistrationDocument hourRegistrationDocumentV1IdGet(UUID id, List<String> extend) throws ApiException {
        ApiResponse<HourRegistrationDocument> resp = hourRegistrationDocumentV1IdGetWithHttpInfo(id, extend);
        return resp.getData();
    }

    /**
     * Gets an existing HourRegistrationDocument given the specified Id.
     * 
     * @param id The Id to get HourRegistrationDocument for. (required)
     * @param extend A list of keys on which to extend the Customer, e.g. Orders (not implemented). (optional)
     * @return ApiResponse&lt;HourRegistrationDocument&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<HourRegistrationDocument> hourRegistrationDocumentV1IdGetWithHttpInfo(UUID id, List<String> extend) throws ApiException {
        com.squareup.okhttp.Call call = hourRegistrationDocumentV1IdGetValidateBeforeCall(id, extend, null, null);
        Type localVarReturnType = new TypeToken<HourRegistrationDocument>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Gets an existing HourRegistrationDocument given the specified Id. (asynchronously)
     * 
     * @param id The Id to get HourRegistrationDocument for. (required)
     * @param extend A list of keys on which to extend the Customer, e.g. Orders (not implemented). (optional)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call hourRegistrationDocumentV1IdGetAsync(UUID id, List<String> extend, final ApiCallback<HourRegistrationDocument> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = hourRegistrationDocumentV1IdGetValidateBeforeCall(id, extend, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<HourRegistrationDocument>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for hourRegistrationDocumentV1Post
     * @param body The HourRegistrationDocumentCreate to create a new HourRegistrationDocument from. (optional)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call hourRegistrationDocumentV1PostCall(HourRegistrationDocumentCreate body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/HourRegistrationDocument/v1";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "text/plain", "application/json", "text/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json-patch+json", "application/json", "text/json", "application/_*+json"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "ApiKeyClientAuthentication", "ApiKeyIntegrationAuthentication", "UserAuthentication" };
        return apiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call hourRegistrationDocumentV1PostValidateBeforeCall(HourRegistrationDocumentCreate body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        com.squareup.okhttp.Call call = hourRegistrationDocumentV1PostCall(body, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Creates a new HourRegistrationDocument.
     * 
     * @param body The HourRegistrationDocumentCreate to create a new HourRegistrationDocument from. (optional)
     * @return String
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public String hourRegistrationDocumentV1Post(HourRegistrationDocumentCreate body) throws ApiException {
        ApiResponse<String> resp = hourRegistrationDocumentV1PostWithHttpInfo(body);
        return resp.getData();
    }

    /**
     * Creates a new HourRegistrationDocument.
     * 
     * @param body The HourRegistrationDocumentCreate to create a new HourRegistrationDocument from. (optional)
     * @return ApiResponse&lt;String&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<String> hourRegistrationDocumentV1PostWithHttpInfo(HourRegistrationDocumentCreate body) throws ApiException {
        com.squareup.okhttp.Call call = hourRegistrationDocumentV1PostValidateBeforeCall(body, null, null);
        Type localVarReturnType = new TypeToken<String>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Creates a new HourRegistrationDocument. (asynchronously)
     * 
     * @param body The HourRegistrationDocumentCreate to create a new HourRegistrationDocument from. (optional)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call hourRegistrationDocumentV1PostAsync(HourRegistrationDocumentCreate body, final ApiCallback<String> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = hourRegistrationDocumentV1PostValidateBeforeCall(body, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<String>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
}
