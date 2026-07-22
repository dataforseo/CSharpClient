# ImagesSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values;<br>positions of elements with different type values are omitted from rank_group;<br>always equals 0 for desktop |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP<br>always equals 0 for desktop |[optional]|
**Title** | **string** | title of the row |[optional]|
**Url** | **string** | URL of the third-party review source |[optional]|
**Items** | **IEnumerable<AiModeImagesElementInfo>** | contains arrays of elements available in the list |[optional]|
**RelatedImageSearches** | **IEnumerable<RelatedImageSearchesElement>** | contains keywords and images related to the specified search term<br>Note: this array is deprecated and always returns null |[optional]|