# ThirdPartyReviewsSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values;<br>positions of elements with different type values are omitted from rank_group;<br>always equals 0 for desktop |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP<br>always equals 0 for desktop |[optional]|
**ReviewsCount** | **long?** | the number of reviews |[optional]|
**Title** | **string** | reference page title |[optional]|
**Url** | **string** | URL |[optional]|
**Rating** | **RatingElement** | the element’s rating<br>the popularity rate based on reviews and displayed in SERP |[optional]|