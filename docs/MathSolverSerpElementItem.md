# MathSolverSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of the row |[optional]|
**Result** | **string** | solution to the equation<br>solution to the mathematical equation specified in the keyword field when setting a task |[optional]|
**Items** | **IEnumerable<MathSolverElement>** | contains arrays of specific images |[optional]|
**Links** | **IEnumerable<LinkElement>** | link of the element |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|