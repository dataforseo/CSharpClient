# MerchantGoogleSellersTaskGetAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**ProductId** | **string** | product_id received in a POST array<br>learn more about the parameter in this help center guide |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to Google Shopping results<br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Title** | **string** | title of the product |[optional]|
**Url** | **string** | URL to the product page |[optional]|
**ImageUrl** | **string** | URL to the product image |[optional]|
**Rating** | **RatingElement** | product rating<br>the product popularity rate based on product reviews |[optional]|
**ItemTypes** | **IEnumerable<string>** | types of search results found in Google Shopping SERP<br>contains types of all search results (items) found in the returned SERP<br>possible item types:<br>shops_list, buy_on_google |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<BaseMerchantSerpElementItem>** | items in SERP |[optional]|