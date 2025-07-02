# BuyOnGoogleMerchantSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Xpath** | **string** | XPath of the element |[optional]|
**Domain** | **string** | domain in SERP |[optional]|
**Title** | **string** | product title |[optional]|
**Url** | **string** | Google Shopping URL forwarding to the product page |[optional]|
**Details** | **string** | details and special offers<br>if there are no details, the value will be null |[optional]|
**BasePrice** | **int?** | product price without tax and shipping |[optional]|
**Tax** | **int?** | the amount of tax<br>tax is specified as the actual amount of money, not as the percentage |[optional]|
**ShippingPrice** | **int?** | product shipping price |[optional]|
**TotalPrice** | **long?** | product price including tax and shipping |[optional]|
**Currency** | **string** | currency in the ISO format<br>example:<br>USD |[optional]|
**SellerName** | **string** | name of the seller<br>the name of the company that placed a corresponding product on Google Shopping |[optional]|
**Rating** | **RatingElement** | shop rating<br>the shop popularity rate based on product reviews |[optional]|
**ShopAdAclk** | **string** | unique ad click referral parameter<br>using this parameter you can get a URL of the advertisement in Google Shopping Sellers Ad URL<br>in this case, the value equals null |[optional]|