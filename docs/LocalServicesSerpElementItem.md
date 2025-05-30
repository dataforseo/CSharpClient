# LocalServicesSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of the row |[optional]|
**Url** | **string** | URL |[optional]|
**Domain** | **string** | domain in the URL |[optional]|
**Items** | **IEnumerable<LocalServicesElement>** | contains arrays of specific images |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|