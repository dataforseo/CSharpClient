# AppDataGoogleAppListingsSearchLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | <em>the total number of relevant results in the database</em> |[optional]|
**Count** | **long?** | <em>the number of items in the results array</em> |[optional]|
**Offset** | **int?** | <em>offset in the results array of returned apps</em> |[optional]|
**OffsetToken** | **string** | <em>token for subsequent requests</em><br>you can use this parameter in the POST request to avoid timeouts while trying to obtain over 100,000 results in a single request |[optional]|
**Items** | **IEnumerable<AppDataGoogleAppListingsSearchLiveItem>** | <em>array of apps and related data</em> |[optional]|