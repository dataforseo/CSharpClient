# AppDataGoogleAppListingsSearchLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **double?** | the total number of relevant results in the database |[optional]|
**Count** | **double?** | the number of items in the results array |[optional]|
**Offset** | **double?** | offset in the results array of returned apps |[optional]|
**OffsetToken** | **string** | token for subsequent requests<br>you can use this parameter in the POST request to avoid timeouts while trying to obtain over 100,000 results in a single request |[optional]|
**Items** | **IEnumerable<AppDataGoogleAppListingsSearchLiveItem>** | array of apps and related data |[optional]|