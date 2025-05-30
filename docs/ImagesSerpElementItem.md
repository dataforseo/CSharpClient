# ImagesSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of the row |[optional]|
**Url** | **string** | URL |[optional]|
**Items** | **IEnumerable<ImagesElement>** | contains arrays of specific images |[optional]|
**RelatedImageSearches** | **IEnumerable<RelatedImageSearchesElement>** | contains keywords and images related to the specified search term<br>if there are none, equals null |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|