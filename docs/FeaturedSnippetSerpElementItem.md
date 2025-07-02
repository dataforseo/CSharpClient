# FeaturedSnippetSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Domain** | **string** | domain of the ad element in SERP |[optional]|
**Title** | **string** | title of the ad element in SERP |[optional]|
**Description** | **string** | description of the ad element in SERP |[optional]|
**Url** | **string** | relevant URL of the ad element in SERP |[optional]|
**Breadcrumb** | **string** | breadcrumb of the ad element in SERP |[optional]|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**FeaturedTitle** | **string** | title |[optional]|
**Timestamp** | **string** | date and time when the result was published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Images** | **IEnumerable<ImagesElement>** | images of the element |[optional]|
**Table** | **Table** | results table<br>if there are none, equals null |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|