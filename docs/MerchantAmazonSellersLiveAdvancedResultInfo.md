# MerchantAmazonSellersLiveAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Asin** | **string** | <em><code>asin</code> received in a POST array</em><br>learn more about ASINs in <a href='https://dataforseo.com/help-center/asin-in-amazon-api' rel='noopener noreferrer' target='_blank'>this help center guide</a> |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | <em>search engine domain received in a POST array</em> |[optional]|
**LocationCode** | **int?** | <em>location code received in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code received in a POST array</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to Amazon results</em><br>you can use it to make sure the provided results are accurate |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Title** | **string** | <em>product title</em><br>title of the product relevant to the <code>asin</code> received in a POST array |[optional]|
**Image** | **string** | <em>product image url</em><br>image URL of the product relevant to the <code>asin</code> received in a POST array |[optional]|
**ItemTypes** | **IEnumerable<string>** | <em>types of search results found in Amazon Sellers SERP</em><br>contains types of all search results (<code>items</code>) found in the returned SERP<br>possible item types:<br><code>amazon_seller_main_item</code>, <code>amazon_seller_item</code> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <strong><code>items</code></strong> array</em> |[optional]|
**Items** | **IEnumerable<BaseMerchantAmazonSellersElementItem>** | <em>items in SERP</em> |[optional]|