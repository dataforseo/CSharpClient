# DataforseoLabsAmazonRelatedKeywordsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**SeedKeyword** | **string** | <em>keyword in a POST array</em> |[optional]|
**SeedKeywordData** | **AmazonKeywordData** | <em>keyword data for the seed keyword</em><br>fields in the object are identical to that of <code>keyword_data</code> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**TotalCount** | **long?** | <em>total amount of results in our database relevant to your request</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**Items** | **IEnumerable<DataforseoLabsAmazonRelatedKeywordsLiveItem>** | <em>contains objects with keywords and related data</em> |[optional]|