using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;
using DataForSeo.Client.Models.Responses;

namespace DataForSeo.Client.Api
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "1.0.0.0 (NJsonSchema v1.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KeywordsDataApi
    {
#pragma warning disable 8618
        private string _baseUrl;
#pragma warning restore 8618
        private System.Net.Http.HttpClient _httpClient;
        private static System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings, true);
        private Newtonsoft.Json.JsonSerializerSettings _instanceSettings;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public KeywordsDataApi(System.Net.Http.HttpClient httpClient)
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
        /// This endpoint is designed to provide you with the list of IDs and metadata of the completed Keywords Data tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/id_list/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataIdListResponseInfo> KeywordsDataIdListAsync(System.Collections.Generic.IEnumerable<KeywordsDataIdListRequestInfo> body)
        {
            return KeywordsDataIdListAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// This endpoint is designed to provide you with the list of IDs and metadata of the completed Keywords Data tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/id_list/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataIdListResponseInfo> KeywordsDataIdListAsync(System.Collections.Generic.IEnumerable<KeywordsDataIdListRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/id_list"
                    urlBuilder_.Append("v3/keywords_data/id_list");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataIdListResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// By calling this endpoint you will receive information about the Keywords Data API tasks that returned an error within the past 24 hours.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/errors/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataErrorsResponseInfo> KeywordsDataErrorsAsync(System.Collections.Generic.IEnumerable<KeywordsDataErrorsRequestInfo> body)
        {
            return KeywordsDataErrorsAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// By calling this endpoint you will receive information about the Keywords Data API tasks that returned an error within the past 24 hours.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/errors/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataErrorsResponseInfo> KeywordsDataErrorsAsync(System.Collections.Generic.IEnumerable<KeywordsDataErrorsRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/errors"
                    urlBuilder_.Append("v3/keywords_data/errors");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataErrorsResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>By calling this endpoint, you will know if Google updated keyword data for the previous month. Generally, Google updates keyword data in the middle of the month. So, if Google updated its data in October, you would be able to see the actual search volume, cost-per-click, competition, and other metrics for September. If Google didn’t update its data in October, the latest information would be available for August.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/status/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsStatusResponseInfo> GoogleAdsStatusAsync()
        {
            return GoogleAdsStatusAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>By calling this endpoint, you will know if Google updated keyword data for the previous month. Generally, Google updates keyword data in the middle of the month. So, if Google updated its data in October, you would be able to see the actual search volume, cost-per-click, competition, and other metrics for September. If Google didn’t update its data in October, the latest information would be available for August.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/status/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsStatusResponseInfo> GoogleAdsStatusAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_ads/status"
                    urlBuilder_.Append("v3/keywords_data/google_ads/status");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsStatusResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>We use Google Geographical Targeting. You can refer to Google Ads Target Types page to review the full list of possible location types. With Keywords Data API, you can select any location type supported by Google, except for “Okrug”.
        /// <br/>Postal Codes can be used to set a task, albeit API response will not return data for such tasks.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsLocationsResponseInfo> KeywordsDataGoogleAdsLocationsAsync()
        {
            return KeywordsDataGoogleAdsLocationsAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>We use Google Geographical Targeting. You can refer to Google Ads Target Types page to review the full list of possible location types. With Keywords Data API, you can select any location type supported by Google, except for “Okrug”.
        /// <br/>Postal Codes can be used to set a task, albeit API response will not return data for such tasks.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsLocationsResponseInfo> KeywordsDataGoogleAdsLocationsAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_ads/locations"
                    urlBuilder_.Append("v3/keywords_data/google_ads/locations");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsLocationsResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>We use Google Geographical Targeting. You can refer to Google Ads Target Types page to review the full list of possible location types. With Keywords Data API, you can select any location type supported by Google, except for “Okrug”.
        /// <br/>Postal Codes can be used to set a task, albeit API response will not return data for such tasks.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsLocationsCountryResponseInfo> KeywordsDataGoogleAdsLocationsCountryAsync(string country)
        {
            return KeywordsDataGoogleAdsLocationsCountryAsync(country, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>We use Google Geographical Targeting. You can refer to Google Ads Target Types page to review the full list of possible location types. With Keywords Data API, you can select any location type supported by Google, except for “Okrug”.
        /// <br/>Postal Codes can be used to set a task, albeit API response will not return data for such tasks.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsLocationsCountryResponseInfo> KeywordsDataGoogleAdsLocationsCountryAsync(string country, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_ads/locations/{country}"
                    urlBuilder_.Append("v3/keywords_data/google_ads/locations/");
                    urlBuilder_.Append(System.Uri.EscapeDataString(ConvertToString(country, System.Globalization.CultureInfo.InvariantCulture)));
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsLocationsCountryResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// By calling this API you will receive the list of languages supported by Keywords Data API.
        /// <br/>‌
        /// <br/>‌‌As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information about available languages.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsLanguagesResponseInfo> KeywordsDataGoogleAdsLanguagesAsync()
        {
            return KeywordsDataGoogleAdsLanguagesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// By calling this API you will receive the list of languages supported by Keywords Data API.
        /// <br/>‌
        /// <br/>‌‌As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information about available languages.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsLanguagesResponseInfo> KeywordsDataGoogleAdsLanguagesAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_ads/languages"
                    urlBuilder_.Append("v3/keywords_data/google_ads/languages");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsLanguagesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/search_volume/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsSearchVolumeTaskPostResponseInfo> GoogleAdsSearchVolumeTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataTaskRequestInfo> body)
        {
            return GoogleAdsSearchVolumeTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/search_volume/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsSearchVolumeTaskPostResponseInfo> GoogleAdsSearchVolumeTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_ads/search_volume/task_post"
                    urlBuilder_.Append("v3/keywords_data/google_ads/search_volume/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsSearchVolumeTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/search_volume/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsSearchVolumeTasksReadyResponseInfo> GoogleAdsSearchVolumeTasksReadyAsync()
        {
            return GoogleAdsSearchVolumeTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/search_volume/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsSearchVolumeTasksReadyResponseInfo> GoogleAdsSearchVolumeTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_ads/search_volume/tasks_ready"
                    urlBuilder_.Append("v3/keywords_data/google_ads/search_volume/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsSearchVolumeTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/search_volume/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsSearchVolumeTaskGetResponseInfo> GoogleAdsSearchVolumeTaskGetAsync(string id)
        {
            return GoogleAdsSearchVolumeTaskGetAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/search_volume/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsSearchVolumeTaskGetResponseInfo> GoogleAdsSearchVolumeTaskGetAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
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
                    // Operation Path: "v3/keywords_data/google_ads/search_volume/task_get/{id}"
                    urlBuilder_.Append("v3/keywords_data/google_ads/search_volume/task_get/");
                    urlBuilder_.Append(System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsSearchVolumeTaskGetResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/search_volume/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsSearchVolumeLiveResponseInfo> GoogleAdsSearchVolumeLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataTaskRequestInfo> body)
        {
            return GoogleAdsSearchVolumeLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/search_volume/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsSearchVolumeLiveResponseInfo> GoogleAdsSearchVolumeLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_ads/search_volume/live"
                    urlBuilder_.Append("v3/keywords_data/google_ads/search_volume/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsSearchVolumeLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_site/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsKeywordsForSiteTaskPostResponseInfo> GoogleAdsKeywordsForSiteTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataGoogleAdsKeywordsForSiteTaskPostRequestInfo> body)
        {
            return GoogleAdsKeywordsForSiteTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_site/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsKeywordsForSiteTaskPostResponseInfo> GoogleAdsKeywordsForSiteTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataGoogleAdsKeywordsForSiteTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_ads/keywords_for_site/task_post"
                    urlBuilder_.Append("v3/keywords_data/google_ads/keywords_for_site/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsKeywordsForSiteTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_site/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResponseInfo> GoogleAdsKeywordsForSiteTasksReadyAsync()
        {
            return GoogleAdsKeywordsForSiteTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_site/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResponseInfo> GoogleAdsKeywordsForSiteTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_ads/keywords_for_site/tasks_ready"
                    urlBuilder_.Append("v3/keywords_data/google_ads/keywords_for_site/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsKeywordsForSiteTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
        /// <br/>‌‌
        /// <br/>This endpoint will provide you with a list of keywords relevant to the specified domain along with their bids, search volumes for the last month, search volume trends for the last year (for estimating search volume dynamics), and competition levels.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_site/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsKeywordsForSiteTaskGetResponseInfo> GoogleAdsKeywordsForSiteTaskGetAsync(string id)
        {
            return GoogleAdsKeywordsForSiteTaskGetAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
        /// <br/>‌‌
        /// <br/>This endpoint will provide you with a list of keywords relevant to the specified domain along with their bids, search volumes for the last month, search volume trends for the last year (for estimating search volume dynamics), and competition levels.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_site/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsKeywordsForSiteTaskGetResponseInfo> GoogleAdsKeywordsForSiteTaskGetAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
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
                    // Operation Path: "v3/keywords_data/google_ads/keywords_for_site/task_get/{id}"
                    urlBuilder_.Append("v3/keywords_data/google_ads/keywords_for_site/task_get/");
                    urlBuilder_.Append(System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsKeywordsForSiteTaskGetResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
        /// <br/>‌‌
        /// <br/>This endpoint will provide you with a list of keywords relevant to the specified domain along with their bids, search volumes for the last month, search volume trends for the last year (for estimating search volume dynamics), and competition levels.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_site/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsKeywordsForSiteLiveResponseInfo> GoogleAdsKeywordsForSiteLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataGoogleAdsKeywordsForSiteLiveRequestInfo> body)
        {
            return GoogleAdsKeywordsForSiteLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
        /// <br/>‌‌
        /// <br/>This endpoint will provide you with a list of keywords relevant to the specified domain along with their bids, search volumes for the last month, search volume trends for the last year (for estimating search volume dynamics), and competition levels.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_site/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsKeywordsForSiteLiveResponseInfo> GoogleAdsKeywordsForSiteLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataGoogleAdsKeywordsForSiteLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_ads/keywords_for_site/live"
                    urlBuilder_.Append("v3/keywords_data/google_ads/keywords_for_site/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsKeywordsForSiteLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
        /// <br/>‌‌
        /// <br/>This endpoint will provide relevant keywords for the specified terms. Set up to 20 keywords in the keywords array and get keyword suggestions from Google Ads.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_keywords/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostResponseInfo> GoogleAdsKeywordsForKeywordsTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostRequestInfo> body)
        {
            return GoogleAdsKeywordsForKeywordsTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
        /// <br/>‌‌
        /// <br/>This endpoint will provide relevant keywords for the specified terms. Set up to 20 keywords in the keywords array and get keyword suggestions from Google Ads.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_keywords/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostResponseInfo> GoogleAdsKeywordsForKeywordsTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_ads/keywords_for_keywords/task_post"
                    urlBuilder_.Append("v3/keywords_data/google_ads/keywords_for_keywords/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsKeywordsForKeywordsTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_keywords/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsKeywordsForKeywordsTasksReadyResponseInfo> GoogleAdsKeywordsForKeywordsTasksReadyAsync()
        {
            return GoogleAdsKeywordsForKeywordsTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_keywords/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsKeywordsForKeywordsTasksReadyResponseInfo> GoogleAdsKeywordsForKeywordsTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_ads/keywords_for_keywords/tasks_ready"
                    urlBuilder_.Append("v3/keywords_data/google_ads/keywords_for_keywords/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsKeywordsForKeywordsTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
        /// <br/>‌
        /// <br/>This endpoint will select relevant keywords for the specified terms. Set up to 20 keywords and get the results, which are suggested by Google Ads for your query.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_keywords/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResponseInfo> GoogleAdsKeywordsForKeywordsTaskGetAsync(string id)
        {
            return GoogleAdsKeywordsForKeywordsTaskGetAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
        /// <br/>‌
        /// <br/>This endpoint will select relevant keywords for the specified terms. Set up to 20 keywords and get the results, which are suggested by Google Ads for your query.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_keywords/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResponseInfo> GoogleAdsKeywordsForKeywordsTaskGetAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
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
                    // Operation Path: "v3/keywords_data/google_ads/keywords_for_keywords/task_get/{id}"
                    urlBuilder_.Append("v3/keywords_data/google_ads/keywords_for_keywords/task_get/");
                    urlBuilder_.Append(System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsKeywordsForKeywordsTaskGetResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
        /// <br/>‌‌
        /// <br/>This endpoint will provide relevant keywords for the specified terms. Set up to 20 keywords in the keywords array and get keyword suggestions from Google Ads.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsKeywordsForKeywordsLiveResponseInfo> GoogleAdsKeywordsForKeywordsLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataTaskRequestInfo> body)
        {
            return GoogleAdsKeywordsForKeywordsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Note that Google Ads Keywords Data API is based on the latest version of the Google Ads API that has replaced legacy Google AdWords API. If you’re using DataForSEO Google AdWords API, you need to upgrade to DataForSEO Google Ads API.
        /// <br/>‌‌
        /// <br/>This endpoint will provide relevant keywords for the specified terms. Set up to 20 keywords in the keywords array and get keyword suggestions from Google Ads.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/keywords_for_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsKeywordsForKeywordsLiveResponseInfo> GoogleAdsKeywordsForKeywordsLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_ads/keywords_for_keywords/live"
                    urlBuilder_.Append("v3/keywords_data/google_ads/keywords_for_keywords/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsKeywordsForKeywordsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/ad_traffic_by_keywords/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostResponseInfo> GoogleAdsAdTrafficByKeywordsTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo> body)
        {
            return GoogleAdsAdTrafficByKeywordsTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/ad_traffic_by_keywords/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostResponseInfo> GoogleAdsAdTrafficByKeywordsTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_ads/ad_traffic_by_keywords/task_post"
                    urlBuilder_.Append("v3/keywords_data/google_ads/ad_traffic_by_keywords/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/ad_traffic_by_keywords/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsAdTrafficByKeywordsTasksReadyResponseInfo> GoogleAdsAdTrafficByKeywordsTasksReadyAsync()
        {
            return GoogleAdsAdTrafficByKeywordsTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/ad_traffic_by_keywords/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsAdTrafficByKeywordsTasksReadyResponseInfo> GoogleAdsAdTrafficByKeywordsTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_ads/ad_traffic_by_keywords/tasks_ready"
                    urlBuilder_.Append("v3/keywords_data/google_ads/ad_traffic_by_keywords/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsAdTrafficByKeywordsTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/ad_traffic_by_keywords/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskGetResponseInfo> GoogleAdsAdTrafficByKeywordsTaskGetAsync(string id)
        {
            return GoogleAdsAdTrafficByKeywordsTaskGetAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/ad_traffic_by_keywords/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskGetResponseInfo> GoogleAdsAdTrafficByKeywordsTaskGetAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
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
                    // Operation Path: "v3/keywords_data/google_ads/ad_traffic_by_keywords/task_get/{id}"
                    urlBuilder_.Append("v3/keywords_data/google_ads/ad_traffic_by_keywords/task_get/");
                    urlBuilder_.Append(System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsAdTrafficByKeywordsTaskGetResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/ad_traffic_by_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResponseInfo> GoogleAdsAdTrafficByKeywordsLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataGoogleAdsAdTrafficByKeywordsLiveRequestInfo> body)
        {
            return GoogleAdsAdTrafficByKeywordsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_ads/ad_traffic_by_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResponseInfo> GoogleAdsAdTrafficByKeywordsLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataGoogleAdsAdTrafficByKeywordsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_ads/ad_traffic_by_keywords/live"
                    urlBuilder_.Append("v3/keywords_data/google_ads/ad_traffic_by_keywords/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleTrendsLocationsResponseInfo> KeywordsDataGoogleTrendsLocationsAsync()
        {
            return KeywordsDataGoogleTrendsLocationsAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleTrendsLocationsResponseInfo> KeywordsDataGoogleTrendsLocationsAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_trends/locations"
                    urlBuilder_.Append("v3/keywords_data/google_trends/locations");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleTrendsLocationsResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleTrendsLocationsCountryResponseInfo> KeywordsDataGoogleTrendsLocationsCountryAsync(string country)
        {
            return KeywordsDataGoogleTrendsLocationsCountryAsync(country, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleTrendsLocationsCountryResponseInfo> KeywordsDataGoogleTrendsLocationsCountryAsync(string country, System.Threading.CancellationToken cancellationToken)
        {
            if (country == null)
                throw new System.ArgumentNullException("country");
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
                    // Operation Path: "v3/keywords_data/google_trends/locations/{country}"
                    urlBuilder_.Append("v3/keywords_data/google_trends/locations/");
                    urlBuilder_.Append(System.Uri.EscapeDataString(ConvertToString(country, System.Globalization.CultureInfo.InvariantCulture)));
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleTrendsLocationsCountryResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// By calling this API you will receive the list of languages supported by Google Trends API.
        /// <br/>‌
        /// <br/>‌‌As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information about available languages.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleTrendsLanguagesResponseInfo> KeywordsDataGoogleTrendsLanguagesAsync()
        {
            return KeywordsDataGoogleTrendsLanguagesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// By calling this API you will receive the list of languages supported by Google Trends API.
        /// <br/>‌
        /// <br/>‌‌As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information about available languages.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleTrendsLanguagesResponseInfo> KeywordsDataGoogleTrendsLanguagesAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_trends/languages"
                    urlBuilder_.Append("v3/keywords_data/google_trends/languages");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleTrendsLanguagesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// By calling this API you will receive the list of categories supported by Google Trends API.
        /// <br/>‌
        /// <br/>‌‌As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information about available categories.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/categories/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleTrendsCategoriesResponseInfo> GoogleTrendsCategoriesAsync()
        {
            return GoogleTrendsCategoriesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// By calling this API you will receive the list of categories supported by Google Trends API.
        /// <br/>‌
        /// <br/>‌‌As a response of the API server, you will receive JSON-encoded data containing a tasks array with the information about available categories.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/categories/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleTrendsCategoriesResponseInfo> GoogleTrendsCategoriesAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_trends/categories"
                    urlBuilder_.Append("v3/keywords_data/google_trends/categories");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleTrendsCategoriesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with the keyword popularity data from the ‘Explore’ feature of Google Trends. You can check keyword trends for Google Search, Google News, Google Images, Google Shopping, and YouTube.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/explore/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleTrendsExploreTaskPostResponseInfo> GoogleTrendsExploreTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataGoogleTrendsExploreTaskPostRequestInfo> body)
        {
            return GoogleTrendsExploreTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with the keyword popularity data from the ‘Explore’ feature of Google Trends. You can check keyword trends for Google Search, Google News, Google Images, Google Shopping, and YouTube.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/explore/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleTrendsExploreTaskPostResponseInfo> GoogleTrendsExploreTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataGoogleTrendsExploreTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_trends/explore/task_post"
                    urlBuilder_.Append("v3/keywords_data/google_trends/explore/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleTrendsExploreTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/explore/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleTrendsExploreTasksReadyResponseInfo> GoogleTrendsExploreTasksReadyAsync()
        {
            return GoogleTrendsExploreTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint is designed to provide you with a list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/explore/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleTrendsExploreTasksReadyResponseInfo> GoogleTrendsExploreTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_trends/explore/tasks_ready"
                    urlBuilder_.Append("v3/keywords_data/google_trends/explore/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleTrendsExploreTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/explore/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleTrendsExploreTaskGetResponseInfo> GoogleTrendsExploreTaskGetAsync(string id)
        {
            return GoogleTrendsExploreTaskGetAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/explore/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleTrendsExploreTaskGetResponseInfo> GoogleTrendsExploreTaskGetAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
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
                    // Operation Path: "v3/keywords_data/google_trends/explore/task_get/{id}"
                    urlBuilder_.Append("v3/keywords_data/google_trends/explore/task_get/");
                    urlBuilder_.Append(System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleTrendsExploreTaskGetResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// This endpoint will provide you with the keyword popularity data from the ‘Explore’ feature of Google Trends. You can check keyword trends for Google Search, Google News, Google Images, Google Shopping, and YouTube.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/explore/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataGoogleTrendsExploreLiveResponseInfo> GoogleTrendsExploreLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataGoogleTrendsExploreLiveRequestInfo> body)
        {
            return GoogleTrendsExploreLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// This endpoint will provide you with the keyword popularity data from the ‘Explore’ feature of Google Trends. You can check keyword trends for Google Search, Google News, Google Images, Google Shopping, and YouTube.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/google_trends/explore/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataGoogleTrendsExploreLiveResponseInfo> GoogleTrendsExploreLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataGoogleTrendsExploreLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/google_trends/explore/live"
                    urlBuilder_.Append("v3/keywords_data/google_trends/explore/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataGoogleTrendsExploreLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of DataForSEO Trends locations by calling this API. You can filter the list of locations by country when setting a task. Please note that the minimum geographic scope supported for the DataForSEO Trends API is country level.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataDataforseoTrendsLocationsResponseInfo> KeywordsDataDataforseoTrendsLocationsAsync()
        {
            return KeywordsDataDataforseoTrendsLocationsAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of DataForSEO Trends locations by calling this API. You can filter the list of locations by country when setting a task. Please note that the minimum geographic scope supported for the DataForSEO Trends API is country level.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataDataforseoTrendsLocationsResponseInfo> KeywordsDataDataforseoTrendsLocationsAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/dataforseo_trends/locations"
                    urlBuilder_.Append("v3/keywords_data/dataforseo_trends/locations");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataDataforseoTrendsLocationsResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of DataForSEO Trends locations by calling this API. You can filter the list of locations by country when setting a task. Please note that the minimum geographic scope supported for the DataForSEO Trends API is country level.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataDataforseoTrendsLocationsCountryResponseInfo> KeywordsDataDataforseoTrendsLocationsCountryAsync(string country)
        {
            return KeywordsDataDataforseoTrendsLocationsCountryAsync(country, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of DataForSEO Trends locations by calling this API. You can filter the list of locations by country when setting a task. Please note that the minimum geographic scope supported for the DataForSEO Trends API is country level.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataDataforseoTrendsLocationsCountryResponseInfo> KeywordsDataDataforseoTrendsLocationsCountryAsync(string country, System.Threading.CancellationToken cancellationToken)
        {
            if (country == null)
                throw new System.ArgumentNullException("country");
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
                    // Operation Path: "v3/keywords_data/dataforseo_trends/locations/{country}"
                    urlBuilder_.Append("v3/keywords_data/dataforseo_trends/locations/");
                    urlBuilder_.Append(System.Uri.EscapeDataString(ConvertToString(country, System.Globalization.CultureInfo.InvariantCulture)));
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataDataforseoTrendsLocationsCountryResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// This endpoint will provide you with the keyword popularity data from DataForSEO Trends. You can check keyword trends for Google Search, Google News, and Google Shopping.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/explore/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataDataforseoTrendsExploreLiveResponseInfo> DataforseoTrendsExploreLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataDataforseoTrendsExploreLiveRequestInfo> body)
        {
            return DataforseoTrendsExploreLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// This endpoint will provide you with the keyword popularity data from DataForSEO Trends. You can check keyword trends for Google Search, Google News, and Google Shopping.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/explore/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataDataforseoTrendsExploreLiveResponseInfo> DataforseoTrendsExploreLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataDataforseoTrendsExploreLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/dataforseo_trends/explore/live"
                    urlBuilder_.Append("v3/keywords_data/dataforseo_trends/explore/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataDataforseoTrendsExploreLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// This endpoint will provide you with location-specific keyword popularity data from DataForSEO Trends. You can check keyword trends for Google Search, Google News, and Google Shopping.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/subregion_interests/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataDataforseoTrendsSubregionInterestsLiveResponseInfo> DataforseoTrendsSubregionInterestsLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataDataforseoTrendsSubregionInterestsLiveRequestInfo> body)
        {
            return DataforseoTrendsSubregionInterestsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// This endpoint will provide you with location-specific keyword popularity data from DataForSEO Trends. You can check keyword trends for Google Search, Google News, and Google Shopping.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/subregion_interests/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataDataforseoTrendsSubregionInterestsLiveResponseInfo> DataforseoTrendsSubregionInterestsLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataDataforseoTrendsSubregionInterestsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/dataforseo_trends/subregion_interests/live"
                    urlBuilder_.Append("v3/keywords_data/dataforseo_trends/subregion_interests/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataDataforseoTrendsSubregionInterestsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// This endpoint will provide you with the demographic breakdown (by age and gender) of keyword popularity per each specified term based on DataForSEO Trends data. You can check keyword trends for Google Search, Google News, and Google Shopping.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/demography/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataDataforseoTrendsDemographyLiveResponseInfo> DataforseoTrendsDemographyLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataDataforseoTrendsDemographyLiveRequestInfo> body)
        {
            return DataforseoTrendsDemographyLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// This endpoint will provide you with the demographic breakdown (by age and gender) of keyword popularity per each specified term based on DataForSEO Trends data. You can check keyword trends for Google Search, Google News, and Google Shopping.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/demography/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataDataforseoTrendsDemographyLiveResponseInfo> DataforseoTrendsDemographyLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataDataforseoTrendsDemographyLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/dataforseo_trends/demography/live"
                    urlBuilder_.Append("v3/keywords_data/dataforseo_trends/demography/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataDataforseoTrendsDemographyLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// This endpoint will provide you with the keyword popularity data from DataForSEO Trends. In addition to keyword popularity rate over the given time range, you will get location-specific keyword popularity data, and a demographic breakdown of keyword popularity per each specified term along with comparative values.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/merged_data/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataDataforseoTrendsMergedDataLiveResponseInfo> DataforseoTrendsMergedDataLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataDataforseoTrendsMergedDataLiveRequestInfo> body)
        {
            return DataforseoTrendsMergedDataLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// This endpoint will provide you with the keyword popularity data from DataForSEO Trends. In addition to keyword popularity rate over the given time range, you will get location-specific keyword popularity data, and a demographic breakdown of keyword popularity per each specified term along with comparative values.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/dataforseo_trends/merged_data/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataDataforseoTrendsMergedDataLiveResponseInfo> DataforseoTrendsMergedDataLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataDataforseoTrendsMergedDataLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/dataforseo_trends/merged_data/live"
                    urlBuilder_.Append("v3/keywords_data/dataforseo_trends/merged_data/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataDataforseoTrendsMergedDataLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// By calling this API you will receive the list of locations supported in Bing Ads API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingLocationsResponseInfo> KeywordsDataBingLocationsAsync()
        {
            return KeywordsDataBingLocationsAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// By calling this API you will receive the list of locations supported in Bing Ads API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingLocationsResponseInfo> KeywordsDataBingLocationsAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/locations"
                    urlBuilder_.Append("v3/keywords_data/bing/locations");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingLocationsResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// By calling this API you will receive the list of languages supported by Bing Ads API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingLanguagesResponseInfo> KeywordsDataBingLanguagesAsync()
        {
            return KeywordsDataBingLanguagesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// By calling this API you will receive the list of languages supported by Bing Ads API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingLanguagesResponseInfo> KeywordsDataBingLanguagesAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/languages"
                    urlBuilder_.Append("v3/keywords_data/bing/languages");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingLanguagesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with search volume data for the last month, search volume trend for up to 24 past months (that will let you estimate search volume dynamics), current cost-per-click and competition values for paid search.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeTaskPostResponseInfo> BingSearchVolumeTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingSearchVolumeTaskPostRequestInfo> body)
        {
            return BingSearchVolumeTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with search volume data for the last month, search volume trend for up to 24 past months (that will let you estimate search volume dynamics), current cost-per-click and competition values for paid search.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeTaskPostResponseInfo> BingSearchVolumeTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingSearchVolumeTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/search_volume/task_post"
                    urlBuilder_.Append("v3/keywords_data/bing/search_volume/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingSearchVolumeTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeTasksReadyResponseInfo> BingSearchVolumeTasksReadyAsync()
        {
            return BingSearchVolumeTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeTasksReadyResponseInfo> BingSearchVolumeTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/search_volume/tasks_ready"
                    urlBuilder_.Append("v3/keywords_data/bing/search_volume/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingSearchVolumeTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeTaskGetResponseInfo> BingSearchVolumeTaskGetAsync(string id)
        {
            return BingSearchVolumeTaskGetAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeTaskGetResponseInfo> BingSearchVolumeTaskGetAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
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
                    // Operation Path: "v3/keywords_data/bing/search_volume/task_get/{id}"
                    urlBuilder_.Append("v3/keywords_data/bing/search_volume/task_get/");
                    urlBuilder_.Append(System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingSearchVolumeTaskGetResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// ‌This endpoint will provide you with search volume data for the last month, search volume trend for up to 24 past months (that will let you estimate search volume dynamics), current cost-per-click and competition values for paid search.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeLiveResponseInfo> BingSearchVolumeLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingSearchVolumeLiveRequestInfo> body)
        {
            return BingSearchVolumeLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌This endpoint will provide you with search volume data for the last month, search volume trend for up to 24 past months (that will let you estimate search volume dynamics), current cost-per-click and competition values for paid search.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeLiveResponseInfo> BingSearchVolumeLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingSearchVolumeLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/search_volume/live"
                    urlBuilder_.Append("v3/keywords_data/bing/search_volume/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingSearchVolumeLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// ‌This endpoint will provide you with a list of keywords relevant to the specified website along with their search volume for the last month, search volume trend for up to 24 past months (for estimating search volume dynamics), current cost-per-click and competition level for paid search. The maximum number of returned keywords is 3000.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_site/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingKeywordsForSiteTaskPostResponseInfo> BingKeywordsForSiteTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingKeywordsForSiteTaskPostRequestInfo> body)
        {
            return BingKeywordsForSiteTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌This endpoint will provide you with a list of keywords relevant to the specified website along with their search volume for the last month, search volume trend for up to 24 past months (for estimating search volume dynamics), current cost-per-click and competition level for paid search. The maximum number of returned keywords is 3000.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_site/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingKeywordsForSiteTaskPostResponseInfo> BingKeywordsForSiteTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingKeywordsForSiteTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/keywords_for_site/task_post"
                    urlBuilder_.Append("v3/keywords_data/bing/keywords_for_site/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingKeywordsForSiteTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_site/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingKeywordsForSiteTasksReadyResponseInfo> BingKeywordsForSiteTasksReadyAsync()
        {
            return BingKeywordsForSiteTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_site/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingKeywordsForSiteTasksReadyResponseInfo> BingKeywordsForSiteTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/keywords_for_site/tasks_ready"
                    urlBuilder_.Append("v3/keywords_data/bing/keywords_for_site/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingKeywordsForSiteTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with a list of keywords relevant to the specified website along with their search volume for the last month, search volume trend for the last year (for estimating search volume dynamics), current cost-per-click and competition level for paid search. The maximum number of returned keywords is 3000.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_site/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingKeywordsForSiteTaskGetResponseInfo> BingKeywordsForSiteTaskGetAsync(string id)
        {
            return BingKeywordsForSiteTaskGetAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with a list of keywords relevant to the specified website along with their search volume for the last month, search volume trend for the last year (for estimating search volume dynamics), current cost-per-click and competition level for paid search. The maximum number of returned keywords is 3000.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_site/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingKeywordsForSiteTaskGetResponseInfo> BingKeywordsForSiteTaskGetAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
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
                    // Operation Path: "v3/keywords_data/bing/keywords_for_site/task_get/{id}"
                    urlBuilder_.Append("v3/keywords_data/bing/keywords_for_site/task_get/");
                    urlBuilder_.Append(System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingKeywordsForSiteTaskGetResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// ‌This endpoint will provide you with a list of keywords relevant to the specified URL along with their search volume for the last month, search volume trend for up to 24 past months (for estimating search volume dynamics), current cost-per-click and competition values for paid search. The maximum number of returned keywords is 3000.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_site/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingKeywordsForSiteLiveResponseInfo> BingKeywordsForSiteLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingKeywordsForSiteLiveRequestInfo> body)
        {
            return BingKeywordsForSiteLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌This endpoint will provide you with a list of keywords relevant to the specified URL along with their search volume for the last month, search volume trend for up to 24 past months (for estimating search volume dynamics), current cost-per-click and competition values for paid search. The maximum number of returned keywords is 3000.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_site/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingKeywordsForSiteLiveResponseInfo> BingKeywordsForSiteLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingKeywordsForSiteLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/keywords_for_site/live"
                    urlBuilder_.Append("v3/keywords_data/bing/keywords_for_site/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingKeywordsForSiteLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will select relevant keywords for the specified terms. Set up to 200 keywords and get the results, which are suggested by Bing Ads for your query. You can get up to 3000 keyword suggestions using this function.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_keywords/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingKeywordsForKeywordsTaskPostResponseInfo> BingKeywordsForKeywordsTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingKeywordsForKeywordsTaskPostRequestInfo> body)
        {
            return BingKeywordsForKeywordsTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>This endpoint will select relevant keywords for the specified terms. Set up to 200 keywords and get the results, which are suggested by Bing Ads for your query. You can get up to 3000 keyword suggestions using this function.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_keywords/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingKeywordsForKeywordsTaskPostResponseInfo> BingKeywordsForKeywordsTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingKeywordsForKeywordsTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/keywords_for_keywords/task_post"
                    urlBuilder_.Append("v3/keywords_data/bing/keywords_for_keywords/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingKeywordsForKeywordsTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_keywords/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingKeywordsForKeywordsTasksReadyResponseInfo> BingKeywordsForKeywordsTasksReadyAsync()
        {
            return BingKeywordsForKeywordsTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_keywords/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingKeywordsForKeywordsTasksReadyResponseInfo> BingKeywordsForKeywordsTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/keywords_for_keywords/tasks_ready"
                    urlBuilder_.Append("v3/keywords_data/bing/keywords_for_keywords/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingKeywordsForKeywordsTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will select relevant keywords for the specified terms. Set up to 200 keywords and get the results, which are suggested by Bing Ads for your query. You can get up to 3000 keyword suggestions using this function.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_keywords/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingKeywordsForKeywordsTaskGetResponseInfo> BingKeywordsForKeywordsTaskGetAsync(string id)
        {
            return BingKeywordsForKeywordsTaskGetAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will select relevant keywords for the specified terms. Set up to 200 keywords and get the results, which are suggested by Bing Ads for your query. You can get up to 3000 keyword suggestions using this function.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_keywords/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingKeywordsForKeywordsTaskGetResponseInfo> BingKeywordsForKeywordsTaskGetAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
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
                    // Operation Path: "v3/keywords_data/bing/keywords_for_keywords/task_get/{id}"
                    urlBuilder_.Append("v3/keywords_data/bing/keywords_for_keywords/task_get/");
                    urlBuilder_.Append(System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingKeywordsForKeywordsTaskGetResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will select the relevant keywords for the specified ones. Set up to 200 keywords and get the results, which are suggested by Bing Ads for your query. You can get up to 3000 keyword suggestions using this function.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingKeywordsForKeywordsLiveResponseInfo> BingKeywordsForKeywordsLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingKeywordsForKeywordsLiveRequestInfo> body)
        {
            return BingKeywordsForKeywordsLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will select the relevant keywords for the specified ones. Set up to 200 keywords and get the results, which are suggested by Bing Ads for your query. You can get up to 3000 keyword suggestions using this function.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keywords_for_keywords/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingKeywordsForKeywordsLiveResponseInfo> BingKeywordsForKeywordsLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingKeywordsForKeywordsLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/keywords_for_keywords/live"
                    urlBuilder_.Append("v3/keywords_data/bing/keywords_for_keywords/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingKeywordsForKeywordsLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Using this endpoint you can get the full list of locations and languages supported in Keyword Performance endpoints of Bing Keywords Data API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/locations_and_languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingKeywordPerformanceLocationsAndLanguagesResponseInfo> KeywordsDataBingKeywordPerformanceLocationsAndLanguagesAsync()
        {
            return KeywordsDataBingKeywordPerformanceLocationsAndLanguagesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Using this endpoint you can get the full list of locations and languages supported in Keyword Performance endpoints of Bing Keywords Data API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/locations_and_languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingKeywordPerformanceLocationsAndLanguagesResponseInfo> KeywordsDataBingKeywordPerformanceLocationsAndLanguagesAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/keyword_performance/locations_and_languages"
                    urlBuilder_.Append("v3/keywords_data/bing/keyword_performance/locations_and_languages");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingKeywordPerformanceLocationsAndLanguagesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>You can receive a set of keyword performance stats for a group of keywords depending on the specified match type, location and language parameters. Ad position, clicks, impressions, and other keyword metrics are aggregated for the last month for one or all of the following device types: mobile, desktop, tablet.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingKeywordPerformanceTaskPostResponseInfo> BingKeywordPerformanceTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingKeywordPerformanceTaskPostRequestInfo> body)
        {
            return BingKeywordPerformanceTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>You can receive a set of keyword performance stats for a group of keywords depending on the specified match type, location and language parameters. Ad position, clicks, impressions, and other keyword metrics are aggregated for the last month for one or all of the following device types: mobile, desktop, tablet.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingKeywordPerformanceTaskPostResponseInfo> BingKeywordPerformanceTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingKeywordPerformanceTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/keyword_performance/task_post"
                    urlBuilder_.Append("v3/keywords_data/bing/keyword_performance/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingKeywordPerformanceTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingKeywordPerformanceTasksReadyResponseInfo> BingKeywordPerformanceTasksReadyAsync()
        {
            return BingKeywordPerformanceTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingKeywordPerformanceTasksReadyResponseInfo> BingKeywordPerformanceTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/keyword_performance/tasks_ready"
                    urlBuilder_.Append("v3/keywords_data/bing/keyword_performance/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingKeywordPerformanceTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>You can receive a set of keyword performance stats for a group of keywords depending on the specified match type, location and language parameters. Ad position, clicks, impressions, and other keyword metrics are aggregated for the last month for one or all of the following device types: mobile, desktop, tablet.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingKeywordPerformanceTaskGetResponseInfo> BingKeywordPerformanceTaskGetAsync(string id)
        {
            return BingKeywordPerformanceTaskGetAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>You can receive a set of keyword performance stats for a group of keywords depending on the specified match type, location and language parameters. Ad position, clicks, impressions, and other keyword metrics are aggregated for the last month for one or all of the following device types: mobile, desktop, tablet.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingKeywordPerformanceTaskGetResponseInfo> BingKeywordPerformanceTaskGetAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
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
                    // Operation Path: "v3/keywords_data/bing/keyword_performance/task_get/{id}"
                    urlBuilder_.Append("v3/keywords_data/bing/keyword_performance/task_get/");
                    urlBuilder_.Append(System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingKeywordPerformanceTaskGetResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>You can receive a set of keyword performance stats for a group of keywords depending on the specified match type, location and language parameters. Ad position, clicks, impressions, and other keyword metrics are aggregated for the last month for one or all of the following device types: mobile, desktop, tablet.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingKeywordPerformanceLiveResponseInfo> BingKeywordPerformanceLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingKeywordPerformanceLiveRequestInfo> body)
        {
            return BingKeywordPerformanceLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>You can receive a set of keyword performance stats for a group of keywords depending on the specified match type, location and language parameters. Ad position, clicks, impressions, and other keyword metrics are aggregated for the last month for one or all of the following device types: mobile, desktop, tablet.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/keyword_performance/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingKeywordPerformanceLiveResponseInfo> BingKeywordPerformanceLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingKeywordPerformanceLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/keyword_performance/live"
                    urlBuilder_.Append("v3/keywords_data/bing/keyword_performance/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingKeywordPerformanceLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// By calling this API you will receive the list of locations and languages supported by Bing ‘Search Volume History’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/locations_and_languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesResponseInfo> KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesAsync()
        {
            return KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// By calling this API you will receive the list of locations and languages supported by Bing ‘Search Volume History’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/locations_and_languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesResponseInfo> KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/search_volume_history/locations_and_languages"
                    urlBuilder_.Append("v3/keywords_data/bing/search_volume_history/locations_and_languages");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingSearchVolumeHistoryLocationsAndLanguagesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with historical search volume data for up to 1000 keywords in one request. You can get search volume for keywords in monthly, weekly, or daily format and specify the device type.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeHistoryTaskPostResponseInfo> BingSearchVolumeHistoryTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingSearchVolumeHistoryTaskPostRequestInfo> body)
        {
            return BingSearchVolumeHistoryTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint will provide you with historical search volume data for up to 1000 keywords in one request. You can get search volume for keywords in monthly, weekly, or daily format and specify the device type.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeHistoryTaskPostResponseInfo> BingSearchVolumeHistoryTaskPostAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingSearchVolumeHistoryTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/search_volume_history/task_post"
                    urlBuilder_.Append("v3/keywords_data/bing/search_volume_history/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingSearchVolumeHistoryTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeHistoryTasksReadyResponseInfo> BingSearchVolumeHistoryTasksReadyAsync()
        {
            return BingSearchVolumeHistoryTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>This endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeHistoryTasksReadyResponseInfo> BingSearchVolumeHistoryTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/search_volume_history/tasks_ready"
                    urlBuilder_.Append("v3/keywords_data/bing/search_volume_history/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingSearchVolumeHistoryTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeHistoryTaskGetResponseInfo> BingSearchVolumeHistoryTaskGetAsync(string id)
        {
            return BingSearchVolumeHistoryTaskGetAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/task_get/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeHistoryTaskGetResponseInfo> BingSearchVolumeHistoryTaskGetAsync(string id, System.Threading.CancellationToken cancellationToken)
        {
            if (id == null)
                throw new System.ArgumentNullException("id");
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
                    // Operation Path: "v3/keywords_data/bing/search_volume_history/task_get/{id}"
                    urlBuilder_.Append("v3/keywords_data/bing/search_volume_history/task_get/");
                    urlBuilder_.Append(System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingSearchVolumeHistoryTaskGetResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// ‌This endpoint will provide you with historical search volume data for up to 1000 keywords in one request. You can get search volume for keywords in monthly, weekly, or daily format and specify the device type.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeHistoryLiveResponseInfo> BingSearchVolumeHistoryLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingSearchVolumeHistoryLiveRequestInfo> body)
        {
            return BingSearchVolumeHistoryLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌This endpoint will provide you with historical search volume data for up to 1000 keywords in one request. You can get search volume for keywords in monthly, weekly, or daily format and specify the device type.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/bing/search_volume_history/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataBingSearchVolumeHistoryLiveResponseInfo> BingSearchVolumeHistoryLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataBingSearchVolumeHistoryLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/bing/search_volume_history/live"
                    urlBuilder_.Append("v3/keywords_data/bing/search_volume_history/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataBingSearchVolumeHistoryLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Using this endpoint you can get the full list of locations and languages supported in DataForSEO Clickstream Data API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/clickstream_data/locations_and_languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataClickstreamDataLocationsAndLanguagesResponseInfo> KeywordsDataClickstreamDataLocationsAndLanguagesAsync()
        {
            return KeywordsDataClickstreamDataLocationsAndLanguagesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Using this endpoint you can get the full list of locations and languages supported in DataForSEO Clickstream Data API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/clickstream_data/locations_and_languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataClickstreamDataLocationsAndLanguagesResponseInfo> KeywordsDataClickstreamDataLocationsAndLanguagesAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/clickstream_data/locations_and_languages"
                    urlBuilder_.Append("v3/keywords_data/clickstream_data/locations_and_languages");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataClickstreamDataLocationsAndLanguagesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/clickstream_data/dataforseo_search_volume/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataClickstreamDataDataforseoSearchVolumeLiveResponseInfo> ClickstreamDataDataforseoSearchVolumeLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataClickstreamDataDataforseoSearchVolumeLiveRequestInfo> body)
        {
            return ClickstreamDataDataforseoSearchVolumeLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/clickstream_data/dataforseo_search_volume/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataClickstreamDataDataforseoSearchVolumeLiveResponseInfo> ClickstreamDataDataforseoSearchVolumeLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataClickstreamDataDataforseoSearchVolumeLiveRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/clickstream_data/dataforseo_search_volume/live"
                    urlBuilder_.Append("v3/keywords_data/clickstream_data/dataforseo_search_volume/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataClickstreamDataDataforseoSearchVolumeLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The Clickstream Global Search Volume endpoint of DataForSEO Keywords Data API is designed to provide clickstream-based search volume data for up to 1000 keywords in a single Live request. What’s more, it offers geographical distribution of clickstream search volume values across all available locations.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/clickstream_data/global_search_volume/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataClickstreamDataGlobalSearchVolumeLiveResponseInfo> ClickstreamDataGlobalSearchVolumeLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataTaskRequestInfo> body)
        {
            return ClickstreamDataGlobalSearchVolumeLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌ 
        /// <br/>The Clickstream Global Search Volume endpoint of DataForSEO Keywords Data API is designed to provide clickstream-based search volume data for up to 1000 keywords in a single Live request. What’s more, it offers geographical distribution of clickstream search volume values across all available locations.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/clickstream_data/global_search_volume/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataClickstreamDataGlobalSearchVolumeLiveResponseInfo> ClickstreamDataGlobalSearchVolumeLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/clickstream_data/global_search_volume/live"
                    urlBuilder_.Append("v3/keywords_data/clickstream_data/global_search_volume/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataClickstreamDataGlobalSearchVolumeLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The Bulk Clickstream Search Volume endpoint of DataForSEO Keywords Data API is designed to provide clickstream-based search volume data for up to 1000 keywords in a single Live request. What’s more, it offers historical search volume values for up to 12 months (depending on keywords, location, and language parameters).
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/clickstream_data/bulk_search_volume/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<KeywordsDataClickstreamDataBulkSearchVolumeLiveResponseInfo> ClickstreamDataBulkSearchVolumeLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataTaskRequestInfo> body)
        {
            return ClickstreamDataBulkSearchVolumeLiveAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌ 
        /// <br/>The Bulk Clickstream Search Volume endpoint of DataForSEO Keywords Data API is designed to provide clickstream-based search volume data for up to 1000 keywords in a single Live request. What’s more, it offers historical search volume values for up to 12 months (depending on keywords, location, and language parameters).
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/keywords_data/clickstream_data/bulk_search_volume/live/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<KeywordsDataClickstreamDataBulkSearchVolumeLiveResponseInfo> ClickstreamDataBulkSearchVolumeLiveAsync(System.Collections.Generic.IEnumerable<KeywordsDataTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/keywords_data/clickstream_data/bulk_search_volume/live"
                    urlBuilder_.Append("v3/keywords_data/clickstream_data/bulk_search_volume/live");
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
                            var objectResponse_ = await ReadObjectResponseAsync<KeywordsDataClickstreamDataBulkSearchVolumeLiveResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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