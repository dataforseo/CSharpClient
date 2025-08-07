# DataLabsOrganicSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Domain** | **string** | domain in SERP |[optional]|
**Title** | **string** | title of the result in SERP |[optional]|
**Url** | **string** | sitelink URL |[optional]|
**Breadcrumb** | **string** | breadcrumb in SERP |[optional]|
**WebsiteName** | **string** | name of the website in SERP |[optional]|
**IsImage** | **bool?** | indicates whether the element contains an image |[optional]|
**IsVideo** | **bool?** | indicates whether the element contains a video |[optional]|
**IsFeaturedSnippet** | **bool?** | indicates whether the element is a featured_snippet |[optional]|
**IsMalicious** | **bool?** | indicates whether the element is marked as malicious |[optional]|
**Description** | **string** | description of the results element in SERP |[optional]|
**PreSnippet** | **string** | includes additional information appended before the result description in SERP |[optional]|
**ExtendedSnippet** | **string** | includes additional information appended after the result description in SERP |[optional]|
**AmpVersion** | **bool?** | Accelerated Mobile Pages<br>indicates whether an item has the Accelerated Mobile Page (AMP) version |[optional]|
**Rating** | **RatingElement** | the item’s rating <br>the popularity rate based on reviews and displayed in SERP |[optional]|
**Highlighted** | **IEnumerable<string>** | words highlighted in bold within the results description |[optional]|
**Links** | **IEnumerable<LinkElement>** | sitelinks<br>the links shown below some of Google’s search results<br>if there are none, equals null |[optional]|
**AboutThisResult** | **AboutThisResultElement** | contains information from the ‘About this result’ panel<br>‘About this result’ panel provides additional context about why Google returned this result for the given query;<br>this feature appears after clicking on the three dots next to most results |[optional]|
**MainDomain** | **string** | primary domain name in SERP |[optional]|
**RelativeUrl** | **string** | URL in SERP that does not specify the HTTPs protocol and domain name |[optional]|
**Etv** | **double?** | estimated traffic volume<br>estimated organic monthly traffic a featured URL delivers to the domain<br>calculated as the product of CTR (click-through-rate) and search volume values of the returned keyword<br>learn more about how the metric is calculated in this help center article |[optional]|
**EstimatedPaidTrafficCost** | **double?** | estimated cost of converting organic search traffic into paid<br>represents the estimated monthly cost of running ads for the returned keyword<br>the metric is calculated as the product of organic etv and paid cpc values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search<br>learn more about how the metric is calculated in this help center article |[optional]|
**ClickstreamEtv** | **double?** |  |[optional]|
**RankChanges** | **RankChanges** | changes in rankings<br>ranking changes of the SERP element compared to the preceding month;<br>Note: the changes are calculated even if the preceding month is not included in a POST request |[optional]|
**BacklinksInfo** | **BacklinksInfo** | backlinks information for the ranked website |[optional]|
**RankInfo** | **RankInfo** | page and domain rank information |[optional]|