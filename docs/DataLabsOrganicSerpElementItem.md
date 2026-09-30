# DataLabsOrganicSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Domain** | **string** | <em>subdomain in SERP</em> |[optional]|
**Title** | **string** | <em>title of the result in SERP</em> |[optional]|
**Url** | **string** | <em> relevant URL in SERP</em> |[optional]|
**Breadcrumb** | **string** | <em>breadcrumb in SERP</em> |[optional]|
**WebsiteName** | **string** | <em>relevant website name in SERP</em> |[optional]|
**IsImage** | **bool?** | <em>indicates whether the element contains an <code class='prettyprint'>image</code></em><br><strong>Note:</strong> this check no longer appears in SERP |[optional]|
**IsVideo** | **bool?** | <em>indicates whether the element contains a <code class='prettyprint'>video</code></em><br><strong>Note:</strong> this check no longer appears in SERP |[optional]|
**IsFeaturedSnippet** | **bool?** | <em>indicates whether the element is a <code class='prettyprint'>featured_snippet</code></em><br><strong>Note:</strong> this check no longer appears in SERP |[optional]|
**IsMalicious** | **bool?** | <em>indicates whether the element is marked as malicious</em><br><strong>Note:</strong> this check no longer appears in SERP |[optional]|
**Description** | **string** | <em>description of the results element in SERP</em> |[optional]|
**PreSnippet** | **string** | <em>includes additional information appended before the result description in SERP</em> |[optional]|
**ExtendedSnippet** | **string** | <em>includes additional information appended after the result description in SERP</em> |[optional]|
**AmpVersion** | **bool?** | <em>Accelerated Mobile Pages</em><br>            indicates whether an item has the Accelerated Mobile Page (AMP) version |[optional]|
**Rating** | **RatingInfo** | <em>the item's rating </em><br>            the popularity rate based on reviews and displayed in SERP |[optional]|
**Highlighted** | **IEnumerable<string>** | <em>words highlighted in bold within the results <code>description</code></em> |[optional]|
**Links** | **IEnumerable<LinkElement>** | <em>sitelinks</em><br>            the links shown below some of Google's search results<br>            if there are none, equals <code>null</code> |[optional]|
**AboutThisResult** | **AboutThisResultElement** | <em>contains information from the 'About this result' panel</em><br>            <a href='https://blog.google/products/search/learn-more-and-get-more-from-search/'>'About this result' panel</a> provides additional context about why Google returned this result for the given query;<br>            this feature appears after clicking on the three dots next to most results |[optional]|
**MainDomain** | **string** | <em>primary domain name in SERP</em> |[optional]|
**RelativeUrl** | **string** | <em>URL in SERP that does not specify the HTTPs protocol and domain name</em> |[optional]|
**Etv** | **double?** | <em>estimated traffic volume</em><br>            estimated organic monthly traffic to the domain or webpage;<br>            calculated as the product of CTR (click-through-rate) and search volume values of all keywords the domain or webpage rank for;<br>            learn more about how the metric is calculated in <a href='https://dataforseo.com/help-center/how-is-etv-calculated' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**EstimatedPaidTrafficCost** | **double?** | <em>estimated cost of converting organic search traffic into paid</em><br>            represents the estimated monthly cost of running ads for all keywords that a domain or webpage ranks for;<br>            the metric is calculated as the product of organic <code>etv</code> and paid <code>cpc</code> values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search;<br>            learn more about how the metric is calculated in <a href='https://dataforseo.com/help-center/how-is-traffic-cost-calculated' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**ClickstreamEtv** | **double?** | <em>estimated traffic volume based on clickstream data</em><br>            calculated as the product of click-through-rate and clickstream search volume values of all keywords the domain or webpage ranks for;<br>            to retrieve results for this field, the parameter <code>include_clickstream_data</code> must be set to <code>true</code>;<br>            learn more about how the metric is calculated in this <a href='https://dataforseo.com/help-center/whats-clickstream-estimated-traffic-volume-and-how-is-it-calculated' rel='noopener noreferrer' target='_blank'>help center article</a> |[optional]|
**RankChanges** | **RankChanges** | <em>changes in rankings</em><br>            contains information about the ranking changes of the SERP element since the <code>previous_updated_time</code> |[optional]|
**BacklinksInfo** | **BacklinksInfo** | <em>backlinks information for the relevant page URL</em> |[optional]|
**RankInfo** | **RankInfo** | <em>page and domain rank information</em> |[optional]|