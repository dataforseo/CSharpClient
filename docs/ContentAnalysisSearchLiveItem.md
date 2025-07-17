# ContentAnalysisSearchLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Url** | **string** | URL where the citation was found |[optional]|
**Domain** | **string** | domain name |[optional]|
**MainDomain** | **string** | main domain |[optional]|
**UrlRank** | **int?** | rank of the url<br>this value is based on backlink data for the given URL from DataForSEO Backlink Index;<br>url_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm<br>learn more about the metric and how it is calculated in this help center article |[optional]|
**SpamScore** | **int?** | backlink spam score of the url<br>this value is based on backlink data for the given URL from DataForSEO Backlink Index;<br>learn more about how the metric is calculated on this help center page |[optional]|
**DomainRank** | **int?** | rank of the domain<br>this value is based on backlink data for the given domain from DataForSEO Backlink Index;<br>domain_rank is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm<br>learn more about the metric and how it is calculated in this help center article |[optional]|
**FetchTime** | **string** | date and time when our crawler visited the page<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2017-01-24 13:20:59 +00:00 |[optional]|
**Country** | **string** | country code of the domain registration<br>to obtain a full list of available countries, refer to the Locations endpoint |[optional]|
**Language** | **string** | main language of the domain<br>to obtain a full list of available languages, refer to the Languages endpoint |[optional]|
**Score** | **double?** | citation prominence score<br>this value is based on url_rank, domain_rank, keyword presence in title, main_title, url, snippet<br>the higher the score, the more value the related citation has |[optional]|
**PageCategory** | **IEnumerable<int?>** | contains all relevant page categories<br>product and service categories relevant for the page<br>to obtain a full list of available categories, refer to the Categories endpoint |[optional]|
**PageTypes** | **IEnumerable<string>** | page types |[optional]|
**Ratings** | **IEnumerable<ContentRatingInfo>** | ratings found on the page<br>all ratings found on the page based on microdata |[optional]|
**SocialMetrics** | **IEnumerable<SocialMetricsInfo>** | social media engagement metrics<br>data on social media interactions associated with the content based on website embeds developed and supported by social media platforms |[optional]|
**ContentInfo** | **AnalysisContentInfo** | contains data on citations from the given url |[optional]|