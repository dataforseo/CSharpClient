# DataforseoLabsGoogleKeywordIdeasLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**SeedKeywords** | **IEnumerable<string>** | keywords in a POST array<br>keywords are returned with decoded %## (plus character ‘+’ will be decoded to a space character) |[optional]|
**LocationCode** | **double?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**TotalCount** | **double?** | total number of results relevant to your request in our database |[optional]|
**ItemsCount** | **double?** | number of results returned in the items array |[optional]|
**Offset** | **double?** | current offset value |[optional]|
**OffsetToken** | **string** | offset token for subsequent requests<br>you can use the string provided in this field to get the subsequent results of the initial task;<br>note: offset_token values are unique for each subsequent task |[optional]|
**Items** | **IEnumerable<KeywordDataInfo>** | contains keyword ideas and related data |[optional]|