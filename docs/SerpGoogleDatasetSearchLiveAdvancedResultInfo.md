# SerpGoogleDatasetSearchLiveAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | <em>keyword received in a POST array<br></em><strong>the keyword is returned with decoded %## (plus character '+' will be decoded to a space character)</strong> |[optional]|
**SeDomain** | **string** | <em>search engine domain in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to search engine results</em><br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Spell** | **SpellInfo** | <em>autocorrection of the search engine</em><br>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection |[optional]|
**ItemTypes** | **IEnumerable<string>** | <em>types of search results in SERP</em><br>contains types of search results (<code>items</code>) found in SERP.<br>possible item type: <code>dataset</code> |[optional]|
**SeResultsCount** | **long?** | <em> total number of results in SERP</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <strong><code>items</code></strong> array</em> |[optional]|
**Items** | **IEnumerable<Dataset>** | <em>items of the element</em> |[optional]|