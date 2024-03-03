using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;
using DataForSeo.Client.Models.Responses;

namespace DataForSeo.Client.Api
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MerchantApi
    {
        private string _baseUrl = "https://api.dataforseo.com";
        private System.Net.Http.HttpClient _httpClient;
        private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;
        public MerchantApi(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient;
            _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings, true);
        }

        private Newtonsoft.Json.JsonSerializerSettings CreateSerializerSettings()
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            UpdateJsonSerializerSettings(settings);
            return settings;
        }

        public string BaseUrl
        {
            get
            {
                return _baseUrl;
            }

            set
            {
                _baseUrl = value;
            }
        }

        protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings
        {
            get
            {
                return _settings.Value;
            }
        }

        partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);
        /// <remarks>
        /// This endpoint is designed to provide you with the list of IDs and metadata of the completed Merchant tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/id_list/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantIdListResponseInfo> MerchantIdListAsync(System.Collections.Generic.IEnumerable<MerchantIdListRequestInfo> body)
        {
            return MerchantIdListAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// This endpoint is designed to provide you with the list of IDs and metadata of the completed Merchant tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/id_list/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantIdListResponseInfo> MerchantIdListAsync(System.Collections.Generic.IEnumerable<MerchantIdListRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/id_list");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantIdListResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// By calling this endpoint you will receive information about the Merchant API tasks that returned an error within the past 24 hours.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/errors/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantErrorsResponseInfo> MerchantErrorsAsync(System.Collections.Generic.IEnumerable<MerchantErrorsRequestInfo> body)
        {
            return MerchantErrorsAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// By calling this endpoint you will receive information about the Merchant API tasks that returned an error within the past 24 hours.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/errors/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantErrorsResponseInfo> MerchantErrorsAsync(System.Collections.Generic.IEnumerable<MerchantErrorsRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/errors");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantErrorsResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// You will receive the list of supported Google Shopping languages by calling this API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleLanguagesResponseInfo> MerchantGoogleLanguagesAsync()
        {
            return MerchantGoogleLanguagesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of supported Google Shopping languages by calling this API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleLanguagesResponseInfo> MerchantGoogleLanguagesAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/languages");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleLanguagesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleLocationsResponseInfo> MerchantGoogleLocationsAsync()
        {
            return MerchantGoogleLocationsAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleLocationsResponseInfo> MerchantGoogleLocationsAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/locations");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleLocationsResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleLocationsCountryResponseInfo> MerchantGoogleLocationsCountryAsync(string country)
        {
            return MerchantGoogleLocationsCountryAsync(country, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleLocationsCountryResponseInfo> MerchantGoogleLocationsCountryAsync(string country, System.Threading.CancellationToken cancellationToken)
        {
            if (country == null)
                throw new System.ArgumentNullException("country");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/locations/{country}");
            urlBuilder_.Replace("{country}", System.Uri.EscapeDataString(ConvertToString(country, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleLocationsCountryResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// ‌‌
        /// <br/>Google Shopping Products endpoint will provide you with the list of products found on Google Shopping for the specified query. The results include product title, description in Google Shopping SERP, product rank, price, reviews and rating as well as the related domain.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleProductsTaskPostResponseInfo> GoogleProductsTaskPostAsync(System.Collections.Generic.IEnumerable<MerchantTaskRequestInfo> body)
        {
            return GoogleProductsTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Google Shopping Products endpoint will provide you with the list of products found on Google Shopping for the specified query. The results include product title, description in Google Shopping SERP, product rank, price, reviews and rating as well as the related domain.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleProductsTaskPostResponseInfo> GoogleProductsTaskPostAsync(System.Collections.Generic.IEnumerable<MerchantTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/products/task_post");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleProductsTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleProductsTasksReadyResponseInfo> GoogleProductsTasksReadyAsync()
        {
            return GoogleProductsTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleProductsTasksReadyResponseInfo> GoogleProductsTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/products/tasks_ready");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleProductsTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleProductsTaskGetAdvancedResponseInfo> GoogleProductsTaskGetAdvancedAsync(string id)
        {
            return GoogleProductsTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleProductsTaskGetAdvancedResponseInfo> GoogleProductsTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/products/task_get/advanced/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleProductsTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleProductsTaskGetHtmlResponseInfo> GoogleProductsTaskGetHtmlAsync(string id)
        {
            return GoogleProductsTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/products/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleProductsTaskGetHtmlResponseInfo> GoogleProductsTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/products/task_get/html/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleProductsTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// ‌‌
        /// <br/>Google Shopping Sellers endpoint will provide you with the list of sellers that listed the specified product on Google Shopping. The provided data for each seller includes related product base and total price, shipment and purchase details and special offers. The results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleSellersTaskPostResponseInfo> GoogleSellersTaskPostAsync(System.Collections.Generic.IEnumerable<MerchantGoogleSellersTaskPostRequestInfo> body)
        {
            return GoogleSellersTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Google Shopping Sellers endpoint will provide you with the list of sellers that listed the specified product on Google Shopping. The provided data for each seller includes related product base and total price, shipment and purchase details and special offers. The results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleSellersTaskPostResponseInfo> GoogleSellersTaskPostAsync(System.Collections.Generic.IEnumerable<MerchantGoogleSellersTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/sellers/task_post");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleSellersTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleSellersTasksReadyResponseInfo> GoogleSellersTasksReadyAsync()
        {
            return GoogleSellersTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleSellersTasksReadyResponseInfo> GoogleSellersTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/sellers/tasks_ready");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleSellersTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleSellersTaskGetAdvancedResponseInfo> GoogleSellersTaskGetAdvancedAsync(string id)
        {
            return GoogleSellersTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleSellersTaskGetAdvancedResponseInfo> GoogleSellersTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/sellers/task_get/advanced/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleSellersTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleSellersTaskGetHtmlResponseInfo> GoogleSellersTaskGetHtmlAsync(string id)
        {
            return GoogleSellersTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleSellersTaskGetHtmlResponseInfo> GoogleSellersTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/sellers/task_get/html/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleSellersTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// ‌‌
        /// <br/>This endpoint provides product data from Google Shopping based on the specified product_id. You will get a full detailed product description as it is given on the Google Shopping product specification page. Product data can include parameters of the product, brand name, part numbers, GTIN, etc.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleProductSpecTaskPostResponseInfo> GoogleProductSpecTaskPostAsync(System.Collections.Generic.IEnumerable<MerchantGoogleProductSpecTaskPostRequestInfo> body)
        {
            return GoogleProductSpecTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>This endpoint provides product data from Google Shopping based on the specified product_id. You will get a full detailed product description as it is given on the Google Shopping product specification page. Product data can include parameters of the product, brand name, part numbers, GTIN, etc.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleProductSpecTaskPostResponseInfo> GoogleProductSpecTaskPostAsync(System.Collections.Generic.IEnumerable<MerchantGoogleProductSpecTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/product_spec/task_post");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleProductSpecTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleProductSpecTasksReadyResponseInfo> GoogleProductSpecTasksReadyAsync()
        {
            return GoogleProductSpecTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleProductSpecTasksReadyResponseInfo> GoogleProductSpecTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/product_spec/tasks_ready");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleProductSpecTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleProductSpecTaskGetAdvancedResponseInfo> GoogleProductSpecTaskGetAdvancedAsync(string id)
        {
            return GoogleProductSpecTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleProductSpecTaskGetAdvancedResponseInfo> GoogleProductSpecTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/product_spec/task_get/advanced/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleProductSpecTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleProductSpecTaskGetHtmlResponseInfo> GoogleProductSpecTaskGetHtmlAsync(string id)
        {
            return GoogleProductSpecTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_spec/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleProductSpecTaskGetHtmlResponseInfo> GoogleProductSpecTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/product_spec/task_get/html/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleProductSpecTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// ‌‌
        /// <br/>This endpoint provides data on a product listed on Google Shopping, including product description, images, rating, variations, and sellers. In order to set a task, you have to specify the  product_id.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_info/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleProductInfoTaskPostResponseInfo> GoogleProductInfoTaskPostAsync(System.Collections.Generic.IEnumerable<MerchantGoogleProductInfoTaskPostRequestInfo> body)
        {
            return GoogleProductInfoTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>This endpoint provides data on a product listed on Google Shopping, including product description, images, rating, variations, and sellers. In order to set a task, you have to specify the  product_id.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_info/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleProductInfoTaskPostResponseInfo> GoogleProductInfoTaskPostAsync(System.Collections.Generic.IEnumerable<MerchantGoogleProductInfoTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/product_info/task_post");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleProductInfoTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_info/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleProductInfoTasksReadyResponseInfo> GoogleProductInfoTasksReadyAsync()
        {
            return GoogleProductInfoTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_info/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleProductInfoTasksReadyResponseInfo> GoogleProductInfoTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/product_info/tasks_ready");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleProductInfoTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_info/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleProductInfoTaskGetAdvancedResponseInfo> GoogleProductInfoTaskGetAdvancedAsync(string id)
        {
            return GoogleProductInfoTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/product_info/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleProductInfoTaskGetAdvancedResponseInfo> GoogleProductInfoTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/product_info/task_get/advanced/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleProductInfoTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// Google Shopping Sellers Ad URL is designed to provide you with a full URL of the advertisement containing all additional parameters set by the seller.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/ad_url/?bash'
        /// </remarks>
        /// <param name = "shop_ad_aclk">unique ad click referral parameter
        /// <br/>you can obtain this parameter with Google Shopping Products or Google Shopping Sellers</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantGoogleSellersAdUrlResponseInfo> GoogleSellersAdUrlAsync(string shop_ad_aclk)
        {
            return GoogleSellersAdUrlAsync(shop_ad_aclk, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Google Shopping Sellers Ad URL is designed to provide you with a full URL of the advertisement containing all additional parameters set by the seller.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/google/sellers/ad_url/?bash'
        /// </remarks>
        /// <param name = "shop_ad_aclk">unique ad click referral parameter
        /// <br/>you can obtain this parameter with Google Shopping Products or Google Shopping Sellers</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantGoogleSellersAdUrlResponseInfo> GoogleSellersAdUrlAsync(string shop_ad_aclk, System.Threading.CancellationToken cancellationToken)
        {
            if (shop_ad_aclk == null)
                throw new System.ArgumentNullException("shop_ad_aclk");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/google/sellers/ad_url/{shop_ad_aclk}");
            urlBuilder_.Replace("{shop_ad_aclk}", System.Uri.EscapeDataString(ConvertToString(shop_ad_aclk, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantGoogleSellersAdUrlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// You will receive the list of supported Amazon locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonLocationsResponseInfo> MerchantAmazonLocationsAsync()
        {
            return MerchantAmazonLocationsAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of supported Amazon locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonLocationsResponseInfo> MerchantAmazonLocationsAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/locations");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonLocationsResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// You will receive the list of supported Amazon locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonLocationsCountryResponseInfo> MerchantAmazonLocationsCountryAsync(string country)
        {
            return MerchantAmazonLocationsCountryAsync(country, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of supported Amazon locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonLocationsCountryResponseInfo> MerchantAmazonLocationsCountryAsync(string country, System.Threading.CancellationToken cancellationToken)
        {
            if (country == null)
                throw new System.ArgumentNullException("country");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/locations/{country}");
            urlBuilder_.Replace("{country}", System.Uri.EscapeDataString(ConvertToString(country, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonLocationsCountryResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// You will receive the list of supported Amazon languages by calling this API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonLanguagesResponseInfo> MerchantAmazonLanguagesAsync()
        {
            return MerchantAmazonLanguagesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of supported Amazon languages by calling this API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonLanguagesResponseInfo> MerchantAmazonLanguagesAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/languages");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonLanguagesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// ‌‌
        /// <br/>This endpoint provides results from Amazon product listings according to the specified keyword (product name), location, and language parameters.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonProductsTaskPostResponseInfo> AmazonProductsTaskPostAsync(System.Collections.Generic.IEnumerable<MerchantAmazonProductsTaskPostRequestInfo> body)
        {
            return AmazonProductsTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>This endpoint provides results from Amazon product listings according to the specified keyword (product name), location, and language parameters.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonProductsTaskPostResponseInfo> AmazonProductsTaskPostAsync(System.Collections.Generic.IEnumerable<MerchantAmazonProductsTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/products/task_post");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonProductsTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonProductsTasksReadyResponseInfo> AmazonProductsTasksReadyAsync()
        {
            return AmazonProductsTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonProductsTasksReadyResponseInfo> AmazonProductsTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/products/tasks_ready");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonProductsTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonProductsTaskGetAdvancedResponseInfo> AmazonProductsTaskGetAdvancedAsync(string id)
        {
            return AmazonProductsTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonProductsTaskGetAdvancedResponseInfo> AmazonProductsTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/products/task_get/advanced/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonProductsTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonProductsTaskGetHtmlResponseInfo> AmazonProductsTaskGetHtmlAsync(string id)
        {
            return AmazonProductsTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/products/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonProductsTaskGetHtmlResponseInfo> AmazonProductsTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/products/task_get/html/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonProductsTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// ‌‌
        /// <br/>This endpoint will provide you with a full list of ASINs assigned to different modifications of a product.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonAsinTaskPostResponseInfo> AmazonAsinTaskPostAsync(System.Collections.Generic.IEnumerable<MerchantAmazonAsinTaskPostRequestInfo> body)
        {
            return AmazonAsinTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>This endpoint will provide you with a full list of ASINs assigned to different modifications of a product.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonAsinTaskPostResponseInfo> AmazonAsinTaskPostAsync(System.Collections.Generic.IEnumerable<MerchantAmazonAsinTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/asin/task_post");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonAsinTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonAsinTasksReadyResponseInfo> AmazonAsinTasksReadyAsync()
        {
            return AmazonAsinTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonAsinTasksReadyResponseInfo> AmazonAsinTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/asin/tasks_ready");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonAsinTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// This endpoint will provide you with information about the product and ASINs of all its modifications listed on Amazon.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonAsinTaskGetAdvancedResponseInfo> AmazonAsinTaskGetAdvancedAsync(string id)
        {
            return AmazonAsinTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// This endpoint will provide you with information about the product and ASINs of all its modifications listed on Amazon.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonAsinTaskGetAdvancedResponseInfo> AmazonAsinTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/asin/task_get/advanced/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonAsinTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonAsinTaskGetHtmlResponseInfo> AmazonAsinTaskGetHtmlAsync(string id)
        {
            return AmazonAsinTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/asin/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonAsinTaskGetHtmlResponseInfo> AmazonAsinTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/asin/task_get/html/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonAsinTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// ‌‌
        /// <br/>This endpoint provides a list of sellers of the specified product on Amazon. The data provided for each seller includes related product condition, pricing, shipment, and rating details.
        /// <br/>The results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonSellersTaskPostResponseInfo> AmazonSellersTaskPostAsync(System.Collections.Generic.IEnumerable<MerchantAmazonSellersTaskPostRequestInfo> body)
        {
            return AmazonSellersTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>This endpoint provides a list of sellers of the specified product on Amazon. The data provided for each seller includes related product condition, pricing, shipment, and rating details.
        /// <br/>The results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonSellersTaskPostResponseInfo> AmazonSellersTaskPostAsync(System.Collections.Generic.IEnumerable<MerchantAmazonSellersTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/sellers/task_post");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonSellersTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonSellersTasksReadyResponseInfo> AmazonSellersTasksReadyAsync()
        {
            return AmazonSellersTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonSellersTasksReadyResponseInfo> AmazonSellersTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/sellers/tasks_ready");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonSellersTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// This endpoint provides a list of sellers of the specified product on Amazon. The data provided for each seller includes related product condition, pricing, shipment, and rating details.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonSellersTaskGetAdvancedResponseInfo> AmazonSellersTaskGetAdvancedAsync(string id)
        {
            return AmazonSellersTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// This endpoint provides a list of sellers of the specified product on Amazon. The data provided for each seller includes related product condition, pricing, shipment, and rating details.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonSellersTaskGetAdvancedResponseInfo> AmazonSellersTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/sellers/task_get/advanced/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonSellersTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonSellersTaskGetHtmlResponseInfo> AmazonSellersTaskGetHtmlAsync(string id)
        {
            return AmazonSellersTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/sellers/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonSellersTaskGetHtmlResponseInfo> AmazonSellersTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/sellers/task_get/html/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonSellersTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// ‌‌
        /// <br/>This endpoint will provide you with a list of reviews for the target Amazon product.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonReviewsTaskPostResponseInfo> AmazonReviewsTaskPostAsync(System.Collections.Generic.IEnumerable<MerchantAmazonReviewsTaskPostRequestInfo> body)
        {
            return AmazonReviewsTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>This endpoint will provide you with a list of reviews for the target Amazon product.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonReviewsTaskPostResponseInfo> AmazonReviewsTaskPostAsync(System.Collections.Generic.IEnumerable<MerchantAmazonReviewsTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/reviews/task_post");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonReviewsTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonReviewsTasksReadyResponseInfo> AmazonReviewsTasksReadyAsync()
        {
            return AmazonReviewsTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with a list of completed tasks that haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoints.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonReviewsTasksReadyResponseInfo> AmazonReviewsTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/reviews/tasks_ready");
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonReviewsTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// This endpoint provides feedback data on products listed on the Amazon marketplace, including their titles, images, ratings, review content, user profile info, review publication dates, and more. The results are specific to the asin specified in the POST request.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonReviewsTaskGetAdvancedResponseInfo> AmazonReviewsTaskGetAdvancedAsync(string id)
        {
            return AmazonReviewsTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// This endpoint provides feedback data on products listed on the Amazon marketplace, including their titles, images, ratings, review content, user profile info, review publication dates, and more. The results are specific to the asin specified in the POST request.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonReviewsTaskGetAdvancedResponseInfo> AmazonReviewsTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/reviews/task_get/advanced/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonReviewsTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<MerchantAmazonReviewsTaskGetHtmlResponseInfo> AmazonReviewsTaskGetHtmlAsync(string id)
        {
            return AmazonReviewsTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/merchant/amazon/reviews/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<MerchantAmazonReviewsTaskGetHtmlResponseInfo> AmazonReviewsTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/v3/merchant/amazon/reviews/task_get/html/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<MerchantAmazonReviewsTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
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

        protected struct ObjectResponseResult<T>
        {
            public ObjectResponseResult(T responseObject, string responseText)
            {
                this.Object = responseObject;
                this.Text = responseText;
            }

            public T Object { get; }
            public string Text { get; }
        }

        public bool ReadResponseAsString { get; set; }

        protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Threading.CancellationToken cancellationToken)
        {
            if (response == null || response.Content == null)
            {
                return new ObjectResponseResult<T>(default(T), string.Empty);
            }

            if (ReadResponseAsString)
            {
                var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                    return new ObjectResponseResult<T>(typedBody, responseText);
                }
                catch (Newtonsoft.Json.JsonException exception)
                {
                    var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
                }
            }
            else
            {
                try
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    using (var streamReader = new System.IO.StreamReader(responseStream))
                    using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                    {
                        var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                        var typedBody = serializer.Deserialize<T>(jsonTextReader);
                        return new ObjectResponseResult<T>(typedBody, string.Empty);
                    }
                }
                catch (Newtonsoft.Json.JsonException exception)
                {
                    var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
                }
            }
        }

        private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value == null)
            {
                return "";
            }

            if (value is System.Enum)
            {
                var name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute)) as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value != null ? attribute.Value : name;
                        }
                    }

                    var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                    return converted == null ? string.Empty : converted;
                }
            }
            else if (value is bool)
            {
                return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return System.Convert.ToBase64String((byte[])value);
            }
            else if (value.GetType().IsArray)
            {
                var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }

            var result = System.Convert.ToString(value, cultureInfo);
            return result == null ? "" : result;
        }
    }
}