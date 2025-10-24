# GoogleShoppingSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Domain** | **string** | domain of the URL<br>domain of the URL where a special offer is posted |[optional]|
**Title** | **string** | title of the element |[optional]|
**Description** | **string** | description of the product in Google Shopping SERP |[optional]|
**Url** | **string** | URL pointing at special offer page<br>URL where a special offer is posted |[optional]|
**ShoppingUrl** | **string** | URL to the product page on Google Shopping |[optional]|
**Tags** | **IEnumerable<string>** | tags assigned to the product |[optional]|
**Price** | **double?** | product price<br>example:<br>384.99 |[optional]|
**PriceMultiplier** | **int?** | price multiplier for instalment plan<br>indicates the number of months covered by the monthly payment for the product |[optional]|
**OldPrice** | **double?** | product old price<br>displayed if the product price has been changed<br>example:<br>499 |[optional]|
**Currency** | **string** | currency in the ISO format<br>example:<br>USD |[optional]|
**ProductId** | **string** | unique product identifier on Google Shopping<br>note that there is no full list of possible values as the product_id is a dynamic value assigned by Google<br>if there are no values, you will get null<br>example:<br>4485466949985702538<br>learn more about the parameter in this help center guide |[optional]|
**DataDocid** | **string** | unique identifier of the SERP data element<br>note that there is no full list of possible values as the data_docid is a dynamic value assigned by Google<br>example:<br>17363035694596624076 |[optional]|
**Seller** | **string** | name of the seller<br>the name of the company that placed a corresponding product on Google Shopping |[optional]|
**AdditionalSpecifications** | **IDictionary<string, string>** | object containing additional url parameters<br>you can get more details about the product by using this object in the POST request to the Google Shopping Product Specification and Google Shopping Sellers endpoint |[optional]|
**ReviewsCount** | **long?** | number of product reviews<br>indicates the number of reviews left by users on Google Shopping<br>if there are no values, you will get null |[optional]|
**IsBestMatch** | **bool?** | “best match” label<br>if the value is true, the product is marked with the “best match” label<br>if there are no values, you will get null |[optional]|
**ProductRating** | **RatingElement** | product rating<br>the product popularity rate based on product reviews |[optional]|
**ShopRating** | **RatingElement** | shop rating<br>the popularity rate of the seller based on user reviews |[optional]|
**ProductImages** | **IEnumerable<string>** | URLs to the images of the product<br>the first URL in the array is the featured image of the product |[optional]|
**ShopAdAclk** | **string** | unique ad click referral parameter<br>using this parameter you can get a URL of the advertisement in Google Shopping Sellers Ad URL |[optional]|
**Gid** | **string** | global product identifier on Google Shopping<br>note that there is no full list of possible values as the gid is a dynamic value assigned by Google<br>if there are no values, you will get null<br>example:<br>4702526954592161872<br>learn more about gid parameter in this help center guide |[optional]|
**DeliveryInfo** | **DeliveryInfo** | delivery information<br>delivery information including free and fast delivery date ranges |[optional]|
**StoresCountInfo** | **StoresCountInfo** | stores count information<br>contains information about the number of stores that offer the same product |[optional]|