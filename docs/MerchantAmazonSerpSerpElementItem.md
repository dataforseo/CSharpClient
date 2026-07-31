# MerchantAmazonSerpSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Domain** | **string** | <em>Amazon domain</em> |[optional]|
**Title** | **string** | <em>product title</em> |[optional]|
**Url** | **string** | <em>the URL of the product page</em> |[optional]|
**ImageUrl** | **string** | <em>URL of the product image featured in the results</em> |[optional]|
**BoughtPastMonth** | **int?** | <em>number of product purchases in the past month</em> |[optional]|
**PriceFrom** | **double?** | <em>the regular price of a product</em><br>example:<br><code>49.98</code> |[optional]|
**PriceTo** | **double?** | <em>the upper limit of the product price range</em><br>example:<br><code>384.99</code> |[optional]|
**Currency** | **string** | <em>currency in the <a href='https://en.wikipedia.org/wiki/ISO_4217'>ISO</a> format</em><br>example:<br><code>USD</code> |[optional]|
**SpecialOffers** | **IEnumerable<string>** | <em>special offer details</em><br>contains special offer details, including coupon and Subscribe & Save discounts |[optional]|
**DataAsin** | **string** | <em>unique product identifier on Amazon</em><br>note that there is no full list of possible values as the <code>data_asin</code> is a dynamic value assigned by Amazon<br>example:<br><code>B07G82D89J</code> |[optional]|
**Rating** | **RatingElement** | <em>product rating info</em> |[optional]|
**IsAmazonChoice** | **bool?** | <em>'Amazon's choice' label</em><br>if the value is <code>true</code>, the product is marked with the 'Amazon's choice' label |[optional]|
**IsBestSeller** | **bool?** | <em>'Best Seller' label</em><br>if the value is <code>true</code>, the product is marked with the 'Best Seller' label |[optional]|
**DeliveryInfo** | **AmazonDeliveryInfo** | <em>delivery information</em><br>delivery information including free and fast delivery date ranges |[optional]|
**Labels** | **IEnumerable<AmazonLabelElement>** | <em>product labels</em><br>array containing an object with main Amazon labels’ information<br>if the product contains no labels, the value will be <code>null</code> |[optional]|