# ContentAnalysisSearchLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Url** | **string** | <em>URL where the citation was found</em> |[optional]|
**Domain** | **string** | <em>domain name</em> |[optional]|
**MainDomain** | **string** | <em>main domain</em> |[optional]|
**UrlRank** | **int?** | <em>rank of the <code>url</code></em><br>this value is based on backlink data for the given URL from DataForSEO Backlink Index;<br><code>url_rank</code> is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm<br>learn more about the metric and how it is calculated in <a href='https://dataforseo.com/help-center/what_is_rank_in_backlinks_api' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**SpamScore** | **int?** | <em>backlink spam score of the <code>url</code></em><br>this value is based on backlink data for the given URL from DataForSEO Backlink Index;<br>learn more about how the metric is calculated on <a href='https://dataforseo.com/help-center/what-is-spam-score-and-how-is-it-calculated' rel='noopener noreferrer' target='_blank'>this help center page</a> |[optional]|
**DomainRank** | **int?** | <em>rank of the <code>domain</code></em><br>this value is based on backlink data for the given domain from DataForSEO Backlink Index;<br><code>domain_rank</code> is calculated based on the method for node ranking in a linked database – a principle used in the original Google PageRank algorithm<br>learn more about the metric and how it is calculated in <a href='https://dataforseo.com/help-center/what_is_rank_in_backlinks_api' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**FetchTime** | **string** | <em>date and time when our crawler visited the page</em><br>in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'<br>example:<br><code>2017-01-24 13:20:59 +00:00</code> |[optional]|
**Country** | **string** | <em>country code of the domain registration</em><br>to obtain a full list of available countries, refer to the <a href='/v3/content_analysis/locations/' rel='noopener noreferrer' target='_blank'>Locations</a> endpoint |[optional]|
**Language** | **string** | <em>main language of the domain</em><br>to obtain a full list of available languages, refer to the <a href='/v3/content_analysis/languages/' rel='noopener noreferrer' target='_blank'>Languages</a> endpoint |[optional]|
**Score** | **double?** | <em>citation prominence score</em><br>this value is based on <code>url_rank</code>, <code>domain_rank</code>, <code>keyword</code> presence in <code>title</code>, <code>main_title</code>, <code>url</code>, <code>snippet</code><br>the higher the <code>score</code>, the more value the related citation has |[optional]|
**PageCategory** | **IEnumerable<int?>** | <em>contains all relevant page categories</em><br>product and service categories relevant for the page<br>to obtain a full list of available categories, refer to the <a href='/v3/content_analysis/categories/' rel='noopener noreferrer' target='_blank'>Categories</a> endpoint |[optional]|
**PageTypes** | **IEnumerable<string>** | <em>page types</em> |[optional]|
**Ratings** | **IEnumerable<ContentRatingInfo>** | <em>ratings found on the page</em><br>all ratings found on the page based on microdata |[optional]|
**SocialMetrics** | **IEnumerable<SocialMetricsInfo>** | <em>social media engagement metrics</em><br>data on social media interactions associated with the content based on website embeds developed and supported by social media platforms |[optional]|
**ContentInfo** | **AnalysisContentInfo** | <em>contains data on citations from the given <code>url</code></em> |[optional]|