# RelatedResult


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Page** | **int?** | search results page number<br>indicates the number of the SERP page on which the element is located |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**Domain** | **string** | website domain |[optional]|
**Title** | **string** | title of a given link element |[optional]|
**Url** | **string** | URL |[optional]|
**CacheUrl** | **string** | cached version of the page |[optional]|
**RelatedSearchUrl** | **string** | URL to a similar search<br>URL to a new search for the same keyword(s) on related sites |[optional]|
**Breadcrumb** | **string** | breadcrumb in SERP |[optional]|
**WebsiteName** | **string** | name of the website in the ad element |[optional]|
**IsImage** | **bool?** | indicates whether the element contains an image<br>Note: this check no longer appears in SERP |[optional]|
**IsVideo** | **bool?** | indicates whether the element contains a video<br>Note: this check no longer appears in SERP |[optional]|
**Checks** | **IEnumerable<string>** | array of properties detected for the SERP element<br>lists the properties that are true for this element<br>each value in the array represents a detected property<br>example:<br>if is_image is present in the array, the element contains an image<br>possible values in the array:<br>is_image, is_video, is_featured_snippet, amp_version, is_malicious, is_web_story, is_highly_cited<br>equals null if none of the properties are detected for the element<br>learn more about the checks array in this Help Center article |[optional]|
**Description** | **string** | description of the results element in SERP |[optional]|
**PreSnippet** | **string** | includes additional information appended before the result description in SERP |[optional]|
**ExtendedSnippet** | **string** | includes additional information appended after the result description in SERP |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | images of the component<br>if there are none, equals null |[optional]|
**AmpVersion** | **bool?** | Accelerated Mobile Pages<br>indicates whether an item has the Accelerated Mobile Page (AMP) version |[optional]|
**Rating** | **RatingInfo** | the item’s rating <br>the popularity rate based on reviews and displayed in SERP;<br>if there is none, equals null |[optional]|
**Price** | **PriceInfo** | price of booking a place for the specified dates of stay |[optional]|
**Highlighted** | **IEnumerable<string>** | words highlighted in bold within the results description |[optional]|
**AboutThisResult** | **AboutThisResultElement** | contains information from the ‘About this result’ panel<br>Note: this object is deprecated and always returns null |[optional]|
**Timestamp** | **string** | date and time when the result was published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|