## OVERVIEW

There is a C# client to call DataForSeo API.

DataForSEO API uses REST technology for interchanging data between your application and our service. The data exchange is made through the widely used HTTP protocol, which allows applying our API to almost all programming languages.

Client contains 12 sections (aka API):
- Serp ([source](https://docs.dataforseo.com/v3/serp/overview/?bash))
- KeywordsData ([source](https://docs.dataforseo.com/v3/keywords_data/overview/?bash))
- DomainAnalytics ([source](https://docs.dataforseo.com/v3/domain_analytics/overview/?bash))
- DataforseoLabs ([source](https://docs.dataforseo.com/v3/dataforseo_labs/overview/?bash))
- Backlinks ([source](https://docs.dataforseo.com/v3/backlinks/overview/?bash))
- OnPage ([source](https://docs.dataforseo.com/v3/on_page/overview/?bash))
- ContentAnalysis ([source](https://docs.dataforseo.com/v3/content_analysis/overview/?bash))
- ContentGeneration ([source](https://docs.dataforseo.com/v3/content_generation/overview/?bash))
- Merchant ([source](https://docs.dataforseo.com/v3/merchant/overview/?bash))
- AppData ([source](https://docs.dataforseo.com/v3/app_data/overview/?bash))
- BusinessData ([source](https://docs.dataforseo.com/v3/business_data/overview/?bash))
- Appendix ([source](https://docs.dataforseo.com/v3/appendix/user_data/?bash))

API Contains 2 types of requests:
1) Live (Simple HTTP request/response message)
2) Task-Based (Where you need to send a 'Task' entity to execute, waiting until the 'Task' status is ready and getting the 'Task' result in a special endpoint. Usually, it represents in 3 endpoints 'TaskPost', 'TaskReady', and 'TaskGet')

For more details - please follow [here](https://docs.dataforseo.com/v3/?bash)

## YAML Spec

Our API description is based on openAPI [syntax](https://spec.openapis.org/oas/v3.1.0) in YAML format. The YAML file attached to the project with the name [here](./openapi_specification.yaml) 

## Code generation

Code generated with using [NSwag lib](https://github.com/RicoSuter/NSwag)

## Documentation
Code Objects documentation in .md format was generated using [XMLDoc2Markdown](https://charlesdevandiere.github.io/xmldoc2md/) and placed [here](./docs)

## install package from nuget.org

```bash
dotnet add package DataForSeo.Client 
```

## Examples of usage

Example of live request
```csharp
var dfsClient = new DataForSeoClient("USERNAME", "PASSWORD");
      var result = await dfsClient.SerpApi.GoogleOrganicLiveAdvancedAsync(new List<SerpTaskRequestInfo>()
      {
          new()
          {
              LanguageCode = "en",
              LocationCode = 2840,
              Keyword = "albert einstein",
              Priority = 2,
          }
      });
``` 

Example of Task-based endpoint
```csharp
var dfsClient = new DataForSeoClient("USERNAME", "PASSWORD");
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
