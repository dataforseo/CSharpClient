# KeywordsDataDataforseoTrendsExploreLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keywords** | **IEnumerable<string>** | keywords in a POST array |[optional]|
**Type** | **string** | type of element |[optional]|
**LocationCode** | **int?** | location code in a POST array<br>if there is no data, then the value is null |[optional]|
**LanguageCode** | **string** | language code in a POST array<br>if there is no data, then the value is null |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<DataforseoTrendsDataforseoTrendsGraphElementItem>** | contains keyword popularity and related data |[optional]|