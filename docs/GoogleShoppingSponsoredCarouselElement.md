# GoogleShoppingSponsoredCarouselElement


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Xpath** | **string** | XPath of the element |[optional]|
**Title** | **string** | product title |[optional]|
**Tags** | **IEnumerable<string>** | tags assigned to the product |[optional]|
**Seller** | **string** | name of the seller<br>the name of the company that placed a corresponding product on Google Shopping |[optional]|
**Price** | **double?** | product price<br>example:<br>384.99 |[optional]|
**Currency** | **string** | currency in the ISO format<br>example:<br>USD |[optional]|
**ProductRating** | **RatingElement** | product rating<br>the product popularity rate based on product reviews |[optional]|
**ProductImages** | **IEnumerable<string>** | URLs to the images of the product<br>the first URL in the array is the featured image of the product |[optional]|
**ShopAdAclk** | **string** | unique ad click referral parameter<br>using this parameter you can get a URL of the advertisement in Google Shopping Sellers Ad URL |[optional]|
**DeliveryInfo** | **DeliveryInfo** | delivery information<br>delivery information including free and fast delivery date ranges |[optional]|
**SpecialOfferInfo** | **SpecialOfferInfo** | special offer from the seller<br>information on the special offer from the seller, including discount and coupon info |[optional]|