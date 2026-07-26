# BusinessDataBusinessListingsCategoriesAggregationLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TotalCount** | **long?** | <em>total number of results in our database relevant to your request</em> |[optional]|
**Count** | **long?** | <em>item types</em><br>the number of items in the <code>items</code> array |[optional]|
**Offset** | **string** | <em>offset in the results array of returned categories</em> |[optional]|
**OffsetToken** | **object** | <em>token for subsequent requests</em><br>by specifying the unique <code>offset_token</code> when setting a new task, you will get the subsequent results of the initial task;<br><code>offset_token</code> values are unique for each subsequent task |[optional]|
**Items** | **IEnumerable<BusinessDataBusinessListingsCategoriesAggregationLiveItem>** | <em>encountered item types</em><br>types of search engine results encountered in the <code>items</code> array;<br>possible item types: <code>business_category</code> |[optional]|