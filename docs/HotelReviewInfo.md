# HotelReviewInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Value** | **double?** | <em>overall hotel rating based on customer votes</em> |[optional]|
**VotesCount** | **long?** | <em>number of customer votes</em><br>the number of customer votes included in the calculation of the hotel rating |[optional]|
**Mentions** | **IEnumerable<ReviewMentionInfo>** | <em>hotel mentions</em><br>information about hotel reviews by criteria |[optional]|
**RatingDistribution** | **IDictionary<string, int?>** | <em>rating distribution by votes</em><br>the distribution of votes across the rating in the range from 1 to 5 |[optional]|
**OtherSitesReviews** | **IEnumerable<OtherSitesReviewsInfo>** | <em>reviews on third-party sites</em><br>reviews from third-party sites |[optional]|