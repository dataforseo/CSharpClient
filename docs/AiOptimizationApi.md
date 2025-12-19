# AiOptimizationApi

All URIs are relative to *https://api.dataforseo.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
[**chatGptLlmScraperLocations**](AiOptimizationApi.md#chatGptLlmScraperLocations) | **GET**  /v3/ai_optimization/chat_gpt/llm_scraper/locations  |
[**chatGptLlmScraperLocationsCountry**](AiOptimizationApi.md#chatGptLlmScraperLocationsCountry) | **GET**  /v3/ai_optimization/chat_gpt/llm_scraper/locations/{country}  |
[**chatGptLlmScraperLanguages**](AiOptimizationApi.md#chatGptLlmScraperLanguages) | **GET**  /v3/ai_optimization/chat_gpt/llm_scraper/languages  |
[**chatGptLlmScraperTaskPost**](AiOptimizationApi.md#chatGptLlmScraperTaskPost) | **POST**  /v3/ai_optimization/chat_gpt/llm_scraper/task_post  |
[**chatGptLlmScraperTasksReady**](AiOptimizationApi.md#chatGptLlmScraperTasksReady) | **GET**  /v3/ai_optimization/chat_gpt/llm_scraper/tasks_ready  |
[**chatGptLlmScraperTaskGetAdvanced**](AiOptimizationApi.md#chatGptLlmScraperTaskGetAdvanced) | **GET**  /v3/ai_optimization/chat_gpt/llm_scraper/task_get/advanced/{id}  |
[**chatGptLlmScraperTaskGetHtml**](AiOptimizationApi.md#chatGptLlmScraperTaskGetHtml) | **GET**  /v3/ai_optimization/chat_gpt/llm_scraper/task_get/html/{id}  |
[**chatGptLlmScraperLiveAdvanced**](AiOptimizationApi.md#chatGptLlmScraperLiveAdvanced) | **POST**  /v3/ai_optimization/chat_gpt/llm_scraper/live/advanced  |
[**chatGptLlmScraperLiveHtml**](AiOptimizationApi.md#chatGptLlmScraperLiveHtml) | **POST**  /v3/ai_optimization/chat_gpt/llm_scraper/live/html  |
[**llmMentionsLocationsAndLanguages**](AiOptimizationApi.md#llmMentionsLocationsAndLanguages) | **GET**  /v3/ai_optimization/llm_mentions/locations_and_languages  |
[**llmMentionsAvailableFilters**](AiOptimizationApi.md#llmMentionsAvailableFilters) | **GET**  /v3/ai_optimization/llm_mentions/available_filters  |
[**llmMentionsSearchLive**](AiOptimizationApi.md#llmMentionsSearchLive) | **POST**  /v3/ai_optimization/llm_mentions/search/live  |
[**llmMentionsTopPagesLive**](AiOptimizationApi.md#llmMentionsTopPagesLive) | **POST**  /v3/ai_optimization/llm_mentions/top_pages/live  |
[**llmMentionsTopDomainsLive**](AiOptimizationApi.md#llmMentionsTopDomainsLive) | **POST**  /v3/ai_optimization/llm_mentions/top_domains/live  |
[**llmMentionsAggregatedMetricsLive**](AiOptimizationApi.md#llmMentionsAggregatedMetricsLive) | **POST**  /v3/ai_optimization/llm_mentions/aggregated_metrics/live  |
[**llmMentionsCrossAggregatedMetricsLive**](AiOptimizationApi.md#llmMentionsCrossAggregatedMetricsLive) | **POST**  /v3/ai_optimization/llm_mentions/cross_aggregated_metrics/live  |
[**chatGptLlmResponsesModels**](AiOptimizationApi.md#chatGptLlmResponsesModels) | **GET**  /v3/ai_optimization/chat_gpt/llm_responses/models  |
[**chatGptLlmResponsesLive**](AiOptimizationApi.md#chatGptLlmResponsesLive) | **POST**  /v3/ai_optimization/chat_gpt/llm_responses/live  |
[**chatGptLlmResponsesTaskPost**](AiOptimizationApi.md#chatGptLlmResponsesTaskPost) | **POST**  /v3/ai_optimization/chat_gpt/llm_responses/task_post  |
[**chatGptLlmResponsesTasksReady**](AiOptimizationApi.md#chatGptLlmResponsesTasksReady) | **GET**  /v3/ai_optimization/chat_gpt/llm_responses/tasks_ready  |
[**chatGptLlmResponsesTaskGet**](AiOptimizationApi.md#chatGptLlmResponsesTaskGet) | **GET**  /v3/ai_optimization/chat_gpt/llm_responses/task_get/{id}  |
[**claudeLlmResponsesModels**](AiOptimizationApi.md#claudeLlmResponsesModels) | **GET**  /v3/ai_optimization/claude/llm_responses/models  |
[**claudeLlmResponsesLive**](AiOptimizationApi.md#claudeLlmResponsesLive) | **POST**  /v3/ai_optimization/claude/llm_responses/live  |
[**claudeLlmResponsesTaskPost**](AiOptimizationApi.md#claudeLlmResponsesTaskPost) | **POST**  /v3/ai_optimization/claude/llm_responses/task_post  |
[**claudeLlmResponsesTasksReady**](AiOptimizationApi.md#claudeLlmResponsesTasksReady) | **GET**  /v3/ai_optimization/claude/llm_responses/tasks_ready  |
[**claudeLlmResponsesTaskGet**](AiOptimizationApi.md#claudeLlmResponsesTaskGet) | **GET**  /v3/ai_optimization/claude/llm_responses/task_get/{id}  |
[**geminiLlmResponsesModels**](AiOptimizationApi.md#geminiLlmResponsesModels) | **GET**  /v3/ai_optimization/gemini/llm_responses/models  |
[**geminiLlmResponsesTaskPost**](AiOptimizationApi.md#geminiLlmResponsesTaskPost) | **POST**  /v3/ai_optimization/gemini/llm_responses/task_post  |
[**geminiLlmResponsesTasksReady**](AiOptimizationApi.md#geminiLlmResponsesTasksReady) | **GET**  /v3/ai_optimization/gemini/llm_responses/tasks_ready  |
[**geminiLlmResponsesTaskGet**](AiOptimizationApi.md#geminiLlmResponsesTaskGet) | **GET**  /v3/ai_optimization/gemini/llm_responses/task_get/{id}  |
[**geminiLlmResponsesLive**](AiOptimizationApi.md#geminiLlmResponsesLive) | **POST**  /v3/ai_optimization/gemini/llm_responses/live  |
[**perplexityLlmResponsesModels**](AiOptimizationApi.md#perplexityLlmResponsesModels) | **GET**  /v3/ai_optimization/perplexity/llm_responses/models  |
[**perplexityLlmResponsesLive**](AiOptimizationApi.md#perplexityLlmResponsesLive) | **POST**  /v3/ai_optimization/perplexity/llm_responses/live  |
[**aiKeywordDataAvailableFilters**](AiOptimizationApi.md#aiKeywordDataAvailableFilters) | **GET**  /v3/ai_optimization/ai_keyword_data/available_filters  |
[**aiKeywordDataLocationsAndLanguages**](AiOptimizationApi.md#aiKeywordDataLocationsAndLanguages) | **GET**  /v3/ai_optimization/ai_keyword_data/locations_and_languages  |
[**aiKeywordDataKeywordsSearchVolumeLive**](AiOptimizationApi.md#aiKeywordDataKeywordsSearchVolumeLive) | **POST**  /v3/ai_optimization/ai_keyword_data/keywords_search_volume/live  |

<a id="chatGptLlmScraperLocations"></a>
# **chatGptLlmScraperLocations**
> AiOptimizationChatGptLlmScraperLocationsResponseInfo chatGptLlmScraperLocations()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ChatGptLlmScraperLocationsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationChatGptLlmScraperLocationsResponseInfo**](AiOptimizationChatGptLlmScraperLocationsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="chatGptLlmScraperLocationsCountry"></a>
# **chatGptLlmScraperLocationsCountry**
> AiOptimizationChatGptLlmScraperLocationsCountryResponseInfo chatGptLlmScraperLocationsCountry()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var country = "us";
var result = await dfsClient.AiOptimizationApi.ChatGptLlmScraperLocationsCountryAsync(country);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationChatGptLlmScraperLocationsCountryResponseInfo**](AiOptimizationChatGptLlmScraperLocationsCountryResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="chatGptLlmScraperLanguages"></a>
# **chatGptLlmScraperLanguages**
> AiOptimizationChatGptLlmScraperLanguagesResponseInfo chatGptLlmScraperLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ChatGptLlmScraperLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationChatGptLlmScraperLanguagesResponseInfo**](AiOptimizationChatGptLlmScraperLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="chatGptLlmScraperTaskPost"></a>
# **chatGptLlmScraperTaskPost**
> AiOptimizationChatGptLlmScraperTaskPostResponseInfo chatGptLlmScraperTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ChatGptLlmScraperTaskPostAsync(
    new AiOptimizationChatGptLlmScraperTaskPostRequestInfo[]
    {
        new AiOptimizationChatGptLlmScraperTaskPostRequestInfo()
        {
            LanguageCode = "en",
            LocationCode = 2840,
            Keyword = "what is chatgpt",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AiOptimizationChatGptLlmScraperTaskPostRequestInfo>&gt;**](IEnumerable<AiOptimizationChatGptLlmScraperTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**AiOptimizationChatGptLlmScraperTaskPostResponseInfo**](AiOptimizationChatGptLlmScraperTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="chatGptLlmScraperTasksReady"></a>
# **chatGptLlmScraperTasksReady**
> AiOptimizationChatGptLlmScraperTasksReadyResponseInfo chatGptLlmScraperTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ChatGptLlmScraperTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationChatGptLlmScraperTasksReadyResponseInfo**](AiOptimizationChatGptLlmScraperTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="chatGptLlmScraperTaskGetAdvanced"></a>
# **chatGptLlmScraperTaskGetAdvanced**
> AiOptimizationChatGptLlmScraperTaskGetAdvancedResponseInfo chatGptLlmScraperTaskGetAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AiOptimizationApi.ChatGptLlmScraperTaskGetAdvancedAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationChatGptLlmScraperTaskGetAdvancedResponseInfo**](AiOptimizationChatGptLlmScraperTaskGetAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="chatGptLlmScraperTaskGetHtml"></a>
# **chatGptLlmScraperTaskGetHtml**
> AiOptimizationChatGptLlmScraperTaskGetHtmlResponseInfo chatGptLlmScraperTaskGetHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AiOptimizationApi.ChatGptLlmScraperTaskGetHtmlAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationChatGptLlmScraperTaskGetHtmlResponseInfo**](AiOptimizationChatGptLlmScraperTaskGetHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="chatGptLlmScraperLiveAdvanced"></a>
# **chatGptLlmScraperLiveAdvanced**
> AiOptimizationChatGptLlmScraperLiveAdvancedResponseInfo chatGptLlmScraperLiveAdvanced()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ChatGptLlmScraperLiveAdvancedAsync(
    new AiOptimizationChatGptLlmScraperLiveAdvancedRequestInfo[]
    {
        new AiOptimizationChatGptLlmScraperLiveAdvancedRequestInfo()
        {
            LanguageCode = "en",
            LocationCode = 2840,
            Keyword = "albert einstein",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AiOptimizationChatGptLlmScraperLiveAdvancedRequestInfo>&gt;**](IEnumerable<AiOptimizationChatGptLlmScraperLiveAdvancedRequestInfo>.md)|  | [optional] |



### Return type

[**AiOptimizationChatGptLlmScraperLiveAdvancedResponseInfo**](AiOptimizationChatGptLlmScraperLiveAdvancedResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="chatGptLlmScraperLiveHtml"></a>
# **chatGptLlmScraperLiveHtml**
> AiOptimizationChatGptLlmScraperLiveHtmlResponseInfo chatGptLlmScraperLiveHtml()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ChatGptLlmScraperLiveHtmlAsync(
    new AiOptimizationChatGptLlmScraperLiveHtmlRequestInfo[]
    {
        new AiOptimizationChatGptLlmScraperLiveHtmlRequestInfo()
        {
            LanguageCode = "en",
            LocationCode = 2840,
            Keyword = "albert einstein",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AiOptimizationChatGptLlmScraperLiveHtmlRequestInfo>&gt;**](IEnumerable<AiOptimizationChatGptLlmScraperLiveHtmlRequestInfo>.md)|  | [optional] |



### Return type

[**AiOptimizationChatGptLlmScraperLiveHtmlResponseInfo**](AiOptimizationChatGptLlmScraperLiveHtmlResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="llmMentionsLocationsAndLanguages"></a>
# **llmMentionsLocationsAndLanguages**
> AiOptimizationLlmMentionsLocationsAndLanguagesResponseInfo llmMentionsLocationsAndLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.LlmMentionsLocationsAndLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationLlmMentionsLocationsAndLanguagesResponseInfo**](AiOptimizationLlmMentionsLocationsAndLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="llmMentionsAvailableFilters"></a>
# **llmMentionsAvailableFilters**
> AiOptimizationLlmMentionsAvailableFiltersResponseInfo llmMentionsAvailableFilters()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.LlmMentionsAvailableFiltersAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationLlmMentionsAvailableFiltersResponseInfo**](AiOptimizationLlmMentionsAvailableFiltersResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="llmMentionsSearchLive"></a>
# **llmMentionsSearchLive**
> AiOptimizationLlmMentionsSearchLiveResponseInfo llmMentionsSearchLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.LlmMentionsSearchLiveAsync(
    new AiOptimizationLlmMentionsSearchLiveRequestInfo[]
    {
        new AiOptimizationLlmMentionsSearchLiveRequestInfo()
        {
            LanguageName = "English",
            LocationCode = 2840,
            Target = new BaseAiOptimizationLLmMentionsTargetElement[]
        {
            new AiOptimizationLLmMentionsDomainElement()
            {
                Domain = "dataforseo.com",
                SearchFilter = "exclude",
            },
            new AiOptimizationLLmMentionsKeywordElement()
            {
                Keyword = "bmw",
                SearchScope = new string[]
            {
                "answer",
            },
            },
        },
            Platform = "google",
            Filters = new object[]
        {
            new object[]
            {
                "ai_search_volume",
                ">",
                1000,
            },
        },
            OrderBy = new string[]
        {
            "ai_search_volume,desc",
        },
            Offset = 0,
            Limit = 3,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AiOptimizationLlmMentionsSearchLiveRequestInfo>&gt;**](IEnumerable<AiOptimizationLlmMentionsSearchLiveRequestInfo>.md)|  | [optional] |



### Return type

[**AiOptimizationLlmMentionsSearchLiveResponseInfo**](AiOptimizationLlmMentionsSearchLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="llmMentionsTopPagesLive"></a>
# **llmMentionsTopPagesLive**
> AiOptimizationLlmMentionsTopPagesLiveResponseInfo llmMentionsTopPagesLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.LlmMentionsTopPagesLiveAsync(
    new AiOptimizationLlmMentionsTopPagesLiveRequestInfo[]
    {
        new AiOptimizationLlmMentionsTopPagesLiveRequestInfo()
        {
            LanguageCode = "en",
            LocationCode = 2840,
            Platform = "google",
            Target = new AiOptimizationLLmMentionsKeywordElement[]
        {
            new AiOptimizationLLmMentionsKeywordElement()
            {
                Keyword = "bmw",
                SearchScope = new string[]
            {
                "answer",
            },
            },
            new AiOptimizationLLmMentionsKeywordElement()
            {
                Keyword = "auto",
                SearchScope = new string[]
            {
                "question",
            },
                MatchType = "partial_match",
            },
        },
            LinksScope = "sources",
            InitialDatasetFilters = new object[]
        {
            new object[]
            {
                "ai_search_volume",
                ">",
                10,
            },
        },
            ItemsListLimit = 3,
            InternalListLimit = 2,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AiOptimizationLlmMentionsTopPagesLiveRequestInfo>&gt;**](IEnumerable<AiOptimizationLlmMentionsTopPagesLiveRequestInfo>.md)|  | [optional] |



### Return type

[**AiOptimizationLlmMentionsTopPagesLiveResponseInfo**](AiOptimizationLlmMentionsTopPagesLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="llmMentionsTopDomainsLive"></a>
# **llmMentionsTopDomainsLive**
> AiOptimizationLlmMentionsTopDomainsLiveResponseInfo llmMentionsTopDomainsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.LlmMentionsTopDomainsLiveAsync(
    new AiOptimizationLlmMentionsTopDomainsLiveRequestInfo[]
    {
        new AiOptimizationLlmMentionsTopDomainsLiveRequestInfo()
        {
            LanguageCode = "en",
            LocationCode = 2840,
            Platform = "chat_gpt",
            Target = new AiOptimizationLLmMentionsKeywordElement[]
        {
            new AiOptimizationLLmMentionsKeywordElement()
            {
                Keyword = "bmw",
                SearchScope = new string[]
            {
                "answer",
            },
            },
            new AiOptimizationLLmMentionsKeywordElement()
            {
                Keyword = "auto",
                SearchScope = new string[]
            {
                "question",
            },
                MatchType = "partial_match",
            },
        },
            LinksScope = "sources",
            InitialDatasetFilters = new object[]
        {
            new object[]
            {
                "ai_search_volume",
                ">",
                10,
            },
        },
            ItemsListLimit = 3,
            InternalListLimit = 2,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AiOptimizationLlmMentionsTopDomainsLiveRequestInfo>&gt;**](IEnumerable<AiOptimizationLlmMentionsTopDomainsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**AiOptimizationLlmMentionsTopDomainsLiveResponseInfo**](AiOptimizationLlmMentionsTopDomainsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="llmMentionsAggregatedMetricsLive"></a>
# **llmMentionsAggregatedMetricsLive**
> AiOptimizationLlmMentionsAggregatedMetricsLiveResponseInfo llmMentionsAggregatedMetricsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.LlmMentionsAggregatedMetricsLiveAsync(
    new AiOptimizationLlmMentionsAggregatedMetricsLiveRequestInfo[]
    {
        new AiOptimizationLlmMentionsAggregatedMetricsLiveRequestInfo()
        {
            LanguageCode = "es",
            LocationCode = 2840,
            Platform = "google",
            Target = new BaseAiOptimizationLLmMentionsTargetElement[]
        {
            new AiOptimizationLLmMentionsDomainElement()
            {
                Domain = "en.wikipedia.org",
                SearchFilter = "exclude",
            },
            new AiOptimizationLLmMentionsKeywordElement()
            {
                Keyword = "bmw",
                SearchScope = new string[]
            {
                "answer",
            },
            },
        },
            InitialDatasetFilters = new object[]
        {
            new object[]
            {
                "ai_search_volume",
                ">",
                10,
            },
        },
            InternalListLimit = 10,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AiOptimizationLlmMentionsAggregatedMetricsLiveRequestInfo>&gt;**](IEnumerable<AiOptimizationLlmMentionsAggregatedMetricsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**AiOptimizationLlmMentionsAggregatedMetricsLiveResponseInfo**](AiOptimizationLlmMentionsAggregatedMetricsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="llmMentionsCrossAggregatedMetricsLive"></a>
# **llmMentionsCrossAggregatedMetricsLive**
> AiOptimizationLlmMentionsCrossAggregatedMetricsLiveResponseInfo llmMentionsCrossAggregatedMetricsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.LlmMentionsCrossAggregatedMetricsLiveAsync(
    new AiOptimizationLlmMentionsCrossAggregatedMetricsLiveRequestInfo[]
    {
        new AiOptimizationLlmMentionsCrossAggregatedMetricsLiveRequestInfo()
        {
            LanguageCode = "en",
            LocationCode = 2840,
            Platform = "google",
            Targets = new AiOptimizationLLmMentionsCrossAggregateMetricsTargetInfo[]
        {
            new AiOptimizationLLmMentionsCrossAggregateMetricsTargetInfo()
            {
                AggregationKey = "chat_gpt",
                Target = new AiOptimizationLLmMentionsKeywordElement[]
            {
                new AiOptimizationLLmMentionsKeywordElement()
                {
                    Keyword = "chat gpt",
                },
            },
            },
            new AiOptimizationLLmMentionsCrossAggregateMetricsTargetInfo()
            {
                AggregationKey = "claude",
                Target = new AiOptimizationLLmMentionsKeywordElement[]
            {
                new AiOptimizationLLmMentionsKeywordElement()
                {
                    Keyword = "claude",
                },
            },
            },
            new AiOptimizationLLmMentionsCrossAggregateMetricsTargetInfo()
            {
                AggregationKey = "gemini",
                Target = new AiOptimizationLLmMentionsKeywordElement[]
            {
                new AiOptimizationLLmMentionsKeywordElement()
                {
                    Keyword = "gemini",
                },
            },
            },
            new AiOptimizationLLmMentionsCrossAggregateMetricsTargetInfo()
            {
                AggregationKey = "perplexity",
                Target = new AiOptimizationLLmMentionsKeywordElement[]
            {
                new AiOptimizationLLmMentionsKeywordElement()
                {
                    Keyword = "perplexity",
                    SearchFilter = "include",
                },
            },
            },
        },
            InitialDatasetFilters = new object[]
        {
            new object[]
            {
                "ai_search_volume",
                ">",
                10,
            },
        },
            InternalListLimit = 5,
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AiOptimizationLlmMentionsCrossAggregatedMetricsLiveRequestInfo>&gt;**](IEnumerable<AiOptimizationLlmMentionsCrossAggregatedMetricsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**AiOptimizationLlmMentionsCrossAggregatedMetricsLiveResponseInfo**](AiOptimizationLlmMentionsCrossAggregatedMetricsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="chatGptLlmResponsesModels"></a>
# **chatGptLlmResponsesModels**
> AiOptimizationChatGptLlmResponsesModelsResponseInfo chatGptLlmResponsesModels()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ChatGptLlmResponsesModelsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationChatGptLlmResponsesModelsResponseInfo**](AiOptimizationChatGptLlmResponsesModelsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="chatGptLlmResponsesLive"></a>
# **chatGptLlmResponsesLive**
> AiOptimizationChatGptLlmResponsesLiveResponseInfo chatGptLlmResponsesLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ChatGptLlmResponsesLiveAsync(
    new AiOptimizationChatGptLlmResponsesLiveRequestInfo[]
    {
        new AiOptimizationChatGptLlmResponsesLiveRequestInfo()
        {
            SystemMessage = "communicate as if we are in a business meeting",
            MessageChain = new LlmMessageChainItem[]
        {
            new LlmMessageChainItem()
            {
                Role = "user",
                Message = "Hello, what’s up?",
            },
            new LlmMessageChainItem()
            {
                Role = "ai",
                Message = "Hello! I’m doing well, thank you. How can I assist you today? Are there any specific topics or projects you’d like to discuss in our meeting?",
            },
        },
            MaxOutputTokens = 200,
            Temperature = 0.3,
            TopP = 0.5,
            ModelName = "gpt-4.1-mini",
            WebSearch = true,
            WebSearchCountryIsoCode = "FR",
            WebSearchCity = "Paris",
            UserPrompt = "provide information on how relevant the amusement park business is in France now",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AiOptimizationChatGptLlmResponsesLiveRequestInfo>&gt;**](IEnumerable<AiOptimizationChatGptLlmResponsesLiveRequestInfo>.md)|  | [optional] |



### Return type

[**AiOptimizationChatGptLlmResponsesLiveResponseInfo**](AiOptimizationChatGptLlmResponsesLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="chatGptLlmResponsesTaskPost"></a>
# **chatGptLlmResponsesTaskPost**
> AiOptimizationChatGptLlmResponsesTaskPostResponseInfo chatGptLlmResponsesTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ChatGptLlmResponsesTaskPostAsync(
    new AiOptimizationChatGptLlmResponsesTaskPostRequestInfo[]
    {
        new AiOptimizationChatGptLlmResponsesTaskPostRequestInfo()
        {
            SystemMessage = "communicate as if we are in a business meeting",
            MessageChain = new LlmMessageChainItem[]
        {
            new LlmMessageChainItem()
            {
                Role = "user",
                Message = "Hello, what’s up?",
            },
            new LlmMessageChainItem()
            {
                Role = "ai",
                Message = "Hello! I’m doing well, thank you. How can I assist you today? Are there any specific topics or projects you’d like to discuss in our meeting?",
            },
        },
            ModelName = "gpt-4.1-mini",
            UserPrompt = "provide information on how relevant the amusement park business is in France now",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AiOptimizationChatGptLlmResponsesTaskPostRequestInfo>&gt;**](IEnumerable<AiOptimizationChatGptLlmResponsesTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**AiOptimizationChatGptLlmResponsesTaskPostResponseInfo**](AiOptimizationChatGptLlmResponsesTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="chatGptLlmResponsesTasksReady"></a>
# **chatGptLlmResponsesTasksReady**
> AiOptimizationChatGptLlmResponsesTasksReadyResponseInfo chatGptLlmResponsesTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ChatGptLlmResponsesTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationChatGptLlmResponsesTasksReadyResponseInfo**](AiOptimizationChatGptLlmResponsesTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="chatGptLlmResponsesTaskGet"></a>
# **chatGptLlmResponsesTaskGet**
> AiOptimizationChatGptLlmResponsesTaskGetResponseInfo chatGptLlmResponsesTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AiOptimizationApi.ChatGptLlmResponsesTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationChatGptLlmResponsesTaskGetResponseInfo**](AiOptimizationChatGptLlmResponsesTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="claudeLlmResponsesModels"></a>
# **claudeLlmResponsesModels**
> AiOptimizationClaudeLlmResponsesModelsResponseInfo claudeLlmResponsesModels()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ClaudeLlmResponsesModelsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationClaudeLlmResponsesModelsResponseInfo**](AiOptimizationClaudeLlmResponsesModelsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="claudeLlmResponsesLive"></a>
# **claudeLlmResponsesLive**
> AiOptimizationClaudeLlmResponsesLiveResponseInfo claudeLlmResponsesLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ClaudeLlmResponsesLiveAsync(
    new AiOptimizationClaudeLlmResponsesLiveRequestInfo[]
    {
        new AiOptimizationClaudeLlmResponsesLiveRequestInfo()
        {
            SystemMessage = "communicate as if we are in a business meeting",
            MessageChain = new LlmMessageChainItem[]
        {
            new LlmMessageChainItem()
            {
                Role = "user",
                Message = "Hello, what’s up?",
            },
            new LlmMessageChainItem()
            {
                Role = "ai",
                Message = "Hello! I’m doing well, thank you. How can I assist you today? Are there any specific topics or projects you’d like to discuss in our meeting?",
            },
        },
            MaxOutputTokens = 200,
            ModelName = "claude-opus-4-0",
            Temperature = 0.3,
            TopP = 0.5,
            WebSearch = true,
            WebSearchCountryIsoCode = "FR",
            UserPrompt = "provide information on how relevant the amusement park business is in France now",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AiOptimizationClaudeLlmResponsesLiveRequestInfo>&gt;**](IEnumerable<AiOptimizationClaudeLlmResponsesLiveRequestInfo>.md)|  | [optional] |



### Return type

[**AiOptimizationClaudeLlmResponsesLiveResponseInfo**](AiOptimizationClaudeLlmResponsesLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="claudeLlmResponsesTaskPost"></a>
# **claudeLlmResponsesTaskPost**
> AiOptimizationClaudeLlmResponsesTaskPostResponseInfo claudeLlmResponsesTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ClaudeLlmResponsesTaskPostAsync(
    new AiOptimizationClaudeLlmResponsesTaskPostRequestInfo[]
    {
        new AiOptimizationClaudeLlmResponsesTaskPostRequestInfo()
        {
            SystemMessage = "communicate as if we are in a business meeting",
            MessageChain = new LlmMessageChainItem[]
        {
            new LlmMessageChainItem()
            {
                Role = "user",
                Message = "Hello, what’s up?",
            },
            new LlmMessageChainItem()
            {
                Role = "ai",
                Message = "Hello! I’m doing well, thank you. How can I assist you today? Are there any specific topics or projects you’d like to discuss in our meeting?",
            },
        },
            MaxOutputTokens = 1024,
            Temperature = 0.3,
            TopP = 0.5,
            WebSearchCountryIsoCode = "FR",
            ModelName = "claude-sonnet-4-0",
            WebSearch = true,
            UserPrompt = "provide information on how relevant the amusement park business is in France now",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AiOptimizationClaudeLlmResponsesTaskPostRequestInfo>&gt;**](IEnumerable<AiOptimizationClaudeLlmResponsesTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**AiOptimizationClaudeLlmResponsesTaskPostResponseInfo**](AiOptimizationClaudeLlmResponsesTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="claudeLlmResponsesTasksReady"></a>
# **claudeLlmResponsesTasksReady**
> AiOptimizationClaudeLlmResponsesTasksReadyResponseInfo claudeLlmResponsesTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.ClaudeLlmResponsesTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationClaudeLlmResponsesTasksReadyResponseInfo**](AiOptimizationClaudeLlmResponsesTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="claudeLlmResponsesTaskGet"></a>
# **claudeLlmResponsesTaskGet**
> AiOptimizationClaudeLlmResponsesTaskGetResponseInfo claudeLlmResponsesTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AiOptimizationApi.ClaudeLlmResponsesTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationClaudeLlmResponsesTaskGetResponseInfo**](AiOptimizationClaudeLlmResponsesTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="geminiLlmResponsesModels"></a>
# **geminiLlmResponsesModels**
> AiOptimizationGeminiLlmResponsesModelsResponseInfo geminiLlmResponsesModels()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.GeminiLlmResponsesModelsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationGeminiLlmResponsesModelsResponseInfo**](AiOptimizationGeminiLlmResponsesModelsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="geminiLlmResponsesTaskPost"></a>
# **geminiLlmResponsesTaskPost**
> AiOptimizationGeminiLlmResponsesTaskPostResponseInfo geminiLlmResponsesTaskPost()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.GeminiLlmResponsesTaskPostAsync(
    new AiOptimizationGeminiLlmResponsesTaskPostRequestInfo[]
    {
        new AiOptimizationGeminiLlmResponsesTaskPostRequestInfo()
        {
            SystemMessage = "communicate as if we are in a business meeting",
            MessageChain = new LlmMessageChainItem[]
        {
            new LlmMessageChainItem()
            {
                Role = "user",
                Message = "Hello, what’s up?",
            },
            new LlmMessageChainItem()
            {
                Role = "ai",
                Message = "Hello! I’m doing well, thank you. How can I assist you today? Are there any specific topics or projects you’d like to discuss in our meeting?",
            },
        },
            ModelName = "gemini-2.5-flash",
            UserPrompt = "provide information on how relevant the amusement park business is in France now",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AiOptimizationGeminiLlmResponsesTaskPostRequestInfo>&gt;**](IEnumerable<AiOptimizationGeminiLlmResponsesTaskPostRequestInfo>.md)|  | [optional] |



### Return type

[**AiOptimizationGeminiLlmResponsesTaskPostResponseInfo**](AiOptimizationGeminiLlmResponsesTaskPostResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="geminiLlmResponsesTasksReady"></a>
# **geminiLlmResponsesTasksReady**
> AiOptimizationGeminiLlmResponsesTasksReadyResponseInfo geminiLlmResponsesTasksReady()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.GeminiLlmResponsesTasksReadyAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationGeminiLlmResponsesTasksReadyResponseInfo**](AiOptimizationGeminiLlmResponsesTasksReadyResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="geminiLlmResponsesTaskGet"></a>
# **geminiLlmResponsesTaskGet**
> AiOptimizationGeminiLlmResponsesTaskGetResponseInfo geminiLlmResponsesTaskGet()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var id = "00000000-0000-0000-0000-000000000000";
var result = await dfsClient.AiOptimizationApi.GeminiLlmResponsesTaskGetAsync(id);
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationGeminiLlmResponsesTaskGetResponseInfo**](AiOptimizationGeminiLlmResponsesTaskGetResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="geminiLlmResponsesLive"></a>
# **geminiLlmResponsesLive**
> AiOptimizationGeminiLlmResponsesLiveResponseInfo geminiLlmResponsesLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.GeminiLlmResponsesLiveAsync(
    new AiOptimizationGeminiLlmResponsesLiveRequestInfo[]
    {
        new AiOptimizationGeminiLlmResponsesLiveRequestInfo()
        {
            SystemMessage = "communicate as if we are in a business meeting",
            MessageChain = new LlmMessageChainItem[]
        {
            new LlmMessageChainItem()
            {
                Role = "user",
                Message = "Hello, what’s up?",
            },
            new LlmMessageChainItem()
            {
                Role = "ai",
                Message = "Hello! I’m doing well, thank you. How can I assist you today? Are there any specific topics or projects you’d like to discuss in our meeting?",
            },
        },
            MaxOutputTokens = 200,
            Temperature = 0.3,
            TopP = 0.5,
            ModelName = "gemini-2.5-flash",
            WebSearch = true,
            UserPrompt = "provide information on how relevant the amusement park business is in France now",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AiOptimizationGeminiLlmResponsesLiveRequestInfo>&gt;**](IEnumerable<AiOptimizationGeminiLlmResponsesLiveRequestInfo>.md)|  | [optional] |



### Return type

[**AiOptimizationGeminiLlmResponsesLiveResponseInfo**](AiOptimizationGeminiLlmResponsesLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="perplexityLlmResponsesModels"></a>
# **perplexityLlmResponsesModels**
> AiOptimizationPerplexityLlmResponsesModelsResponseInfo perplexityLlmResponsesModels()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.PerplexityLlmResponsesModelsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationPerplexityLlmResponsesModelsResponseInfo**](AiOptimizationPerplexityLlmResponsesModelsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="perplexityLlmResponsesLive"></a>
# **perplexityLlmResponsesLive**
> AiOptimizationPerplexityLlmResponsesLiveResponseInfo perplexityLlmResponsesLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.PerplexityLlmResponsesLiveAsync(
    new AiOptimizationPerplexityLlmResponsesLiveRequestInfo[]
    {
        new AiOptimizationPerplexityLlmResponsesLiveRequestInfo()
        {
            SystemMessage = "communicate as if we are in a business meeting",
            MessageChain = new LlmMessageChainItem[]
        {
            new LlmMessageChainItem()
            {
                Role = "user",
                Message = "Hello, what’s up?",
            },
            new LlmMessageChainItem()
            {
                Role = "ai",
                Message = "Hello! I’m doing well, thank you. How can I assist you today? Are there any specific topics or projects you’d like to discuss in our meeting?",
            },
        },
            MaxOutputTokens = 200,
            Temperature = 0.3,
            TopP = 0.5,
            WebSearchCountryIsoCode = "FR",
            ModelName = "sonar-reasoning",
            UserPrompt = "provide information on how relevant the amusement park business is in France now",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AiOptimizationPerplexityLlmResponsesLiveRequestInfo>&gt;**](IEnumerable<AiOptimizationPerplexityLlmResponsesLiveRequestInfo>.md)|  | [optional] |



### Return type

[**AiOptimizationPerplexityLlmResponsesLiveResponseInfo**](AiOptimizationPerplexityLlmResponsesLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="aiKeywordDataAvailableFilters"></a>
# **aiKeywordDataAvailableFilters**
> AiOptimizationAiKeywordDataAvailableFiltersResponseInfo aiKeywordDataAvailableFilters()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.AiKeywordDataAvailableFiltersAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationAiKeywordDataAvailableFiltersResponseInfo**](AiOptimizationAiKeywordDataAvailableFiltersResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="aiKeywordDataLocationsAndLanguages"></a>
# **aiKeywordDataLocationsAndLanguages**
> AiOptimizationAiKeywordDataLocationsAndLanguagesResponseInfo aiKeywordDataLocationsAndLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.AiKeywordDataLocationsAndLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AiOptimizationAiKeywordDataLocationsAndLanguagesResponseInfo**](AiOptimizationAiKeywordDataLocationsAndLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="aiKeywordDataKeywordsSearchVolumeLive"></a>
# **aiKeywordDataKeywordsSearchVolumeLive**
> AiOptimizationAiKeywordDataKeywordsSearchVolumeLiveResponseInfo aiKeywordDataKeywordsSearchVolumeLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AiOptimizationApi.AiKeywordDataKeywordsSearchVolumeLiveAsync(
    new AiOptimizationAiKeywordDataKeywordsSearchVolumeLiveRequestInfo[]
    {
        new AiOptimizationAiKeywordDataKeywordsSearchVolumeLiveRequestInfo()
        {
            LanguageName = "English",
            LocationCode = 2840,
            Keywords = new string[]
        {
            "iphone",
            "seo",
        },
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AiOptimizationAiKeywordDataKeywordsSearchVolumeLiveRequestInfo>&gt;**](IEnumerable<AiOptimizationAiKeywordDataKeywordsSearchVolumeLiveRequestInfo>.md)|  | [optional] |



### Return type

[**AiOptimizationAiKeywordDataKeywordsSearchVolumeLiveResponseInfo**](AiOptimizationAiKeywordDataKeywordsSearchVolumeLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |