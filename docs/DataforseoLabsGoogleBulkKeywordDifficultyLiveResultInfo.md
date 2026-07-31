# DataforseoLabsGoogleBulkKeywordDifficultyLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em><br>if there is no data, then the value is <code>null</code> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em><br>if there is no data, then the value is <code>null</code> |[optional]|
**TotalCount** | **long?** | <em>total amount of results in our database relevant to your request</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**Items** | **IEnumerable<DataforseoLabsGoogleBulkKeywordDifficultyLiveItem>** | <em>contains keywords and related keyword difficulty scores</em> |[optional]|