# FeaturedSnippetSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements found in SERP<br>note values are returned in the ascending order, with values corresponding to advanced SERP features omitted from the results;<br>to get all items (including SERP features and rich snippets) with their positions, please refer to the Google Organiс Advanced SERP endpoint |[optional]|
**Domain** | **string** | domain of the ad element in SERP |[optional]|
**Title** | **string** | title of the ad element in SERP |[optional]|
**Description** | **string** | description of the ad element in SERP |[optional]|
**Url** | **string** | relevant URL of the ad element in SERP |[optional]|
**Breadcrumb** | **string** | breadcrumb of the ad element in SERP |[optional]|
**FeaturedTitle** | **string** | title |[optional]|
**Timestamp** | **string** | date and time when the result was published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Images** | **IEnumerable<AiModeImagesElement>** | images of the element |[optional]|
**Table** | **Table** | results table<br>if there are none, equals null |[optional]|