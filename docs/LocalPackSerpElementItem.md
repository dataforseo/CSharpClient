# LocalPackSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**Title** | **string** | title of the row |[optional]|
**Description** | **string** | description of the results element in SERP |[optional]|
**Domain** | **string** | source domain |[optional]|
**Phone** | **string** | phone number |[optional]|
**Url** | **string** | source URL |[optional]|
**IsPaid** | **bool?** | indicates whether the element is an ad |[optional]|
**Rating** | **RatingInfo** | the element’s rating<br>the popularity rate based on reviews and displayed in SERP |[optional]|
**Cid** | **string** | google-defined client id |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|