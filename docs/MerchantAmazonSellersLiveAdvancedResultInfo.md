# MerchantAmazonSellersLiveAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Asin** | **string** | asin received in a POST arraylearn more about ASINs in this help center guide |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | search engine domain received in a POST array |[optional]|
**LocationCode** | **int?** | location code received in a POST array |[optional]|
**LanguageCode** | **string** | language code received in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to Amazon resultsyou can use it to make sure the provided results are accurate |[optional]|
**Datetime** | **string** | date and time when the result was receivedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2019-11-15 12:57:46 +00:00 |[optional]|
**Title** | **string** | product titletitle of the product relevant to the asin received in a POST array |[optional]|
**Image** | **string** | product image urlimage URL of the product relevant to the asin received in a POST array |[optional]|
**ItemTypes** | **IEnumerable<string>** | types of search results found in Amazon Sellers SERPcontains types of all search results (items) found in the returned SERPpossible item types:amazon_seller_main_item, amazon_seller_item |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<BaseMerchantAmazonSellersElementItem>** | items in SERP |[optional]|