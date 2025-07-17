# MerchantAmazonAsinTaskGetAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Asin** | **string** | ASIN received in a POST array<br>the unique product identifier in Amazon (ASIN) received in a POST array<br>learn more about the identified in this help center guide |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | Amazon domain in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to Amazon results<br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**ItemTypes** | **IEnumerable<string>** | types of search results found on Amazon<br>contains types of all search results (items) found in the returned SERP<br>possible item types:<br>amazon_product_info |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<AmazonProductInfo>** | Amazon product info items |[optional]|