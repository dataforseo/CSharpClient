# MerchantAmazonProductsTaskGetAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | keyword received in a POST array<br>keyword is returned with decoded %## (plus character ‘+’ will be decoded to a space character) |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to Amazon results<br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Spell** | **SpellInfo** | autocorrection of the search engine<br>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection |[optional]|
**ItemTypes** | **IEnumerable<string>** | types of search results found in Amazon SERP<br>contains types of all search results (items) found in the returned SERP<br>possible item types:<br>amazon_serp, amazon_paid, editorial_recommendations, top_rated_from_our_brands, related_searches |[optional]|
**SeResultsCount** | **long?** | search engine results count |[optional]|
**Categories** | **IEnumerable<string>** | amazon product departments and subcategories |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<BaseMerchantAmazonElementItem>** | Amazon product items within the editorial_recommendations element |[optional]|