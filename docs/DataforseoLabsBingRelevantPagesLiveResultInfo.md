# DataforseoLabsBingRelevantPagesLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**Target** | **string** | target domain in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array<br>if there is no data, then the value is null |[optional]|
**LanguageCode** | **string** | language code in a POST array<br>if there is no data, then the value is null |[optional]|
**TotalCount** | **long?** | total amount of results in our database relevant to your request |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<DataforseoLabsRelevantPagesLiveItem>** | relevant pages and related data |[optional]|