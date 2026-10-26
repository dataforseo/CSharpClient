# DataLabsOrganicSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Domain** | **string** | subdomain in SERP |[optional]|
**Title** | **string** | title of the result in SERP |[optional]|
**Url** | **string** | relevant URL in SERP |[optional]|
**Breadcrumb** | **string** | breadcrumb in SERP |[optional]|
**WebsiteName** | **string** |  |[optional]|
**IsImage** | **bool?** | indicates whether the element contains an imageNote: this check no longer appears in SERP |[optional]|
**IsVideo** | **bool?** | indicates whether the element contains a videoNote: this check no longer appears in SERP |[optional]|
**IsFeaturedSnippet** | **bool?** | indicates whether the element is a featured_snippetNote: this check no longer appears in SERP |[optional]|
**IsMalicious** | **bool?** | indicates whether the element is marked as maliciousNote: this check no longer appears in SERP |[optional]|
**Checks** | **IEnumerable<string>** | array of properties detected for the SERP elementlists the properties that are true for this elementeach value in the array represents a detected property example:if is_image is present in the array, the element contains an imagepossible values in the array:is_image, is_video, is_featured_snippet, amp_version, is_malicious, is_web_story, is_highly_citedequals null if none of the properties are detected for the elementlearn more about the checks array in this Help Center article |[optional]|
**Description** | **string** | description of the results element in SERP |[optional]|
**PreSnippet** | **string** |  |[optional]|
**ExtendedSnippet** | **string** |  |[optional]|
**AmpVersion** | **bool?** |  |[optional]|
**Rating** | **RatingInfo** | the item's rating             the popularity rate based on reviews and displayed in SERP |[optional]|
**Highlighted** | **IEnumerable<string>** | words highlighted in bold within the results description |[optional]|
**Links** | **IEnumerable<LinkElement>** | sitelinks            the links shown below some of Google's search results            if there are none, equals null |[optional]|
**AboutThisResult** | **AboutThisResultElement** |  |[optional]|
**MainDomain** | **string** | primary domain name in SERP |[optional]|
**RelativeUrl** | **string** | URL in SERP that does not specify the HTTPs protocol and domain name |[optional]|
**Etv** | **double?** | estimated traffic volume            estimated organic monthly traffic to the domain            calculated as the product of CTR (click-through-rate) and search volume values of the returned keyword            learn more about how the metric is calculated in this help center article |[optional]|
**EstimatedPaidTrafficCost** | **double?** | estimated cost of paid monthly search traffic            represents the estimated cost of paid monthly traffic (USD) based on etv and cpc values            learn more about how the metric is calculated in this help center article |[optional]|
**ClickstreamEtv** | **double?** | estimated traffic volume based on clickstream data            calculated as the product of click-through-rate and clickstream search volume values of all keywords the domain ranks for            to retrieve results for this field, the parameter include_clickstream_data must be set to true            learn more about how the metric is calculated in this help center article |[optional]|
**RankChanges** | **RankChanges** | changes in rankings            contains information about the ranking changes of the SERP element since the previous_updated_time |[optional]|
**BacklinksInfo** | **BacklinksInfo** | backlinks information for the ranked website |[optional]|
**RankInfo** | **RankInfo** | page and domain rank information |[optional]|