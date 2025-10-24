# AmazonInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in Amazon SERP<br>absolute position among all the elements in SERP |[optional]|
**Position** | **string** | the alignment of the element in Amazon SERP<br>can take the following values:<br>left, right |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**Domain** | **string** | Amazon domain |[optional]|
**Title** | **string** | product title |[optional]|
**Url** | **string** | URL of the product page |[optional]|
**Asin** | **string** | ASIN of the product<br>learn more about ASIN in this help center guide |[optional]|
**ImageUrl** | **string** | URL of the product image featured in the results |[optional]|
**PriceFrom** | **double?** | the regular price of a product<br>example:<br>49.98 |[optional]|
**PriceTo** | **double?** | the upper limit of the product price range<br>example:<br>384.99 |[optional]|
**Currency** | **string** | currency in the ISO format<br>example:<br>USD |[optional]|
**SpecialOffers** | **IEnumerable<string>** | special offer details<br>contains special offer details, including coupon and Subscribe & Save discounts |[optional]|
**IsBestSeller** | **bool?** | “Best Seller” label<br>if the value is true, the product is marked with the “Best Seller” label |[optional]|
**IsAmazonChoice** | **bool?** | “Amazon’s choice” label<br>if the value is true, the product is marked with the “Amazon’s choice” label |[optional]|
**Rating** | **RatingInfo** | the item’s rating <br>the popularity rate based on reviews and displayed in SERP |[optional]|
**DeliveryInfo** | **AmazonDeliveryInfo** | delivery information<br>delivery information including free and fast delivery date ranges |[optional]|
**BoughtPastMonth** | **int?** |  |[optional]|