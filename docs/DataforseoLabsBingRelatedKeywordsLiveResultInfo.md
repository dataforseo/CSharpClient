# DataforseoLabsBingRelatedKeywordsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**SeedKeyword** | **string** | keyword in a POST array |[optional]|
**SeedKeywordData** | **KeywordDataInfo** | keyword data for the seed keyword<br>fields in the array are identical to that of keyword_data |[optional]|
**LocationCode** | **double?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**TotalCount** | **double?** | total amount of results in our database relevant to your request |[optional]|
**ItemsCount** | **double?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<DataforseoLabsRelatedKeywordsLiveItem>** | contains keywords and related data |[optional]|