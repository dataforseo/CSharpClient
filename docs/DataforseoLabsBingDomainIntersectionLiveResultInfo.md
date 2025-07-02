# DataforseoLabsBingDomainIntersectionLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type<br>search engine type specified in a POST request;<br>for this endpoint, the field equals bing |[optional]|
**Target1** | **string** | target specified in a POST array |[optional]|
**Target2** | **string** | target specified in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**TotalCount** | **long?** | total amount of results in our database relevant to your request |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<DataforseoLabsDomainIntersectionLiveItem>** | contains keywords, relevant SERP elements and related data |[optional]|