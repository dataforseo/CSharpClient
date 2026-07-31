# DataforseoLabsGoogleAppIntersectionLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**AppIds** | **IDictionary<string, string>** | <em>ids of the apps in a POST array</em> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**TotalCount** | **long?** | <em>total amount of results in our database relevant to your request</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**Items** | **IEnumerable<DataforseoLabsleAppIntersectionLiveItem>** | <em>contains data related to the ranking keywords for the app specified in the <code>app_id</code> field</em> |[optional]|