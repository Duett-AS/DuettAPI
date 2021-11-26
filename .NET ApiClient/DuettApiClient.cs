using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Duett.Filter;
using Duett.Interface;
using Duett.Model;
using Newtonsoft.Json;

namespace Duett
{
    [GeneratedCode("NSwag", "13.14.4.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v12.0.0.2))")]
    public class DuettApiClient : IDuettApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly Lazy<JsonSerializerSettings> _settings;
        private readonly string _integrationKey;
        private readonly string _clientKey;

        public DuettApiClient(HttpClient httpClient, string integrationKey, string clientKey)
        {
            _httpClient = httpClient;
            _integrationKey = integrationKey;
            _clientKey = clientKey;
            _settings = new Lazy<JsonSerializerSettings>(CreateSerializerSettings);
        }

        protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

        public bool ReadResponseAsString { get; set; }

        private JsonSerializerSettings CreateSerializerSettings()
        {
            var settings = new JsonSerializerSettings();
            UpdateJsonSerializerSettings(settings);
            return settings;
        }

        private void UpdateJsonSerializerSettings(JsonSerializerSettings settings)
        {
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        }


        private void PrepareRequest(HttpClient client, HttpRequestMessage request, string url)
        {
            PrepareRequest(request);
        }

        private void PrepareRequest(HttpClient client, HttpRequestMessage request, StringBuilder urlBuilder)
        {
            PrepareRequest(request);
        }

        private void PrepareRequest(HttpRequestMessage request)
        {
            request.Headers.Add("X-Api-Integration-Key", _integrationKey);
            request.Headers.Add("X-Api-Client-Key", _clientKey);
        }

        private void ProcessResponse(HttpClient client, HttpResponseMessage response)
        {
            throw new NotImplementedException();
        }

        /// <summary>Creates a new Carrier.</summary>
        /// <param name="body">The CarrierCreate to create a new Carrier from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<Carrier> CarrierPostAsync(CarrierCreate body)
        {
            return CarrierPostAsync(body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Creates a new Carrier.</summary>
        /// <param name="body">The CarrierCreate to create a new Carrier from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<Carrier> CarrierPostAsync(CarrierCreate body, CancellationToken cancellationToken)
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Carrier/v1");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<Carrier>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Deletes an existing CarrierType given the specified Id.</summary>
        /// <param name="id">The Id of the CarrierType to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task CarrierTypeDeleteAsync(int id)
        {
            return CarrierTypeDeleteAsync(id, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Deletes an existing CarrierType given the specified Id.</summary>
        /// <param name="id">The Id of the CarrierType to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task CarrierTypeDeleteAsync(int id, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("CarrierType/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Gets an existing CarrierType given the specified Id.</summary>
        /// <param name="id">The Id to get CarrierType for.</param>
        /// <param name="extend">A list of keys on which to extend the CarrierType, e.g. Carriers.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<CarrierType> CarrierTypeGetAsync(int id, IEnumerable<string> extend)
        {
            return CarrierTypeGetAsync(id, extend, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Gets an existing CarrierType given the specified Id.</summary>
        /// <param name="id">The Id to get CarrierType for.</param>
        /// <param name="extend">A list of keys on which to extend the CarrierType, e.g. Carriers.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<CarrierType> CarrierTypeGetAsync(int id, IEnumerable<string> extend,
            CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("CarrierType/v1/{id}?");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
            if (extend != null)
                foreach (var item_ in extend)
                    urlBuilder_.Append(Uri.EscapeDataString("extend") + "=")
                        .Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<CarrierType>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Patches an existing CarrierType given the specified Id.</summary>
        /// <param name="id">The Id of the CarrierType to patch.</param>
        /// <param name="body">The operations to perform on CarrierTypeCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task CarrierTypePatchAsync(int id, IEnumerable<JsonPatchOperation> body)
        {
            return CarrierTypePatchAsync(id, body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Patches an existing CarrierType given the specified Id.</summary>
        /// <param name="id">The Id of the CarrierType to patch.</param>
        /// <param name="body">The operations to perform on CarrierTypeCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task CarrierTypePatchAsync(int id, IEnumerable<JsonPatchOperation> body,
            CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("CarrierType/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PATCH");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 204)
                        {
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Replaces an existing CarrierType given the specified Id.</summary>
        /// <param name="id">The Id of the CarrierType to replace.</param>
        /// <param name="body">The CarrierTypeCreate to create a new CarrierType from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task CarrierTypePutAsync(int id, CarrierTypeCreate body)
        {
            return CarrierTypePutAsync(id, body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Replaces an existing CarrierType given the specified Id.</summary>
        /// <param name="id">The Id of the CarrierType to replace.</param>
        /// <param name="body">The CarrierTypeCreate to create a new CarrierType from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task CarrierTypePutAsync(int id, CarrierTypeCreate body, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("CarrierType/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 204)
                        {
                        }
                        else if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Gets all existing CarrierType.</summary>
        /// <param name="extend">A list of keys on which to extend the CarrierType, e.g. Carriers.</param>
        /// <param name="filter">
        ///     Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE],
        ///     [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.
        /// </param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<CarrierType>> CarrierTypeGetAllAsync(IEnumerable<string> extend, FilterAction filter)
        {
            return CarrierTypeGetAllAsync(extend, filter, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Gets all existing CarrierType.</summary>
        /// <param name="extend">A list of keys on which to extend the CarrierType, e.g. Carriers.</param>
        /// <param name="filter">
        ///     Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE],
        ///     [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.
        /// </param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ICollection<CarrierType>> CarrierTypeGetAllAsync(IEnumerable<string> extend, FilterAction filter,
            CancellationToken cancellationToken)
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("CarrierType/v1?");
            if (extend != null)
                foreach (var item_ in extend)
                    urlBuilder_.Append(Uri.EscapeDataString("extend") + "=")
                        .Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append("&");
            if (filter != null)
            {
            }

            urlBuilder_.Length--;

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ICollection<CarrierType>>(response_, headers_,
                                    cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Creates a new CarrierType.</summary>
        /// <param name="body">The CarrierTypeCreate to create a new CarrierType of the type CT_Free from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<CarrierType> CarrierTypePostAsync(CarrierTypeCreate body)
        {
            return CarrierTypePostAsync(body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Creates a new CarrierType.</summary>
        /// <param name="body">The CarrierTypeCreate to create a new CarrierType of the type CT_Free from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<CarrierType> CarrierTypePostAsync(CarrierTypeCreate body, CancellationToken cancellationToken)
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("CarrierType/v1");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<CarrierType>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Deletes an existing Customer given the specified Id.</summary>
        /// <param name="id">The Id of the Customer to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task CustomerDeleteAsync(int id)
        {
            return CustomerDeleteAsync(id, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Deletes an existing Customer given the specified Id.</summary>
        /// <param name="id">The Id of the Customer to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task CustomerDeleteAsync(int id, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Customer/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Gets an existing Customer given the specified Id.</summary>
        /// <param name="id">The Id to get Customer for.</param>
        /// <param name="extend">
        ///     A list of keys on which to extend the Customer, e.g. Address, ContactInfo, ContactPerson,
        ///     HourRegistrations.
        /// </param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<Customer> CustomerGetAsync(int id, IEnumerable<string> extend)
        {
            return CustomerGetAsync(id, extend, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Gets an existing Customer given the specified Id.</summary>
        /// <param name="id">The Id to get Customer for.</param>
        /// <param name="extend">
        ///     A list of keys on which to extend the Customer, e.g. Address, ContactInfo, ContactPerson,
        ///     HourRegistrations.
        /// </param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<Customer> CustomerGetAsync(int id, IEnumerable<string> extend, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Customer/v1/{id}?");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
            if (extend != null)
                foreach (var item_ in extend)
                    urlBuilder_.Append(Uri.EscapeDataString("extend") + "=")
                        .Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<Customer>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Patches an existing Customer given the specified Id.</summary>
        /// <param name="id">The Id of the Customer to patch.</param>
        /// <param name="body">The operations to perform on CustomerCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task CustomerPatchAsync(int id, IEnumerable<JsonPatchOperation> body)
        {
            return CustomerPatchAsync(id, body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Patches an existing Customer given the specified Id.</summary>
        /// <param name="id">The Id of the Customer to patch.</param>
        /// <param name="body">The operations to perform on CustomerCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task CustomerPatchAsync(int id, IEnumerable<JsonPatchOperation> body, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Customer/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PATCH");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 204)
                        {
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Replaces an existing Customer given the specified Id.</summary>
        /// <param name="id">The Id of the Customer to replace.</param>
        /// <param name="body">The CustomerCreate to create a new Customer from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task CustomerPutAsync(int id, CustomerCreate body)
        {
            return CustomerPutAsync(id, body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Replaces an existing Customer given the specified Id.</summary>
        /// <param name="id">The Id of the Customer to replace.</param>
        /// <param name="body">The CustomerCreate to create a new Customer from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task CustomerPutAsync(int id, CustomerCreate body, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Customer/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 204)
                        {
                        }
                        else if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Gets all existing Customer.</summary>
        /// <param name="extend">
        ///     A list of keys on which to extend the Customer, e.g. Address, ContactInfo, ContactPerson,
        ///     HourRegistrations.
        /// </param>
        /// <param name="filter">
        ///     Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE],
        ///     [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.
        /// </param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<Customer>> CustomerGetAllAsync(IEnumerable<string> extend, FilterAction filter)
        {
            return CustomerGetAllAsync(extend, filter, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Gets all existing Customer.</summary>
        /// <param name="extend">
        ///     A list of keys on which to extend the Customer, e.g. Address, ContactInfo, ContactPerson,
        ///     HourRegistrations.
        /// </param>
        /// <param name="filter">
        ///     Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE],
        ///     [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.
        /// </param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ICollection<Customer>> CustomerGetAllAsync(IEnumerable<string> extend, FilterAction filter,
            CancellationToken cancellationToken)
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Customer/v1?");
            if (extend != null)
                foreach (var item_ in extend)
                    urlBuilder_.Append(Uri.EscapeDataString("extend") + "=")
                        .Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append("&");
            if (filter != null)
            {
            }

            urlBuilder_.Length--;

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ICollection<Customer>>(response_, headers_,
                                    cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Creates a new Customer.</summary>
        /// <param name="body">The CustomerCreate to create a new Customer from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<Customer> CustomerPostAsync(CustomerCreate body)
        {
            return CustomerPostAsync(body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Creates a new Customer.</summary>
        /// <param name="body">The CustomerCreate to create a new Customer from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<Customer> CustomerPostAsync(CustomerCreate body, CancellationToken cancellationToken)
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Customer/v1");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<Customer>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Deletes an existing HourRegistration given the specified Id.</summary>
        /// <param name="id">The Id of the HourRegistration to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task HourRegistrationDeleteAsync(int id)
        {
            return HourRegistrationDeleteAsync(id, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Deletes an existing HourRegistration given the specified Id.</summary>
        /// <param name="id">The Id of the HourRegistration to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task HourRegistrationDeleteAsync(int id, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("HourRegistration/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Gets an existing HourRegistration given the specified Id.</summary>
        /// <param name="id">The Id to get HourRegistration for.</param>
        /// <param name="extend">A list of keys on which to extend the HourRegistration, e.g. Article,Customer, Carriers.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<HourRegistration> HourRegistrationGetAsync(int id, IEnumerable<string> extend)
        {
            return HourRegistrationGetAsync(id, extend, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Gets an existing HourRegistration given the specified Id.</summary>
        /// <param name="id">The Id to get HourRegistration for.</param>
        /// <param name="extend">A list of keys on which to extend the HourRegistration, e.g. Article,Customer, Carriers.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<HourRegistration> HourRegistrationGetAsync(int id, IEnumerable<string> extend,
            CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("HourRegistration/v1/{id}?");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
            if (extend != null)
                foreach (var item_ in extend)
                    urlBuilder_.Append(Uri.EscapeDataString("extend") + "=")
                        .Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<HourRegistration>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Patches an existing HourRegistration given the specified Id.</summary>
        /// <param name="id">The Id of the HourRegistration to patch.</param>
        /// <param name="body">The operations to perform onHourRegistrationCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task HourRegistrationPatchAsync(int id, IEnumerable<JsonPatchOperation> body)
        {
            return HourRegistrationPatchAsync(id, body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Patches an existing HourRegistration given the specified Id.</summary>
        /// <param name="id">The Id of the HourRegistration to patch.</param>
        /// <param name="body">The operations to perform onHourRegistrationCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task HourRegistrationPatchAsync(int id, IEnumerable<JsonPatchOperation> body,
            CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("HourRegistration/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PATCH");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 204)
                        {
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Replaces an existing HourRegistration given the specified Id.</summary>
        /// <param name="id">The Id of the HourRegistration to replace.</param>
        /// <param name="body">The HourRegistrationCreate to create a new HourRegistration from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task HourRegistrationPutAsync(int id, HourRegistrationCreate body)
        {
            return HourRegistrationPutAsync(id, body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Replaces an existing HourRegistration given the specified Id.</summary>
        /// <param name="id">The Id of the HourRegistration to replace.</param>
        /// <param name="body">The HourRegistrationCreate to create a new HourRegistration from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task HourRegistrationPutAsync(int id, HourRegistrationCreate body, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("HourRegistration/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 204)
                        {
                        }
                        else if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Gets all existing HourRegistration.</summary>
        /// <param name="extend">A list of keys on which to extend the HourRegistration, e.g. Article, Customer.</param>
        /// <param name="filter">
        ///     Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE],
        ///     [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.
        /// </param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<HourRegistration>> HourRegistrationGetAllAsync(IEnumerable<string> extend, FilterAction filter)
        {
            return HourRegistrationGetAllAsync(extend, filter, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Gets all existing HourRegistration.</summary>
        /// <param name="extend">A list of keys on which to extend the HourRegistration, e.g. Article, Customer.</param>
        /// <param name="filter">
        ///     Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE],
        ///     [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.
        /// </param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ICollection<HourRegistration>> HourRegistrationGetAllAsync(IEnumerable<string> extend, FilterAction filter,
            CancellationToken cancellationToken)
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("HourRegistration/v1?");
            if (extend != null)
                foreach (var item_ in extend)
                    urlBuilder_.Append(Uri.EscapeDataString("extend") + "=")
                        .Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append("&");
            if (filter != null)
            {
            }

            urlBuilder_.Length--;

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ICollection<HourRegistration>>(response_, headers_,
                                    cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Creates a new HourRegistration.</summary>
        /// <param name="body">The HourRegistrationCreate to create a new HourRegistration from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<HourRegistration> HourRegistrationPostAsync(HourRegistrationCreate body)
        {
            return HourRegistrationPostAsync(body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Creates a new HourRegistration.</summary>
        /// <param name="body">The HourRegistrationCreate to create a new HourRegistration from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<HourRegistration> HourRegistrationPostAsync(HourRegistrationCreate body,
            CancellationToken cancellationToken)
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("HourRegistration/v1");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<HourRegistration>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Gets an existing HourRegistrationDocument given the specified Id.</summary>
        /// <param name="id">The Id to get HourRegistrationDocument for.</param>
        /// <param name="extend">A list of keys on which to extend the Customer, e.g. Orders (not implemented).</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<HourRegistrationDocument> HourRegistrationDocumentGetAsync(Guid id, IEnumerable<string> extend)
        {
            return HourRegistrationDocumentGetAsync(id, extend, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Gets an existing HourRegistrationDocument given the specified Id.</summary>
        /// <param name="id">The Id to get HourRegistrationDocument for.</param>
        /// <param name="extend">A list of keys on which to extend the Customer, e.g. Orders (not implemented).</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<HourRegistrationDocument> HourRegistrationDocumentGetAsync(Guid id, IEnumerable<string> extend,
            CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("HourRegistrationDocument/v1/{id}?");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
            if (extend != null)
                foreach (var item_ in extend)
                    urlBuilder_.Append(Uri.EscapeDataString("extend") + "=")
                        .Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<HourRegistrationDocument>(response_, headers_,
                                    cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Creates a new HourRegistrationDocument.</summary>
        /// <param name="body">The HourRegistrationDocumentCreate to create a new HourRegistrationDocument from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<string> HourRegistrationDocumentPostAsync(HourRegistrationDocumentCreate body)
        {
            return HourRegistrationDocumentPostAsync(body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Creates a new HourRegistrationDocument.</summary>
        /// <param name="body">The HourRegistrationDocumentCreate to create a new HourRegistrationDocument from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<string> HourRegistrationDocumentPostAsync(HourRegistrationDocumentCreate body, CancellationToken cancellationToken)
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("HourRegistrationDocument/v1");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<string>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Deletes an existing Project given the specified Id.</summary>
        /// <param name="id">The Id of the Project to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task ProjectDeleteAsync(int id)
        {
            return ProjectDeleteAsync(id, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Deletes an existing Project given the specified Id.</summary>
        /// <param name="id">The Id of the Project to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task ProjectDeleteAsync(int id, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Project/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Gets an existing Project given the specified Id.</summary>
        /// <param name="id">The Id to get Project for.</param>
        /// <param name="extend">A list of keys on which to extend the Project.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<Project> ProjectGetAsync(int id, IEnumerable<string> extend)
        {
            return ProjectGetAsync(id, extend, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Gets an existing Project given the specified Id.</summary>
        /// <param name="id">The Id to get Project for.</param>
        /// <param name="extend">A list of keys on which to extend the Project.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<Project> ProjectGetAsync(int id, IEnumerable<string> extend, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Project/v1/{id}?");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
            if (extend != null)
                foreach (var item_ in extend)
                    urlBuilder_.Append(Uri.EscapeDataString("extend") + "=")
                        .Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<Project>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Patches an existing Project given the specified Id.</summary>
        /// <param name="id">The Id of the Project to patch.</param>
        /// <param name="body">The operations to perform onProjectCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task ProjectPatchAsync(int id, IEnumerable<JsonPatchOperation> body)
        {
            return ProjectPatchAsync(id, body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Patches an existing Project given the specified Id.</summary>
        /// <param name="id">The Id of the Project to patch.</param>
        /// <param name="body">The operations to perform onProjectCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task ProjectPatchAsync(int id, IEnumerable<JsonPatchOperation> body,
            CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Project/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PATCH");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 204)
                        {
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Replaces an existing Project given the specified Id.</summary>
        /// <param name="id">The Id of the Project to replace.</param>
        /// <param name="body">The ProjectCreate to create a new Project from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task ProjectPutAsync(int id, ProjectCreate body)
        {
            return ProjectPutAsync(id, body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Replaces an existing Project given the specified Id.</summary>
        /// <param name="id">The Id of the Project to replace.</param>
        /// <param name="body">The ProjectCreate to create a new Project from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task ProjectPutAsync(int id, ProjectCreate body, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Project/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 204)
                        {
                        }
                        else if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Gets all existing Project.</summary>
        /// <param name="extend">A list of keys on which to extend the Project.</param>
        /// <param name="filter">
        ///     Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE],
        ///     [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.
        /// </param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<Project>> ProjectGetAllAsync(IEnumerable<string> extend, FilterAction filter)
        {
            return ProjectGetAllAsync(extend, filter, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Gets all existing Project.</summary>
        /// <param name="extend">A list of keys on which to extend the Project.</param>
        /// <param name="filter">
        ///     Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE],
        ///     [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.
        /// </param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ICollection<Project>> ProjectGetAllAsync(IEnumerable<string> extend, FilterAction filter,
            CancellationToken cancellationToken)
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Project/v1?");
            if (extend != null)
                foreach (var item_ in extend)
                    urlBuilder_.Append(Uri.EscapeDataString("extend") + "=")
                        .Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append("&");
            if (filter != null)
            {
            }

            urlBuilder_.Length--;

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ICollection<Project>>(response_, headers_,
                                    cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Creates a new Project.</summary>
        /// <param name="body">The ProjectCreate to create a new Project from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<Project> ProjectPostAsync(ProjectCreate body)
        {
            return ProjectPostAsync(body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Creates a new Project.</summary>
        /// <param name="body">The ProjectCreate to create a new Project from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<Project> ProjectPostAsync(ProjectCreate body, CancellationToken cancellationToken)
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Project/v1");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<Project>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }


        /// <summary>Deletes an existing Article given the specified Id.</summary>
        /// <param name="id">The Id of the Article to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task ArticleDeleteAsync(int id)
        {
            return ArticleDeleteAsync(id, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Deletes an existing Article given the specified Id.</summary>
        /// <param name="id">The Id of the Article to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task ArticleDeleteAsync(int id, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Article/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Patches an existing Article given the specified Id.</summary>
        /// <param name="id">The Id of the Article to patch.</param>
        /// <param name="body">The operations to perform on ArticleCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task ArticlePatchAsync(int id, IEnumerable<JsonPatchOperation> body)
        {
            return ArticlePatchAsync(id, body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Patches an existing Article given the specified Id.</summary>
        /// <param name="id">The Id of the Article to patch.</param>
        /// <param name="body">The operations to perform on ArticleCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task ArticlePatchAsync(int id, IEnumerable<JsonPatchOperation> body,
            CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Article/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PATCH");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 204)
                        {
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Replaces an existing Article given the specified Id.</summary>
        /// <param name="id">The Id of the Article to replace.</param>
        /// <param name="body">The ArticleCreate to replace the old Article from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task ArticlePutAsync(int id, ArticleCreate body)
        {
            return ArticlePutAsync(id, body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Replaces an existing Article given the specified Id.</summary>
        /// <param name="id">The Id of the Article to replace.</param>
        /// <param name="body">The ArticleCreate to replace the old Article from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task ArticlePutAsync(int id, ArticleCreate body, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Article/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 204)
                        {
                        }
                        else if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Gets all existing Article.</summary>
        /// <param name="extend">A list of keys on which to extend the Article, e.g. HourRegistrations, Metadata.</param>
        /// <param name="filter">
        ///     Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE],
        ///     [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.
        /// </param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<Article>> ArticleGetAllAsync(IEnumerable<string> extend, FilterAction filter)
        {
            return ArticleGetAllAsync(extend, filter, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Gets all existing Article.</summary>
        /// <param name="extend">A list of keys on which to extend the Article, e.g. HourRegistrations, Metadata.</param>
        /// <param name="filter">
        ///     Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE],
        ///     [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.
        /// </param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ICollection<Article>> ArticleGetAllAsync(IEnumerable<string> extend, FilterAction filter,
            CancellationToken cancellationToken)
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Article/v1?");
            if (extend != null)
                foreach (var item_ in extend)
                    urlBuilder_.Append(Uri.EscapeDataString("extend") + "=")
                        .Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append("&");
            if (filter != null)
            {
            }

            urlBuilder_.Length--;

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ICollection<Article>>(response_, headers_,
                                    cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Creates a new Article.</summary>
        /// <param name="body">The ArticleCreate to create a new Article from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<Article> ArticlePostAsync(ArticleCreate body)
        {
            return ArticlePostAsync(body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Creates a new Article.</summary>
        /// <param name="body">The ArticleCreate to create a new Article from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<Article> ArticlePostAsync(ArticleCreate body, CancellationToken cancellationToken)
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Article/v1");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<Article>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Deletes an existing Carrier given the specified Id.</summary>
        /// <param name="id">The Id of the Carrier to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task CarrierDeleteAsync(int id)
        {
            return CarrierDeleteAsync(id, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Deletes an existing Carrier given the specified Id.</summary>
        /// <param name="id">The Id of the Carrier to delete.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task CarrierDeleteAsync(int id, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Carrier/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Gets an existing Carrier given the specified Id.</summary>
        /// <param name="id">The Id to get Carrier for.</param>
        /// <param name="extend">A list of keys on which to extend the Carrier, e.g. HourRegistrations, CarrierType.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<Carrier> CarrierGetAsync(int id, IEnumerable<string> extend)
        {
            return CarrierGetAsync(id, extend, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Gets an existing Carrier given the specified Id.</summary>
        /// <param name="id">The Id to get Carrier for.</param>
        /// <param name="extend">A list of keys on which to extend the Carrier, e.g. HourRegistrations, CarrierType.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<Carrier> CarrierGetAsync(int id, IEnumerable<string> extend,
            CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Carrier/v1/{id}?");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));
            if (extend != null)
                foreach (var item_ in extend)
                    urlBuilder_.Append(Uri.EscapeDataString("extend") + "=")
                        .Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append("&");
            urlBuilder_.Length--;

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<Carrier>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Patches an existing Carrier given the specified Id.</summary>
        /// <param name="id">The Id of the Carrier to patch.</param>
        /// <param name="body">The operations to perform on  CarrierCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task CarrierPatchAsync(int id, IEnumerable<JsonPatchOperation> body)
        {
            return CarrierPatchAsync(id, body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Patches an existing Carrier given the specified Id.</summary>
        /// <param name="id">The Id of the Carrier to patch.</param>
        /// <param name="body">The operations to perform on  CarrierCreate.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task CarrierPatchAsync(int id, IEnumerable<JsonPatchOperation> body,
            CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Carrier/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PATCH");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 204)
                        {
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Replaces an existing Carrier given the specified Id.</summary>
        /// <param name="id">The Id of the Carrier to replace.</param>
        /// <param name="body">The CarrierCreate to create a new Carrier from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task CarrierPutAsync(int id, CarrierCreate body)
        {
            return CarrierPutAsync(id, body, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Replaces an existing Carrier given the specified Id.</summary>
        /// <param name="id">The Id of the Carrier to replace.</param>
        /// <param name="body">The CarrierCreate to create a new Carrier from.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task CarrierPutAsync(int id, CarrierCreate body, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Carrier/v1/{id}");
            urlBuilder_.Replace("{id}", Uri.EscapeDataString(ConvertToString(id, CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new StringContent(JsonConvert.SerializeObject(body, _settings.Value));
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 204)
                        {
                        }
                        else if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 400)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Bad Request", status_, objectResponse_.Text,
                                headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <summary>Gets all existing Carrier.</summary>
        /// <param name="extend">A list of keys on which to extend the Carrier, e.g. HourRegistrations, CarrierType.</param>
        /// <param name="filter">
        ///     Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE],
        ///     [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.
        /// </param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<Carrier>> CarrierGetAllAsync(IEnumerable<string> extend, FilterAction filter)
        {
            return CarrierGetAllAsync(extend, filter, CancellationToken.None);
        }

        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of
        ///     cancellation.
        /// </param>
        /// <summary>Gets all existing Carrier.</summary>
        /// <param name="extend">A list of keys on which to extend the Carrier, e.g. HourRegistrations, CarrierType.</param>
        /// <param name="filter">
        ///     Query object used for filtering the result list. Supported operators are [EQ], [NEQ], [GT], [GTE],
        ///     [LT], [LTE], [IN], [NIN], [LIKE], [BETWEEN] for value properties.
        /// </param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ICollection<Carrier>> CarrierGetAllAsync(IEnumerable<string> extend, FilterAction filter,
            CancellationToken cancellationToken)
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append("Carrier/v1?");
            if (extend != null)
                foreach (var item_ in extend)
                    urlBuilder_.Append(Uri.EscapeDataString("extend") + "=")
                        .Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append("&");
            if (filter != null) urlBuilder_.Append(filter.ToKeyValueList());
            urlBuilder_.Length--;

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_
                        .SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;

                        ProcessResponse(client_, response_);

                        var status_ = (int) response_.StatusCode;
                        if (status_ == 404)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Not Found", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                        else if (status_ == 200)
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ICollection<Carrier>>(response_, headers_,
                                    cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var objectResponse_ =
                                await ReadObjectResponseAsync<ProblemDetails>(response_, headers_, cancellationToken)
                                    .ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_,
                                    objectResponse_.Text, headers_, null);
                            throw new ApiException<ProblemDetails>("Error", status_, objectResponse_.Text, headers_,
                                objectResponse_.Object, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response,
            IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
        {
            if (response == null || response.Content == null) return new ObjectResponseResult<T>(default, string.Empty);

            if (ReadResponseAsString)
            {
                var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    var typedBody = JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                    return new ObjectResponseResult<T>(typedBody, responseText);
                }
                catch (JsonException exception)
                {
                    var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int) response.StatusCode, responseText, headers, exception);
                }
            }

            try
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (var streamReader = new StreamReader(responseStream))
                using (var jsonTextReader = new JsonTextReader(streamReader))
                {
                    var serializer = JsonSerializer.Create(JsonSerializerSettings);
                    var typedBody = serializer.Deserialize<T>(jsonTextReader);
                    return new ObjectResponseResult<T>(typedBody, string.Empty);
                }
            }
            catch (JsonException exception)
            {
                var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int) response.StatusCode, string.Empty, headers, exception);
            }
        }

        private string ConvertToString(object value, CultureInfo cultureInfo)
        {
            if (value == null) return "";

            if (value is Enum)
            {
                var name = Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = CustomAttributeExtensions.GetCustomAttribute(field, typeof(EnumMemberAttribute))
                            as EnumMemberAttribute;
                        if (attribute != null) return attribute.Value != null ? attribute.Value : name;
                    }

                    var converted = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()),
                        cultureInfo));
                    return converted == null ? string.Empty : converted;
                }
            }
            else if (value is bool)
            {
                return Convert.ToString((bool) value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return Convert.ToBase64String((byte[]) value);
            }
            else if (value.GetType().IsArray)
            {
                var array = Enumerable.OfType<object>((Array) value);
                return string.Join(",", Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }

            var result = Convert.ToString(value, cultureInfo);
            return result == null ? "" : result;
        }

        protected struct ObjectResponseResult<T>
        {
            public ObjectResponseResult(T responseObject, string responseText)
            {
                Object = responseObject;
                Text = responseText;
            }

            public T Object { get; }

            public string Text { get; }
        }
    }
}