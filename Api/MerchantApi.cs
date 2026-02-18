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
    public  class MerchantApi
    {
    #pragma warning disable 8618
        private string _baseUrl;
        private HttpClient _httpClient;
        private JsonSerializerSettings _settings = new JsonSerializerSettings();
    #pragma warning restore 8618
    
        public bool ReadResponseAsString { get; set; }
    
        public MerchantApi(HttpClient httpClient)
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

        public virtual async Task<MerchantIdListResponseInfo> MerchantIdListAsync(IEnumerable<MerchantIdListRequestInfo> payload)
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
                var path = "/v3/merchant/id_list";
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantIdListResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantErrorsResponseInfo> MerchantErrorsAsync(IEnumerable<MerchantErrorsRequestInfo> payload)
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
                var path = "/v3/merchant/errors";
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantErrorsResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantGoogleLanguagesResponseInfo> MerchantGoogleLanguagesAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/google/languages"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantGoogleLanguagesResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantGoogleLocationsResponseInfo> MerchantGoogleLocationsAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/google/locations"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantGoogleLocationsResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantGoogleLocationsCountryResponseInfo> MerchantGoogleLocationsCountryAsync(string country)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/google/locations/{country}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantGoogleLocationsCountryResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantGoogleProductsTaskPostResponseInfo> GoogleProductsTaskPostAsync(IEnumerable<MerchantGoogleProductsTaskPostRequestInfo> payload)
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
                var path = "/v3/merchant/google/products/task_post";
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantGoogleProductsTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantGoogleProductsTasksReadyResponseInfo> GoogleProductsTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/google/products/tasks_ready"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantGoogleProductsTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantTasksReadyResponseInfo> MerchantTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/tasks_ready"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantGoogleProductsTaskGetAdvancedResponseInfo> GoogleProductsTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/google/products/task_get/advanced/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantGoogleProductsTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantGoogleProductsTaskGetHtmlResponseInfo> GoogleProductsTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/google/products/task_get/html/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantGoogleProductsTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantGoogleSellersTaskPostResponseInfo> GoogleSellersTaskPostAsync(IEnumerable<MerchantGoogleSellersTaskPostRequestInfo> payload)
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
                var path = "/v3/merchant/google/sellers/task_post";
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantGoogleSellersTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantGoogleSellersTasksReadyResponseInfo> GoogleSellersTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/google/sellers/tasks_ready"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantGoogleSellersTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantGoogleSellersTaskGetAdvancedResponseInfo> GoogleSellersTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/google/sellers/task_get/advanced/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantGoogleSellersTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantGoogleProductInfoTaskPostResponseInfo> GoogleProductInfoTaskPostAsync(IEnumerable<MerchantGoogleProductInfoTaskPostRequestInfo> payload)
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
                var path = "/v3/merchant/google/product_info/task_post";
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantGoogleProductInfoTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantGoogleProductInfoTasksReadyResponseInfo> GoogleProductInfoTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/google/product_info/tasks_ready"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantGoogleProductInfoTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantGoogleProductInfoTaskGetAdvancedResponseInfo> GoogleProductInfoTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/google/product_info/task_get/advanced/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantGoogleProductInfoTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantGoogleSellersAdUrlResponseInfo> GoogleSellersAdUrlAsync(string shop_ad_aclk)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/google/sellers/ad_url/{shop_ad_aclk}"
        
                    .Replace("{shop_ad_aclk}", shop_ad_aclk.ToString())
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantGoogleSellersAdUrlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantAmazonLocationsResponseInfo> AmazonLocationsAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/amazon/locations"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantAmazonLocationsResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantAmazonLocationsCountryResponseInfo> AmazonLocationsCountryAsync(string country)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/amazon/locations/{country}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantAmazonLocationsCountryResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantAmazonLanguagesResponseInfo> AmazonLanguagesAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/amazon/languages"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantAmazonLanguagesResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantAmazonProductsTaskPostResponseInfo> AmazonProductsTaskPostAsync(IEnumerable<MerchantAmazonProductsTaskPostRequestInfo> payload)
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
                var path = "/v3/merchant/amazon/products/task_post";
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantAmazonProductsTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantAmazonProductsTasksReadyResponseInfo> AmazonProductsTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/amazon/products/tasks_ready"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantAmazonProductsTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantAmazonProductsTaskGetAdvancedResponseInfo> AmazonProductsTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/amazon/products/task_get/advanced/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantAmazonProductsTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantAmazonProductsTaskGetHtmlResponseInfo> AmazonProductsTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/amazon/products/task_get/html/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantAmazonProductsTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantAmazonAsinTaskPostResponseInfo> AmazonAsinTaskPostAsync(IEnumerable<MerchantAmazonAsinTaskPostRequestInfo> payload)
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
                var path = "/v3/merchant/amazon/asin/task_post";
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantAmazonAsinTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantAmazonAsinTasksReadyResponseInfo> AmazonAsinTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/amazon/asin/tasks_ready"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantAmazonAsinTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantAmazonAsinTaskGetAdvancedResponseInfo> AmazonAsinTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/amazon/asin/task_get/advanced/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantAmazonAsinTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantAmazonAsinTaskGetHtmlResponseInfo> AmazonAsinTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/amazon/asin/task_get/html/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantAmazonAsinTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantAmazonSellersTaskPostResponseInfo> AmazonSellersTaskPostAsync(IEnumerable<MerchantAmazonSellersTaskPostRequestInfo> payload)
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
                var path = "/v3/merchant/amazon/sellers/task_post";
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantAmazonSellersTaskPostResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantAmazonSellersTasksReadyResponseInfo> AmazonSellersTasksReadyAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/amazon/sellers/tasks_ready"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantAmazonSellersTasksReadyResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantAmazonSellersTaskGetAdvancedResponseInfo> AmazonSellersTaskGetAdvancedAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/amazon/sellers/task_get/advanced/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantAmazonSellersTaskGetAdvancedResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<MerchantAmazonSellersTaskGetHtmlResponseInfo> AmazonSellersTaskGetHtmlAsync(string id)
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/merchant/amazon/sellers/task_get/html/{id}"
        
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
                        var objectResponse = await ReadObjectResponseAsync<MerchantAmazonSellersTaskGetHtmlResponseInfo>(response, headers).ConfigureAwait(false);
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