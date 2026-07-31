# OrganicSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em> absolute rank in SERP</em><br>absolute position among all the elements found in SERP<strong>note</strong> values are returned in the ascending order, with values corresponding to advanced SERP features omitted from the results;<br>to get all items (including SERP features and rich snippets) with their positions, please refer to the <a href='https://docs.dataforseo.com/v3/serp/google/organic/live/advanced/?php'>Google Organiс Advanced SERP</a> endpoint |[optional]|
**Domain** | **string** | <em>domain in SERP</em> |[optional]|
**Title** | **string** | <em>title of the results element in SERP</em> |[optional]|
**Description** | **string** | <em>description of the results element in SERP</em> |[optional]|
**Url** | **string** | <em> relevant URL in SERP</em> |[optional]|
**Breadcrumb** | **string** | <em>breadcrumb in SERP</em> |[optional]|
**CacheUrl** | **string** | cached version of the page |[optional]|
**RelatedSearchUrl** | **string** | URL to a similar search<br>URL to a new search for the same keyword(s) on related sites |[optional]|
**WebsiteName** | **string** | name of the website in SERP |[optional]|
**IsImage** | **bool?** | indicates whether the element contains an image<br>Note: this check no longer appears in SERP |[optional]|
**IsVideo** | **bool?** | indicates whether the element contains a video<br>Note: this check no longer appears in SERP |[optional]|
**IsFeaturedSnippet** | **bool?** | indicates whether the element is a featured_snippet<br>Note: this check no longer appears in SERP |[optional]|
**IsMalicious** | **bool?** | indicates whether the element is marked as malicious<br>Note: this check no longer appears in SERP |[optional]|
**IsWebStory** | **bool?** | indicates whether the element is marked as Google web story<br>Note: this check no longer appears in SERP |[optional]|
**Checks** | **IEnumerable<string>** | array of properties detected for the SERP element<br>lists the properties that are true for this element<br>each value in the array represents a detected property<br>example:<br>if is_image is present in the array, the element contains an image<br>possible values in the array:<br>is_image, is_video, is_featured_snippet, amp_version, is_malicious, is_web_story, is_highly_cited<br>equals null if none of the properties are detected for the element<br>learn more about the checks array in this Help Center article |[optional]|
**PreSnippet** | **string** | includes additional information appended before the result description in SERP |[optional]|
**ExtendedSnippet** | **string** | includes additional information appended after the result description in SERP |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | images of the element<br>if there are none, equals null |[optional]|
**AmpVersion** | **bool?** | Accelerated Mobile Pages<br>indicates whether an item has the Accelerated Mobile Page (AMP) version |[optional]|
**Rating** | **RatingInfo** | the item’s rating <br>the popularity rate based on reviews and displayed in SERP<br>if there is none, equals null |[optional]|
**Price** | **PriceInfo** | pricing details<br>contains the pricing details of the product or service featured in the result;<br>if there is none, equals null |[optional]|
**Highlighted** | **IEnumerable<string>** | words highlighted in bold within the results description |[optional]|
**Links** | **IEnumerable<LinkElement>** | link of the element |[optional]|
**Faq** | **FaqBox** | frequently asked questions<br>questions and answers extension shown below some of Google’s search results<br>Note: this object is deprecated and always returns null |[optional]|
**ExtendedPeopleAlsoSearch** | **IEnumerable<string>** | extension of the organic element<br>extension of the organic result containing related search queries<br>Note: extension appears in SERP upon clicking on the result and then bouncing back to search results |[optional]|
**AboutThisResult** | **AboutThisResultElement** | contains information from the ‘About this result’ panel<br>Note: this object is deprecated and always returns null |[optional]|
**RelatedResult** | **IEnumerable<RelatedResult>** | related result from the same domain<br>related result from the same domain appears as a part of the main result snippet;<br>you can derive the related_result snippets as 'type': 'organic' results by setting the group_organic_results parameter to false in the POST request |[optional]|
**Timestamp** | **string** | date and time when the result was published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|