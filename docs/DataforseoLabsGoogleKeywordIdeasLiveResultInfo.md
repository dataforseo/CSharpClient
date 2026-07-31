# DataforseoLabsGoogleKeywordIdeasLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**SeedKeywords** | **IEnumerable<string>** | <em>keywords in a POST array</em><br><strong>keywords are returned with decoded %## (plus character '+' will be decoded to a space character)</strong> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**TotalCount** | **long?** | <em>total number of results relevant to your request in our database </em> |[optional]|
**ItemsCount** | **long?** | <em>number of results returned in the <code>items</code> array</em> |[optional]|
**Offset** | **int?** | <em>current offset value</em> |[optional]|
**OffsetToken** | **string** | <em>offset token for subsequent requests</em><br>you can use the string provided in this field to get the subsequent results of the initial task;<br><strong>note:</strong> <code>offset_token</code> values are unique for each subsequent task |[optional]|
**Items** | **IEnumerable<KeywordDataInfo>** | <em>contains keyword ideas and related data</em> |[optional]|