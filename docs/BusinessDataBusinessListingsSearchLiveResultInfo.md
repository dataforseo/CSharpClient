# BusinessDataBusinessListingsSearchLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | <em>total number of results in our database relevant to your request</em> |[optional]|
**Count** | **long?** | <em>item types</em><br>the number of items in the <code>items</code> array |[optional]|
**Offset** | **long?** |  |[optional]|
**OffsetToken** | **string** |  |[optional]|
**Items** | **IEnumerable<BusinessDataBusinessListingsSearchLiveItem>** | <em>encountered item types</em><br>types of search engine results encountered in the <code>items</code> array;<br>possible item types: <code>business_listing</code> |[optional]|