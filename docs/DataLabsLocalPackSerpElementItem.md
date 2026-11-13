# DataLabsLocalPackSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of the result in SERP |[optional]|
**Description** | **string** | description of the results element in SERP |[optional]|
**Domain** | **string** | subdomain in SERP |[optional]|
**Phone** | **string** | phone number |[optional]|
**Url** | **string** | relevant URL in SERP |[optional]|
**IsPaid** | **bool?** | indicates whether the element is an ad |[optional]|
**Rating** | **RatingInfo** | the item's rating             the popularity rate based on reviews and displayed in SERP |[optional]|
**MainDomain** | **string** | primary domain name in SERP |[optional]|
**RelativeUrl** | **string** | URL in SERP that does not specify the HTTPs protocol and domain name |[optional]|
**Etv** | **double?** | estimated traffic volume            estimated organic monthly traffic to the domain            calculated as the product of CTR (click-through-rate) and search volume values of the returned keyword            learn more about how the metric is calculated in this help center article |[optional]|
**EstimatedPaidTrafficCost** | **double?** | estimated cost of paid monthly search traffic            represents the estimated cost of paid monthly traffic (USD) based on etv and cpc values            learn more about how the metric is calculated in this help center article |[optional]|
**ClickstreamEtv** | **double?** | estimated traffic volume based on clickstream data            calculated as the product of click-through-rate and clickstream search volume values of all keywords the domain ranks for            to retrieve results for this field, the parameter include_clickstream_data must be set to true            learn more about how the metric is calculated in this help center article |[optional]|
**RankChanges** | **RankChanges** | changes in rankings            contains information about the ranking changes of the SERP element since the previous_updated_time |[optional]|
**BacklinksInfo** | **BacklinksInfo** | backlinks information for the ranked website |[optional]|
**RankInfo** | **RankInfo** | page and domain rank information |[optional]|