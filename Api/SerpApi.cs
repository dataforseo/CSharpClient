using System;
using System.Collections.Generic;
using System.Globalization;
using DataForSeo.Client.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DataForSeo.Client.Models.Requests;
using DataForSeo.Client.Models.Responses;

namespace DataForSeo.Client.Api
{
    public  class SerpApi
    {
    #pragma warning disable 8618
        private string _baseUrl;
        private HttpClient _httpClient;
        private JsonSerializerSettings _settings = new JsonSerializerSettings();
    #pragma warning restore 8618
    
        public bool ReadResponseAsString { get; set; }
    
        public SerpApi(HttpClient httpClient)
        {
            BaseUrl = "https://api.dataforseo.com";
            _httpClient = httpClient;
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

        public virtual async Task<SerpIdListResponseInfo> SerpIdListAsync(IEnumerable<SerpIdListRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/id_list";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpIdListResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpErrorsResponseInfo> SerpErrorsAsync(IEnumerable<SerpErrorsRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/errors";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpErrorsResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpScreenshotResponseInfo> ScreenshotAsync(IEnumerable<SerpScreenshotRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/screenshot";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpScreenshotResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpAiSummaryResponseInfo> AiSummaryAsync(IEnumerable<SerpAiSummaryRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/ai_summary";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpAiSummaryResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleLocationsResponseInfo> SerpGoogleLocationsAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/locations"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleLocationsResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleLocationsCountryResponseInfo> SerpGoogleLocationsCountryAsync(string country)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/locations/{country}"
        
                    .Replace("{country}", country.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleLocationsCountryResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleLanguagesResponseInfo> SerpGoogleLanguagesAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/languages"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleLanguagesResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleOrganicTaskPostResponseInfo> GoogleOrganicTaskPostAsync(IEnumerable<SerpGoogleOrganicTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/organic/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleOrganicTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleOrganicTasksReadyResponseInfo> GoogleOrganicTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/organic/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleOrganicTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpTasksReadyResponseInfo> TasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleOrganicTasksFixedResponseInfo> GoogleOrganicTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/organic/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleOrganicTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleOrganicTaskGetRegularResponseInfo> GoogleOrganicTaskGetRegularAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/organic/task_get/regular/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleOrganicTaskGetRegularResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleOrganicTaskGetAdvancedResponseInfo> GoogleOrganicTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/organic/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleOrganicTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleOrganicTaskGetHtmlResponseInfo> GoogleOrganicTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/organic/task_get/html/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleOrganicTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleOrganicLiveRegularResponseInfo> GoogleOrganicLiveRegularAsync(IEnumerable<SerpGoogleOrganicLiveRegularRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/organic/live/regular";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleOrganicLiveRegularResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleOrganicLiveAdvancedResponseInfo> GoogleOrganicLiveAdvancedAsync(IEnumerable<SerpGoogleOrganicLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/organic/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleOrganicLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleOrganicLiveHtmlResponseInfo> GoogleOrganicLiveHtmlAsync(IEnumerable<SerpGoogleOrganicLiveHtmlRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/organic/live/html";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleOrganicLiveHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleMapsTaskPostResponseInfo> GoogleMapsTaskPostAsync(IEnumerable<SerpGoogleMapsTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/maps/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleMapsTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleMapsTasksReadyResponseInfo> GoogleMapsTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/maps/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleMapsTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleMapsTasksFixedResponseInfo> GoogleMapsTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/maps/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleMapsTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleMapsTaskGetAdvancedResponseInfo> GoogleMapsTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/maps/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleMapsTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleMapsLiveAdvancedResponseInfo> GoogleMapsLiveAdvancedAsync(IEnumerable<SerpGoogleMapsLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/maps/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleMapsLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleLocalFinderTaskPostResponseInfo> GoogleLocalFinderTaskPostAsync(IEnumerable<SerpGoogleLocalFinderTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/local_finder/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleLocalFinderTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleLocalFinderTasksReadyResponseInfo> GoogleLocalFinderTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/local_finder/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleLocalFinderTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleLocalFinderTasksFixedResponseInfo> GoogleLocalFinderTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/local_finder/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleLocalFinderTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleLocalFinderTaskGetAdvancedResponseInfo> GoogleLocalFinderTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/local_finder/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleLocalFinderTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleLocalFinderTaskGetHtmlResponseInfo> GoogleLocalFinderTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/local_finder/task_get/html/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleLocalFinderTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleLocalFinderLiveAdvancedResponseInfo> GoogleLocalFinderLiveAdvancedAsync(IEnumerable<SerpGoogleLocalFinderLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/local_finder/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleLocalFinderLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleLocalFinderLiveHtmlResponseInfo> GoogleLocalFinderLiveHtmlAsync(IEnumerable<SerpGoogleLocalFinderLiveHtmlRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/local_finder/live/html";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleLocalFinderLiveHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleNewsTaskPostResponseInfo> GoogleNewsTaskPostAsync(IEnumerable<SerpGoogleNewsTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/news/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleNewsTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleNewsTasksReadyResponseInfo> GoogleNewsTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/news/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleNewsTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleNewsTasksFixedResponseInfo> GoogleNewsTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/news/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleNewsTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleNewsTaskGetAdvancedResponseInfo> GoogleNewsTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/news/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleNewsTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleNewsTaskGetHtmlResponseInfo> GoogleNewsTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/news/task_get/html/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleNewsTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleNewsLiveAdvancedResponseInfo> GoogleNewsLiveAdvancedAsync(IEnumerable<SerpGoogleNewsLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/news/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleNewsLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleNewsLiveHtmlResponseInfo> GoogleNewsLiveHtmlAsync(IEnumerable<SerpGoogleNewsLiveHtmlRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/news/live/html";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleNewsLiveHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleEventsTaskPostResponseInfo> GoogleEventsTaskPostAsync(IEnumerable<SerpGoogleEventsTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/events/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleEventsTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleEventsTasksReadyResponseInfo> GoogleEventsTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/events/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleEventsTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleEventsTasksFixedResponseInfo> GoogleEventsTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/events/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleEventsTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleEventsTaskGetAdvancedResponseInfo> GoogleEventsTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/events/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleEventsTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleEventsLiveAdvancedResponseInfo> GoogleEventsLiveAdvancedAsync(IEnumerable<SerpGoogleEventsLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/events/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleEventsLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleImagesTaskPostResponseInfo> GoogleImagesTaskPostAsync(IEnumerable<SerpGoogleImagesTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/images/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleImagesTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleImagesTasksReadyResponseInfo> GoogleImagesTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/images/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleImagesTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleImagesTasksFixedResponseInfo> GoogleImagesTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/images/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleImagesTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleImagesTaskGetAdvancedResponseInfo> GoogleImagesTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/images/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleImagesTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleImagesTaskGetHtmlResponseInfo> GoogleImagesTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/images/task_get/html/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleImagesTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleImagesLiveAdvancedResponseInfo> GoogleImagesLiveAdvancedAsync(IEnumerable<SerpGoogleImagesLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/images/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleImagesLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleImagesLiveHtmlResponseInfo> GoogleImagesLiveHtmlAsync(IEnumerable<SerpGoogleImagesLiveHtmlRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/images/live/html";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleImagesLiveHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleSearchByImageTaskPostResponseInfo> GoogleSearchByImageTaskPostAsync(IEnumerable<SerpGoogleSearchByImageTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/search_by_image/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleSearchByImageTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleSearchByImageTasksReadyResponseInfo> GoogleSearchByImageTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/search_by_image/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleSearchByImageTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleSearchByImageTasksFixedResponseInfo> GoogleSearchByImageTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/search_by_image/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleSearchByImageTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleSearchByImageTaskGetAdvancedResponseInfo> GoogleSearchByImageTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/search_by_image/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleSearchByImageTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleJobsTaskPostResponseInfo> GoogleJobsTaskPostAsync(IEnumerable<SerpGoogleJobsTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/jobs/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleJobsTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleJobsTasksReadyResponseInfo> GoogleJobsTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/jobs/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleJobsTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleJobsTasksFixedResponseInfo> GoogleJobsTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/jobs/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleJobsTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleJobsTaskGetAdvancedResponseInfo> GoogleJobsTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/jobs/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleJobsTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleJobsTaskGetHtmlResponseInfo> GoogleJobsTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/jobs/task_get/html/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleJobsTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleAutocompleteTaskPostResponseInfo> GoogleAutocompleteTaskPostAsync(IEnumerable<SerpGoogleAutocompleteTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/autocomplete/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleAutocompleteTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleAutocompleteTasksReadyResponseInfo> GoogleAutocompleteTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/autocomplete/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleAutocompleteTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleAutocompleteTasksFixedResponseInfo> GoogleAutocompleteTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/autocomplete/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleAutocompleteTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleAutocompleteTaskGetAdvancedResponseInfo> GoogleAutocompleteTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/autocomplete/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleAutocompleteTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleAutocompleteLiveAdvancedResponseInfo> GoogleAutocompleteLiveAdvancedAsync(IEnumerable<SerpGoogleAutocompleteLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/autocomplete/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleAutocompleteLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleDatasetSearchTaskPostResponseInfo> GoogleDatasetSearchTaskPostAsync(IEnumerable<SerpGoogleDatasetSearchTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/dataset_search/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleDatasetSearchTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleDatasetSearchTasksReadyResponseInfo> GoogleDatasetSearchTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/dataset_search/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleDatasetSearchTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleDatasetSearchTasksFixedResponseInfo> GoogleDatasetSearchTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/dataset_search/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleDatasetSearchTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo> GoogleDatasetSearchTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/dataset_search/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleDatasetSearchTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleDatasetSearchLiveAdvancedResponseInfo> GoogleDatasetSearchLiveAdvancedAsync(IEnumerable<SerpGoogleDatasetSearchLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/dataset_search/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleDatasetSearchLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleDatasetInfoTaskPostResponseInfo> GoogleDatasetInfoTaskPostAsync(IEnumerable<SerpGoogleDatasetInfoTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/dataset_info/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleDatasetInfoTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleDatasetInfoTasksReadyResponseInfo> GoogleDatasetInfoTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/dataset_info/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleDatasetInfoTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleDatasetInfoTasksFixedResponseInfo> GoogleDatasetInfoTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/dataset_info/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleDatasetInfoTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo> GoogleDatasetInfoTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/dataset_info/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleDatasetInfoTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleDatasetInfoLiveAdvancedResponseInfo> GoogleDatasetInfoLiveAdvancedAsync(IEnumerable<SerpGoogleDatasetInfoLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/dataset_info/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleDatasetInfoLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleAdsAdvertisersLocationsResponseInfo> SerpGoogleAdsAdvertisersLocationsAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/ads_advertisers/locations"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleAdsAdvertisersLocationsResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleAdsAdvertisersTaskPostResponseInfo> GoogleAdsAdvertisersTaskPostAsync(IEnumerable<SerpGoogleAdsAdvertisersTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/ads_advertisers/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleAdsAdvertisersTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleAdsAdvertisersTasksReadyResponseInfo> GoogleAdsAdvertisersTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/ads_advertisers/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleAdsAdvertisersTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleAdsAdvertisersTaskGetAdvancedResponseInfo> GoogleAdsAdvertisersTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/ads_advertisers/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleAdsAdvertisersTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleAdsSearchLocationsResponseInfo> SerpGoogleAdsSearchLocationsAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/ads_search/locations"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleAdsSearchLocationsResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleAdsSearchTaskPostResponseInfo> GoogleAdsSearchTaskPostAsync(IEnumerable<SerpGoogleAdsSearchTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/ads_search/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleAdsSearchTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleAdsSearchTasksReadyResponseInfo> GoogleAdsSearchTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/ads_search/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleAdsSearchTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleAdsSearchTaskGetAdvancedResponseInfo> GoogleAdsSearchTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/ads_search/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleAdsSearchTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingLocationsResponseInfo> SerpBingLocationsAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/locations"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingLocationsResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingLocationsCountryResponseInfo> SerpBingLocationsCountryAsync(string country)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/locations/{country}"
        
                    .Replace("{country}", country.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingLocationsCountryResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingLanguagesResponseInfo> SerpBingLanguagesAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/languages"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingLanguagesResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingOrganicTaskPostResponseInfo> BingOrganicTaskPostAsync(IEnumerable<SerpBingOrganicTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/organic/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingOrganicTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingOrganicTasksReadyResponseInfo> BingOrganicTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/organic/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingOrganicTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingOrganicTasksFixedResponseInfo> BingOrganicTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/organic/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingOrganicTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingOrganicTaskGetRegularResponseInfo> BingOrganicTaskGetRegularAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/organic/task_get/regular/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingOrganicTaskGetRegularResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingOrganicTaskGetAdvancedResponseInfo> BingOrganicTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/organic/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingOrganicTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingOrganicTaskGetHtmlResponseInfo> BingOrganicTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/organic/task_get/html/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingOrganicTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingOrganicLiveRegularResponseInfo> BingOrganicLiveRegularAsync(IEnumerable<SerpBingOrganicLiveRegularRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/organic/live/regular";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingOrganicLiveRegularResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingOrganicLiveAdvancedResponseInfo> BingOrganicLiveAdvancedAsync(IEnumerable<SerpBingOrganicLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/organic/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingOrganicLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingOrganicLiveHtmlResponseInfo> BingOrganicLiveHtmlAsync(IEnumerable<SerpBingOrganicLiveHtmlRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/organic/live/html";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingOrganicLiveHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingLocalPackTaskPostResponseInfo> BingLocalPackTaskPostAsync(IEnumerable<SerpBingLocalPackTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/local_pack/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingLocalPackTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingLocalPackTasksReadyResponseInfo> BingLocalPackTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/local_pack/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingLocalPackTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingLocalPackTasksFixedResponseInfo> BingLocalPackTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/local_pack/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingLocalPackTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingLocalPackTaskGetRegularResponseInfo> BingLocalPackTaskGetRegularAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/local_pack/task_get/regular/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingLocalPackTaskGetRegularResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingLocalPackTaskGetHtmlResponseInfo> BingLocalPackTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/local_pack/task_get/html/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingLocalPackTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingLocalPackLiveRegularResponseInfo> BingLocalPackLiveRegularAsync(IEnumerable<SerpBingLocalPackLiveRegularRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/local_pack/live/regular";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingLocalPackLiveRegularResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBingLocalPackLiveHtmlResponseInfo> BingLocalPackLiveHtmlAsync(IEnumerable<SerpBingLocalPackLiveHtmlRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/bing/local_pack/live/html";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBingLocalPackLiveHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeLocationsResponseInfo> SerpYoutubeLocationsAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/locations"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeLocationsResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeLocationsCountryResponseInfo> SerpYoutubeLocationsCountryAsync(string country)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/locations/{country}"
        
                    .Replace("{country}", country.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeLocationsCountryResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeLanguagesResponseInfo> SerpYoutubeLanguagesAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/languages"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeLanguagesResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeVideoInfoTaskPostResponseInfo> YoutubeVideoInfoTaskPostAsync(IEnumerable<SerpYoutubeVideoInfoTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/video_info/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeVideoInfoTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeVideoInfoTasksReadyResponseInfo> YoutubeVideoInfoTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/video_info/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeVideoInfoTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeVideoInfoTasksFixedResponseInfo> YoutubeVideoInfoTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/video_info/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeVideoInfoTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo> YoutubeVideoInfoTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/video_info/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeVideoInfoTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeVideoInfoLiveAdvancedResponseInfo> YoutubeVideoInfoLiveAdvancedAsync(IEnumerable<SerpYoutubeVideoInfoLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/video_info/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeVideoInfoLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeVideoSubtitlesTaskPostResponseInfo> YoutubeVideoSubtitlesTaskPostAsync(IEnumerable<SerpYoutubeVideoSubtitlesTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/video_subtitles/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeVideoSubtitlesTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeVideoSubtitlesTasksReadyResponseInfo> YoutubeVideoSubtitlesTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/video_subtitles/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeVideoSubtitlesTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeVideoSubtitlesTasksFixedResponseInfo> YoutubeVideoSubtitlesTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/video_subtitles/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeVideoSubtitlesTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo> YoutubeVideoSubtitlesTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/video_subtitles/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeVideoSubtitlesTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo> YoutubeVideoSubtitlesLiveAdvancedAsync(IEnumerable<SerpYoutubeVideoSubtitlesLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/video_subtitles/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeVideoSubtitlesLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeVideoCommentsTaskPostResponseInfo> YoutubeVideoCommentsTaskPostAsync(IEnumerable<SerpYoutubeVideoCommentsTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/video_comments/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeVideoCommentsTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeVideoCommentsTasksReadyResponseInfo> YoutubeVideoCommentsTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/video_comments/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeVideoCommentsTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeVideoCommentsTasksFixedResponseInfo> YoutubeVideoCommentsTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/video_comments/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeVideoCommentsTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo> YoutubeVideoCommentsTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/video_comments/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeVideoCommentsTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYoutubeVideoCommentsLiveAdvancedResponseInfo> YoutubeVideoCommentsLiveAdvancedAsync(IEnumerable<SerpYoutubeVideoCommentsLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/youtube/video_comments/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYoutubeVideoCommentsLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYahooLocationsResponseInfo> SerpYahooLocationsAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/yahoo/locations"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYahooLocationsResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYahooLocationsCountryResponseInfo> SerpYahooLocationsCountryAsync(string country)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/yahoo/locations/{country}"
        
                    .Replace("{country}", country.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYahooLocationsCountryResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYahooLanguagesResponseInfo> SerpYahooLanguagesAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/yahoo/languages"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYahooLanguagesResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYahooOrganicTaskPostResponseInfo> YahooOrganicTaskPostAsync(IEnumerable<SerpYahooOrganicTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/yahoo/organic/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYahooOrganicTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYahooOrganicTasksReadyResponseInfo> YahooOrganicTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/yahoo/organic/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYahooOrganicTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYahooOrganicTasksFixedResponseInfo> YahooOrganicTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/yahoo/organic/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYahooOrganicTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYahooOrganicTaskGetRegularResponseInfo> YahooOrganicTaskGetRegularAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/yahoo/organic/task_get/regular/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYahooOrganicTaskGetRegularResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYahooOrganicTaskGetAdvancedResponseInfo> YahooOrganicTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/yahoo/organic/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYahooOrganicTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYahooOrganicTaskGetHtmlResponseInfo> YahooOrganicTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/yahoo/organic/task_get/html/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYahooOrganicTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYahooOrganicLiveRegularResponseInfo> YahooOrganicLiveRegularAsync(IEnumerable<SerpYahooOrganicLiveRegularRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/yahoo/organic/live/regular";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYahooOrganicLiveRegularResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYahooOrganicLiveAdvancedResponseInfo> YahooOrganicLiveAdvancedAsync(IEnumerable<SerpYahooOrganicLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/yahoo/organic/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYahooOrganicLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpYahooOrganicLiveHtmlResponseInfo> YahooOrganicLiveHtmlAsync(IEnumerable<SerpYahooOrganicLiveHtmlRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/yahoo/organic/live/html";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpYahooOrganicLiveHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBaiduLocationsResponseInfo> SerpBaiduLocationsAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/baidu/locations"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBaiduLocationsResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBaiduLocationsCountryResponseInfo> SerpBaiduLocationsCountryAsync(string country)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/baidu/locations/{country}"
        
                    .Replace("{country}", country.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBaiduLocationsCountryResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBaiduLanguagesResponseInfo> SerpBaiduLanguagesAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/baidu/languages"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBaiduLanguagesResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBaiduOrganicTaskPostResponseInfo> BaiduOrganicTaskPostAsync(IEnumerable<SerpBaiduOrganicTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/baidu/organic/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBaiduOrganicTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBaiduOrganicTasksReadyResponseInfo> BaiduOrganicTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/baidu/organic/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBaiduOrganicTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBaiduOrganicTasksFixedResponseInfo> BaiduOrganicTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/baidu/organic/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBaiduOrganicTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBaiduOrganicTaskGetRegularResponseInfo> BaiduOrganicTaskGetRegularAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/baidu/organic/task_get/regular/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBaiduOrganicTaskGetRegularResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBaiduOrganicTaskGetAdvancedResponseInfo> BaiduOrganicTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/baidu/organic/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBaiduOrganicTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpBaiduOrganicTaskGetHtmlResponseInfo> BaiduOrganicTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/baidu/organic/task_get/html/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpBaiduOrganicTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpNaverOrganicTaskPostResponseInfo> NaverOrganicTaskPostAsync(IEnumerable<SerpNaverOrganicTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/naver/organic/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpNaverOrganicTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpNaverOrganicTasksReadyResponseInfo> NaverOrganicTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/naver/organic/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpNaverOrganicTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpNaverOrganicTasksFixedResponseInfo> NaverOrganicTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/naver/organic/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpNaverOrganicTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpNaverOrganicTaskGetRegularResponseInfo> NaverOrganicTaskGetRegularAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/naver/organic/task_get/regular/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpNaverOrganicTaskGetRegularResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpNaverOrganicTaskGetAdvancedResponseInfo> NaverOrganicTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/naver/organic/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpNaverOrganicTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpNaverOrganicTaskGetHtmlResponseInfo> NaverOrganicTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/naver/organic/task_get/html/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpNaverOrganicTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpSeznamLocationsResponseInfo> SerpSeznamLocationsAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/seznam/locations"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpSeznamLocationsResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpSeznamLocationsCountryResponseInfo> SerpSeznamLocationsCountryAsync(string country)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/seznam/locations/{country}"
        
                    .Replace("{country}", country.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpSeznamLocationsCountryResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpSeznamLanguagesResponseInfo> SerpSeznamLanguagesAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/seznam/languages"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpSeznamLanguagesResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpSeznamOrganicTaskPostResponseInfo> SeznamOrganicTaskPostAsync(IEnumerable<SerpSeznamOrganicTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/seznam/organic/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpSeznamOrganicTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpSeznamOrganicTasksReadyResponseInfo> SeznamOrganicTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/seznam/organic/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpSeznamOrganicTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpSeznamOrganicTasksFixedResponseInfo> SeznamOrganicTasksFixedAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/seznam/organic/tasks_fixed"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpSeznamOrganicTasksFixedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpSeznamOrganicTaskGetRegularResponseInfo> SeznamOrganicTaskGetRegularAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/seznam/organic/task_get/regular/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpSeznamOrganicTaskGetRegularResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpSeznamOrganicTaskGetAdvancedResponseInfo> SeznamOrganicTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/seznam/organic/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpSeznamOrganicTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpSeznamOrganicTaskGetHtmlResponseInfo> SeznamOrganicTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/seznam/organic/task_get/html/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpSeznamOrganicTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceExploreTaskPostResponseInfo> GoogleFinanceExploreTaskPostAsync(IEnumerable<SerpGoogleFinanceExploreTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_explore/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceExploreTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceExploreTasksReadyResponseInfo> GoogleFinanceExploreTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_explore/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceExploreTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceExploreTaskGetAdvancedResponseInfo> GoogleFinanceExploreTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_explore/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceExploreTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceExploreTaskGetHtmlResponseInfo> GoogleFinanceExploreTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_explore/task_get/html/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceExploreTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceExploreLiveAdvancedResponseInfo> GoogleFinanceExploreLiveAdvancedAsync(IEnumerable<SerpGoogleFinanceExploreLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_explore/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceExploreLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceExploreLiveHtmlResponseInfo> GoogleFinanceExploreLiveHtmlAsync(IEnumerable<SerpGoogleFinanceExploreLiveHtmlRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_explore/live/html";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceExploreLiveHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceMarketsTaskPostResponseInfo> GoogleFinanceMarketsTaskPostAsync(IEnumerable<SerpGoogleFinanceMarketsTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_markets/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceMarketsTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceMarketsTasksReadyResponseInfo> GoogleFinanceMarketsTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_markets/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceMarketsTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceMarketsTaskGetAdvancedResponseInfo> GoogleFinanceMarketsTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_markets/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceMarketsTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceMarketsTaskGetHtmlResponseInfo> GoogleFinanceMarketsTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_markets/task_get/html/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceMarketsTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceMarketsLiveAdvancedResponseInfo> GoogleFinanceMarketsLiveAdvancedAsync(IEnumerable<SerpGoogleFinanceMarketsLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_markets/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceMarketsLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceMarketsLiveHtmlResponseInfo> GoogleFinanceMarketsLiveHtmlAsync(IEnumerable<SerpGoogleFinanceMarketsLiveHtmlRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_markets/live/html";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceMarketsLiveHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceQuoteTaskPostResponseInfo> GoogleFinanceQuoteTaskPostAsync(IEnumerable<SerpGoogleFinanceQuoteTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_quote/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceQuoteTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceQuoteTasksReadyResponseInfo> GoogleFinanceQuoteTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_quote/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceQuoteTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceQuoteTaskGetAdvancedResponseInfo> GoogleFinanceQuoteTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_quote/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceQuoteTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceQuoteTaskGetHtmlResponseInfo> GoogleFinanceQuoteTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_quote/task_get/html/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceQuoteTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceQuoteLiveAdvancedResponseInfo> GoogleFinanceQuoteLiveAdvancedAsync(IEnumerable<SerpGoogleFinanceQuoteLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_quote/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceQuoteLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceQuoteLiveHtmlResponseInfo> GoogleFinanceQuoteLiveHtmlAsync(IEnumerable<SerpGoogleFinanceQuoteLiveHtmlRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_quote/live/html";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceQuoteLiveHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceTickerSearchTaskPostResponseInfo> GoogleFinanceTickerSearchTaskPostAsync(IEnumerable<SerpGoogleFinanceTickerSearchTaskPostRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_ticker_search/task_post";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceTickerSearchTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceTickerSearchTasksReadyResponseInfo> GoogleFinanceTickerSearchTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_ticker_search/tasks_ready"
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceTickerSearchTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceTickerSearchTaskGetAdvancedResponseInfo> GoogleFinanceTickerSearchTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_ticker_search/task_get/advanced/{id}"
        
                    .Replace("{id}", id.ToString())
        
                ;
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceTickerSearchTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<SerpGoogleFinanceTickerSearchLiveAdvancedResponseInfo> GoogleFinanceTickerSearchLiveAdvancedAsync(IEnumerable<SerpGoogleFinanceTickerSearchLiveAdvancedRequestInfo> payload)
        {
            using (var request = new HttpRequestMessage())
            {
                var json = JsonConvert.SerializeObject(payload, _settings);
                var content = new StringContent(json);
                content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                request.Content = content;
                request.Method = new HttpMethod("POST");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/serp/google/finance_ticker_search/live/advanced";
                urlBuilder.Append(path);
                var url = urlBuilder.ToString();
                request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);
                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false))
                {
                    var headers = new Dictionary<string, IEnumerable<string>>();
                    foreach (var item_ in response.Headers)
                        headers[item_.Key] = item_.Value;
                    if (response.Content != null && response.Content.Headers != null)
                    {
                        foreach (var item_ in response.Content.Headers)
                            headers[item_.Key] = item_.Value;
                    }

                    var status = (int)response.StatusCode;
                    if (status == 200)
                    {
                        var objectResponse = await ReadObjectResponseAsync<SerpGoogleFinanceTickerSearchLiveAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
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
    
        protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers)
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
                    var typedBody = JsonConvert.DeserializeObject<T>(responseText, _settings);
                    return new ObjectResponseResult<T>(typedBody, responseText);
                }
                catch (JsonException exception)
                {
                    var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
                }
            }
    
            try
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                using (var streamReader = new System.IO.StreamReader(responseStream))
                using (var jsonTextReader = new JsonTextReader(streamReader))
                {
                    var serializer = JsonSerializer.Create(_settings);
                    var typedBody = serializer.Deserialize<T>(jsonTextReader);
                    return new ObjectResponseResult<T>(typedBody, string.Empty);
                }
            }
            catch (JsonException exception)
            {
                var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
            }
        }
    } 
}