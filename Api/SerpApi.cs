using DataForSeo.Client.Models;
using DataForSeo.Client.Models.Requests;
using DataForSeo.Client.Models.Responses;

namespace DataForSeo.Client.Api
{
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.6.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SerpApi
    {
#pragma warning disable 8618
        private string _baseUrl;
#pragma warning restore 8618
        private System.Net.Http.HttpClient _httpClient;
        private static System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings, true);
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public SerpApi(System.Net.Http.HttpClient httpClient)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        {
            BaseUrl = "https://api.dataforseo.com";
            _httpClient = httpClient;
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
                return _settings.Value;
            }
        }

        static partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);
        /// <remarks>
        /// This endpoint is designed to provide you with the list of IDs and metadata of the completed SERP tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/id_list/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpIdListResponseInfo> SerpIdListAsync(System.Collections.Generic.IEnumerable<SerpIdListRequestInfo> body)
        {
            return SerpIdListAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// This endpoint is designed to provide you with the list of IDs and metadata of the completed SERP tasks during the specified period. You will get all task IDs that were made including successful, uncompleted, and tasks that responded as errors.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/id_list/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpIdListResponseInfo> SerpIdListAsync(System.Collections.Generic.IEnumerable<SerpIdListRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/id_list"
                    urlBuilder_.Append("v3/serp/id_list");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpIdListResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// By calling this endpoint you will receive information about the SERP API tasks that returned an error within the past 24 hours.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/errors/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpErrorsResponseInfo> SerpErrorsAsync(System.Collections.Generic.IEnumerable<SerpErrorsRequestInfo> body)
        {
            return SerpErrorsAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// By calling this endpoint you will receive information about the SERP API tasks that returned an error within the past 24 hours.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/errors/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpErrorsResponseInfo> SerpErrorsAsync(System.Collections.Generic.IEnumerable<SerpErrorsRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/errors"
                    urlBuilder_.Append("v3/serp/errors");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpErrorsResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Using the Live Page Screenshot endpoint, you can capture a screenshot of any SERP page.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/screenshot/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpScreenshotResponseInfo> ScreenshotAsync(System.Collections.Generic.IEnumerable<SerpScreenshotRequestInfo> body)
        {
            return ScreenshotAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Using the Live Page Screenshot endpoint, you can capture a screenshot of any SERP page.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/screenshot/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpScreenshotResponseInfo> ScreenshotAsync(System.Collections.Generic.IEnumerable<SerpScreenshotRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/screenshot"
                    urlBuilder_.Append("v3/serp/screenshot");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpScreenshotResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The purpose of the Live SERP API AI Summary endpoint is to provide a summary of the content found on any SERP and generate a response based on the user’s specified prompt.
        /// <br/>To obtain results, you have to specify task_id, which you can find in the response to the POST request.
        /// <br/>Learn more in our Help Center.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/ai_summary/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpAiSummaryResponseInfo> AiSummaryAsync(System.Collections.Generic.IEnumerable<SerpAiSummaryRequestInfo> body)
        {
            return AiSummaryAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>The purpose of the Live SERP API AI Summary endpoint is to provide a summary of the content found on any SERP and generate a response based on the user’s specified prompt.
        /// <br/>To obtain results, you have to specify task_id, which you can find in the response to the POST request.
        /// <br/>Learn more in our Help Center.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/ai_summary/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpAiSummaryResponseInfo> AiSummaryAsync(System.Collections.Generic.IEnumerable<SerpAiSummaryRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/ai_summary"
                    urlBuilder_.Append("v3/serp/ai_summary");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpAiSummaryResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleLocationsResponseInfo> SerpGoogleLocationsAsync()
        {
            return SerpGoogleLocationsAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleLocationsResponseInfo> SerpGoogleLocationsAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/locations"
                    urlBuilder_.Append("v3/serp/google/locations");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleLocationsResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleLocationsCountryResponseInfo> SerpGoogleLocationsCountryAsync(string country)
        {
            return SerpGoogleLocationsCountryAsync(country, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleLocationsCountryResponseInfo> SerpGoogleLocationsCountryAsync(string country, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/locations/{country}"
                    urlBuilder_.Append("v3/serp/google/locations/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleLocationsCountryResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of languages by calling this API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleLanguagesResponseInfo> SerpGoogleLanguagesAsync()
        {
            return SerpGoogleLanguagesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of languages by calling this API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleLanguagesResponseInfo> SerpGoogleLanguagesAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/languages"
                    urlBuilder_.Append("v3/serp/google/languages");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleLanguagesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleOrganicTaskPostResponseInfo> GoogleOrganicTaskPostAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return GoogleOrganicTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleOrganicTaskPostResponseInfo> GoogleOrganicTaskPostAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/organic/task_post"
                    urlBuilder_.Append("v3/serp/google/organic/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleOrganicTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleOrganicTasksReadyResponseInfo> GoogleOrganicTasksReadyAsync()
        {
            return GoogleOrganicTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleOrganicTasksReadyResponseInfo> GoogleOrganicTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/organic/tasks_ready"
                    urlBuilder_.Append("v3/serp/google/organic/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleOrganicTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpTasksReadyResponseInfo> TasksReadyAsync()
        {
            return TasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpTasksReadyResponseInfo> TasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/tasks_ready"
                    urlBuilder_.Append("v3/serp/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleOrganicTasksFixedResponseInfo> GoogleOrganicTasksFixedAsync()
        {
            return GoogleOrganicTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleOrganicTasksFixedResponseInfo> GoogleOrganicTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/organic/tasks_fixed"
                    urlBuilder_.Append("v3/serp/google/organic/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleOrganicTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/regular/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleOrganicTaskGetRegularResponseInfo> GoogleOrganicTaskGetRegularAsync(string id)
        {
            return GoogleOrganicTaskGetRegularAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/regular/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleOrganicTaskGetRegularResponseInfo> GoogleOrganicTaskGetRegularAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/organic/task_get/regular/{id}"
                    urlBuilder_.Append("v3/serp/google/organic/task_get/regular/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleOrganicTaskGetRegularResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleOrganicTaskGetAdvancedResponseInfo> GoogleOrganicTaskGetAdvancedAsync(string id)
        {
            return GoogleOrganicTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleOrganicTaskGetAdvancedResponseInfo> GoogleOrganicTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/organic/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/google/organic/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleOrganicTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleOrganicTaskGetHtmlResponseInfo> GoogleOrganicTaskGetHtmlAsync(string id)
        {
            return GoogleOrganicTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleOrganicTaskGetHtmlResponseInfo> GoogleOrganicTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/organic/task_get/html/{id}"
                    urlBuilder_.Append("v3/serp/google/organic/task_get/html/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleOrganicTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/regular/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleOrganicLiveRegularResponseInfo> GoogleOrganicLiveRegularAsync(System.Collections.Generic.IEnumerable<SerpGoogleOrganicLiveRegularRequestInfo> body)
        {
            return GoogleOrganicLiveRegularAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/regular/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleOrganicLiveRegularResponseInfo> GoogleOrganicLiveRegularAsync(System.Collections.Generic.IEnumerable<SerpGoogleOrganicLiveRegularRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/organic/live/regular"
                    urlBuilder_.Append("v3/serp/google/organic/live/regular");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleOrganicLiveRegularResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location. This endpoint will supply a complete overview of featured snippets and other extra elements of SERPs.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleOrganicLiveAdvancedResponseInfo> GoogleOrganicLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpGoogleOrganicLiveAdvancedRequestInfo> body)
        {
            return GoogleOrganicLiveAdvancedAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location. This endpoint will supply a complete overview of featured snippets and other extra elements of SERPs.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleOrganicLiveAdvancedResponseInfo> GoogleOrganicLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpGoogleOrganicLiveAdvancedRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/organic/live/advanced"
                    urlBuilder_.Append("v3/serp/google/organic/live/advanced");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleOrganicLiveAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/html/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleOrganicLiveHtmlResponseInfo> GoogleOrganicLiveHtmlAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return GoogleOrganicLiveHtmlAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/organic/live/html/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleOrganicLiveHtmlResponseInfo> GoogleOrganicLiveHtmlAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/organic/live/html"
                    urlBuilder_.Append("v3/serp/google/organic/live/html");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleOrganicLiveHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleMapsTaskPostResponseInfo> GoogleMapsTaskPostAsync(System.Collections.Generic.IEnumerable<SerpGoogleMapsTaskPostRequestInfo> body)
        {
            return GoogleMapsTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleMapsTaskPostResponseInfo> GoogleMapsTaskPostAsync(System.Collections.Generic.IEnumerable<SerpGoogleMapsTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/maps/task_post"
                    urlBuilder_.Append("v3/serp/google/maps/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleMapsTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleMapsTasksReadyResponseInfo> GoogleMapsTasksReadyAsync()
        {
            return GoogleMapsTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleMapsTasksReadyResponseInfo> GoogleMapsTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/maps/tasks_ready"
                    urlBuilder_.Append("v3/serp/google/maps/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleMapsTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleMapsTasksFixedResponseInfo> GoogleMapsTasksFixedAsync()
        {
            return GoogleMapsTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleMapsTasksFixedResponseInfo> GoogleMapsTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/maps/tasks_fixed"
                    urlBuilder_.Append("v3/serp/google/maps/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleMapsTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>a universally unique identifier (UUID)
        /// <br/>unique task identifier in our system
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleMapsTaskGetAdvancedResponseInfo> GoogleMapsTaskGetAdvancedAsync(string id)
        {
            return GoogleMapsTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>a universally unique identifier (UUID)
        /// <br/>unique task identifier in our system
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleMapsTaskGetAdvancedResponseInfo> GoogleMapsTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/maps/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/google/maps/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleMapsTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live Google Maps SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleMapsLiveAdvancedResponseInfo> GoogleMapsLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpGoogleMapsLiveAdvancedRequestInfo> body)
        {
            return GoogleMapsLiveAdvancedAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Live Google Maps SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/maps/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleMapsLiveAdvancedResponseInfo> GoogleMapsLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpGoogleMapsLiveAdvancedRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/maps/live/advanced"
                    urlBuilder_.Append("v3/serp/google/maps/live/advanced");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleMapsLiveAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Google Local Finder SERP API provides top search engine results specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleLocalFinderTaskPostResponseInfo> GoogleLocalFinderTaskPostAsync(System.Collections.Generic.IEnumerable<SerpGoogleLocalFinderTaskPostRequestInfo> body)
        {
            return GoogleLocalFinderTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Google Local Finder SERP API provides top search engine results specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleLocalFinderTaskPostResponseInfo> GoogleLocalFinderTaskPostAsync(System.Collections.Generic.IEnumerable<SerpGoogleLocalFinderTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/local_finder/task_post"
                    urlBuilder_.Append("v3/serp/google/local_finder/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleLocalFinderTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleLocalFinderTasksReadyResponseInfo> GoogleLocalFinderTasksReadyAsync()
        {
            return GoogleLocalFinderTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleLocalFinderTasksReadyResponseInfo> GoogleLocalFinderTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/local_finder/tasks_ready"
                    urlBuilder_.Append("v3/serp/google/local_finder/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleLocalFinderTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleLocalFinderTasksFixedResponseInfo> GoogleLocalFinderTasksFixedAsync()
        {
            return GoogleLocalFinderTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleLocalFinderTasksFixedResponseInfo> GoogleLocalFinderTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/local_finder/tasks_fixed"
                    urlBuilder_.Append("v3/serp/google/local_finder/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleLocalFinderTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>a universally unique identifier (UUID)
        /// <br/>unique task identifier in our system
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleLocalFinderTaskGetAdvancedResponseInfo> GoogleLocalFinderTaskGetAdvancedAsync(string id)
        {
            return GoogleLocalFinderTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>a universally unique identifier (UUID)
        /// <br/>unique task identifier in our system
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleLocalFinderTaskGetAdvancedResponseInfo> GoogleLocalFinderTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/local_finder/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/google/local_finder/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleLocalFinderTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleLocalFinderTaskGetHtmlResponseInfo> GoogleLocalFinderTaskGetHtmlAsync(string id)
        {
            return GoogleLocalFinderTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleLocalFinderTaskGetHtmlResponseInfo> GoogleLocalFinderTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/local_finder/task_get/html/{id}"
                    urlBuilder_.Append("v3/serp/google/local_finder/task_get/html/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleLocalFinderTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live Google Local finder SERP provides real-time search engine results for the specified keyword and location. By default, you can get up to 20 results for desktop and up to 10 results for mobile.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleLocalFinderLiveAdvancedResponseInfo> GoogleLocalFinderLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpGoogleLocalFinderLiveAdvancedRequestInfo> body)
        {
            return GoogleLocalFinderLiveAdvancedAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Live Google Local finder SERP provides real-time search engine results for the specified keyword and location. By default, you can get up to 20 results for desktop and up to 10 results for mobile.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleLocalFinderLiveAdvancedResponseInfo> GoogleLocalFinderLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpGoogleLocalFinderLiveAdvancedRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/local_finder/live/advanced"
                    urlBuilder_.Append("v3/serp/google/local_finder/live/advanced");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleLocalFinderLiveAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live Google Local Finder SERP HTML provides a raw HTML page of the search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/live/html/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleLocalFinderLiveHtmlResponseInfo> GoogleLocalFinderLiveHtmlAsync(System.Collections.Generic.IEnumerable<SerpGoogleLocalFinderLiveHtmlRequestInfo> body)
        {
            return GoogleLocalFinderLiveHtmlAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Live Google Local Finder SERP HTML provides a raw HTML page of the search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/local_finder/live/html/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleLocalFinderLiveHtmlResponseInfo> GoogleLocalFinderLiveHtmlAsync(System.Collections.Generic.IEnumerable<SerpGoogleLocalFinderLiveHtmlRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/local_finder/live/html"
                    urlBuilder_.Append("v3/serp/google/local_finder/live/html");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleLocalFinderLiveHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleNewsTaskPostResponseInfo> GoogleNewsTaskPostAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return GoogleNewsTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleNewsTaskPostResponseInfo> GoogleNewsTaskPostAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/news/task_post"
                    urlBuilder_.Append("v3/serp/google/news/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleNewsTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleNewsTasksReadyResponseInfo> GoogleNewsTasksReadyAsync()
        {
            return GoogleNewsTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleNewsTasksReadyResponseInfo> GoogleNewsTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/news/tasks_ready"
                    urlBuilder_.Append("v3/serp/google/news/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleNewsTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleNewsTasksFixedResponseInfo> GoogleNewsTasksFixedAsync()
        {
            return GoogleNewsTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleNewsTasksFixedResponseInfo> GoogleNewsTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/news/tasks_fixed"
                    urlBuilder_.Append("v3/serp/google/news/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleNewsTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleNewsTaskGetAdvancedResponseInfo> GoogleNewsTaskGetAdvancedAsync(string id)
        {
            return GoogleNewsTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleNewsTaskGetAdvancedResponseInfo> GoogleNewsTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/news/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/google/news/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleNewsTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleNewsTaskGetHtmlResponseInfo> GoogleNewsTaskGetHtmlAsync(string id)
        {
            return GoogleNewsTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleNewsTaskGetHtmlResponseInfo> GoogleNewsTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/news/task_get/html/{id}"
                    urlBuilder_.Append("v3/serp/google/news/task_get/html/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleNewsTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live Google News SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleNewsLiveAdvancedResponseInfo> GoogleNewsLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return GoogleNewsLiveAdvancedAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Live Google News SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleNewsLiveAdvancedResponseInfo> GoogleNewsLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/news/live/advanced"
                    urlBuilder_.Append("v3/serp/google/news/live/advanced");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleNewsLiveAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/live/html/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleNewsLiveHtmlResponseInfo> GoogleNewsLiveHtmlAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return GoogleNewsLiveHtmlAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/news/live/html/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleNewsLiveHtmlResponseInfo> GoogleNewsLiveHtmlAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/news/live/html"
                    urlBuilder_.Append("v3/serp/google/news/live/html");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleNewsLiveHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Google Events SERP provides data from Google Events Search for the specified keyword and location (see the List of Locations). Note that Google Events SERP API works for the English language only.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleEventsTaskPostResponseInfo> GoogleEventsTaskPostAsync(System.Collections.Generic.IEnumerable<SerpGoogleEventsTaskPostRequestInfo> body)
        {
            return GoogleEventsTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Google Events SERP provides data from Google Events Search for the specified keyword and location (see the List of Locations). Note that Google Events SERP API works for the English language only.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleEventsTaskPostResponseInfo> GoogleEventsTaskPostAsync(System.Collections.Generic.IEnumerable<SerpGoogleEventsTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/events/task_post"
                    urlBuilder_.Append("v3/serp/google/events/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleEventsTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleEventsTasksReadyResponseInfo> GoogleEventsTasksReadyAsync()
        {
            return GoogleEventsTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleEventsTasksReadyResponseInfo> GoogleEventsTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/events/tasks_ready"
                    urlBuilder_.Append("v3/serp/google/events/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleEventsTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleEventsTasksFixedResponseInfo> GoogleEventsTasksFixedAsync()
        {
            return GoogleEventsTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleEventsTasksFixedResponseInfo> GoogleEventsTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/events/tasks_fixed"
                    urlBuilder_.Append("v3/serp/google/events/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleEventsTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleEventsTaskGetAdvancedResponseInfo> GoogleEventsTaskGetAdvancedAsync(string id)
        {
            return GoogleEventsTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleEventsTaskGetAdvancedResponseInfo> GoogleEventsTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/events/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/google/events/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleEventsTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live Google Events SERP provides real-time data from Google Events Search for the specified keyword and location. Note that Google Events SERP API works for the English language only.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleEventsLiveAdvancedResponseInfo> GoogleEventsLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpGoogleEventsLiveAdvancedRequestInfo> body)
        {
            return GoogleEventsLiveAdvancedAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Live Google Events SERP provides real-time data from Google Events Search for the specified keyword and location. Note that Google Events SERP API works for the English language only.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/events/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleEventsLiveAdvancedResponseInfo> GoogleEventsLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpGoogleEventsLiveAdvancedRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/events/live/advanced"
                    urlBuilder_.Append("v3/serp/google/events/live/advanced");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleEventsLiveAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleImagesTaskPostResponseInfo> GoogleImagesTaskPostAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return GoogleImagesTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleImagesTaskPostResponseInfo> GoogleImagesTaskPostAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/images/task_post"
                    urlBuilder_.Append("v3/serp/google/images/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleImagesTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleImagesTasksReadyResponseInfo> GoogleImagesTasksReadyAsync()
        {
            return GoogleImagesTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleImagesTasksReadyResponseInfo> GoogleImagesTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/images/tasks_ready"
                    urlBuilder_.Append("v3/serp/google/images/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleImagesTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleImagesTasksFixedResponseInfo> GoogleImagesTasksFixedAsync()
        {
            return GoogleImagesTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleImagesTasksFixedResponseInfo> GoogleImagesTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/images/tasks_fixed"
                    urlBuilder_.Append("v3/serp/google/images/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleImagesTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleImagesTaskGetAdvancedResponseInfo> GoogleImagesTaskGetAdvancedAsync(string id)
        {
            return GoogleImagesTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleImagesTaskGetAdvancedResponseInfo> GoogleImagesTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/images/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/google/images/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleImagesTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleImagesTaskGetHtmlResponseInfo> GoogleImagesTaskGetHtmlAsync(string id)
        {
            return GoogleImagesTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleImagesTaskGetHtmlResponseInfo> GoogleImagesTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/images/task_get/html/{id}"
                    urlBuilder_.Append("v3/serp/google/images/task_get/html/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleImagesTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live Google Images SERP provides real-time data on top 100 images results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleImagesLiveAdvancedResponseInfo> GoogleImagesLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return GoogleImagesLiveAdvancedAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Live Google Images SERP provides real-time data on top 100 images results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleImagesLiveAdvancedResponseInfo> GoogleImagesLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/images/live/advanced"
                    urlBuilder_.Append("v3/serp/google/images/live/advanced");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleImagesLiveAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/live/html/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleImagesLiveHtmlResponseInfo> GoogleImagesLiveHtmlAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return GoogleImagesLiveHtmlAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/images/live/html/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleImagesLiveHtmlResponseInfo> GoogleImagesLiveHtmlAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/images/live/html"
                    urlBuilder_.Append("v3/serp/google/images/live/html");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleImagesLiveHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Google Search By Image SERP API provides up to top 100 search engine results based on the image you specified. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleSearchByImageTaskPostResponseInfo> GoogleSearchByImageTaskPostAsync(System.Collections.Generic.IEnumerable<SerpGoogleSearchByImageTaskPostRequestInfo> body)
        {
            return GoogleSearchByImageTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Google Search By Image SERP API provides up to top 100 search engine results based on the image you specified. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleSearchByImageTaskPostResponseInfo> GoogleSearchByImageTaskPostAsync(System.Collections.Generic.IEnumerable<SerpGoogleSearchByImageTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/search_by_image/task_post"
                    urlBuilder_.Append("v3/serp/google/search_by_image/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleSearchByImageTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleSearchByImageTasksReadyResponseInfo> GoogleSearchByImageTasksReadyAsync()
        {
            return GoogleSearchByImageTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleSearchByImageTasksReadyResponseInfo> GoogleSearchByImageTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/search_by_image/tasks_ready"
                    urlBuilder_.Append("v3/serp/google/search_by_image/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleSearchByImageTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleSearchByImageTasksFixedResponseInfo> GoogleSearchByImageTasksFixedAsync()
        {
            return GoogleSearchByImageTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleSearchByImageTasksFixedResponseInfo> GoogleSearchByImageTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/search_by_image/tasks_fixed"
                    urlBuilder_.Append("v3/serp/google/search_by_image/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleSearchByImageTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleSearchByImageTaskGetAdvancedResponseInfo> GoogleSearchByImageTaskGetAdvancedAsync(string id)
        {
            return GoogleSearchByImageTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/search_by_image/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleSearchByImageTaskGetAdvancedResponseInfo> GoogleSearchByImageTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/search_by_image/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/google/search_by_image/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleSearchByImageTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>This endpoint will provide you with SERP data from the Google Jobs search engine. The returned results are specific to the keyword as well as the language and location parameters of the POST request.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleJobsTaskPostResponseInfo> GoogleJobsTaskPostAsync(System.Collections.Generic.IEnumerable<SerpGoogleJobsTaskPostRequestInfo> body)
        {
            return GoogleJobsTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>This endpoint will provide you with SERP data from the Google Jobs search engine. The returned results are specific to the keyword as well as the language and location parameters of the POST request.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleJobsTaskPostResponseInfo> GoogleJobsTaskPostAsync(System.Collections.Generic.IEnumerable<SerpGoogleJobsTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/jobs/task_post"
                    urlBuilder_.Append("v3/serp/google/jobs/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleJobsTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleJobsTasksReadyResponseInfo> GoogleJobsTasksReadyAsync()
        {
            return GoogleJobsTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleJobsTasksReadyResponseInfo> GoogleJobsTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/jobs/tasks_ready"
                    urlBuilder_.Append("v3/serp/google/jobs/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleJobsTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleJobsTasksFixedResponseInfo> GoogleJobsTasksFixedAsync()
        {
            return GoogleJobsTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleJobsTasksFixedResponseInfo> GoogleJobsTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/jobs/tasks_fixed"
                    urlBuilder_.Append("v3/serp/google/jobs/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleJobsTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleJobsTaskGetAdvancedResponseInfo> GoogleJobsTaskGetAdvancedAsync(string id)
        {
            return GoogleJobsTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleJobsTaskGetAdvancedResponseInfo> GoogleJobsTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/jobs/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/google/jobs/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleJobsTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleJobsTaskGetHtmlResponseInfo> GoogleJobsTaskGetHtmlAsync(string id)
        {
            return GoogleJobsTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/jobs/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleJobsTaskGetHtmlResponseInfo> GoogleJobsTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/jobs/task_get/html/{id}"
                    urlBuilder_.Append("v3/serp/google/jobs/task_get/html/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleJobsTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Google Autocomplete is a feature within Google Search that improves the search experience by allowing users to complete searches they started to type. DataForSEO SERP API will provide you with all the suggestions Google Autocomplete offers for a particular keyword, the position of the cursor pointer, and the search client.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleAutocompleteTaskPostResponseInfo> GoogleAutocompleteTaskPostAsync(System.Collections.Generic.IEnumerable<SerpGoogleAutocompleteTaskPostRequestInfo> body)
        {
            return GoogleAutocompleteTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Google Autocomplete is a feature within Google Search that improves the search experience by allowing users to complete searches they started to type. DataForSEO SERP API will provide you with all the suggestions Google Autocomplete offers for a particular keyword, the position of the cursor pointer, and the search client.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleAutocompleteTaskPostResponseInfo> GoogleAutocompleteTaskPostAsync(System.Collections.Generic.IEnumerable<SerpGoogleAutocompleteTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/autocomplete/task_post"
                    urlBuilder_.Append("v3/serp/google/autocomplete/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleAutocompleteTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleAutocompleteTasksReadyResponseInfo> GoogleAutocompleteTasksReadyAsync()
        {
            return GoogleAutocompleteTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleAutocompleteTasksReadyResponseInfo> GoogleAutocompleteTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/autocomplete/tasks_ready"
                    urlBuilder_.Append("v3/serp/google/autocomplete/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleAutocompleteTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleAutocompleteTasksFixedResponseInfo> GoogleAutocompleteTasksFixedAsync()
        {
            return GoogleAutocompleteTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleAutocompleteTasksFixedResponseInfo> GoogleAutocompleteTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/autocomplete/tasks_fixed"
                    urlBuilder_.Append("v3/serp/google/autocomplete/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleAutocompleteTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleAutocompleteTaskGetAdvancedResponseInfo> GoogleAutocompleteTaskGetAdvancedAsync(string id)
        {
            return GoogleAutocompleteTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleAutocompleteTaskGetAdvancedResponseInfo> GoogleAutocompleteTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/autocomplete/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/google/autocomplete/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleAutocompleteTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Google Autocomplete is a feature within Google Search that improves the search experience by allowing users to complete searches they started to type. DataForSEO SERP API will provide you with all the suggestions Google Autocomplete offers for a particular keyword, the position of the cursor pointer, and the search client.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleAutocompleteLiveAdvancedResponseInfo> GoogleAutocompleteLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpGoogleAutocompleteLiveAdvancedRequestInfo> body)
        {
            return GoogleAutocompleteLiveAdvancedAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Google Autocomplete is a feature within Google Search that improves the search experience by allowing users to complete searches they started to type. DataForSEO SERP API will provide you with all the suggestions Google Autocomplete offers for a particular keyword, the position of the cursor pointer, and the search client.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/autocomplete/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleAutocompleteLiveAdvancedResponseInfo> GoogleAutocompleteLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpGoogleAutocompleteLiveAdvancedRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/autocomplete/live/advanced"
                    urlBuilder_.Append("v3/serp/google/autocomplete/live/advanced");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleAutocompleteLiveAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Google Dataset Search API provides top 20 Google Dataset search engine results. These results are specific to the indicated keyword. You can specify other parameters optionally.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleDatasetSearchTaskPostResponseInfo> GoogleDatasetSearchTaskPostAsync(System.Collections.Generic.IEnumerable<SerpGoogleDatasetSearchTaskPostRequestInfo> body)
        {
            return GoogleDatasetSearchTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Google Dataset Search API provides top 20 Google Dataset search engine results. These results are specific to the indicated keyword. You can specify other parameters optionally.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleDatasetSearchTaskPostResponseInfo> GoogleDatasetSearchTaskPostAsync(System.Collections.Generic.IEnumerable<SerpGoogleDatasetSearchTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/dataset_search/task_post"
                    urlBuilder_.Append("v3/serp/google/dataset_search/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleDatasetSearchTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleDatasetSearchTasksReadyResponseInfo> GoogleDatasetSearchTasksReadyAsync()
        {
            return GoogleDatasetSearchTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleDatasetSearchTasksReadyResponseInfo> GoogleDatasetSearchTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/dataset_search/tasks_ready"
                    urlBuilder_.Append("v3/serp/google/dataset_search/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleDatasetSearchTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleDatasetSearchTasksFixedResponseInfo> GoogleDatasetSearchTasksFixedAsync()
        {
            return GoogleDatasetSearchTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleDatasetSearchTasksFixedResponseInfo> GoogleDatasetSearchTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/dataset_search/tasks_fixed"
                    urlBuilder_.Append("v3/serp/google/dataset_search/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleDatasetSearchTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo> GoogleDatasetSearchTaskGetAdvancedAsync(string id)
        {
            return GoogleDatasetSearchTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo> GoogleDatasetSearchTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/dataset_search/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/google/dataset_search/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live Google Dataset Search provides real-time data on the top 20 Google Dataset search engine results. These results are specific to the indicated keyword. You can specify other parameters optionally.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleDatasetSearchLiveAdvancedResponseInfo> GoogleDatasetSearchLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpGoogleDatasetSearchLiveAdvancedRequestInfo> body)
        {
            return GoogleDatasetSearchLiveAdvancedAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Live Google Dataset Search provides real-time data on the top 20 Google Dataset search engine results. These results are specific to the indicated keyword. You can specify other parameters optionally.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_search/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleDatasetSearchLiveAdvancedResponseInfo> GoogleDatasetSearchLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpGoogleDatasetSearchLiveAdvancedRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/dataset_search/live/advanced"
                    urlBuilder_.Append("v3/serp/google/dataset_search/live/advanced");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleDatasetSearchLiveAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Google Dataset Info API provides detailed information about the dataset you specify in the POST request. You will get data from a page of the dataset displayed separately from the SERP. It contains information about dataset content, authors, licenses, and description on the SERP.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleDatasetInfoTaskPostResponseInfo> GoogleDatasetInfoTaskPostAsync(System.Collections.Generic.IEnumerable<SerpGoogleDatasetInfoTaskPostRequestInfo> body)
        {
            return GoogleDatasetInfoTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Google Dataset Info API provides detailed information about the dataset you specify in the POST request. You will get data from a page of the dataset displayed separately from the SERP. It contains information about dataset content, authors, licenses, and description on the SERP.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleDatasetInfoTaskPostResponseInfo> GoogleDatasetInfoTaskPostAsync(System.Collections.Generic.IEnumerable<SerpGoogleDatasetInfoTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/dataset_info/task_post"
                    urlBuilder_.Append("v3/serp/google/dataset_info/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleDatasetInfoTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleDatasetInfoTasksReadyResponseInfo> GoogleDatasetInfoTasksReadyAsync()
        {
            return GoogleDatasetInfoTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleDatasetInfoTasksReadyResponseInfo> GoogleDatasetInfoTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/dataset_info/tasks_ready"
                    urlBuilder_.Append("v3/serp/google/dataset_info/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleDatasetInfoTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleDatasetInfoTasksFixedResponseInfo> GoogleDatasetInfoTasksFixedAsync()
        {
            return GoogleDatasetInfoTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleDatasetInfoTasksFixedResponseInfo> GoogleDatasetInfoTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/dataset_info/tasks_fixed"
                    urlBuilder_.Append("v3/serp/google/dataset_info/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleDatasetInfoTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo> GoogleDatasetInfoTaskGetAdvancedAsync(string id)
        {
            return GoogleDatasetInfoTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo> GoogleDatasetInfoTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/google/dataset_info/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/google/dataset_info/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live Google Dataset Info provides real-time data on the dataset you specify in the request. You will get data from a page of the dataset displayed separately from the SERP. It contains information about dataset content, authors, licenses, and description on the SERP.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpGoogleDatasetInfoLiveAdvancedResponseInfo> GoogleDatasetInfoLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpGoogleDatasetInfoLiveAdvancedRequestInfo> body)
        {
            return GoogleDatasetInfoLiveAdvancedAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Live Google Dataset Info provides real-time data on the dataset you specify in the request. You will get data from a page of the dataset displayed separately from the SERP. It contains information about dataset content, authors, licenses, and description on the SERP.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/google/dataset_info/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpGoogleDatasetInfoLiveAdvancedResponseInfo> GoogleDatasetInfoLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpGoogleDatasetInfoLiveAdvancedRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/google/dataset_info/live/advanced"
                    urlBuilder_.Append("v3/serp/google/dataset_info/live/advanced");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpGoogleDatasetInfoLiveAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingLocationsResponseInfo> SerpBingLocationsAsync()
        {
            return SerpBingLocationsAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingLocationsResponseInfo> SerpBingLocationsAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/bing/locations"
                    urlBuilder_.Append("v3/serp/bing/locations");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingLocationsResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingLocationsCountryResponseInfo> SerpBingLocationsCountryAsync(string country)
        {
            return SerpBingLocationsCountryAsync(country, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingLocationsCountryResponseInfo> SerpBingLocationsCountryAsync(string country, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/bing/locations/{country}"
                    urlBuilder_.Append("v3/serp/bing/locations/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingLocationsCountryResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of languages by calling this API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingLanguagesResponseInfo> SerpBingLanguagesAsync()
        {
            return SerpBingLanguagesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of languages by calling this API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingLanguagesResponseInfo> SerpBingLanguagesAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/bing/languages"
                    urlBuilder_.Append("v3/serp/bing/languages");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingLanguagesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingOrganicTaskPostResponseInfo> BingOrganicTaskPostAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return BingOrganicTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingOrganicTaskPostResponseInfo> BingOrganicTaskPostAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/bing/organic/task_post"
                    urlBuilder_.Append("v3/serp/bing/organic/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingOrganicTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingOrganicTasksReadyResponseInfo> BingOrganicTasksReadyAsync()
        {
            return BingOrganicTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingOrganicTasksReadyResponseInfo> BingOrganicTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/bing/organic/tasks_ready"
                    urlBuilder_.Append("v3/serp/bing/organic/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingOrganicTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingOrganicTasksFixedResponseInfo> BingOrganicTasksFixedAsync()
        {
            return BingOrganicTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingOrganicTasksFixedResponseInfo> BingOrganicTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/bing/organic/tasks_fixed"
                    urlBuilder_.Append("v3/serp/bing/organic/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingOrganicTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/regular/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingOrganicTaskGetRegularResponseInfo> BingOrganicTaskGetRegularAsync(string id)
        {
            return BingOrganicTaskGetRegularAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/regular/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingOrganicTaskGetRegularResponseInfo> BingOrganicTaskGetRegularAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/bing/organic/task_get/regular/{id}"
                    urlBuilder_.Append("v3/serp/bing/organic/task_get/regular/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingOrganicTaskGetRegularResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingOrganicTaskGetAdvancedResponseInfo> BingOrganicTaskGetAdvancedAsync(string id)
        {
            return BingOrganicTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingOrganicTaskGetAdvancedResponseInfo> BingOrganicTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/bing/organic/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/bing/organic/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingOrganicTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingOrganicTaskGetHtmlResponseInfo> BingOrganicTaskGetHtmlAsync(string id)
        {
            return BingOrganicTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingOrganicTaskGetHtmlResponseInfo> BingOrganicTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/bing/organic/task_get/html/{id}"
                    urlBuilder_.Append("v3/serp/bing/organic/task_get/html/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingOrganicTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/regular/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingOrganicLiveRegularResponseInfo> BingOrganicLiveRegularAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return BingOrganicLiveRegularAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/regular/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingOrganicLiveRegularResponseInfo> BingOrganicLiveRegularAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/bing/organic/live/regular"
                    urlBuilder_.Append("v3/serp/bing/organic/live/regular");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingOrganicLiveRegularResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location. This endpoint will supply a complete overview of featured snippets and other extra elements of SERPs.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingOrganicLiveAdvancedResponseInfo> BingOrganicLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return BingOrganicLiveAdvancedAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Live SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location. This endpoint will supply a complete overview of featured snippets and other extra elements of SERPs.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingOrganicLiveAdvancedResponseInfo> BingOrganicLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/bing/organic/live/advanced"
                    urlBuilder_.Append("v3/serp/bing/organic/live/advanced");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingOrganicLiveAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/html/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingOrganicLiveHtmlResponseInfo> BingOrganicLiveHtmlAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return BingOrganicLiveHtmlAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/organic/live/html/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingOrganicLiveHtmlResponseInfo> BingOrganicLiveHtmlAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/bing/organic/live/html"
                    urlBuilder_.Append("v3/serp/bing/organic/live/html");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingOrganicLiveHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingLocalPackTaskPostResponseInfo> BingLocalPackTaskPostAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return BingLocalPackTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingLocalPackTaskPostResponseInfo> BingLocalPackTaskPostAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/bing/local_pack/task_post"
                    urlBuilder_.Append("v3/serp/bing/local_pack/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingLocalPackTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingLocalPackTasksReadyResponseInfo> BingLocalPackTasksReadyAsync()
        {
            return BingLocalPackTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingLocalPackTasksReadyResponseInfo> BingLocalPackTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/bing/local_pack/tasks_ready"
                    urlBuilder_.Append("v3/serp/bing/local_pack/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingLocalPackTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingLocalPackTasksFixedResponseInfo> BingLocalPackTasksFixedAsync()
        {
            return BingLocalPackTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingLocalPackTasksFixedResponseInfo> BingLocalPackTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/bing/local_pack/tasks_fixed"
                    urlBuilder_.Append("v3/serp/bing/local_pack/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingLocalPackTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_get/regular/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingLocalPackTaskGetRegularResponseInfo> BingLocalPackTaskGetRegularAsync(string id)
        {
            return BingLocalPackTaskGetRegularAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_get/regular/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingLocalPackTaskGetRegularResponseInfo> BingLocalPackTaskGetRegularAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/bing/local_pack/task_get/regular/{id}"
                    urlBuilder_.Append("v3/serp/bing/local_pack/task_get/regular/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingLocalPackTaskGetRegularResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingLocalPackTaskGetHtmlResponseInfo> BingLocalPackTaskGetHtmlAsync(string id)
        {
            return BingLocalPackTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingLocalPackTaskGetHtmlResponseInfo> BingLocalPackTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/bing/local_pack/task_get/html/{id}"
                    urlBuilder_.Append("v3/serp/bing/local_pack/task_get/html/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingLocalPackTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live Bing Local Pack SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/live/regular/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingLocalPackLiveRegularResponseInfo> BingLocalPackLiveRegularAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return BingLocalPackLiveRegularAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Live Bing Local Pack SERP provides real-time data on top 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/live/regular/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingLocalPackLiveRegularResponseInfo> BingLocalPackLiveRegularAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/bing/local_pack/live/regular"
                    urlBuilder_.Append("v3/serp/bing/local_pack/live/regular");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingLocalPackLiveRegularResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/live/html/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBingLocalPackLiveHtmlResponseInfo> BingLocalPackLiveHtmlAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return BingLocalPackLiveHtmlAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/bing/local_pack/live/html/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBingLocalPackLiveHtmlResponseInfo> BingLocalPackLiveHtmlAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/bing/local_pack/live/html"
                    urlBuilder_.Append("v3/serp/bing/local_pack/live/html");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBingLocalPackLiveHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeLocationsResponseInfo> SerpYoutubeLocationsAsync()
        {
            return SerpYoutubeLocationsAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeLocationsResponseInfo> SerpYoutubeLocationsAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/youtube/locations"
                    urlBuilder_.Append("v3/serp/youtube/locations");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeLocationsResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeLocationsCountryResponseInfo> SerpYoutubeLocationsCountryAsync(string country)
        {
            return SerpYoutubeLocationsCountryAsync(country, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeLocationsCountryResponseInfo> SerpYoutubeLocationsCountryAsync(string country, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/youtube/locations/{country}"
                    urlBuilder_.Append("v3/serp/youtube/locations/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeLocationsCountryResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of languages by calling this API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeLanguagesResponseInfo> SerpYoutubeLanguagesAsync()
        {
            return SerpYoutubeLanguagesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of languages by calling this API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeLanguagesResponseInfo> SerpYoutubeLanguagesAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/youtube/languages"
                    urlBuilder_.Append("v3/serp/youtube/languages");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeLanguagesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>YouTube Video Info API provides detailed information about the video you specify in the POST request. You will get data from the watching page containing key video and content metrics as well as the channel where the video is published.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeVideoInfoTaskPostResponseInfo> YoutubeVideoInfoTaskPostAsync(System.Collections.Generic.IEnumerable<SerpYoutubeVideoInfoTaskPostRequestInfo> body)
        {
            return YoutubeVideoInfoTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>YouTube Video Info API provides detailed information about the video you specify in the POST request. You will get data from the watching page containing key video and content metrics as well as the channel where the video is published.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeVideoInfoTaskPostResponseInfo> YoutubeVideoInfoTaskPostAsync(System.Collections.Generic.IEnumerable<SerpYoutubeVideoInfoTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/youtube/video_info/task_post"
                    urlBuilder_.Append("v3/serp/youtube/video_info/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeVideoInfoTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeVideoInfoTasksReadyResponseInfo> YoutubeVideoInfoTasksReadyAsync()
        {
            return YoutubeVideoInfoTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeVideoInfoTasksReadyResponseInfo> YoutubeVideoInfoTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/youtube/video_info/tasks_ready"
                    urlBuilder_.Append("v3/serp/youtube/video_info/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeVideoInfoTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeVideoInfoTasksFixedResponseInfo> YoutubeVideoInfoTasksFixedAsync()
        {
            return YoutubeVideoInfoTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeVideoInfoTasksFixedResponseInfo> YoutubeVideoInfoTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/youtube/video_info/tasks_fixed"
                    urlBuilder_.Append("v3/serp/youtube/video_info/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeVideoInfoTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo> YoutubeVideoInfoTaskGetAdvancedAsync(string id)
        {
            return YoutubeVideoInfoTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo> YoutubeVideoInfoTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/youtube/video_info/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/youtube/video_info/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live YouTube Video Info provides real-time data on the video you specify in the request. You will get data from the watching page containing key video and content metrics as well as the channel where the video is published.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeVideoInfoLiveAdvancedResponseInfo> YoutubeVideoInfoLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpYoutubeVideoInfoLiveAdvancedRequestInfo> body)
        {
            return YoutubeVideoInfoLiveAdvancedAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Live YouTube Video Info provides real-time data on the video you specify in the request. You will get data from the watching page containing key video and content metrics as well as the channel where the video is published.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_info/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeVideoInfoLiveAdvancedResponseInfo> YoutubeVideoInfoLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpYoutubeVideoInfoLiveAdvancedRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/youtube/video_info/live/advanced"
                    urlBuilder_.Append("v3/serp/youtube/video_info/live/advanced");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeVideoInfoLiveAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>YouTube Subtitles API provides data on all subtitles in the video you specify in the POST request. You will get data from the watching page containing subtitled text, its language, and duration in the video.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeVideoSubtitlesTaskPostResponseInfo> YoutubeVideoSubtitlesTaskPostAsync(System.Collections.Generic.IEnumerable<SerpYoutubeVideoSubtitlesTaskPostRequestInfo> body)
        {
            return YoutubeVideoSubtitlesTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>YouTube Subtitles API provides data on all subtitles in the video you specify in the POST request. You will get data from the watching page containing subtitled text, its language, and duration in the video.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeVideoSubtitlesTaskPostResponseInfo> YoutubeVideoSubtitlesTaskPostAsync(System.Collections.Generic.IEnumerable<SerpYoutubeVideoSubtitlesTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/youtube/video_subtitles/task_post"
                    urlBuilder_.Append("v3/serp/youtube/video_subtitles/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeVideoSubtitlesTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeVideoSubtitlesTasksReadyResponseInfo> YoutubeVideoSubtitlesTasksReadyAsync()
        {
            return YoutubeVideoSubtitlesTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeVideoSubtitlesTasksReadyResponseInfo> YoutubeVideoSubtitlesTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/youtube/video_subtitles/tasks_ready"
                    urlBuilder_.Append("v3/serp/youtube/video_subtitles/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeVideoSubtitlesTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeVideoSubtitlesTasksFixedResponseInfo> YoutubeVideoSubtitlesTasksFixedAsync()
        {
            return YoutubeVideoSubtitlesTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeVideoSubtitlesTasksFixedResponseInfo> YoutubeVideoSubtitlesTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/youtube/video_subtitles/tasks_fixed"
                    urlBuilder_.Append("v3/serp/youtube/video_subtitles/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeVideoSubtitlesTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo> YoutubeVideoSubtitlesTaskGetAdvancedAsync(string id)
        {
            return YoutubeVideoSubtitlesTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo> YoutubeVideoSubtitlesTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/youtube/video_subtitles/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/youtube/video_subtitles/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live YouTube Subtitles provides real-time data on subtitles in the video you specify in the request. You will get data from the watching page containing subtitled text, its language, and duration in the video.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo> YoutubeVideoSubtitlesLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo> body)
        {
            return YoutubeVideoSubtitlesLiveAdvancedAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Live YouTube Subtitles provides real-time data on subtitles in the video you specify in the request. You will get data from the watching page containing subtitled text, its language, and duration in the video.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_subtitles/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo> YoutubeVideoSubtitlesLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/youtube/video_subtitles/live/advanced"
                    urlBuilder_.Append("v3/serp/youtube/video_subtitles/live/advanced");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>YouTube Comments API provides data on comments on the video you specify in the request. You will get the top 20 comments on the video as well as information about the author, and key comment metrics.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeVideoCommentsTaskPostResponseInfo> YoutubeVideoCommentsTaskPostAsync(System.Collections.Generic.IEnumerable<SerpYoutubeVideoCommentsTaskPostRequestInfo> body)
        {
            return YoutubeVideoCommentsTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>YouTube Comments API provides data on comments on the video you specify in the request. You will get the top 20 comments on the video as well as information about the author, and key comment metrics.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeVideoCommentsTaskPostResponseInfo> YoutubeVideoCommentsTaskPostAsync(System.Collections.Generic.IEnumerable<SerpYoutubeVideoCommentsTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/youtube/video_comments/task_post"
                    urlBuilder_.Append("v3/serp/youtube/video_comments/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeVideoCommentsTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeVideoCommentsTasksReadyResponseInfo> YoutubeVideoCommentsTasksReadyAsync()
        {
            return YoutubeVideoCommentsTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeVideoCommentsTasksReadyResponseInfo> YoutubeVideoCommentsTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/youtube/video_comments/tasks_ready"
                    urlBuilder_.Append("v3/serp/youtube/video_comments/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeVideoCommentsTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeVideoCommentsTasksFixedResponseInfo> YoutubeVideoCommentsTasksFixedAsync()
        {
            return YoutubeVideoCommentsTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeVideoCommentsTasksFixedResponseInfo> YoutubeVideoCommentsTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/youtube/video_comments/tasks_fixed"
                    urlBuilder_.Append("v3/serp/youtube/video_comments/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeVideoCommentsTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo> YoutubeVideoCommentsTaskGetAdvancedAsync(string id)
        {
            return YoutubeVideoCommentsTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo> YoutubeVideoCommentsTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/youtube/video_comments/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/youtube/video_comments/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live YouTube Comments provides real-time data on comments on the video you specify in the request. You will get the top 20 comments on the video as well as information about the author, and key comment metrics.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYoutubeVideoCommentsLiveAdvancedResponseInfo> YoutubeVideoCommentsLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpYoutubeVideoCommentsLiveAdvancedRequestInfo> body)
        {
            return YoutubeVideoCommentsLiveAdvancedAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Live YouTube Comments provides real-time data on comments on the video you specify in the request. You will get the top 20 comments on the video as well as information about the author, and key comment metrics.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/youtube/video_comments/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYoutubeVideoCommentsLiveAdvancedResponseInfo> YoutubeVideoCommentsLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpYoutubeVideoCommentsLiveAdvancedRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/youtube/video_comments/live/advanced"
                    urlBuilder_.Append("v3/serp/youtube/video_comments/live/advanced");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYoutubeVideoCommentsLiveAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYahooLocationsResponseInfo> SerpYahooLocationsAsync()
        {
            return SerpYahooLocationsAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYahooLocationsResponseInfo> SerpYahooLocationsAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/yahoo/locations"
                    urlBuilder_.Append("v3/serp/yahoo/locations");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYahooLocationsResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYahooLocationsCountryResponseInfo> SerpYahooLocationsCountryAsync(string country)
        {
            return SerpYahooLocationsCountryAsync(country, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYahooLocationsCountryResponseInfo> SerpYahooLocationsCountryAsync(string country, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/yahoo/locations/{country}"
                    urlBuilder_.Append("v3/serp/yahoo/locations/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYahooLocationsCountryResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of languages by calling this API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYahooLanguagesResponseInfo> SerpYahooLanguagesAsync()
        {
            return SerpYahooLanguagesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of languages by calling this API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYahooLanguagesResponseInfo> SerpYahooLanguagesAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/yahoo/languages"
                    urlBuilder_.Append("v3/serp/yahoo/languages");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYahooLanguagesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>SERP API provides top search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYahooOrganicTaskPostResponseInfo> YahooOrganicTaskPostAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return YahooOrganicTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>SERP API provides top search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYahooOrganicTaskPostResponseInfo> YahooOrganicTaskPostAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/yahoo/organic/task_post"
                    urlBuilder_.Append("v3/serp/yahoo/organic/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYahooOrganicTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYahooOrganicTasksReadyResponseInfo> YahooOrganicTasksReadyAsync()
        {
            return YahooOrganicTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYahooOrganicTasksReadyResponseInfo> YahooOrganicTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/yahoo/organic/tasks_ready"
                    urlBuilder_.Append("v3/serp/yahoo/organic/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYahooOrganicTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYahooOrganicTasksFixedResponseInfo> YahooOrganicTasksFixedAsync()
        {
            return YahooOrganicTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYahooOrganicTasksFixedResponseInfo> YahooOrganicTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/yahoo/organic/tasks_fixed"
                    urlBuilder_.Append("v3/serp/yahoo/organic/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYahooOrganicTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/regular/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYahooOrganicTaskGetRegularResponseInfo> YahooOrganicTaskGetRegularAsync(string id)
        {
            return YahooOrganicTaskGetRegularAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/regular/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYahooOrganicTaskGetRegularResponseInfo> YahooOrganicTaskGetRegularAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/yahoo/organic/task_get/regular/{id}"
                    urlBuilder_.Append("v3/serp/yahoo/organic/task_get/regular/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYahooOrganicTaskGetRegularResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYahooOrganicTaskGetAdvancedResponseInfo> YahooOrganicTaskGetAdvancedAsync(string id)
        {
            return YahooOrganicTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYahooOrganicTaskGetAdvancedResponseInfo> YahooOrganicTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/yahoo/organic/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/yahoo/organic/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYahooOrganicTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYahooOrganicTaskGetHtmlResponseInfo> YahooOrganicTaskGetHtmlAsync(string id)
        {
            return YahooOrganicTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYahooOrganicTaskGetHtmlResponseInfo> YahooOrganicTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/yahoo/organic/task_get/html/{id}"
                    urlBuilder_.Append("v3/serp/yahoo/organic/task_get/html/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYahooOrganicTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live Yahoo SERP provides real-time data on up to 100 top search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/regular/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYahooOrganicLiveRegularResponseInfo> YahooOrganicLiveRegularAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return YahooOrganicLiveRegularAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Live Yahoo SERP provides real-time data on up to 100 top search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/regular/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYahooOrganicLiveRegularResponseInfo> YahooOrganicLiveRegularAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/yahoo/organic/live/regular"
                    urlBuilder_.Append("v3/serp/yahoo/organic/live/regular");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYahooOrganicLiveRegularResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live SERP provides real-time data on top search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYahooOrganicLiveAdvancedResponseInfo> YahooOrganicLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return YahooOrganicLiveAdvancedAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Live SERP provides real-time data on top search engine results. These results are specific to the selected location (see the List of Locations) and language (see the List of Languages) settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/advanced/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYahooOrganicLiveAdvancedResponseInfo> YahooOrganicLiveAdvancedAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/yahoo/organic/live/advanced"
                    urlBuilder_.Append("v3/serp/yahoo/organic/live/advanced");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYahooOrganicLiveAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/html/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpYahooOrganicLiveHtmlResponseInfo> YahooOrganicLiveHtmlAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return YahooOrganicLiveHtmlAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>Live SERP HTML provides a raw HTML page of 100 search engine results for the specified keyword, search engine, and location.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/yahoo/organic/live/html/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpYahooOrganicLiveHtmlResponseInfo> YahooOrganicLiveHtmlAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/yahoo/organic/live/html"
                    urlBuilder_.Append("v3/serp/yahoo/organic/live/html");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpYahooOrganicLiveHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBaiduLocationsResponseInfo> SerpBaiduLocationsAsync()
        {
            return SerpBaiduLocationsAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBaiduLocationsResponseInfo> SerpBaiduLocationsAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/baidu/locations"
                    urlBuilder_.Append("v3/serp/baidu/locations");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBaiduLocationsResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBaiduLocationsCountryResponseInfo> SerpBaiduLocationsCountryAsync(string country)
        {
            return SerpBaiduLocationsCountryAsync(country, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBaiduLocationsCountryResponseInfo> SerpBaiduLocationsCountryAsync(string country, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/baidu/locations/{country}"
                    urlBuilder_.Append("v3/serp/baidu/locations/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBaiduLocationsCountryResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of languages by calling this API. You can also download the full list of supported languages in the CSV format (last updated 2023-05-02).
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBaiduLanguagesResponseInfo> SerpBaiduLanguagesAsync()
        {
            return SerpBaiduLanguagesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of languages by calling this API. You can also download the full list of supported languages in the CSV format (last updated 2023-05-02).
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBaiduLanguagesResponseInfo> SerpBaiduLanguagesAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/baidu/languages"
                    urlBuilder_.Append("v3/serp/baidu/languages");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBaiduLanguagesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Baidu SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and other settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBaiduOrganicTaskPostResponseInfo> BaiduOrganicTaskPostAsync(System.Collections.Generic.IEnumerable<SerpBaiduOrganicTaskPostRequestInfo> body)
        {
            return BaiduOrganicTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Baidu SERP API provides top 100 search engine results. These results are specific to the selected location (see the List of Locations) and other settings.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBaiduOrganicTaskPostResponseInfo> BaiduOrganicTaskPostAsync(System.Collections.Generic.IEnumerable<SerpBaiduOrganicTaskPostRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/baidu/organic/task_post"
                    urlBuilder_.Append("v3/serp/baidu/organic/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBaiduOrganicTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBaiduOrganicTasksReadyResponseInfo> BaiduOrganicTasksReadyAsync()
        {
            return BaiduOrganicTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBaiduOrganicTasksReadyResponseInfo> BaiduOrganicTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/baidu/organic/tasks_ready"
                    urlBuilder_.Append("v3/serp/baidu/organic/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBaiduOrganicTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBaiduOrganicTasksFixedResponseInfo> BaiduOrganicTasksFixedAsync()
        {
            return BaiduOrganicTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBaiduOrganicTasksFixedResponseInfo> BaiduOrganicTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/baidu/organic/tasks_fixed"
                    urlBuilder_.Append("v3/serp/baidu/organic/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBaiduOrganicTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/regular/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBaiduOrganicTaskGetRegularResponseInfo> BaiduOrganicTaskGetRegularAsync(string id)
        {
            return BaiduOrganicTaskGetRegularAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/regular/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBaiduOrganicTaskGetRegularResponseInfo> BaiduOrganicTaskGetRegularAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/baidu/organic/task_get/regular/{id}"
                    urlBuilder_.Append("v3/serp/baidu/organic/task_get/regular/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBaiduOrganicTaskGetRegularResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBaiduOrganicTaskGetAdvancedResponseInfo> BaiduOrganicTaskGetAdvancedAsync(string id)
        {
            return BaiduOrganicTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBaiduOrganicTaskGetAdvancedResponseInfo> BaiduOrganicTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/baidu/organic/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/baidu/organic/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBaiduOrganicTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpBaiduOrganicTaskGetHtmlResponseInfo> BaiduOrganicTaskGetHtmlAsync(string id)
        {
            return BaiduOrganicTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/baidu/organic/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpBaiduOrganicTaskGetHtmlResponseInfo> BaiduOrganicTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/baidu/organic/task_get/html/{id}"
                    urlBuilder_.Append("v3/serp/baidu/organic/task_get/html/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpBaiduOrganicTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Naver SERP API provides top 100 search engine results. Naver search results do not vary by location and language, and the search parameters for this search engine do not contain language and location variables. However, you can specify a keyword in any language, and the search engine results may vary depending on the language you used for specifying the search query.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpNaverOrganicTaskPostResponseInfo> NaverOrganicTaskPostAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return NaverOrganicTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Naver SERP API provides top 100 search engine results. Naver search results do not vary by location and language, and the search parameters for this search engine do not contain language and location variables. However, you can specify a keyword in any language, and the search engine results may vary depending on the language you used for specifying the search query.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpNaverOrganicTaskPostResponseInfo> NaverOrganicTaskPostAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/naver/organic/task_post"
                    urlBuilder_.Append("v3/serp/naver/organic/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpNaverOrganicTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpNaverOrganicTasksReadyResponseInfo> NaverOrganicTasksReadyAsync()
        {
            return NaverOrganicTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpNaverOrganicTasksReadyResponseInfo> NaverOrganicTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/naver/organic/tasks_ready"
                    urlBuilder_.Append("v3/serp/naver/organic/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpNaverOrganicTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpNaverOrganicTasksFixedResponseInfo> NaverOrganicTasksFixedAsync()
        {
            return NaverOrganicTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpNaverOrganicTasksFixedResponseInfo> NaverOrganicTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/naver/organic/tasks_fixed"
                    urlBuilder_.Append("v3/serp/naver/organic/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpNaverOrganicTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/regular/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpNaverOrganicTaskGetRegularResponseInfo> NaverOrganicTaskGetRegularAsync(string id)
        {
            return NaverOrganicTaskGetRegularAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/regular/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpNaverOrganicTaskGetRegularResponseInfo> NaverOrganicTaskGetRegularAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/naver/organic/task_get/regular/{id}"
                    urlBuilder_.Append("v3/serp/naver/organic/task_get/regular/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpNaverOrganicTaskGetRegularResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpNaverOrganicTaskGetAdvancedResponseInfo> NaverOrganicTaskGetAdvancedAsync(string id)
        {
            return NaverOrganicTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpNaverOrganicTaskGetAdvancedResponseInfo> NaverOrganicTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/naver/organic/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/naver/organic/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpNaverOrganicTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpNaverOrganicTaskGetHtmlResponseInfo> NaverOrganicTaskGetHtmlAsync(string id)
        {
            return NaverOrganicTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/naver/organic/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpNaverOrganicTaskGetHtmlResponseInfo> NaverOrganicTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/naver/organic/task_get/html/{id}"
                    urlBuilder_.Append("v3/serp/naver/organic/task_get/html/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpNaverOrganicTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpSeznamLocationsResponseInfo> SerpSeznamLocationsAsync()
        {
            return SerpSeznamLocationsAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/locations/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpSeznamLocationsResponseInfo> SerpSeznamLocationsAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/seznam/locations"
                    urlBuilder_.Append("v3/serp/seznam/locations");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpSeznamLocationsResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpSeznamLocationsCountryResponseInfo> SerpSeznamLocationsCountryAsync(string country)
        {
            return SerpSeznamLocationsCountryAsync(country, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of locations by this API call. You can filter the list of locations by country when setting a task.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/locations/?bash'
        /// </remarks>
        /// <param name = "country">country ISO code
        /// <br/>optional field
        /// <br/>specify the ISO code if you want to filter the list of locations by country
        /// <br/>example:
        /// <br/>us</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpSeznamLocationsCountryResponseInfo> SerpSeznamLocationsCountryAsync(string country, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/seznam/locations/{country}"
                    urlBuilder_.Append("v3/serp/seznam/locations/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpSeznamLocationsCountryResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// You will receive the list of languages by calling this API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpSeznamLanguagesResponseInfo> SerpSeznamLanguagesAsync()
        {
            return SerpSeznamLanguagesAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// You will receive the list of languages by calling this API.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/languages/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpSeznamLanguagesResponseInfo> SerpSeznamLanguagesAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/seznam/languages"
                    urlBuilder_.Append("v3/serp/seznam/languages");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpSeznamLanguagesResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Seznam SERP API provides top 10 search engine results from one of the most popular search engines in the Czech Republic. Seznam is focused on the local search market, and thus supports the Czech language only.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpSeznamOrganicTaskPostResponseInfo> SeznamOrganicTaskPostAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body)
        {
            return SeznamOrganicTaskPostAsync(body, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌‌
        /// <br/>Seznam SERP API provides top 10 search engine results from one of the most popular search engines in the Czech Republic. Seznam is focused on the local search market, and thus supports the Czech language only.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_post/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpSeznamOrganicTaskPostResponseInfo> SeznamOrganicTaskPostAsync(System.Collections.Generic.IEnumerable<SerpTaskRequestInfo> body, System.Threading.CancellationToken cancellationToken)
        {
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
                    var urlBuilder_ = new System.Text.StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl))
                        urlBuilder_.Append(_baseUrl);
                    // Operation Path: "v3/serp/seznam/organic/task_post"
                    urlBuilder_.Append("v3/serp/seznam/organic/task_post");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpSeznamOrganicTaskPostResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpSeznamOrganicTasksReadyResponseInfo> SeznamOrganicTasksReadyAsync()
        {
            return SeznamOrganicTasksReadyAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Ready’ endpoint is designed to provide you with the list of completed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed tasks using this endpoint. Then, you can collect the results using the ‘Task GET’ endpoint.
        /// <br/>Learn more about task completion and obtaining a list of completed tasks in this help center article.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/tasks_ready/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpSeznamOrganicTasksReadyResponseInfo> SeznamOrganicTasksReadyAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/seznam/organic/tasks_ready"
                    urlBuilder_.Append("v3/serp/seznam/organic/tasks_ready");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpSeznamOrganicTasksReadyResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpSeznamOrganicTasksFixedResponseInfo> SeznamOrganicTasksFixedAsync()
        {
            return SeznamOrganicTasksFixedAsync(System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// ‌
        /// <br/>The ‘Tasks Fixed’ endpoint is designed to provide you with the list of re-parsed tasks, which haven’t been collected yet. If you use the Standard method without specifying the postback_url, you can receive the list of id for all completed re-parsed tasks using this endpoint. Then, you can re-collect the fixed results using the ‘Task GET’ endpoint.
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/tasks_fixed/?bash'
        /// </remarks>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpSeznamOrganicTasksFixedResponseInfo> SeznamOrganicTasksFixedAsync(System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/seznam/organic/tasks_fixed"
                    urlBuilder_.Append("v3/serp/seznam/organic/tasks_fixed");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpSeznamOrganicTasksFixedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/regular/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpSeznamOrganicTaskGetRegularResponseInfo> SeznamOrganicTaskGetRegularAsync(string id)
        {
            return SeznamOrganicTaskGetRegularAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/regular/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpSeznamOrganicTaskGetRegularResponseInfo> SeznamOrganicTaskGetRegularAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/seznam/organic/task_get/regular/{id}"
                    urlBuilder_.Append("v3/serp/seznam/organic/task_get/regular/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpSeznamOrganicTaskGetRegularResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpSeznamOrganicTaskGetAdvancedResponseInfo> SeznamOrganicTaskGetAdvancedAsync(string id)
        {
            return SeznamOrganicTaskGetAdvancedAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/advanced/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 30 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpSeznamOrganicTaskGetAdvancedResponseInfo> SeznamOrganicTaskGetAdvancedAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/seznam/organic/task_get/advanced/{id}"
                    urlBuilder_.Append("v3/serp/seznam/organic/task_get/advanced/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpSeznamOrganicTaskGetAdvancedResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<SerpSeznamOrganicTaskGetHtmlResponseInfo> SeznamOrganicTaskGetHtmlAsync(string id)
        {
            return SeznamOrganicTaskGetHtmlAsync(id, System.Threading.CancellationToken.None);
        }

        /// <param name = "cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <remarks>
        /// Description of the fields for sending a request:
        /// <br/>for more info please visit 'https://docs.dataforseo.com/v3/serp/seznam/organic/task_get/html/?bash'
        /// </remarks>
        /// <param name = "id">task identifier
        /// <br/>unique task identifier in our system in the UUID format
        /// <br/>you will be able to use it within 7 days to request the results of the task at any time</param>
        /// <returns>Successful operation</returns>
        /// <exception cref = "ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<SerpSeznamOrganicTaskGetHtmlResponseInfo> SeznamOrganicTaskGetHtmlAsync(string id, System.Threading.CancellationToken cancellationToken)
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
                    // Operation Path: "v3/serp/seznam/organic/task_get/html/{id}"
                    urlBuilder_.Append("v3/serp/seznam/organic/task_get/html/");
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
                            var objectResponse_ = await ReadObjectResponseAsync<SerpSeznamOrganicTaskGetHtmlResponseInfo>(response_, headers_, cancellationToken).ConfigureAwait(false);
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