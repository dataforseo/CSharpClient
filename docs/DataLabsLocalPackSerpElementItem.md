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
**Rating** | **RatingElement** | the item’s rating <br>the popularity rate based on reviews and displayed in SERP |[optional]|
**MainDomain** | **string** | primary domain name in SERP |[optional]|
**RelativeUrl** | **string** | URL in SERP that does not specify the HTTPs protocol and domain name |[optional]|
**Etv** | **double?** | estimated traffic volume<br>estimated paid monthly traffic to the domain<br>calculated as the product of CTR (click-through-rate) and search volume values of all keywords in the category that the domain ranks for<br>learn more about how the metric is calculated in this help center article |[optional]|
**EstimatedPaidTrafficCost** | **double?** | estimated cost of monthly search traffic<br>represents the estimated cost of paid monthly traffic (USD) based on etv and cpc values of all keywords in the category that the domain ranks for<br>learn more about how the metric is calculated in this help center article |[optional]|
**ClickstreamEtv** | **double?** | estimated traffic volume based on clickstream data<br>calculated as the product of click-through-rate and clickstream search volume values of all keywords the domain ranks for<br>to retrieve results for this field, the parameter include_clickstream_data must be set to true<br>learn more about how the metric is calculated in this help center article |[optional]|
**RankChanges** | **RankChanges** | changes in rankings<br>contains information about the ranking changes of the SERP element since the previous_updated_time |[optional]|
**BacklinksInfo** | **BacklinksInfo** | backlinks information for the target website |[optional]|
**RankInfo** | **RankInfo** | page and domain rank information |[optional]|