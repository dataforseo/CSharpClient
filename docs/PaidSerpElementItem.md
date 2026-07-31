# PaidSerpElementItem


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
**WebsiteName** | **string** | name of the website in SERP |[optional]|
**IsImage** | **bool?** | indicates whether the element contains an image<br>Note: this check no longer appears in SERP |[optional]|
**IsVideo** | **bool?** | indicates whether the element contains a video<br>Note: this check no longer appears in SERP |[optional]|
**Checks** | **IEnumerable<string>** | array of properties detected for the SERP element<br>lists the properties that are true for this element<br>each value in the array represents a detected property<br>example:<br>if is_image is present in the array, the element contains an image<br>possible values in the array:<br>is_image, is_video, is_featured_snippet, amp_version, is_malicious, is_web_story, is_highly_cited<br>equals null if none of the properties are detected for the element<br>learn more about the checks array in this Help Center article |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | images of the element<br>if there are none, equals null |[optional]|
**Highlighted** | **IEnumerable<string>** | words highlighted in bold within the results description |[optional]|
**Extra** | **IDictionary<string, string>** | additional information about the result |[optional]|
**DescriptionRows** | **IEnumerable<string>** | extended description<br>if there is none, equals null |[optional]|
**Links** | **IEnumerable<AdLinkElement>** | link of the element |[optional]|
**Price** | **PriceInfo** | pricing details<br>contains the pricing details of the product or service featured in the result;<br>if there is none, equals null |[optional]|
**Rating** | **RatingInfo** | the item’s rating <br>the popularity rate based on reviews and displayed in SERP<br>if there is none, equals null |[optional]|