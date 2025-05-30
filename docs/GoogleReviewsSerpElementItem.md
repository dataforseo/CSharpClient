# GoogleReviewsSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**ReviewsCount** | **double?** | the number of reviews |[optional]|
**Rating** | **BusinessDataRatingInfo** | the element’s rating<br>the popularity rate based on reviews and displayed in SERP |[optional]|
**PlaceId** | **string** | the identifier of a place |[optional]|
**Feature** | **string** | the additional feature of the review |[optional]|
**Cid** | **string** | google-defined client id |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|