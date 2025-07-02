# FeaturedSnippetDataforseoLabsSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**Domain** | **string** | subdomain in SERP |[optional]|
**Title** | **string** | title of the result in SERP |[optional]|
**FeaturedTitle** | **string** | the title of the featured snippets source page |[optional]|
**Description** | **string** | description of the results element in SERP |[optional]|
**Url** | **string** | relevant URL in SERP |[optional]|
**Table** | **Table** | results table<br>if there are none, equals null |[optional]|
**MainDomain** | **string** | primary domain name in SERP |[optional]|
**RelativeUrl** | **string** | relative URL in SERP |[optional]|
**Etv** | **float?** | estimated traffic volume<br>estimated organic monthly traffic to the domain;<br>calculated as the product of CTR (click-through-rate) and search volume values of the returned keyword<br>learn more about how the metric is calculated in this help center article |[optional]|
**EstimatedPaidTrafficCost** | **float?** | estimated cost of converting organic search traffic into paid<br>represents the estimated monthly cost of running ads (USD) for the returned keyword;<br>the metric is calculated as the product of organic etv and paid cpc values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Bing Search<br>learn more about how the metric is calculated in this help center article |[optional]|
**RankChanges** | **RankChanges** | changes in rankings<br>contains information about the ranking changes of the SERP element since the previous_updated_time |[optional]|
**BacklinksInfo** | **BacklinksInfo** |  |[optional]|
**RankInfo** | **RankInfo** |  |[optional]|