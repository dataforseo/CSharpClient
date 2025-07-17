# PaidSerpElementItem


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
**WebsiteName** | **string** | name of the website in SERP |[optional]|
**IsImage** | **bool?** | indicates whether the element contains an image |[optional]|
**IsVideo** | **bool?** | indicates whether the element contains a video |[optional]|
**Images** | **IEnumerable<AiModeImagesElement>** | images of the element<br>if there are none, equals null |[optional]|
**Highlighted** | **IEnumerable<string>** | words highlighted in bold within the results description |[optional]|
**Extra** | **IDictionary<string, string>** | additional information about the result |[optional]|
**DescriptionRows** | **IEnumerable<string>** | extended description<br>if there is none, equals null |[optional]|
**Links** | **IEnumerable<AdLinkElement>** | sitelinks<br>the links shown below some of Google’s search results<br>if there are none, equals null |[optional]|
**Price** | **PriceInfo** | pricing details<br>contains the pricing details of the product or service featured in the result |[optional]|
**Rating** | **RatingElement** | the item’s rating <br>the popularity rate based on reviews and displayed in SERP |[optional]|