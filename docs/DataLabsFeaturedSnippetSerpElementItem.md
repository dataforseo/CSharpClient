# DataLabsFeaturedSnippetSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Domain** | **string** | <em>domain in SERP</em> |[optional]|
**Title** | **string** | <em>title of the result in SERP</em> |[optional]|
**FeaturedTitle** | **string** | <em>title of a given element</em> |[optional]|
**Description** | **string** | <em>description of the results element in SERP</em> |[optional]|
**Url** | **string** | <em> relevant URL in SERP</em> |[optional]|
**Table** | **Table** | <em>table element</em> |[optional]|
**MainDomain** | **string** | <em>primary domain name in SERP</em> |[optional]|
**RelativeUrl** | **string** | <em>URL in SERP that does not specify the HTTPs protocol and domain name</em> |[optional]|
**Etv** | **double?** | <em>estimated traffic volume</em><br>            estimated organic monthly traffic a featured URL delivers to the domain<br>            calculated as the product of CTR (click-through-rate) and search volume values of the returned keyword<br>            learn more about how the metric is calculated in <a href='https://dataforseo.com/help-center/how-is-etv-calculated' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**EstimatedPaidTrafficCost** | **double?** | <em>estimated cost of converting organic search traffic into paid</em><br>            represents the estimated monthly cost of running ads for the returned keyword<br>            the metric is calculated as the product of organic <code>etv</code> and paid <code>cpc</code> values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search<br>            learn more about how the metric is calculated in <a href='https://dataforseo.com/help-center/how-is-traffic-cost-calculated' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**ClickstreamEtv** | **double?** |  |[optional]|
**RankChanges** | **RankChanges** | <em>changes in rankings</em><br>            ranking changes of the SERP element compared to the preceding month;<br>            <strong>Note:</strong> the changes are calculated even if the preceding month is not included in a POST request |[optional]|
**BacklinksInfo** | **BacklinksInfo** | <em>backlinks information for the ranked website</em> |[optional]|
**RankInfo** | **RankInfo** | <em>page and domain rank information</em> |[optional]|