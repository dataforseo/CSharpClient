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
    public  class ContentAnalysisApi
    {
    #pragma warning disable 8618
        private string _baseUrl;
        private HttpClient _httpClient;
        private JsonSerializerSettings _settings = new JsonSerializerSettings();
    #pragma warning restore 8618
    
        public bool ReadResponseAsString { get; set; }
    
        public ContentAnalysisApi(HttpClient httpClient)
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

        public virtual async Task<ContentAnalysisIdListResponseInfo> ContentAnalysisIdListAsync(IEnumerable<ContentAnalysisIdListRequestInfo> payload)
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
                var path = "/v3/content_analysis/id_list";
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
                        var objectResponse = await ReadObjectResponseAsync<ContentAnalysisIdListResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<ContentAnalysisAvailableFiltersResponseInfo> ContentAnalysisAvailableFiltersAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/content_analysis/available_filters"
        
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
                        var objectResponse = await ReadObjectResponseAsync<ContentAnalysisAvailableFiltersResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<ContentAnalysisLocationsResponseInfo> ContentAnalysisLocationsAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/content_analysis/locations"
        
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
                        var objectResponse = await ReadObjectResponseAsync<ContentAnalysisLocationsResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<ContentAnalysisLanguagesResponseInfo> ContentAnalysisLanguagesAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/content_analysis/languages"
        
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
                        var objectResponse = await ReadObjectResponseAsync<ContentAnalysisLanguagesResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<ContentAnalysisCategoriesResponseInfo> ContentAnalysisCategoriesAsync()
        {
            using (var request = new HttpRequestMessage())
            {
                request.Method = new HttpMethod("GET");
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                var urlBuilder = new StringBuilder();
                if (!string.IsNullOrEmpty(_baseUrl))
                    urlBuilder.Append(_baseUrl);
                var path = "/v3/content_analysis/categories"
        
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
                        var objectResponse = await ReadObjectResponseAsync<ContentAnalysisCategoriesResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<ContentAnalysisSearchLiveResponseInfo> SearchLiveAsync(IEnumerable<ContentAnalysisSearchLiveRequestInfo> payload)
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
                var path = "/v3/content_analysis/search/live";
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
                        var objectResponse = await ReadObjectResponseAsync<ContentAnalysisSearchLiveResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<ContentAnalysisSummaryLiveResponseInfo> ContentAnalysisSummaryLiveAsync(IEnumerable<ContentAnalysisSummaryLiveRequestInfo> payload)
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
                var path = "/v3/content_analysis/summary/live";
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
                        var objectResponse = await ReadObjectResponseAsync<ContentAnalysisSummaryLiveResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<ContentAnalysisSentimentAnalysisLiveResponseInfo> SentimentAnalysisLiveAsync(IEnumerable<ContentAnalysisSentimentAnalysisLiveRequestInfo> payload)
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
                var path = "/v3/content_analysis/sentiment_analysis/live";
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
                        var objectResponse = await ReadObjectResponseAsync<ContentAnalysisSentimentAnalysisLiveResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<ContentAnalysisRatingDistributionLiveResponseInfo> RatingDistributionLiveAsync(IEnumerable<ContentAnalysisRatingDistributionLiveRequestInfo> payload)
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
                var path = "/v3/content_analysis/rating_distribution/live";
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
                        var objectResponse = await ReadObjectResponseAsync<ContentAnalysisRatingDistributionLiveResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<ContentAnalysisPhraseTrendsLiveResponseInfo> PhraseTrendsLiveAsync(IEnumerable<ContentAnalysisPhraseTrendsLiveRequestInfo> payload)
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
                var path = "/v3/content_analysis/phrase_trends/live";
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
                        var objectResponse = await ReadObjectResponseAsync<ContentAnalysisPhraseTrendsLiveResponseInfo>(response, headers).ConfigureAwait(false);
                        return objectResponse.Object;
                    }

                    var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    throw new ApiException("The HTTP status code of the response was not expected (" + status + ").", status, responseData, headers, null);
                }
            }
        }
        public virtual async Task<ContentAnalysisCategoryTrendsLiveResponseInfo> CategoryTrendsLiveAsync(IEnumerable<ContentAnalysisCategoryTrendsLiveRequestInfo> payload)
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
                var path = "/v3/content_analysis/category_trends/live";
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
                        var objectResponse = await ReadObjectResponseAsync<ContentAnalysisCategoryTrendsLiveResponseInfo>(response, headers).ConfigureAwait(false);
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