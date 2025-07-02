# KeywordsDataBingSearchVolumeHistoryTaskGetResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | keyword in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array<br>if there is no data, then the value is null |[optional]|
**LanguageCode** | **string** | language code in a POST array<br>if there is no data, then the value is null |[optional]|
**Device** | **IEnumerable<string>** |  |[optional]|
**Period** | **string** | time period<br>indicates if returned data is aggregated to a certain time period<br>default value monthly |[optional]|
**Searches** | **SearchVolumeHistorySearchInfo** | contains results distributed by device type<br>if the device parameter is not specified, the data will be returned for all available device types |[optional]|