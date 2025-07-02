# AppDataAppleAppListingsSearchLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | the total number of relevant results in the database |[optional]|
**Count** | **long?** | the number of items in the results array |[optional]|
**Offset** | **int?** | offset in the results array of returned apps |[optional]|
**OffsetToken** | **string** | token for subsequent requests<br>you can use this parameter in the POST request to avoid timeouts while trying to obtain over 100,000 results in a single request |[optional]|
**Items** | **IEnumerable<AppDataAppleAppListingsSearchLiveItem>** | array of apps and related data |[optional]|