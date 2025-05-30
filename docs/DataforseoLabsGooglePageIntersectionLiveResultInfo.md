# DataforseoLabsGooglePageIntersectionLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**Pages** | **IDictionary<string, string>** | URLs you specified a POST array |[optional]|
**ExcludePages** | **IEnumerable<string>** | URLs you specified in a POST array that will be excluded from the results |[optional]|
**LocationCode** | **double?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**TotalCount** | **double?** | total amount of results in our database relevant to your request |[optional]|
**ItemsCount** | **double?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<DataforseoLabsPageIntersectionLiveItem>** | contains keywords, relevant SERP elements and related data |[optional]|