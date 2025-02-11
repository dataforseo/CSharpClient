using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;
using DataForSeo.Client.Models.Responses;

namespace DataForSeo.Client.Api
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsApi
    {
#pragma warning disable 8618
        private string _baseUrl;
#pragma warning restore 8618
        private System.Net.Http.HttpClient _httpClient;
        private static System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings, true);
        private Newtonsoft.Json.JsonSerializerSettings _instanceSettings;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public DataforseoLabsApi(System.Net.Http.HttpClient httpClient)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        {
            BaseUrl = "https://api.dataforseo.com";
            _httpClient = httpClient;
            Initialize();
        }

        private static Newtonsoft.Json.JsonSerializerSettings CreateSerializerSettings()
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
                if (!string.IsNullOrEmpty(_baseUrl) && !_baseUrl.EndsWith("/"))
                    _baseUrl += '/';
            }
        }

        protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings
        {
            get
            {
                return _instanceSettings ?? _settings.Value;
            }
        }

        static partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);
        partial void Initialize();
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);
        /// <remarks>
        /// This endpoint is designed to provide you with the list of IDs and metadata of the completed DataForSEO Labs tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/id_list/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsIdListResponseInfo> DataforseoLabsIdListAsync(System.Collections.Generic.IEnumerable<DataforseoLabsIdListRequestInfo> body)
        {
            return DataforseoLabsIdListAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// This endpoint is designed to provide you with the list of IDs and metadata of the completed DataForSEO Labs tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/id_list/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsIdListResponseInfo> DataforseoLabsIdListAsync(System.Collections.Generic.IEnumerable<DataforseoLabsIdListRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/id_list"
                    urlBuilder_.Append("v3/dataforseo_labs/id_list");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsIdListResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>By calling this endpoint, you will find out when the DataForSEO Labs data was last updated. The API response will provide separate update dates for the Google, Bing, and Amazon endpoints of DataForSEO Labs API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/status/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsStatusResponseInfo> DataforseoLabsStatusAsync()
        {
            return DataforseoLabsStatusAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>By calling this endpoint, you will find out when the DataForSEO Labs data was last updated. The API response will provide separate update dates for the Google, Bing, and Amazon endpoints of DataForSEO Labs API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/status/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsStatusResponseInfo> DataforseoLabsStatusAsync(System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/status"
                    urlBuilder_.Append("v3/dataforseo_labs/status");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsStatusResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// By calling this endpoint you will receive information about the DataForSEO Labs API tasks that returned an error within the past 7 days.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/errors/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsErrorsResponseInfo> DataforseoLabsErrorsAsync(System.Collections.Generic.IEnumerable<DataforseoLabsErrorsRequestInfo> body)
        {
            return DataforseoLabsErrorsAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// By calling this endpoint you will receive information about the DataForSEO Labs API tasks that returned an error within the past 7 days.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/errors/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsErrorsResponseInfo> DataforseoLabsErrorsAsync(System.Collections.Generic.IEnumerable<DataforseoLabsErrorsRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/errors"
                    urlBuilder_.Append("v3/dataforseo_labs/errors");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsErrorsResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Here you will find all the necessary information about filters that can be used with DataForSEO Labs API endpoints.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/filters/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsAvailableFiltersResponseInfo> AvailableFiltersAsync()
        {
            return AvailableFiltersAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Here you will find all the necessary information about filters that can be used with DataForSEO Labs API endpoints.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/filters/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsAvailableFiltersResponseInfo> AvailableFiltersAsync(System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/available_filters"
                    urlBuilder_.Append("v3/dataforseo_labs/available_filters");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsAvailableFiltersResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Using this endpoint you can get the full list of locations and languages supported in DataForSEO Labs API. Available sources currently include Google, Bing, and Amazon search engines. However, you should note that Amazon and Bing locations and languages are currently limited to the US/English.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/locations_and_languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsLocationsAndLanguagesResponseInfo> DataforseoLabsLocationsAndLanguagesAsync()
        {
            return DataforseoLabsLocationsAndLanguagesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Using this endpoint you can get the full list of locations and languages supported in DataForSEO Labs API. Available sources currently include Google, Bing, and Amazon search engines. However, you should note that Amazon and Bing locations and languages are currently limited to the US/English.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/locations_and_languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsLocationsAndLanguagesResponseInfo> DataforseoLabsLocationsAndLanguagesAsync(System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/locations_and_languages"
                    urlBuilder_.Append("v3/dataforseo_labs/locations_and_languages");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsLocationsAndLanguagesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// We use Google product and service categories. This endpoint will provide you with the full list of available categories.
        /// <br/>You can also download the CSV file by this link.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/categories_list/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsCategoriesResponseInfo> CategoriesAsync()
        {
            return CategoriesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// We use Google product and service categories. This endpoint will provide you with the full list of available categories.
        /// <br/>You can also download the CSV file by this link.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/categories_list/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsCategoriesResponseInfo> CategoriesAsync(System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/categories"
                    urlBuilder_.Append("v3/dataforseo_labs/categories");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsCategoriesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>By calling this endpoint, you will find obtain a list of dates available for setting in the first_date and second_date fields of the Domain Metrics by Categories endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/available_history/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleAvailableHistoryResponseInfo> GoogleAvailableHistoryAsync()
        {
            return GoogleAvailableHistoryAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>By calling this endpoint, you will find obtain a list of dates available for setting in the first_date and second_date fields of the Domain Metrics by Categories endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/available_history/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleAvailableHistoryResponseInfo> GoogleAvailableHistoryAsync(System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/available_history"
                    urlBuilder_.Append("v3/dataforseo_labs/google/available_history");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleAvailableHistoryResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The Keywords For Site endpoint will provide you with a list of keywords relevant to the target domain. Each keyword is supplied with relevant categories, search volume data for the last month, cost-per-click, competition, and search volume trend values for the past 12 months.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keywords_for_site/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleKeywordsForSiteLiveResponseInfo> GoogleKeywordsForSiteLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleKeywordsForSiteLiveRequestInfo> body)
        {
            return GoogleKeywordsForSiteLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The Keywords For Site endpoint will provide you with a list of keywords relevant to the target domain. Each keyword is supplied with relevant categories, search volume data for the last month, cost-per-click, competition, and search volume trend values for the past 12 months.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keywords_for_site/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleKeywordsForSiteLiveResponseInfo> GoogleKeywordsForSiteLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleKeywordsForSiteLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/keywords_for_site/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/keywords_for_site/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleKeywordsForSiteLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// The Related Keywords endpoint provides keywords appearing in the
        /// <br/>  "searches related to" SERP element
        /// <br/>You can get up to 4680 keyword ideas by specifying the search depth. Each related keyword comes with the list of relevant product categories, search volume rate for the last month, search volume trend for the previous 12 months, as well as current cost-per-click and competition values. Moreover, this endpoint supplies minimum, maximum and average values of daily impressions, clicks and CPC for each result.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/related_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleRelatedKeywordsLiveResponseInfo> GoogleRelatedKeywordsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo> body)
        {
            return GoogleRelatedKeywordsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// The Related Keywords endpoint provides keywords appearing in the
        /// <br/>  "searches related to" SERP element
        /// <br/>You can get up to 4680 keyword ideas by specifying the search depth. Each related keyword comes with the list of relevant product categories, search volume rate for the last month, search volume trend for the previous 12 months, as well as current cost-per-click and competition values. Moreover, this endpoint supplies minimum, maximum and average values of daily impressions, clicks and CPC for each result.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/related_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleRelatedKeywordsLiveResponseInfo> GoogleRelatedKeywordsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleRelatedKeywordsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/related_keywords/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/related_keywords/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleRelatedKeywordsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The Keyword Suggestions endpoint provides search queries that include the specified seed keyword.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keyword_suggestions/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleKeywordSuggestionsLiveResponseInfo> GoogleKeywordSuggestionsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo> body)
        {
            return GoogleKeywordSuggestionsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>The Keyword Suggestions endpoint provides search queries that include the specified seed keyword.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keyword_suggestions/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleKeywordSuggestionsLiveResponseInfo> GoogleKeywordSuggestionsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleKeywordSuggestionsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/keyword_suggestions/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/keyword_suggestions/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleKeywordSuggestionsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The Keyword Ideas endpoint provides search terms that are relevant to the product or service categories of the specified keywords. The algorithm selects the keywords which fall into the same categories as the seed keywords specified in a POST array.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keyword_ideas/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleKeywordIdeasLiveResponseInfo> GoogleKeywordIdeasLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleKeywordIdeasLiveRequestInfo> body)
        {
            return GoogleKeywordIdeasLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The Keyword Ideas endpoint provides search terms that are relevant to the product or service categories of the specified keywords. The algorithm selects the keywords which fall into the same categories as the seed keywords specified in a POST array.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keyword_ideas/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleKeywordIdeasLiveResponseInfo> GoogleKeywordIdeasLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleKeywordIdeasLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/keyword_ideas/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/keyword_ideas/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleKeywordIdeasLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with Google historical search volume, current cost-per-click, and competition values for paid search, as well as current impressions and SERP. You can get historical search volume data since the beginning of 2019, depending on keywords along with location and language combination. You can find the list of supported locations and languages here.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/historical_search_volume/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleHistoricalSearchVolumeLiveResponseInfo> GoogleHistoricalSearchVolumeLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleHistoricalSearchVolumeLiveRequestInfo> body)
        {
            return GoogleHistoricalSearchVolumeLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌ 
        /// <br/>This endpoint will provide you with Google historical search volume, current cost-per-click, and competition values for paid search, as well as current impressions and SERP. You can get historical search volume data since the beginning of 2019, depending on keywords along with location and language combination. You can find the list of supported locations and languages here.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/historical_search_volume/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleHistoricalSearchVolumeLiveResponseInfo> GoogleHistoricalSearchVolumeLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleHistoricalSearchVolumeLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/historical_search_volume/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/historical_search_volume/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleHistoricalSearchVolumeLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// This endpoint will provide you with the Keyword Difficulty metric for a maximum of 1,000 keywords in one API request. Keyword Difficulty stands for the relative difficulty of ranking in the first top-10 organic results for the related keyword. Keyword Difficulty in DataForSEO API responses indicates the chance of getting in top-10 organic results for a keyword on a logarithmic scale from 0 to 100.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/bulk_keyword_difficulty/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleBulkKeywordDifficultyLiveResponseInfo> GoogleBulkKeywordDifficultyLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleBulkKeywordDifficultyLiveRequestInfo> body)
        {
            return GoogleBulkKeywordDifficultyLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// This endpoint will provide you with the Keyword Difficulty metric for a maximum of 1,000 keywords in one API request. Keyword Difficulty stands for the relative difficulty of ranking in the first top-10 organic results for the related keyword. Keyword Difficulty in DataForSEO API responses indicates the chance of getting in top-10 organic results for a keyword on a logarithmic scale from 0 to 100.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/bulk_keyword_difficulty/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleBulkKeywordDifficultyLiveResponseInfo> GoogleBulkKeywordDifficultyLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleBulkKeywordDifficultyLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/bulk_keyword_difficulty/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/bulk_keyword_difficulty/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleBulkKeywordDifficultyLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with search intent data for up to 1,000 keywords. For each keyword that you specify when setting a task, the API will return the keyword’s search intent and intent probability. Besides the highest probable search intent, the results will also provide you with other likely search intent(s) and their probability.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/search_intent/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleSearchIntentLiveResponseInfo> GoogleSearchIntentLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleSearchIntentLiveRequestInfo> body)
        {
            return GoogleSearchIntentLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with search intent data for up to 1,000 keywords. For each keyword that you specify when setting a task, the API will return the keyword’s search intent and intent probability. Besides the highest probable search intent, the results will also provide you with other likely search intent(s) and their probability.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/search_intent/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleSearchIntentLiveResponseInfo> GoogleSearchIntentLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleSearchIntentLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/search_intent/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/search_intent/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleSearchIntentLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Using this endpoint you can get the full list of languages supported for the Google Categories for Keywords endpoint of DataForSEO Labs API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/categories_for_keywords/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleCategoriesForKeywordsLanguagesResponseInfo> DataforseoLabsGoogleCategoriesForKeywordsLanguagesAsync()
        {
            return DataforseoLabsGoogleCategoriesForKeywordsLanguagesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Using this endpoint you can get the full list of languages supported for the Google Categories for Keywords endpoint of DataForSEO Labs API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/categories_for_keywords/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleCategoriesForKeywordsLanguagesResponseInfo> DataforseoLabsGoogleCategoriesForKeywordsLanguagesAsync(System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/categories_for_keywords/languages"
                    urlBuilder_.Append("v3/dataforseo_labs/google/categories_for_keywords/languages");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleCategoriesForKeywordsLanguagesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with Google product or service categories that include keywords the domain ranks for in search. Furthermore, you will obtain general rankings and traffic data for the keywords under a certain category.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/categories_for_domain/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleCategoriesForDomainLiveResponseInfo> GoogleCategoriesForDomainLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleCategoriesForDomainLiveRequestInfo> body)
        {
            return GoogleCategoriesForDomainLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with Google product or service categories that include keywords the domain ranks for in search. Furthermore, you will obtain general rankings and traffic data for the keywords under a certain category.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/categories_for_domain/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleCategoriesForDomainLiveResponseInfo> GoogleCategoriesForDomainLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleCategoriesForDomainLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/categories_for_domain/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/categories_for_domain/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleCategoriesForDomainLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// This endpoint will provide you with Google product and service categories related for each specified keyword. You can indicate a maximum of 1,000 keywords in one API request.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/categories_for_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleCategoriesForKeywordsLiveResponseInfo> GoogleCategoriesForKeywordsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleCategoriesForKeywordsLiveRequestInfo> body)
        {
            return GoogleCategoriesForKeywordsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// This endpoint will provide you with Google product and service categories related for each specified keyword. You can indicate a maximum of 1,000 keywords in one API request.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/categories_for_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleCategoriesForKeywordsLiveResponseInfo> GoogleCategoriesForKeywordsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleCategoriesForKeywordsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/categories_for_keywords/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/categories_for_keywords/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleCategoriesForKeywordsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a list of keywords relevant to the specified product categories. You will get the search volume rate for the last month, search volume trend for the previous 12 months, as well as current cost-per-click and competition values for each keyword. Moreover, this endpoint supplies minimum, maximum, and average values of daily impressions, clicks, and CPC for each result.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keywords_for_categories/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleKeywordsForCategoriesLiveResponseInfo> GoogleKeywordsForCategoriesLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleKeywordsForCategoriesLiveRequestInfo> body)
        {
            return GoogleKeywordsForCategoriesLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with a list of keywords relevant to the specified product categories. You will get the search volume rate for the last month, search volume trend for the previous 12 months, as well as current cost-per-click and competition values for each keyword. Moreover, this endpoint supplies minimum, maximum, and average values of daily impressions, clicks, and CPC for each result.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keywords_for_categories/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleKeywordsForCategoriesLiveResponseInfo> GoogleKeywordsForCategoriesLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleKeywordsForCategoriesLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/keywords_for_categories/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/keywords_for_categories/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleKeywordsForCategoriesLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with dynamics of change in metrics of domains relevant to the specified product and service categories. You will receive historical ranking data from Google SERPs, along with valuable current and historical domain metrics, such as ETV, impressions ETV, estimated paid traffic cost, the total count of SERPs that contain domains, and more.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/domain_metrics_by_categories/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleDomainMetricsByCategoriesLiveResponseInfo> GoogleDomainMetricsByCategoriesLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo> body)
        {
            return GoogleDomainMetricsByCategoriesLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with dynamics of change in metrics of domains relevant to the specified product and service categories. You will receive historical ranking data from Google SERPs, along with valuable current and historical domain metrics, such as ETV, impressions ETV, estimated paid traffic cost, the total count of SERPs that contain domains, and more.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/domain_metrics_by_categories/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleDomainMetricsByCategoriesLiveResponseInfo> GoogleDomainMetricsByCategoriesLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleDomainMetricsByCategoriesLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/domain_metrics_by_categories/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/domain_metrics_by_categories/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleDomainMetricsByCategoriesLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The Top Searches endpoint of DataForSEO Labs API can provide you with over 7 billion keywords from the DataForSEO Keyword Database. Each keyword in the API response is provided with a set of relevant keyword data with Google Ads metrics, product categories, and Google SERP data.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/top_searches/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleTopSearchesLiveResponseInfo> GoogleTopSearchesLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleTopSearchesLiveRequestInfo> body)
        {
            return GoogleTopSearchesLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>The Top Searches endpoint of DataForSEO Labs API can provide you with over 7 billion keywords from the DataForSEO Keyword Database. Each keyword in the API response is provided with a set of relevant keyword data with Google Ads metrics, product categories, and Google SERP data.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/top_searches/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleTopSearchesLiveResponseInfo> GoogleTopSearchesLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleTopSearchesLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/top_searches/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/top_searches/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleTopSearchesLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with Whois data enriched with ranking and traffic info from organic and paid search results. Using this endpoint you will be able to get all these data for the domains matching the parameters you specify in the request.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/domain_whois_overview/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleDomainWhoisOverviewLiveResponseInfo> GoogleDomainWhoisOverviewLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleDomainWhoisOverviewLiveRequestInfo> body)
        {
            return GoogleDomainWhoisOverviewLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with Whois data enriched with ranking and traffic info from organic and paid search results. Using this endpoint you will be able to get all these data for the domains matching the parameters you specify in the request.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/domain_whois_overview/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleDomainWhoisOverviewLiveResponseInfo> GoogleDomainWhoisOverviewLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleDomainWhoisOverviewLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/domain_whois_overview/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/domain_whois_overview/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleDomainWhoisOverviewLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with the list of keywords that any domain or webpage is ranking for. You will also get SERP elements related to the keyword position, as well as impressions, monthly searches and other data relevant to the returned keywords.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/ranked_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleRankedKeywordsLiveResponseInfo> GoogleRankedKeywordsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleRankedKeywordsLiveRequestInfo> body)
        {
            return GoogleRankedKeywordsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with the list of keywords that any domain or webpage is ranking for. You will also get SERP elements related to the keyword position, as well as impressions, monthly searches and other data relevant to the returned keywords.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/ranked_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleRankedKeywordsLiveResponseInfo> GoogleRankedKeywordsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleRankedKeywordsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/ranked_keywords/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/ranked_keywords/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleRankedKeywordsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a list of domains ranking for the keywords you specify. You will also get SERP rankings, rating, estimated traffic volume, and visibility values the provided domains gain from the specified keywords.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/serp_competitors/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleSerpCompetitorsLiveResponseInfo> GoogleSerpCompetitorsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleSerpCompetitorsLiveRequestInfo> body)
        {
            return GoogleSerpCompetitorsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with a list of domains ranking for the keywords you specify. You will also get SERP rankings, rating, estimated traffic volume, and visibility values the provided domains gain from the specified keywords.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/serp_competitors/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleSerpCompetitorsLiveResponseInfo> GoogleSerpCompetitorsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleSerpCompetitorsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/serp_competitors/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/serp_competitors/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleSerpCompetitorsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a full overview of ranking and traffic data of the competitor domains from organic and paid search. In addition to that, you will get the metrics specific to the keywords both competitor domains and your domain rank for within the same SERP.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/competitors_domain/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleCompetitorsDomainLiveResponseInfo> GoogleCompetitorsDomainLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo> body)
        {
            return GoogleCompetitorsDomainLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with a full overview of ranking and traffic data of the competitor domains from organic and paid search. In addition to that, you will get the metrics specific to the keywords both competitor domains and your domain rank for within the same SERP.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/competitors_domain/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleCompetitorsDomainLiveResponseInfo> GoogleCompetitorsDomainLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleCompetitorsDomainLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/competitors_domain/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/competitors_domain/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleCompetitorsDomainLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with the keywords for which both specified domains rank within the same SERP. You will get search volume, competition, cost-per-click and impressions data on each intersecting keyword. Along with that, you will get data on the first and second domain’s SERP element discovered for this keyword, as well as the estimated traffic volume and cost of ad traffic. Domain Intersection endpoint supports organic, paid, local pack, and featured snippet results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/domain_intersection/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleDomainIntersectionLiveResponseInfo> GoogleDomainIntersectionLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleDomainIntersectionLiveRequestInfo> body)
        {
            return GoogleDomainIntersectionLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with the keywords for which both specified domains rank within the same SERP. You will get search volume, competition, cost-per-click and impressions data on each intersecting keyword. Along with that, you will get data on the first and second domain’s SERP element discovered for this keyword, as well as the estimated traffic volume and cost of ad traffic. Domain Intersection endpoint supports organic, paid, local pack, and featured snippet results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/domain_intersection/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleDomainIntersectionLiveResponseInfo> GoogleDomainIntersectionLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleDomainIntersectionLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/domain_intersection/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/domain_intersection/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleDomainIntersectionLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a list of subdomains of the specified domain, along with the ranking distribution across organic and paid search. In addition to that, you will also get the estimated traffic volume of subdomains based on search volume and impressions.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/subdomains/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleSubdomainsLiveResponseInfo> GoogleSubdomainsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleSubdomainsLiveRequestInfo> body)
        {
            return GoogleSubdomainsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>This endpoint will provide you with a list of subdomains of the specified domain, along with the ranking distribution across organic and paid search. In addition to that, you will also get the estimated traffic volume of subdomains based on search volume and impressions.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/subdomains/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleSubdomainsLiveResponseInfo> GoogleSubdomainsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleSubdomainsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/subdomains/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/subdomains/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleSubdomainsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/relevant_pages/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleRelevantPagesLiveResponseInfo> GoogleRelevantPagesLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleRelevantPagesLiveRequestInfo> body)
        {
            return GoogleRelevantPagesLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/relevant_pages/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleRelevantPagesLiveResponseInfo> GoogleRelevantPagesLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleRelevantPagesLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/relevant_pages/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/relevant_pages/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleRelevantPagesLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with ranking and traffic data from organic and paid search for the specified domain. You will be able to review the domain ranking distribution in SERPs as well as estimated monthly traffic volume for both organic and paid results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/domain_rank_overview/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleDomainRankOverviewLiveResponseInfo> GoogleDomainRankOverviewLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleDomainRankOverviewLiveRequestInfo> body)
        {
            return GoogleDomainRankOverviewLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with ranking and traffic data from organic and paid search for the specified domain. You will be able to review the domain ranking distribution in SERPs as well as estimated monthly traffic volume for both organic and paid results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/domain_rank_overview/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleDomainRankOverviewLiveResponseInfo> GoogleDomainRankOverviewLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleDomainRankOverviewLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/domain_rank_overview/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/domain_rank_overview/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleDomainRankOverviewLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with Google SERPs collected within the specified time frame. You will also receive a complete overview of featured snippets and other extra elements that were present within the specified dates. The data will allow you to analyze the dynamics of keyword rankings over time for the specified keyword and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/historical_serps/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleHistoricalSerpsLiveResponseInfo> GoogleHistoricalSerpsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleHistoricalSerpsLiveRequestInfo> body)
        {
            return GoogleHistoricalSerpsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with Google SERPs collected within the specified time frame. You will also receive a complete overview of featured snippets and other extra elements that were present within the specified dates. The data will allow you to analyze the dynamics of keyword rankings over time for the specified keyword and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/historical_serps/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleHistoricalSerpsLiveResponseInfo> GoogleHistoricalSerpsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleHistoricalSerpsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/historical_serps/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/historical_serps/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleHistoricalSerpsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with historical data on rankings and traffic of the specified domain, such as domain ranking distribution in SERPs and estimated monthly traffic volume for both organic and paid results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/historical_rank_overview/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleHistoricalRankOverviewLiveResponseInfo> GoogleHistoricalRankOverviewLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo> body)
        {
            return GoogleHistoricalRankOverviewLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with historical data on rankings and traffic of the specified domain, such as domain ranking distribution in SERPs and estimated monthly traffic volume for both organic and paid results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/historical_rank_overview/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleHistoricalRankOverviewLiveResponseInfo> GoogleHistoricalRankOverviewLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleHistoricalRankOverviewLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/historical_rank_overview/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/historical_rank_overview/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleHistoricalRankOverviewLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with the keywords for which specified pages rank within the same SERP. You will get search volume, competition, cost-per-click and impressions data on each intersecting keyword. Along with that, you will get data on SERP elements that specified pages rank for in search results, as well as the estimated traffic volume and cost of ad traffic. Page Intersection endpoint supports organic, paid, local pack and featured snippet results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/page_intersection/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGooglePageIntersectionLiveResponseInfo> GooglePageIntersectionLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGooglePageIntersectionLiveRequestInfo> body)
        {
            return GooglePageIntersectionLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with the keywords for which specified pages rank within the same SERP. You will get search volume, competition, cost-per-click and impressions data on each intersecting keyword. Along with that, you will get data on SERP elements that specified pages rank for in search results, as well as the estimated traffic volume and cost of ad traffic. Page Intersection endpoint supports organic, paid, local pack and featured snippet results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/page_intersection/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGooglePageIntersectionLiveResponseInfo> GooglePageIntersectionLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGooglePageIntersectionLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/page_intersection/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/page_intersection/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGooglePageIntersectionLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with estimated monthly traffic volumes for up to 1,000 domains. Along with organic search traffic estimations, you will also get separate values for paid search, featured snippet, and local pack results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/bulk_traffic_estimation/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleBulkTrafficEstimationLiveResponseInfo> GoogleBulkTrafficEstimationLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleBulkTrafficEstimationLiveRequestInfo> body)
        {
            return GoogleBulkTrafficEstimationLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with estimated monthly traffic volumes for up to 1,000 domains. Along with organic search traffic estimations, you will also get separate values for paid search, featured snippet, and local pack results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/bulk_traffic_estimation/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleBulkTrafficEstimationLiveResponseInfo> GoogleBulkTrafficEstimationLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleBulkTrafficEstimationLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/bulk_traffic_estimation/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/bulk_traffic_estimation/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleBulkTrafficEstimationLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with historical monthly traffic volumes for up to 1,000 domains collected within the specified time range through October 2020. If you do not specify the range, data will be returned for the previous 12 months. Along with organic search traffic estimations, you will also get separate values for paid search, featured snippet, and local pack results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/historical_bulk_traffic_estimation/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveResponseInfo> GoogleHistoricalBulkTrafficEstimationLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo> body)
        {
            return GoogleHistoricalBulkTrafficEstimationLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with historical monthly traffic volumes for up to 1,000 domains collected within the specified time range through October 2020. If you do not specify the range, data will be returned for the previous 12 months. Along with organic search traffic estimations, you will also get separate values for paid search, featured snippet, and local pack results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/historical_bulk_traffic_estimation/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveResponseInfo> GoogleHistoricalBulkTrafficEstimationLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/historical_bulk_traffic_estimation/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/historical_bulk_traffic_estimation/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleHistoricalBulkTrafficEstimationLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with search volume values for a maximum of 1,000 keywords in one API request. Here search volume represents the approximate number of monthly searches for a keyword on Amazon. The returned results are specific to the keywords, location, and language parameters specified in a POST request.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/bulk_search_volume/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsAmazonBulkSearchVolumeLiveResponseInfo> AmazonBulkSearchVolumeLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo> body)
        {
            return AmazonBulkSearchVolumeLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with search volume values for a maximum of 1,000 keywords in one API request. Here search volume represents the approximate number of monthly searches for a keyword on Amazon. The returned results are specific to the keywords, location, and language parameters specified in a POST request.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/bulk_search_volume/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsAmazonBulkSearchVolumeLiveResponseInfo> AmazonBulkSearchVolumeLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAmazonBulkSearchVolumeLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/amazon/bulk_search_volume/live"
                    urlBuilder_.Append("v3/dataforseo_labs/amazon/bulk_search_volume/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsAmazonBulkSearchVolumeLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The Related Keywords endpoint provides keywords appearing in the  "Related Searches" section on Amazon.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/related_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsAmazonRelatedKeywordsLiveResponseInfo> AmazonRelatedKeywordsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo> body)
        {
            return AmazonRelatedKeywordsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>The Related Keywords endpoint provides keywords appearing in the  "Related Searches" section on Amazon.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/related_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsAmazonRelatedKeywordsLiveResponseInfo> AmazonRelatedKeywordsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAmazonRelatedKeywordsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/amazon/related_keywords/live"
                    urlBuilder_.Append("v3/dataforseo_labs/amazon/related_keywords/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsAmazonRelatedKeywordsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a list of keywords the target product ranks for on Amazon. The returned results are specific to the asin specified in a POST request. Learn more about ASIN in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/ranked_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsAmazonRankedKeywordsLiveResponseInfo> AmazonRankedKeywordsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAmazonRankedKeywordsLiveRequestInfo> body)
        {
            return AmazonRankedKeywordsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with a list of keywords the target product ranks for on Amazon. The returned results are specific to the asin specified in a POST request. Learn more about ASIN in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/ranked_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsAmazonRankedKeywordsLiveResponseInfo> AmazonRankedKeywordsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAmazonRankedKeywordsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/amazon/ranked_keywords/live"
                    urlBuilder_.Append("v3/dataforseo_labs/amazon/ranked_keywords/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsAmazonRankedKeywordsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with ranking data from organic and paid Amazon SERPs for the target products. The returned results are specific to the asins specified in a POST request. Learn more about ASIN in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/product_rank_overview/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsAmazonProductRankOverviewLiveResponseInfo> AmazonProductRankOverviewLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAmazonProductRankOverviewLiveRequestInfo> body)
        {
            return AmazonProductRankOverviewLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with ranking data from organic and paid Amazon SERPs for the target products. The returned results are specific to the asins specified in a POST request. Learn more about ASIN in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/product_rank_overview/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsAmazonProductRankOverviewLiveResponseInfo> AmazonProductRankOverviewLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAmazonProductRankOverviewLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/amazon/product_rank_overview/live"
                    urlBuilder_.Append("v3/dataforseo_labs/amazon/product_rank_overview/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsAmazonProductRankOverviewLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a list of products that intersect with a target asin in Amazon SERPs. The data can help you identify product competitors for any listing published on Amazon. The returned results are specific to the asin as well as the location and language parameters specified in a POST request.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/product_competitors/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsAmazonProductCompetitorsLiveResponseInfo> AmazonProductCompetitorsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAmazonProductCompetitorsLiveRequestInfo> body)
        {
            return AmazonProductCompetitorsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with a list of products that intersect with a target asin in Amazon SERPs. The data can help you identify product competitors for any listing published on Amazon. The returned results are specific to the asin as well as the location and language parameters specified in a POST request.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/product_competitors/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsAmazonProductCompetitorsLiveResponseInfo> AmazonProductCompetitorsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAmazonProductCompetitorsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/amazon/product_competitors/live"
                    urlBuilder_.Append("v3/dataforseo_labs/amazon/product_competitors/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsAmazonProductCompetitorsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a list of keywords for which the target products intersect in Amazon SERP. The returned results are specific to the asins specified in a POST request. Learn more about ASIN in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/product_keyword_intersections/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsAmazonProductKeywordIntersectionsLiveResponseInfo> AmazonProductKeywordIntersectionsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAmazonProductKeywordIntersectionsLiveRequestInfo> body)
        {
            return AmazonProductKeywordIntersectionsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with a list of keywords for which the target products intersect in Amazon SERP. The returned results are specific to the asins specified in a POST request. Learn more about ASIN in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/amazon/product_keyword_intersections/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsAmazonProductKeywordIntersectionsLiveResponseInfo> AmazonProductKeywordIntersectionsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAmazonProductKeywordIntersectionsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/amazon/product_keyword_intersections/live"
                    urlBuilder_.Append("v3/dataforseo_labs/amazon/product_keyword_intersections/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsAmazonProductKeywordIntersectionsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with the Keyword Difficulty metric for a maximum of 1,000 keywords in one API request. Keyword Difficulty stands for the relative difficulty of ranking in the first top-10 organic results for the related keyword. Keyword Difficulty in DataForSEO API responses indicates the chance of getting in top-10 organic results for a keyword on a logarithmic scale from 0 to 100.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/bulk_keyword_difficulty/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsBingBulkKeywordDifficultyLiveResponseInfo> BingBulkKeywordDifficultyLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingBulkKeywordDifficultyLiveRequestInfo> body)
        {
            return BingBulkKeywordDifficultyLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with the Keyword Difficulty metric for a maximum of 1,000 keywords in one API request. Keyword Difficulty stands for the relative difficulty of ranking in the first top-10 organic results for the related keyword. Keyword Difficulty in DataForSEO API responses indicates the chance of getting in top-10 organic results for a keyword on a logarithmic scale from 0 to 100.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/bulk_keyword_difficulty/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsBingBulkKeywordDifficultyLiveResponseInfo> BingBulkKeywordDifficultyLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingBulkKeywordDifficultyLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/bing/bulk_keyword_difficulty/live"
                    urlBuilder_.Append("v3/dataforseo_labs/bing/bulk_keyword_difficulty/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsBingBulkKeywordDifficultyLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with estimated monthly traffic volumes for up to 1,000 domains. Along with organic search traffic estimations, you will also get separate values for paid search, featured snippet, and local pack results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/bulk_traffic_estimation/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsBingBulkTrafficEstimationLiveResponseInfo> BingBulkTrafficEstimationLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingBulkTrafficEstimationLiveRequestInfo> body)
        {
            return BingBulkTrafficEstimationLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with estimated monthly traffic volumes for up to 1,000 domains. Along with organic search traffic estimations, you will also get separate values for paid search, featured snippet, and local pack results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/bulk_traffic_estimation/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsBingBulkTrafficEstimationLiveResponseInfo> BingBulkTrafficEstimationLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingBulkTrafficEstimationLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/bing/bulk_traffic_estimation/live"
                    urlBuilder_.Append("v3/dataforseo_labs/bing/bulk_traffic_estimation/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsBingBulkTrafficEstimationLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a full overview of ranking and traffic data of the competitor domains from organic and paid search. In addition to that, you will get the metrics specific to the keywords both competitor domains and your domain rank for within the same SERP.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/competitors_domain/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsBingCompetitorsDomainLiveResponseInfo> BingCompetitorsDomainLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingCompetitorsDomainLiveRequestInfo> body)
        {
            return BingCompetitorsDomainLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with a full overview of ranking and traffic data of the competitor domains from organic and paid search. In addition to that, you will get the metrics specific to the keywords both competitor domains and your domain rank for within the same SERP.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/competitors_domain/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsBingCompetitorsDomainLiveResponseInfo> BingCompetitorsDomainLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingCompetitorsDomainLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/bing/competitors_domain/live"
                    urlBuilder_.Append("v3/dataforseo_labs/bing/competitors_domain/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsBingCompetitorsDomainLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with the keywords for which both specified domains rank within the same SERP. You will get data on each intersecting keyword. Along with that, you will get data on the first and second domain’s SERP element discovered for this keyword, as well as the estimated traffic volume and cost of ad traffic. Domain Intersection endpoint supports organic, paid, local pack, and featured snippet results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/domain_intersection/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsBingDomainIntersectionLiveResponseInfo> BingDomainIntersectionLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingDomainIntersectionLiveRequestInfo> body)
        {
            return BingDomainIntersectionLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with the keywords for which both specified domains rank within the same SERP. You will get data on each intersecting keyword. Along with that, you will get data on the first and second domain’s SERP element discovered for this keyword, as well as the estimated traffic volume and cost of ad traffic. Domain Intersection endpoint supports organic, paid, local pack, and featured snippet results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/domain_intersection/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsBingDomainIntersectionLiveResponseInfo> BingDomainIntersectionLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingDomainIntersectionLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/bing/domain_intersection/live"
                    urlBuilder_.Append("v3/dataforseo_labs/bing/domain_intersection/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsBingDomainIntersectionLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with ranking and traffic data from Bing’s organic and paid search for the specified domain. You will be able to review the domain ranking distribution in SERPs as well as estimated monthly traffic volume for both organic and paid results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/domain_rank_overview/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsBingDomainRankOverviewLiveResponseInfo> BingDomainRankOverviewLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingDomainRankOverviewLiveRequestInfo> body)
        {
            return BingDomainRankOverviewLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with ranking and traffic data from Bing’s organic and paid search for the specified domain. You will be able to review the domain ranking distribution in SERPs as well as estimated monthly traffic volume for both organic and paid results.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/domain_rank_overview/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsBingDomainRankOverviewLiveResponseInfo> BingDomainRankOverviewLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingDomainRankOverviewLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/bing/domain_rank_overview/live"
                    urlBuilder_.Append("v3/dataforseo_labs/bing/domain_rank_overview/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsBingDomainRankOverviewLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with the keywords for which specified pages rank within the same Bing SERP.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/page_intersection/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsBingPageIntersectionLiveResponseInfo> BingPageIntersectionLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingPageIntersectionLiveRequestInfo> body)
        {
            return BingPageIntersectionLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with the keywords for which specified pages rank within the same Bing SERP.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/page_intersection/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsBingPageIntersectionLiveResponseInfo> BingPageIntersectionLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingPageIntersectionLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/bing/page_intersection/live"
                    urlBuilder_.Append("v3/dataforseo_labs/bing/page_intersection/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsBingPageIntersectionLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with the list of keywords that any domain or webpage is ranking for. You will also get SERP elements related to the keyword position, as well as monthly searches and other data relevant to the returned keywords.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/ranked_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsBingRankedKeywordsLiveResponseInfo> BingRankedKeywordsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingRankedKeywordsLiveRequestInfo> body)
        {
            return BingRankedKeywordsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with the list of keywords that any domain or webpage is ranking for. You will also get SERP elements related to the keyword position, as well as monthly searches and other data relevant to the returned keywords.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/ranked_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsBingRankedKeywordsLiveResponseInfo> BingRankedKeywordsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingRankedKeywordsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/bing/ranked_keywords/live"
                    urlBuilder_.Append("v3/dataforseo_labs/bing/ranked_keywords/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsBingRankedKeywordsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The Related Keywords endpoint provides keywords appearing in the “searches related to” SERP element.
        /// <br/>You can get up to 4680 keyword ideas by specifying the search depth. Each related keyword comes with search volume rate for the last month, search volume trend for the previous 12 months, as well as current cost-per-click and competition values.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/related_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsBingRelatedKeywordsLiveResponseInfo> BingRelatedKeywordsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingRelatedKeywordsLiveRequestInfo> body)
        {
            return BingRelatedKeywordsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>The Related Keywords endpoint provides keywords appearing in the “searches related to” SERP element.
        /// <br/>You can get up to 4680 keyword ideas by specifying the search depth. Each related keyword comes with search volume rate for the last month, search volume trend for the previous 12 months, as well as current cost-per-click and competition values.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/related_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsBingRelatedKeywordsLiveResponseInfo> BingRelatedKeywordsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingRelatedKeywordsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/bing/related_keywords/live"
                    urlBuilder_.Append("v3/dataforseo_labs/bing/related_keywords/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsBingRelatedKeywordsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/relevant_pages/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsBingRelevantPagesLiveResponseInfo> BingRelevantPagesLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingRelevantPagesLiveRequestInfo> body)
        {
            return BingRelevantPagesLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/relevant_pages/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsBingRelevantPagesLiveResponseInfo> BingRelevantPagesLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingRelevantPagesLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/bing/relevant_pages/live"
                    urlBuilder_.Append("v3/dataforseo_labs/bing/relevant_pages/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsBingRelevantPagesLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a list of domain rankings for the keywords you specify. You will also get SERP rankings, rating, estimated traffic volume, and visibility values the provided domains gain from the specified keywords.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/serp_competitors/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsBingSerpCompetitorsLiveResponseInfo> BingSerpCompetitorsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingSerpCompetitorsLiveRequestInfo> body)
        {
            return BingSerpCompetitorsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with a list of domain rankings for the keywords you specify. You will also get SERP rankings, rating, estimated traffic volume, and visibility values the provided domains gain from the specified keywords.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/serp_competitors/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsBingSerpCompetitorsLiveResponseInfo> BingSerpCompetitorsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingSerpCompetitorsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/bing/serp_competitors/live"
                    urlBuilder_.Append("v3/dataforseo_labs/bing/serp_competitors/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsBingSerpCompetitorsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a list of subdomains of the specified domain, along with the ranking distribution across organic and paid search. In addition to that, you will also get the estimated traffic volume of subdomains based on search volume.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/subdomains/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsBingSubdomainsLiveResponseInfo> BingSubdomainsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingSubdomainsLiveRequestInfo> body)
        {
            return BingSubdomainsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>This endpoint will provide you with a list of subdomains of the specified domain, along with the ranking distribution across organic and paid search. In addition to that, you will also get the estimated traffic volume of subdomains based on search volume.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/bing/subdomains/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsBingSubdomainsLiveResponseInfo> BingSubdomainsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsBingSubdomainsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/bing/subdomains/live"
                    urlBuilder_.Append("v3/dataforseo_labs/bing/subdomains/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsBingSubdomainsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with ranking metrics for up to 1000 Google Play applications.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/bulk_app_metrics/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleBulkAppMetricsLiveResponseInfo> GoogleBulkAppMetricsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleBulkAppMetricsLiveRequestInfo> body)
        {
            return GoogleBulkAppMetricsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with ranking metrics for up to 1000 Google Play applications.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/bulk_app_metrics/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleBulkAppMetricsLiveResponseInfo> GoogleBulkAppMetricsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleBulkAppMetricsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/bulk_app_metrics/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/bulk_app_metrics/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleBulkAppMetricsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a list of keywords for which the target app ranks on Google Play. You will obtain keyword data and discover the app’s ranking position for each returned keyword.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keywords_for_app/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleKeywordsForAppLiveResponseInfo> GoogleKeywordsForAppLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleKeywordsForAppLiveRequestInfo> body)
        {
            return GoogleKeywordsForAppLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with a list of keywords for which the target app ranks on Google Play. You will obtain keyword data and discover the app’s ranking position for each returned keyword.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/keywords_for_app/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleKeywordsForAppLiveResponseInfo> GoogleKeywordsForAppLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleKeywordsForAppLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/keywords_for_app/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/keywords_for_app/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleKeywordsForAppLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a list of mobile applications that intersect with the target app for its ranking keywords on Google Play. You will obtain the IDs of competitor apps along with search volume and ranking data on competitor ranking keywords.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/app_competitors/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleAppCompetitorsLiveResponseInfo> GoogleAppCompetitorsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleAppCompetitorsLiveRequestInfo> body)
        {
            return GoogleAppCompetitorsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with a list of mobile applications that intersect with the target app for its ranking keywords on Google Play. You will obtain the IDs of competitor apps along with search volume and ranking data on competitor ranking keywords.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/app_competitors/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleAppCompetitorsLiveResponseInfo> GoogleAppCompetitorsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleAppCompetitorsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/app_competitors/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/app_competitors/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleAppCompetitorsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a list of keywords for which the mobile applications specified in the app_ids object rank within the same Google Play SERP.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/app_intersection/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsGoogleAppIntersectionLiveResponseInfo> GoogleAppIntersectionLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleAppIntersectionLiveRequestInfo> body)
        {
            return GoogleAppIntersectionLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with a list of keywords for which the mobile applications specified in the app_ids object rank within the same Google Play SERP.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/google/app_intersection/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsGoogleAppIntersectionLiveResponseInfo> GoogleAppIntersectionLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsGoogleAppIntersectionLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/google/app_intersection/live"
                    urlBuilder_.Append("v3/dataforseo_labs/google/app_intersection/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsGoogleAppIntersectionLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with ranking metrics for up to 1000 App Store applications.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/apple/bulk_app_metrics/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsAppleBulkAppMetricsLiveResponseInfo> AppleBulkAppMetricsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAppleBulkAppMetricsLiveRequestInfo> body)
        {
            return AppleBulkAppMetricsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with ranking metrics for up to 1000 App Store applications.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/apple/bulk_app_metrics/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsAppleBulkAppMetricsLiveResponseInfo> AppleBulkAppMetricsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAppleBulkAppMetricsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/apple/bulk_app_metrics/live"
                    urlBuilder_.Append("v3/dataforseo_labs/apple/bulk_app_metrics/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsAppleBulkAppMetricsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a list of keywords for which the target app ranks on App Store. You will obtain keyword data and discover the app’s ranking position for each returned keyword.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/apple/keywords_for_app/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsAppleKeywordsForAppLiveResponseInfo> AppleKeywordsForAppLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAppleKeywordsForAppLiveRequestInfo> body)
        {
            return AppleKeywordsForAppLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with a list of keywords for which the target app ranks on App Store. You will obtain keyword data and discover the app’s ranking position for each returned keyword.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/apple/keywords_for_app/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsAppleKeywordsForAppLiveResponseInfo> AppleKeywordsForAppLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAppleKeywordsForAppLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/apple/keywords_for_app/live"
                    urlBuilder_.Append("v3/dataforseo_labs/apple/keywords_for_app/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsAppleKeywordsForAppLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a list of mobile applications that intersect with the target app for its ranking keywords on App Store. You will obtain the IDs of competitor apps along with search volume and ranking data on competitor ranking keywords.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/apple/app_competitors/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsAppleAppCompetitorsLiveResponseInfo> AppleAppCompetitorsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAppleAppCompetitorsLiveRequestInfo> body)
        {
            return AppleAppCompetitorsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with a list of mobile applications that intersect with the target app for its ranking keywords on App Store. You will obtain the IDs of competitor apps along with search volume and ranking data on competitor ranking keywords.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/apple/app_competitors/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsAppleAppCompetitorsLiveResponseInfo> AppleAppCompetitorsLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAppleAppCompetitorsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/apple/app_competitors/live"
                    urlBuilder_.Append("v3/dataforseo_labs/apple/app_competitors/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsAppleAppCompetitorsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a list of keywords for which the mobile applications specified in the app_ids object rank within the same App Store SERP.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/apple/app_intersection/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<DataforseoLabsAppleAppIntersectionLiveResponseInfo> AppleAppIntersectionLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAppleAppIntersectionLiveRequestInfo> body)
        {
            return AppleAppIntersectionLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with a list of keywords for which the mobile applications specified in the app_ids object rank within the same App Store SERP.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/dataforseo_labs/apple/app_intersection/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<DataforseoLabsAppleAppIntersectionLiveResponseInfo> AppleAppIntersectionLiveAsync(System.Collections.Generic.IEnumerable<DataforseoLabsAppleAppIntersectionLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, JsonSerializerSettings);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/dataforseo_labs/apple/app_intersection/live"
                    urlBuilder_.Append("v3/dataforseo_labs/apple/app_intersection/live");
                    PrepareRequest(client_, request_, urlBuilder_);
                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);
                    PrepareRequest(client_, request_, url_);
                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<DataforseoLabsAppleAppIntersectionLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
            else if (value is string[])
            {
                return string.Join(",", (string[])value);
            }
            else if (value.GetType().IsArray)
            {
                var valueArray = (System.Array)value;
                var valueTextArray = new string[valueArray.Length];
                for (var i = 0; i < valueArray.Length; i++)
                {
                    valueTextArray[i] = ConvertToString(valueArray.GetValue(i), cultureInfo);
                }

                return string.Join(",", valueTextArray);
            }

            var result = System.Convert.ToString(value, cultureInfo);
            return result == null ? "" : result;
        }
    }
}