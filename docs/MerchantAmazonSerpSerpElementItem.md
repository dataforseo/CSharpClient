# MerchantAmazonSerpSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Domain** | **string** | Amazon domain |[optional]|
**Title** | **string** | product title |[optional]|
**Url** | **string** | the URL of the product page |[optional]|
**ImageUrl** | **string** | URL of the product image featured in the results |[optional]|
**BoughtPastMonth** | **int?** | number of product purchases in the past month |[optional]|
**PriceFrom** | **double?** | the regular price of a product<br>example:<br>49.98 |[optional]|
**PriceTo** | **double?** | the upper limit of the product price range<br>example:<br>384.99 |[optional]|
**Currency** | **string** | currency in the ISO format<br>example:<br>USD |[optional]|
**SpecialOffers** | **IEnumerable<string>** | special offer details<br>contains special offer details, including coupon and Subscribe & Save discounts |[optional]|
**DataAsin** | **string** | unique product identifier on Amazon<br>note that there is no full list of possible values as the data_asin is a dynamic value assigned by Amazon<br>example:<br>B07G82D89J |[optional]|
**Rating** | **RatingElement** | product rating info |[optional]|
**IsAmazonChoice** | **bool?** | “Amazon’s choice” label<br>if the value is true, the product is marked with the “Amazon’s choice” label |[optional]|
**IsBestSeller** | **bool?** | “Best Seller” label<br>if the value is true, the product is marked with the “Best Seller” label |[optional]|
**DeliveryInfo** | **AmazonDeliveryInfo** | delivery information<br>delivery information including free and fast delivery date ranges |[optional]|