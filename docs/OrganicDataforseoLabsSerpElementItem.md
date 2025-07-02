# OrganicDataforseoLabsSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**Domain** | **string** | subdomain in SERP |[optional]|
**Title** | **string** | title of the result in SERP |[optional]|
**Url** | **string** | relevant URL in SERP |[optional]|
**Breadcrumb** | **string** | breadcrumb in SERP |[optional]|
**WebsiteName** | **string** | relevant website name in SERP |[optional]|
**IsImage** | **bool?** | indicates whether the element contains an image |[optional]|
**IsVideo** | **bool?** | indicates whether the element contains a video |[optional]|
**IsFeaturedSnippet** | **bool?** | indicates whether the element is a featured_snippet |[optional]|
**IsMalicious** | **bool?** | indicates whether the element is marked as malicious |[optional]|
**Description** | **string** | description of the results element in SERP |[optional]|
**PreSnippet** | **string** | includes additional information appended before the result description in SERP |[optional]|
**ExtendedSnippet** | **string** | includes additional information appended after the result description in SERP |[optional]|
**AmpVersion** | **bool?** | Accelerated Mobile Pages<br>indicates whether an item has the Accelerated Mobile Page (AMP) version |[optional]|
**Rating** | **RatingInfo** | the item’s rating <br>the popularity rate based on reviews and displayed in SERP |[optional]|
**Highlighted** | **IEnumerable<string>** | words highlighted in bold within the results description |[optional]|
**Links** | **IEnumerable<LinkElement>** | sitelinks<br>the links shown below some of Google’s search results<br>if there are none, equals null |[optional]|
**AboutThisResult** | **IDictionary<string, AboutThisResultElement>** | contains information from the ‘About this result’ panel<br>‘About this result’ panel provides additional context about why Google returned this result for the given query;<br>this feature appears after clicking on the three dots next to most results |[optional]|
**MainDomain** | **string** | primary domain name in SERP |[optional]|
**RelativeUrl** | **string** | URL in SERP that does not specify the HTTPs protocol and domain name |[optional]|
**Etv** | **float?** | estimated traffic volume<br>estimated paid monthly traffic to the domain<br>calculated as the product of CTR (click-through-rate) and search volume values of all keywords in the category that the domain ranks for<br>learn more about how the metric is calculated in this help center article |[optional]|
**ImpressionsEtv** | **float?** | estimated traffic volume based on impressions<br>estimated paid monthly traffic to the domain<br>calculated as the product of CTR (click-through-rate) and impressions values of all keywords in the category that the domain ranks for<br>learn more about how the metric is calculated in this help center article |[optional]|
**EstimatedPaidTrafficCost** | **float?** | estimated cost of monthly search traffic<br>represents the estimated cost of paid monthly traffic (USD) based on etv and cpc values of all keywords in the category that the domain ranks for<br>learn more about how the metric is calculated in this help center article |[optional]|
**ClickstreamEtv** | **int?** | estimated traffic volume based on clickstream data<br>calculated as the product of click-through-rate and clickstream search volume values of all keywords the domain ranks for<br>to retrieve results for this field, the parameter include_clickstream_data must be set to true<br>learn more about how the metric is calculated in this help center article |[optional]|
**RankChanges** | **RankChanges** | changes in rankings<br>contains information about the ranking changes of the SERP element since the previous_updated_time |[optional]|
**BacklinksInfo** | **BacklinksInfo** | backlinks information for the target website |[optional]|
**RankInfo** | **RankInfo** | page and domain rank information |[optional]|