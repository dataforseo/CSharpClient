# MerchantAmazonAsinLiveAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Asin** | **string** | <em>ASIN received in a POST array</em><br>the unique product identifier in Amazon (ASIN) received in a POST array<br>learn more about the identified in <a href='https://dataforseo.com/help-center/asin-in-amazon-api' rel='noopener noreferrer' target='_blank'>this help center guide</a> |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | <em>Amazon domain in a POST array</em> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to Amazon results</em><br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**ItemTypes** | **IEnumerable<string>** | <em>types of search results found on Amazon</em><br>contains types of all search results (<code>items</code>) found in the returned SERP<br>possible item types:<br><code>amazon_product_info</code> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <strong><code>items</code></strong> array</em> |[optional]|
**Items** | **IEnumerable<AmazonProductInfo>** | <em>Amazon product info items</em> |[optional]|