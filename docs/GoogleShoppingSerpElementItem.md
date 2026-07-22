# GoogleShoppingSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Domain** | **string** | domain of the URLdomain of the URL where a special offer is postedNote: this field is deprecated and will return null |[optional]|
**Title** | **string** | title of the element |[optional]|
**Description** | **string** | description of the product in Google Shopping SERP |[optional]|
**Url** | **string** | URL pointing at special offer pageURL where a special offer is postedNote: this field is deprecated and will return null |[optional]|
**ShoppingUrl** | **string** | URL to the product page on Google Shopping |[optional]|
**Tags** | **IEnumerable<string>** | tags assigned to the product |[optional]|
**Price** | **double?** | product priceexample:384.99 |[optional]|
**PriceMultiplier** | **int?** | price multiplier for instalment planindicates the number of months covered by the monthly payment for the product |[optional]|
**OldPrice** | **double?** | product old pricedisplayed if the product price has been changedexample:499 |[optional]|
**Currency** | **string** | currency in the ISO formatexample:USD |[optional]|
**ProductId** | **string** | unique product identifier on Google Shoppingnote that there is no full list of possible values as the product_id is a dynamic value assigned by Googleif there are no values, you will get nullexample:4485466949985702538learn more about the parameter in this help center guide |[optional]|
**DataDocid** | **string** | unique identifier of the SERP data elementnote that there is no full list of possible values as the data_docid is a dynamic value assigned by Googleexample:17363035694596624076 |[optional]|
**Seller** | **string** | name of the sellerthe name of the company that placed a corresponding product on Google Shopping |[optional]|
**AdditionalSpecifications** | **IDictionary<string, string>** | object containing additional url parametersyou can get more details about the product by using this object in the POST request to the Google Shopping Product Specification and Google Shopping Sellers endpoint |[optional]|
**ReviewsCount** | **long?** | number of product reviewsindicates the number of reviews left by users on Google Shoppingif there are no values, you will get null |[optional]|
**IsBestMatch** | **bool?** | 'best match' labelif the value is true, the product is marked with the 'best match' labelif there are no values, you will get null |[optional]|
**ProductRating** | **RatingElement** | product ratingthe product popularity rate based on product reviews |[optional]|
**ShopRating** | **RatingElement** | shop ratingthe popularity rate of the seller based on user reviews |[optional]|
**ProductImages** | **IEnumerable<string>** | URLs to the images of the productthe first URL in the array is the featured image of the product |[optional]|
**ShopAdAclk** | **string** | unique ad click referral parameterusing this parameter you can get a URL of the advertisement in Google Shopping Sellers Ad URL |[optional]|
**Gid** | **string** | global product identifier on Google Shoppingnote that there is no full list of possible values as the gid is a dynamic value assigned by Googleif there are no values, you will get nullexample:4702526954592161872learn more about gid parameter in this help center guide |[optional]|
**DeliveryInfo** | **DeliveryInfo** | delivery informationdelivery information including free and fast delivery date ranges |[optional]|
**StoresCountInfo** | **StoresCountInfo** | stores count informationcontains information about the number of stores that offer the same product |[optional]|