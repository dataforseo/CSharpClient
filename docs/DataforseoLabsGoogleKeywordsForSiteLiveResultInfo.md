# DataforseoLabsGoogleKeywordsForSiteLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**Target** | **string** | target domain in a POST array |[optional]|
**LocationCode** | **double?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**TotalCount** | **double?** | total number of results in our database relevant to your request |[optional]|
**ItemsCount** | **double?** | the number of results returned in the items array |[optional]|
**Offset** | **double?** | current offset value |[optional]|
**OffsetToken** | **string** | offset token for subsequent requests<br>you can use the string provided in this field to get the subsequent results of the initial task;<br>note: offset_token values are unique for each subsequent task |[optional]|
**Items** | **IEnumerable<KeywordDataInfo>** | contains keyword ideas and related data |[optional]|