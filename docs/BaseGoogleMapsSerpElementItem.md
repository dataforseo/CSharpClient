# BaseGoogleMapsSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **double?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **double?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Domain** | **string** | domain in SERP |[optional]|
**Title** | **string** | title of the element |[optional]|
**Url** | **string** | search URL with refinement parameters |[optional]|
**Rating** | **BusinessDataRatingInfo** | the element’s rating <br>the popularity rate based on reviews and displayed in SERP |[optional]|
**RatingDistribution** | **IDictionary<string, int?>** | the distribution of ratings of the business entity<br>the object displays the number of 1-star to 5-star ratings, as reviewed by users |[optional]|