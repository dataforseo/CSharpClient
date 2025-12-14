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
    public  class AppDataApi
    {
    #pragma warning disable 8618
        private string _baseUrl;
        private HttpClient _httpClient;
        private JsonSerializerSettings _settings = new JsonSerializerSettings();
    #pragma warning restore 8618
    
        public bool ReadResponseAsString { get; set; }
    
        public AppDataApi(HttpClient httpClient)
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

        public virtual async Task<AppDataIdListResponseInfo> AppDataIdListAsync(IEnumerable<AppDataIdListRequestInfo> payload)
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
                var path = "/v3/app_data/id_list";
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataIdListResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataErrorsResponseInfo> AppDataErrorsAsync(IEnumerable<AppDataErrorsRequestInfo> payload)
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
                var path = "/v3/app_data/errors";
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataErrorsResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleCategoriesResponseInfo> GoogleCategoriesAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/categories"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleCategoriesResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleLocationsResponseInfo> AppDataGoogleLocationsAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/locations"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleLocationsResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleLocationsCountryResponseInfo> AppDataGoogleLocationsCountryAsync(string country)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/locations/{country}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleLocationsCountryResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleLanguagesResponseInfo> AppDataGoogleLanguagesAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/languages"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleLanguagesResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppSearchesTaskPostResponseInfo> GoogleAppSearchesTaskPostAsync(IEnumerable<AppDataGoogleAppSearchesTaskPostRequestInfo> payload)
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
                var path = "/v3/app_data/google/app_searches/task_post";
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppSearchesTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppSearchesTasksReadyResponseInfo> GoogleAppSearchesTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/app_searches/tasks_ready"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppSearchesTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataTasksReadyResponseInfo> AppDataTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/tasks_ready"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppSearchesTaskGetAdvancedResponseInfo> GoogleAppSearchesTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/app_searches/task_get/advanced/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppSearchesTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppSearchesTaskGetHtmlResponseInfo> GoogleAppSearchesTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/app_searches/task_get/html/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppSearchesTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppListTaskPostResponseInfo> GoogleAppListTaskPostAsync(IEnumerable<AppDataGoogleAppListTaskPostRequestInfo> payload)
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
                var path = "/v3/app_data/google/app_list/task_post";
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppListTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppListTasksReadyResponseInfo> GoogleAppListTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/app_list/tasks_ready"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppListTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppListTaskGetAdvancedResponseInfo> GoogleAppListTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/app_list/task_get/advanced/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppListTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppListTaskGetHtmlResponseInfo> GoogleAppListTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/app_list/task_get/html/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppListTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppInfoTaskPostResponseInfo> GoogleAppInfoTaskPostAsync(IEnumerable<AppDataGoogleAppInfoTaskPostRequestInfo> payload)
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
                var path = "/v3/app_data/google/app_info/task_post";
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppInfoTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppInfoTasksReadyResponseInfo> GoogleAppInfoTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/app_info/tasks_ready"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppInfoTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppInfoTaskGetAdvancedResponseInfo> GoogleAppInfoTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/app_info/task_get/advanced/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppInfoTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppInfoTaskGetHtmlResponseInfo> GoogleAppInfoTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/app_info/task_get/html/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppInfoTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppReviewsTaskPostResponseInfo> GoogleAppReviewsTaskPostAsync(IEnumerable<AppDataGoogleAppReviewsTaskPostRequestInfo> payload)
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
                var path = "/v3/app_data/google/app_reviews/task_post";
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppReviewsTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppReviewsTasksReadyResponseInfo> GoogleAppReviewsTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/app_reviews/tasks_ready"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppReviewsTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppReviewsTaskGetAdvancedResponseInfo> GoogleAppReviewsTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/app_reviews/task_get/advanced/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppReviewsTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppReviewsTaskGetHtmlResponseInfo> GoogleAppReviewsTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/app_reviews/task_get/html/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppReviewsTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppListingsCategoriesResponseInfo> GoogleAppListingsCategoriesAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/google/app_listings/categories"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppListingsCategoriesResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataGoogleAppListingsSearchLiveResponseInfo> GoogleAppListingsSearchLiveAsync(IEnumerable<AppDataGoogleAppListingsSearchLiveRequestInfo> payload)
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
                var path = "/v3/app_data/google/app_listings/search/live";
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataGoogleAppListingsSearchLiveResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleCategoriesResponseInfo> AppleCategoriesAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/apple/categories"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleCategoriesResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleLocationsResponseInfo> AppleLocationsAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/apple/locations"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleLocationsResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleLanguagesResponseInfo> AppleLanguagesAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/apple/languages"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleLanguagesResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleAppSearchesTaskPostResponseInfo> AppleAppSearchesTaskPostAsync(IEnumerable<AppDataAppleAppSearchesTaskPostRequestInfo> payload)
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
                var path = "/v3/app_data/apple/app_searches/task_post";
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleAppSearchesTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleAppSearchesTasksReadyResponseInfo> AppleAppSearchesTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/apple/app_searches/tasks_ready"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleAppSearchesTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleAppSearchesTaskGetAdvancedResponseInfo> AppleAppSearchesTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/apple/app_searches/task_get/advanced/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleAppSearchesTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleAppInfoTaskPostResponseInfo> AppleAppInfoTaskPostAsync(IEnumerable<AppDataAppleAppInfoTaskPostRequestInfo> payload)
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
                var path = "/v3/app_data/apple/app_info/task_post";
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleAppInfoTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleAppInfoTasksReadyResponseInfo> AppleAppInfoTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/apple/app_info/tasks_ready"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleAppInfoTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleAppInfoTaskGetAdvancedResponseInfo> AppleAppInfoTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/apple/app_info/task_get/advanced/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleAppInfoTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleAppListTaskPostResponseInfo> AppleAppListTaskPostAsync(IEnumerable<AppDataAppleAppListTaskPostRequestInfo> payload)
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
                var path = "/v3/app_data/apple/app_list/task_post";
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleAppListTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleAppListTasksReadyResponseInfo> AppleAppListTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/apple/app_list/tasks_ready"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleAppListTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleAppListTaskGetAdvancedResponseInfo> AppleAppListTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/apple/app_list/task_get/advanced/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleAppListTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleAppReviewsTaskPostResponseInfo> AppleAppReviewsTaskPostAsync(IEnumerable<AppDataAppleAppReviewsTaskPostRequestInfo> payload)
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
                var path = "/v3/app_data/apple/app_reviews/task_post";
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleAppReviewsTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleAppReviewsTasksReadyResponseInfo> AppleAppReviewsTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/apple/app_reviews/tasks_ready"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleAppReviewsTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleAppReviewsTaskGetAdvancedResponseInfo> AppleAppReviewsTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/apple/app_reviews/task_get/advanced/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleAppReviewsTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleAppListingsCategoriesResponseInfo> AppleAppListingsCategoriesAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/app_data/apple/app_listings/categories"
        
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleAppListingsCategoriesResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<AppDataAppleAppListingsSearchLiveResponseInfo> AppleAppListingsSearchLiveAsync(IEnumerable<AppDataAppleAppListingsSearchLiveRequestInfo> payload)
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
                var path = "/v3/app_data/apple/app_listings/search/live";
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
                        var objectResponse = await ReadObjectResponseAsync<AppDataAppleAppListingsSearchLiveResponseInfo>(response, headers).ConfigureAwait(false);
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