# GoogleShoppingCarouselElement


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Xpath** | **string** | XPath of the element |[optional]|
**Title** | **string** | product title |[optional]|
**Tags** | **IEnumerable<string>** | tags assigned to the product |[optional]|
**Seller** | **string** | name of the sellerthe name of the company that placed a corresponding product on Google Shopping |[optional]|
**Price** | **double?** | product priceexample:384.99 |[optional]|
**Currency** | **string** | currency in the ISO formatexample:USD |[optional]|
**ProductRating** | **RatingElement** | product ratingthe product popularity rate based on product reviews |[optional]|
**ProductImages** | **IEnumerable<string>** | URLs to the images of the productthe first URL in the array is the featured image of the product |[optional]|
**ShoppingUrl** | **string** | URL to the product page on Google Shopping |[optional]|
**ProductId** | **string** | unique product identifier on Google Shoppingnote that there is no full list of possible values as the product_id is a dynamic value assigned by Googleif there are no values, you will get nullexample:4485466949985702538learn more about the parameter in this help center guide |[optional]|
**DataDocid** | **string** | unique identifier of the SERP data elementnote that there is no full list of possible values as the data_docid is a dynamic value assigned by Googleexample:17363035694596624076 |[optional]|
**Gid** | **string** | global product identifier on Google Shoppingnote that there is no full list of possible values as the gid is a dynamic value assigned by Googleif there are no values, you will get nullexample:4702526954592161872learn more about gid parameter in this help center guide |[optional]|
**DeliveryInfo** | **DeliveryInfo** | delivery informationdelivery information including free and fast delivery date ranges |[optional]|
**SpecialOfferInfo** | **SpecialOfferInfo** | special offer from the sellerinformation on the special offer from the seller, including discount and coupon info |[optional]|