# DataforseoLabsAmazonRelatedKeywordsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**SeedKeyword** | **string** | keyword in a POST array |[optional]|
**SeedKeywordData** | **AmazonKeywordData** | keyword data for the seed keyword<br>fields in the object are identical to that of keyword_data |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**TotalCount** | **long?** | total amount of results in our database relevant to your request |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<DataforseoLabsAmazonRelatedKeywordsLiveItem>** | contains objects with keywords and related data |[optional]|