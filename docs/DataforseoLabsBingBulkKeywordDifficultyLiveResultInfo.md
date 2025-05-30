# DataforseoLabsBingBulkKeywordDifficultyLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**LocationCode** | **double?** | location code in a POST array<br>if there is no data, then the value is null |[optional]|
**LanguageCode** | **string** | language code in a POST array<br>if there is no data, then the value is null |[optional]|
**TotalCount** | **double?** | total amount of results in our database relevant to your request |[optional]|
**ItemsCount** | **double?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<DataforseoLabsBulkKeywordDifficultyLiveItem>** | contains keywords and related keyword difficulty scores |[optional]|