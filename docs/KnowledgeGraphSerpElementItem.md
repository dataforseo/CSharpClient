# KnowledgeGraphSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of the result in SERP |[optional]|
**Subtitle** | **string** | subtitle of the item |[optional]|
**Description** | **string** | description of the results element in SERP |[optional]|
**CardId** | **string** | card id |[optional]|
**Url** | **string** | relevant URL in SERP |[optional]|
**ImageUrl** | **string** | URL of the image<br>the URL leading to the image on the original resource or DataForSEO storage (in case the original source is not available) |[optional]|
**LogoUrl** | **string** | URL of the logo from knowledge graph |[optional]|
**Cid** | **string** | google-defined client id<br>unique id of a local establishment;<br>can be used with Google Reviews API to get a full list of reviews |[optional]|
**Items** | **IEnumerable<BaseSerpElementItem>** | contains results featured in the ‘hotels_pack’ element of SERP |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|