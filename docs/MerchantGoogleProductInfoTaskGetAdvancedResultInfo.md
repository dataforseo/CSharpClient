# MerchantGoogleProductInfoTaskGetAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**ProductId** | **string** | product ID in a POST array<br>learn more about the parameter in this help center guide |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine results<br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the format: “year-month-date:minutes:UTC_difference_hours:UTC_difference_minutes”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**ItemTypes** | **IEnumerable<string>** | types of items found on the product specification page<br>possible item types:<br>product_info_element |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<ProductInfoElement>** | items on the product page<br>contains all product attributes and related data listed on the product page |[optional]|