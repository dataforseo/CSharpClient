# HotelReviewInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Value** | **float?** | overall hotel rating based on customer votes |[optional]|
**VotesCount** | **double?** | number of customer votes<br>the number of customer votes included in the calculation of the hotel rating |[optional]|
**Mentions** | **IEnumerable<ReviewMentionInfo>** | hotel mentions<br>information about hotel reviews by criteria |[optional]|
**RatingDistribution** | **IDictionary<string, int?>** | rating distribution by votes<br>the distribution of votes across the rating in the range from 1 to 5 |[optional]|
**OtherSitesReviews** | **IEnumerable<OtherSitesReviewsInfo>** | reviews on third-party sites<br>reviews from third-paty sites |[optional]|