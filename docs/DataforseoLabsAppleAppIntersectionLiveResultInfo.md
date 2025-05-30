# DataforseoLabsAppleAppIntersectionLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**AppIds** | **IDictionary<string, string>** | ids of the apps in a POST array |[optional]|
**LocationCode** | **double?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**TotalCount** | **double?** | total amount of results in our database relevant to your request |[optional]|
**ItemsCount** | **double?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<DataforseoLabsAppleAppIntersectionLiveItem>** | contains data related to the ranking keywords for the app specified in the app_id field |[optional]|