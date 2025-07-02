# BusinessDataBusinessListingsSearchLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | total number of results in our database relevant to your request |[optional]|
**Count** | **long?** | item types<br>the number of items in the items array |[optional]|
**Offset** | **long?** | offset in the results array of returned businesses |[optional]|
**OffsetToken** | **string** | token for subsequent requests<br>by specifying the unique offset_token when setting a new task, you will get the subsequent results of the initial task;<br>offset_token values are unique for each subsequent task |[optional]|
**Items** | **IEnumerable<BusinessDataBusinessListingsSearchLiveItem>** | encountered item types<br>types of search engine results encountered in the items array;<br>possible item types: business_listing |[optional]|