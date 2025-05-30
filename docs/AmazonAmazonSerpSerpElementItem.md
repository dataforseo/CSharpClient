# AmazonAmazonSerpSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**Domain** | **string** | Amazon domain |[optional]|
**Title** | **string** | product title |[optional]|
**Url** | **string** | URL of the product page |[optional]|
**Asin** | **string** | ASIN of the product<br>learn more about ASIN in this help center guide |[optional]|
**ImageUrl** | **string** | URL of the product image featured in the results |[optional]|
**PriceFrom** | **float?** | the regular price of a product<br>example:<br>49.98 |[optional]|
**PriceTo** | **float?** | the upper limit of the product price range<br>example:<br>384.99 |[optional]|
**Currency** | **string** | currency in the ISO format<br>example:<br>USD |[optional]|
**SpecialOffers** | **IEnumerable<string>** | special offer details<br>contains special offer details, including coupon and Subscribe & Save discounts |[optional]|
**IsBestSeller** | **bool?** | “Best Seller” label<br>if the value is true, the product is marked with the “Best Seller” label |[optional]|
**IsAmazonChoice** | **bool?** | “Amazon’s choice” label<br>if the value is true, the product is marked with the “Amazon’s choice” label |[optional]|
**Rating** | **RatingElement** | the item’s rating <br>the popularity rate based on reviews and displayed in SERP |[optional]|
**DeliveryInfo** | **AmazonDeliveryInfo** | delivery information<br>delivery information including free and fast delivery date ranges |[optional]|
**BoughtPastMonth** | **double?** | number of product purchases in the past month |[optional]|
**Description** | **string** | description of the product |[optional]|
**DataAsin** | **string** | unique product identifier on Amazon<br>note that there is no full list of possible values as the data_asin is a dynamic value assigned by Amazon<br>example:<br>B07G82D89J |[optional]|