# BaseMerchantGoogleShoppingSellersElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements found in Google Shopping SERP |[optional]|
**Position** | **string** | the alignment of the element in Google Shopping SERP<br>possible values:<br>left, right |[optional]|
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
**SellerName** | **string** | name of the seller<br>the name of the company that placed a corresponding product on Google Shopping |[optional]|
**Rating** | **RatingElement** | shop rating<br>the shop popularity rate based on product reviews |[optional]|
**ShopAdAclk** | **string** | unique ad click referral parameter<br>using this parameter you can get a URL of the advertisement in Google Shopping Sellers Ad URL |[optional]|