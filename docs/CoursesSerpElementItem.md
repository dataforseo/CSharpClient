# CoursesSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of the row |[optional]|
**Categories** | **IEnumerable<string>** | array of course categories<br>contains a list of categories relevant to courses |[optional]|
**Items** | **IEnumerable<CoursesElement>** | contains arrays of specific images |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|