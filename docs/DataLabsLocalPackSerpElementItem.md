# DataLabsLocalPackSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | <em>title of the result in SERP</em> |[optional]|
**Description** | **string** | <em>description of the results element in SERP</em> |[optional]|
**Domain** | **string** | <em>subdomain in SERP</em> |[optional]|
**Phone** | **string** | <em>phone number</em> |[optional]|
**Url** | **string** | <em> relevant URL in SERP</em> |[optional]|
**IsPaid** | **bool?** | <em>indicates whether the element is an ad</em> |[optional]|
**Rating** | **RatingInfo** | <em>the item's rating </em><br>            the popularity rate based on reviews and displayed in SERP |[optional]|
**MainDomain** | **string** | <em>primary domain name in SERP</em> |[optional]|
**RelativeUrl** | **string** | <em>URL in SERP that does not specify the HTTPs protocol and domain name</em> |[optional]|
**Etv** | **double?** | <em>estimated traffic volume</em><br>            estimated organic monthly traffic to the domain or webpage;<br>            calculated as the product of CTR (click-through-rate) and search volume values of all keywords the domain or webpage rank for;<br>            learn more about how the metric is calculated in <a href='https://dataforseo.com/help-center/how-is-etv-calculated' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**EstimatedPaidTrafficCost** | **double?** | <em>estimated cost of converting organic search traffic into paid</em><br>            represents the estimated monthly cost of running ads for all keywords that a domain or webpage ranks for;<br>            the metric is calculated as the product of organic <code>etv</code> and paid <code>cpc</code> values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search;<br>            learn more about how the metric is calculated in <a href='https://dataforseo.com/help-center/how-is-traffic-cost-calculated' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**ClickstreamEtv** | **double?** | <em>estimated traffic volume based on clickstream data</em><br>            calculated as the product of click-through-rate and clickstream search volume values of all keywords the domain or webpage ranks for;<br>            to retrieve results for this field, the parameter <code>include_clickstream_data</code> must be set to <code>true</code>;<br>            learn more about how the metric is calculated in this <a href='https://dataforseo.com/help-center/whats-clickstream-estimated-traffic-volume-and-how-is-it-calculated' rel='noopener noreferrer' target='_blank'>help center article</a> |[optional]|
**RankChanges** | **RankChanges** | <em>changes in rankings</em><br>            contains information about the ranking changes of the SERP element since the <code>previous_updated_time</code> |[optional]|
**BacklinksInfo** | **BacklinksInfo** | <em>backlinks information for the relevant page URL</em> |[optional]|
**RankInfo** | **RankInfo** | <em>page and domain rank information</em> |[optional]|