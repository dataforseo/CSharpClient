# DataforseoLabsBingSerpCompetitorsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**SeedKeywords** | **IEnumerable<string>** | keywords specified in the request<br>keyword is returned with decoded %## (plus character ‘+’ will be decoded to a space character) |[optional]|
**LocationCode** | **int?** | location code in a POST array<br>if there is no data, then the value is null |[optional]|
**LanguageCode** | **string** | language code in a POST array<br>if there is no data, then the value is null |[optional]|
**TotalCount** | **long?** | the total amount of results in our database relevant to your request |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<DataforseoLabsSerpCompetitorsLiveItem>** | contains detected SERP competitors and related data |[optional]|