# Paid


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Page** | **int?** | search results page number<br>indicates the number of the SERP page on which the element is located |[optional]|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**Title** | **string** | title of the result in SERP |[optional]|
**Domain** | **string** | domain in SERP |[optional]|
**WebsiteName** | **string** | name of the website in SERP |[optional]|
**Breadcrumb** | **string** | breadcrumb in SERP |[optional]|
**IsImage** | **bool?** | indicates whether the element contains an image |[optional]|
**IsVideo** | **bool?** | indicates whether the element contains a video |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | images of the element |[optional]|
**Url** | **string** | relevant URL |[optional]|
**Highlighted** | **IEnumerable<string>** | words highlighted in bold within the results description |[optional]|
**Extra** | **IDictionary<string, string>** | additional information about the result |[optional]|
**Description** | **string** | description of the results element in SERP |[optional]|
**DescriptionRows** | **IEnumerable<string>** | extended description<br>if there is none, equals null |[optional]|
**Links** | **IEnumerable<AdLinkElement>** | sitelinks<br>the links shown below some of Google’s search results<br>if there are none, equals null |[optional]|
**Price** | **PriceInfo** | pricing details<br>contains the pricing details of the product or service featured in the result |[optional]|
**Rating** | **AiModeRatingInfo** | the item’s rating <br>the popularity rate based on reviews and displayed in SERP |[optional]|
**Rectangle** | **AiModeRectangleInfo** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|