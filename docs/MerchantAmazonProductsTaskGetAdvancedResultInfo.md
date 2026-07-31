# MerchantAmazonProductsTaskGetAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | <em>keyword received in a POST array</em><br><strong>keyword is returned with decoded %## (plus character '+' will be decoded to a space character)</strong> |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | <em>search engine domain in a POST array</em> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to Amazon results</em><br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Spell** | **SpellInfo** | <em>autocorrection of the search engine</em><br>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection |[optional]|
**ItemTypes** | **IEnumerable<string>** | <em>types of search results found in Amazon SERP</em><br>contains types of all search results (<code>items</code>) found in the returned SERP<br>possible item types:<br><code>amazon_serp</code>, <code>amazon_paid</code>, <code>editorial_recommendations</code>, <code>top_rated_from_our_brands</code>, <code>related_searches</code> |[optional]|
**SeResultsCount** | **long?** | <em>search engine results count</em> |[optional]|
**Categories** | **IEnumerable<string>** | <em>amazon product departments and subcategories</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <strong><code>items</code></strong> array</em> |[optional]|
**Items** | **IEnumerable<BaseMerchantAmazonElementItem>** | <em>Amazon product items within the <code>editorial_recommendations</code> element</em> |[optional]|