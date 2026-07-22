# BusinessDataBusinessListingsSearchLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | total number of results in our database relevant to your request |[optional]|
**Count** | **long?** | item types<br>the number of items in the items array |[optional]|
**Offset** | **long?** |  |[optional]|
**OffsetToken** | **string** |  |[optional]|
**Items** | **IEnumerable<BusinessDataBusinessListingsSearchLiveItem>** | encountered item types<br>types of search engine results encountered in the items array;<br>possible item types: business_listing |[optional]|