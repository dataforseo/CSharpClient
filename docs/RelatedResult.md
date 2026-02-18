# RelatedResult


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Page** | **int?** | search results page number<br>indicates the number of the SERP page on which the element is located |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**Domain** | **string** | website domain |[optional]|
**Title** | **string** | reference page title |[optional]|
**Url** | **string** | URL |[optional]|
**CacheUrl** | **string** | cached version of the page |[optional]|
**RelatedSearchUrl** | **string** | URL to a similar search<br>URL to a new search for the same keyword(s) on related sites |[optional]|
**Breadcrumb** | **string** | breadcrumb in SERP |[optional]|
**WebsiteName** | **string** | name of the website in the ad element |[optional]|
**IsImage** | **bool?** | indicates whether the element contains an image |[optional]|
**IsVideo** | **bool?** | indicates whether the element contains a video |[optional]|
**Description** | **string** | description of the hotel booking element |[optional]|
**PreSnippet** | **string** | includes additional information appended before the result description in SERP |[optional]|
**ExtendedSnippet** | **string** | includes additional information appended after the result description in SERP |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | images of the component<br>if there are none, equals null |[optional]|
**AmpVersion** | **bool?** | Accelerated Mobile Pages<br>indicates whether an item has the Accelerated Mobile Page (AMP) version |[optional]|
**Rating** | **RatingInfo** | the element’s rating<br>the popularity rate based on reviews and displayed in SERP;<br>if there is none, equals null |[optional]|
**Price** | **PriceInfo** | price indicated in the element |[optional]|
**Highlighted** | **IEnumerable<string>** | words highlighted in bold within the results description |[optional]|
**AboutThisResult** | **AboutThisResultElement** | contains information from the ‘About this result’ panel<br>‘About this result’ panel provides additional context about why Google returned this result for the given query;<br>this feature appears after clicking on the three dots next to most results |[optional]|
**Timestamp** | **string** | date and time when the video was published or indexed<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|