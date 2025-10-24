# OrganicSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements found in SERP<br>note values are returned in the ascending order, with values corresponding to advanced SERP features omitted from the results;<br>to get all items (including SERP features and rich snippets) with their positions, please refer to the Google Organiс Advanced SERP endpoint |[optional]|
**Domain** | **string** | domain in SERP |[optional]|
**Title** | **string** | title of the results element in SERP |[optional]|
**Description** | **string** | description of the results element in SERP |[optional]|
**Url** | **string** | relevant URL in SERP |[optional]|
**Breadcrumb** | **string** | breadcrumb in SERP |[optional]|
**CacheUrl** | **string** | cached version of the page |[optional]|
**RelatedSearchUrl** | **string** | URL to a similar search<br>URL to a new search for the same keyword(s) on related sites |[optional]|
**WebsiteName** | **string** | name of the website in SERP |[optional]|
**IsImage** | **bool?** | indicates whether the element contains an image |[optional]|
**IsVideo** | **bool?** | indicates whether the element contains a video |[optional]|
**IsFeaturedSnippet** | **bool?** | indicates whether the element is a featured_snippet |[optional]|
**IsMalicious** | **bool?** | indicates whether the element is marked as malicious |[optional]|
**IsWebStory** | **bool?** | indicates whether the element is marked as Google web story |[optional]|
**PreSnippet** | **string** | includes additional information appended before the result description in SERP |[optional]|
**ExtendedSnippet** | **string** | includes additional information appended after the result description in SERP |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | images of the element<br>if there are none, equals null |[optional]|
**AmpVersion** | **bool?** | Accelerated Mobile Pages<br>indicates whether an item has the Accelerated Mobile Page (AMP) version |[optional]|
**Rating** | **RatingInfo** | the item’s rating <br>the popularity rate based on reviews and displayed in SERP |[optional]|
**Price** | **PriceInfo** | price of booking a place for the specified dates of stay |[optional]|
**Highlighted** | **IEnumerable<string>** | words highlighted in bold within the results description |[optional]|
**Links** | **IEnumerable<LinkElement>** | sitelinks<br>the links shown below some of Google’s search results<br>if there are none, equals null |[optional]|
**Faq** | **FaqBox** | frequently asked questions<br>questions and answers extension shown below some of Google’s search results<br>if there are none, equals null |[optional]|
**ExtendedPeopleAlsoSearch** | **IEnumerable<string>** | extension of the organic element<br>extension of the organic result containing related search queries<br>Note: extension appears in SERP upon clicking on the result and then bouncing back to search results |[optional]|
**AboutThisResult** | **AboutThisResultElement** | contains information from the ‘About this result’ panel<br>‘About this result’ panel provides additional context about why Google returned this result for the given query;<br>this feature appears after clicking on the three dots next to most results |[optional]|
**RelatedResult** | **IEnumerable<RelatedResult>** | related result from the same domain<br>related result from the same domain appears as a part of the main result snippet;<br>you can derive the related_result snippets as 'type': 'organic' results by setting the group_organic_results parameter to false in the POST request |[optional]|
**Timestamp** | **string** | date and time when the result was published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|