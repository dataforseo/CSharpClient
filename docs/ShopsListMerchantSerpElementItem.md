# ShopsListMerchantSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Xpath** | **string** | XPath of the element |[optional]|
**Domain** | **string** | domain in SERP |[optional]|
**Title** | **string** | product title |[optional]|
**Url** | **string** | Google Shopping URL forwarding to the product page on the seller’s website<br>if you want to obtain a URL of the advertisement forwarding to the product page on the seller’s website, please refer to the Google Shopping Sellers Ad URL endpoint |[optional]|
**Details** | **string** | details and special offers<br>if there are no details, the value will be null |[optional]|
**BasePrice** | **double?** | product price without tax and shipping |[optional]|
**Tax** | **double?** | the amount of tax<br>tax is specified as the actual amount of money, not as the percentage |[optional]|
**ShippingPrice** | **double?** | product shipping price |[optional]|
**TotalPrice** | **double?** | product price including tax and shipping |[optional]|
**Currency** | **string** | currency in the ISO format<br>example:<br>USD |[optional]|
**PriceMultiplier** | **double?** | monthly price multiplier<br>indicates the number of months covered by the monthly payment for the product |[optional]|
**SellerName** | **string** | name of the seller<br>the name of the company that placed a corresponding product on Google Shopping |[optional]|
**Rating** | **RatingElement** | shop rating<br>the shop popularity rate based on product reviews |[optional]|
**ShopAdAclk** | **string** | unique ad click referral parameter<br>using this parameter you can get a URL of the advertisement in Google Shopping Sellers Ad URL |[optional]|
**ProductCondition** | **string** | indicated condition of the product<br>possible values: Used, Refurbished, New, null |[optional]|
**ProductAnnotation** | **string** | data from annotations and badges with special offers<br>if there is no annotation for this product, the value will be null<br>examples: LOW PRICE, SPECIAL OFFER, SALE, PRICE DROP |[optional]|