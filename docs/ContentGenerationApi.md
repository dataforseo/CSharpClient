# ContentGenerationApi

All URIs are relative to *https://api.dataforseo.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
[**generateLive**](ContentGenerationApi.md#generateLive) | **POST**  /v3/content_generation/generate/live  |
[**generateTextLive**](ContentGenerationApi.md#generateTextLive) | **POST**  /v3/content_generation/generate_text/live  |
[**generateMetaTagsLive**](ContentGenerationApi.md#generateMetaTagsLive) | **POST**  /v3/content_generation/generate_meta_tags/live  |
[**generateSubTopicsLive**](ContentGenerationApi.md#generateSubTopicsLive) | **POST**  /v3/content_generation/generate_sub_topics/live  |
[**paraphraseLive**](ContentGenerationApi.md#paraphraseLive) | **POST**  /v3/content_generation/paraphrase/live  |
[**checkGrammarLive**](ContentGenerationApi.md#checkGrammarLive) | **POST**  /v3/content_generation/check_grammar/live  |
[**contentGenerationCheckGrammarLanguages**](ContentGenerationApi.md#contentGenerationCheckGrammarLanguages) | **GET**  /v3/content_generation/check_grammar/languages  |
[**grammarRules**](ContentGenerationApi.md#grammarRules) | **GET**  /v3/content_generation/grammar_rules  |
[**textSummaryLive**](ContentGenerationApi.md#textSummaryLive) | **POST**  /v3/content_generation/text_summary/live  |
[**contentGenerationTextSummaryLanguages**](ContentGenerationApi.md#contentGenerationTextSummaryLanguages) | **GET**  /v3/content_generation/text_summary/languages  |

<a id="generateLive"></a>
# **generateLive**
> ContentGenerationGenerateLiveResponseInfo generateLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentGenerationApi.GenerateLiveAsync(new List<ContentGenerationGenerateLiveRequestInfo>()
{
    new()
    {
        Text = "SEO is",
        MaxNewTokens = 100,
        CreativityIndex = 1,
        AvoidStartingWords = new List<string>()
        {
            "SEO",
            "search engine optimization",
            "SEO is",
        },
        StopWords = new List<string>()
        {
            "123",
            "\n",
        },
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<ContentGenerationGenerateLiveRequestInfo>&gt;**](IEnumerable<ContentGenerationGenerateLiveRequestInfo>.md)|  | [optional] |



### Return type

[**ContentGenerationGenerateLiveResponseInfo**](ContentGenerationGenerateLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="generateTextLive"></a>
# **generateTextLive**
> ContentGenerationGenerateTextLiveResponseInfo generateTextLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentGenerationApi.GenerateTextLiveAsync(new List<ContentGenerationGenerateTextLiveRequestInfo>()
{
    new()
    {
        Topic = "Steve Jobs",
        WordCount = 50,
        SubTopics = new List<string>()
        {
            "Apple",
            "Pixar",
            "Amazing Products",
        },
        Description = "Take a closer look at Steve Jobs' life and his incredible impact on the tech industry, with a special focus on the development of the iPhone.",
        MetaKeywords = new List<string>()
        {
            "iPhone",
            "sell",
            "CEO",
        },
        CreativityIndex = 0.8,
        IncludeConclusion = true,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<ContentGenerationGenerateTextLiveRequestInfo>&gt;**](IEnumerable<ContentGenerationGenerateTextLiveRequestInfo>.md)|  | [optional] |



### Return type

[**ContentGenerationGenerateTextLiveResponseInfo**](ContentGenerationGenerateTextLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="generateMetaTagsLive"></a>
# **generateMetaTagsLive**
> ContentGenerationGenerateMetaTagsLiveResponseInfo generateMetaTagsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentGenerationApi.GenerateMetaTagsLiveAsync(new List<ContentGenerationGenerateMetaTagsLiveRequestInfo>()
{
    new()
    {
        Text = "The idea to develop an instrument for local SEO didn’t come to the GMB Crush CEO, Matteo Barletta, out of the blue. Having a huge interest in search engine optimization, Matteo has come a long way from being an SEO freelancer to launching his own agency, SEO Heroes. At some point, he and his team noticed that it was quite challenging to work with local SEO projects, especially those related to Google My Business listings. There were simply no tools that could streamline their work and provide the functionality the agency needed.\n\n“We started to develop the idea of ​​our tool capable of doing Google Business SEO audits, tracking stats, and generating business proposals at the same time.",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<ContentGenerationGenerateMetaTagsLiveRequestInfo>&gt;**](IEnumerable<ContentGenerationGenerateMetaTagsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**ContentGenerationGenerateMetaTagsLiveResponseInfo**](ContentGenerationGenerateMetaTagsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="generateSubTopicsLive"></a>
# **generateSubTopicsLive**
> ContentGenerationGenerateSubTopicsLiveResponseInfo generateSubTopicsLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentGenerationApi.GenerateSubTopicsLiveAsync(new List<ContentGenerationGenerateSubTopicsLiveRequestInfo>()
{
    new()
    {
        Topic = "Steve Jobs",
        CreativityIndex = 0.9,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<ContentGenerationGenerateSubTopicsLiveRequestInfo>&gt;**](IEnumerable<ContentGenerationGenerateSubTopicsLiveRequestInfo>.md)|  | [optional] |



### Return type

[**ContentGenerationGenerateSubTopicsLiveResponseInfo**](ContentGenerationGenerateSubTopicsLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="paraphraseLive"></a>
# **paraphraseLive**
> ContentGenerationParaphraseLiveResponseInfo paraphraseLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentGenerationApi.ParaphraseLiveAsync(new List<ContentGenerationParaphraseLiveRequestInfo>()
{
    new()
    {
        Text = "The idea to develop an instrument for local SEO didn’t come to the GMB Crush CEO, Matteo Barletta, out of the blue. Having a huge interest in search engine optimization, Matteo has come a long way from being an SEO freelancer to launching his own agency, SEO Heroes. At some point, he and his team noticed that it was quite challenging to work with local SEO projects, especially those related to Google My Business listings.",
        CreativityIndex = 0.8,
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<ContentGenerationParaphraseLiveRequestInfo>&gt;**](IEnumerable<ContentGenerationParaphraseLiveRequestInfo>.md)|  | [optional] |



### Return type

[**ContentGenerationParaphraseLiveResponseInfo**](ContentGenerationParaphraseLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="checkGrammarLive"></a>
# **checkGrammarLive**
> ContentGenerationCheckGrammarLiveResponseInfo checkGrammarLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentGenerationApi.CheckGrammarLiveAsync(new List<ContentGenerationCheckGrammarLiveRequestInfo>()
{
    new()
    {
        Text = "Hello, my name is John! And I'm very glad to work with you toda",
        LanguageCode = "en-US",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<ContentGenerationCheckGrammarLiveRequestInfo>&gt;**](IEnumerable<ContentGenerationCheckGrammarLiveRequestInfo>.md)|  | [optional] |



### Return type

[**ContentGenerationCheckGrammarLiveResponseInfo**](ContentGenerationCheckGrammarLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="contentGenerationCheckGrammarLanguages"></a>
# **contentGenerationCheckGrammarLanguages**
> ContentGenerationCheckGrammarLanguagesResponseInfo contentGenerationCheckGrammarLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentGenerationApi.ContentGenerationCheckGrammarLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**ContentGenerationCheckGrammarLanguagesResponseInfo**](ContentGenerationCheckGrammarLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="grammarRules"></a>
# **grammarRules**
> ContentGenerationGrammarRulesResponseInfo grammarRules()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentGenerationApi.GrammarRulesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**ContentGenerationGrammarRulesResponseInfo**](ContentGenerationGrammarRulesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="textSummaryLive"></a>
# **textSummaryLive**
> ContentGenerationTextSummaryLiveResponseInfo textSummaryLive()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentGenerationApi.TextSummaryLiveAsync(new List<ContentGenerationTextSummaryLiveRequestInfo>()
{
    new()
    {
        Text = "Removing [RequireHttps] does nothing but break the https redirection, and doesn't enforce an https url on my route. I've got one method which i want to expose over http and a different one over https. If i accidentally enter http in my url for the https-only method, it should redirect. It currently works as is, the problem is that there is an undocument (seemingly unrelated) setting I have to add to get it all working. And that is the SslPort thing",
        LanguageName = "English (United States)",
    }
});
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<ContentGenerationTextSummaryLiveRequestInfo>&gt;**](IEnumerable<ContentGenerationTextSummaryLiveRequestInfo>.md)|  | [optional] |



### Return type

[**ContentGenerationTextSummaryLiveResponseInfo**](ContentGenerationTextSummaryLiveResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="contentGenerationTextSummaryLanguages"></a>
# **contentGenerationTextSummaryLanguages**
> ContentGenerationTextSummaryLanguagesResponseInfo contentGenerationTextSummaryLanguages()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.ContentGenerationApi.ContentGenerationTextSummaryLanguagesAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**ContentGenerationTextSummaryLanguagesResponseInfo**](ContentGenerationTextSummaryLanguagesResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |