# DataforseoLabsGoogleHistoricalSerpsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**Keyword** | **string** | keyword received in a POST array<br>the keyword is returned with decoded %## (plus character ‘+’ will be decoded to a space character) |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**TotalCount** | **int?** | the number of results returned in the items array |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<DataforseoLabsGoogleHistoricalSerpsLiveItem>** | contains arrays of specific images |[optional]|