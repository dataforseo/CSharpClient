# DataforseoLabsGoogleRankedKeywordsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**Target** | **string** | target domain in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array<br>if there is no data, then the value is null |[optional]|
**LanguageCode** | **string** | language code in a POST array<br>if there is no data, then the value is null |[optional]|
**TotalCount** | **long?** | total number of results in our database relevant to your request |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Metrics** | **IDictionary<string, DataforseoLabsMetricsInfo>** | ranking data relevant to the specified domain<br>ranking data is provided by the rank_group parameters that show the result’s rank considering only equivalent SERP elements |[optional]|
**MetricsAbsolute** | **IDictionary<string, DataforseoLabsMetricsInfo>** | ranking data relevant to the specified domain<br>ranking data is provided by the rank_absolute parameters that indicate the result’s position among all SERP elements |[optional]|
**Items** | **IEnumerable<DataforseoLabsRankedKeywordsLiveItem>** | contains ranked keywords and related data |[optional]|