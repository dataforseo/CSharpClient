# DataLabsFeaturedSnippetSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Domain** | **string** | subdomain in SERP |[optional]|
**Title** | **string** | title of the result in SERP |[optional]|
**FeaturedTitle** | **string** | the title of the featured snippets source page |[optional]|
**Description** | **string** | description of the results element in SERP |[optional]|
**Url** | **string** | relevant URL in SERP |[optional]|
**Table** | **Table** | results table            if there are none, equals null |[optional]|
**MainDomain** | **string** | primary domain name in SERP |[optional]|
**RelativeUrl** | **string** | URL in SERP that does not specify the HTTPs protocol and domain name |[optional]|
**Etv** | **double?** | estimated traffic volume            estimated organic monthly traffic to the domain            calculated as the product of CTR (click-through-rate) and search volume values of the returned keyword            learn more about how the metric is calculated in this help center article |[optional]|
**EstimatedPaidTrafficCost** | **double?** | estimated cost of paid monthly search traffic            represents the estimated cost of paid monthly traffic (USD) based on etv and cpc values            learn more about how the metric is calculated in this help center article |[optional]|
**ClickstreamEtv** | **double?** | estimated traffic volume based on clickstream data            calculated as the product of click-through-rate and clickstream search volume values of all keywords the domain ranks for            to retrieve results for this field, the parameter include_clickstream_data must be set to true            learn more about how the metric is calculated in this help center article |[optional]|
**RankChanges** | **RankChanges** | changes in rankings            contains information about the ranking changes of the SERP element since the previous_updated_time |[optional]|
**BacklinksInfo** | **BacklinksInfo** | backlinks information for the ranked website |[optional]|
**RankInfo** | **RankInfo** | page and domain rank information |[optional]|