# MerchantAmazonSellersTaskGetAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Asin** | **string** | asin received in a POST array<br>learn more about ASINs in this help center guide |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | search engine domain received in a POST array |[optional]|
**LocationCode** | **double?** | location code received in a POST array |[optional]|
**LanguageCode** | **string** | language code received in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to Amazon results<br>you can use it to make sure the provided results are accurate |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Title** | **string** | product title<br>title of the product relevant to the asin received in a POST array |[optional]|
**Image** | **string** | product image url<br>image URL of the product relevant to the asin received in a POST array |[optional]|
**ItemTypes** | **IEnumerable<string>** | types of search results found in Amazon Sellers SERP<br>contains types of all search results (items) found in the returned SERP<br>possible item types:<br>amazon_seller_main_item, amazon_seller_item |[optional]|
**ItemsCount** | **double?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<BaseAmazonSerpElementItem>** | items in SERP |[optional]|