# SerpApiGoogleImagesRelatedSearchesElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**Items** | **IEnumerable<string>** | items of the element |[optional]|
**Rectangle** | **AiModeRectangleInfo** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>note: calculate_rectangles parameter is not yet available when setting tasks for this search engine type, that’s why rectangle always equals null |[optional]|