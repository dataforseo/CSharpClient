# DataLabsLocalPackSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of the result in SERP |[optional]|
**Description** | **string** | description of the results element in SERP |[optional]|
**Domain** | **string** | domain in SERP |[optional]|
**Phone** | **string** | phone number |[optional]|
**Url** | **string** | sitelink URL |[optional]|
**IsPaid** | **bool?** | indicates whether the element is an ad |[optional]|
**Rating** | **RatingElement** | the item’s rating <br>the popularity rate based on reviews and displayed in SERP |[optional]|
**MainDomain** | **string** | primary domain name in SERP |[optional]|
**RelativeUrl** | **string** | URL in SERP that does not specify the HTTPs protocol and domain name |[optional]|
**Etv** | **double?** | estimated traffic volume<br>estimated organic monthly traffic a featured URL delivers to the domain<br>calculated as the product of CTR (click-through-rate) and search volume values of the returned keyword<br>learn more about how the metric is calculated in this help center article |[optional]|
**EstimatedPaidTrafficCost** | **double?** | estimated cost of converting organic search traffic into paid<br>represents the estimated monthly cost of running ads for the returned keyword<br>the metric is calculated as the product of organic etv and paid cpc values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search<br>learn more about how the metric is calculated in this help center article |[optional]|
**ClickstreamEtv** | **double?** |  |[optional]|
**RankChanges** | **RankChanges** | changes in rankings<br>ranking changes of the SERP element compared to the preceding month;<br>Note: the changes are calculated even if the preceding month is not included in a POST request |[optional]|
**BacklinksInfo** | **BacklinksInfo** | backlinks information for the ranked website |[optional]|
**RankInfo** | **RankInfo** | page and domain rank information |[optional]|