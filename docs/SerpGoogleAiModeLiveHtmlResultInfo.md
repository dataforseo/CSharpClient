# SerpGoogleAiModeLiveHtmlResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | <em>keyword received in a POST array<br></em><strong>keyword is returned with decoded %## (plus character '+' will be decoded to a space character)</strong> |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | <em>search engine domain in a POST array</em> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <strong><code>items</code></strong> array</em> |[optional]|
**Items** | **IEnumerable<HtmlItemInfo>** | <em>elements of search results found in SERP</em> |[optional]|