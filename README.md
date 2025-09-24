## OVERVIEW

This is a C# client providing you, as a developer, with a tool for obtaining the necessary data from DataForSEO APIs. You don't have to figure out how to make a request and process a response - all that is readily available in this client.

[![GitHub issues](https://img.shields.io/github/issues/dataforseo/CSharpClient.svg)](https://github.com/dataforseo/CSharpClient/issues)
[![GitHub license](https://img.shields.io/github/license/dataforseo/CSharpClient.svg)](https://github.com/dataforseo/CSharpClient)

DataForSEO API uses REST technology for interchanging data between your application and our service. The data exchange is made through the widely used HTTP protocol, which allows using our API with almost any programming language.

Client contains 13 sections (aka APIs):

- AI Optimization API (source docs | api docs)
- SERP ([source docs](https://github.com/dataforseo/CSharpClient/tree/master/docs/SerpApi.md) | [api docs](https://docs.dataforseo.com/v3/serp/overview/?bash))
- Keywords Data ([source docs](https://github.com/dataforseo/CSharpClient/tree/master/docs/KeywordsDataApi.md) | [api docs](https://docs.dataforseo.com/v3/keywords_data/overview/?bash))
- Domain Analytics ([source docs](https://github.com/dataforseo/CSharpClient/tree/master/docs/DomainAnalyticsApi.md) | [api docs](https://docs.dataforseo.com/v3/domain_analytics/overview/?bash))
- DataForSEO Labs ([source docs](https://github.com/dataforseo/CSharpClient/tree/master/docs/DataforseoLabsApi.md) | [api docs](https://docs.dataforseo.com/v3/dataforseo_labs/overview/?bash))
- Backlinks ([source docs](https://github.com/dataforseo/CSharpClient/tree/master/docs/BacklinksApi.md) | [api docs](https://docs.dataforseo.com/v3/backlinks/overview/?bash))
- OnPage ([source docs](https://github.com/dataforseo/CSharpClient/tree/master/docs/OnPageApi.md) | [api docs](https://docs.dataforseo.com/v3/on_page/overview/?bash))
- Content Analysis ([source docs](https://github.com/dataforseo/CSharpClient/tree/master/docs/ContentAnalysisApi.md) | [api docs](https://docs.dataforseo.com/v3/content_analysis/overview/?bash))
- Content Generation ([source docs](https://github.com/dataforseo/CSharpClient/tree/master/docs/ContentGenerationApi.md) | [api docs](https://docs.dataforseo.com/v3/content_generation/overview/?bash))
- Merchant ([source docs](https://github.com/dataforseo/CSharpClient/tree/master/docs/MerchantApi.md) | [api docs](https://docs.dataforseo.com/v3/merchant/overview/?bash))
- AppData ([source docs](https://github.com/dataforseo/CSharpClient/tree/master/docs/AppDataApi.md) | [api docs](https://docs.dataforseo.com/v3/app_data/overview/?bash))
- Business Data ([source docs](https://github.com/dataforseo/CSharpClient/tree/master/docs/BusinessDataApi.md) | [api docs](https://docs.dataforseo.com/v3/business_data/overview/?bash))
- Appendix ([source docs](https://github.com/dataforseo/CSharpClient/tree/master/docs/AppendixApi.md) | [api docs](https://docs.dataforseo.com/v3/appendix/user_data/?bash))

API Contains 2 types of requests:
1) Live (Simple HTTP request/response message)
2) Task-based (Requires sending a 'Task' entity to execute, waiting until the 'Task' status is ready, and getting the 'Task' result in a special endpoint. Usually, it is represented by 3 types of endpoints: 'TaskPost', 'TaskReady', and 'TaskGet')

For more details, please follow [here](https://docs.dataforseo.com/v3/?bash)

## YAML Spec

Our API description is based on the OpenAPI [syntax](https://spec.openapis.org/oas/v3.1.0) in YAML format. The YAML file attached to the project with the name [here](https://github.com/dataforseo/OpenApiDocumentation)

## Code generation

Code generated using the [NSwag lib](https://github.com/RicoSuter/NSwag)

## Documentation
The documentation for code objects, formatted in the Markdown (.md) is available [here](https://github.com/dataforseo/CSharpClient/tree/master/docs/dataforseo.client.dataforseoclient.md).
Official documentation for DataForSEO APIs is available [here](https://docs.dataforseo.com).

## Install package from nuget.org

```bash
dotnet add package DataForSeo.Client 
```

## Examples of usage

Example of live request
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",    
});
var result = await dfsClient.SerpApi.GoogleOrganicLiveAdvancedAsync(new List<SerpGoogleOrganicLiveAdvancedRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationCode = 2840,
        Keyword = "albert einstein",
        CalculateRectangles = true,
    }
});
``` 

Example of Task-based request
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",    
});
var result = await dfsClient.SerpApi.GoogleOrganicTaskPostAsync(new List<SerpTaskRequestInfo>()
{
    new()
    {
        LanguageCode = "en",
        LocationCode = 2840,
        Keyword = "albert einstein",
        Priority = 2,
    }
});

var sw = Stopwatch.StartNew();

var id = result.Tasks.First().Id;
while (!await GoogleOrganicTaskReady(id) && sw.Elapsed < TimeSpan.FromMinutes(1))
    await Task.Delay(1_000);

var taskGetResult = await dfsClient.SerpApi.GoogleOrganicTaskGetAdvancedAsync(id);

async Task<bool> GoogleOrganicTaskReady(string id)
{
    var result = await  dfsClient.SerpApi.GoogleOrganicTasksReadyAsync();
    return result.Tasks?.Any(x => x.Result?.Any(xx => xx.Id == id) ?? false) ?? false;
}
```
