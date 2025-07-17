# AmazonRankedSerpElement


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**SerpItem** | **AmazonInfo** | contains data on the SERP element<br>the list of supported SERP elements can be found below |[optional]|
**CheckUrl** | **string** | direct URL to Amazon results<br>you can use it to make sure that we provided accurate results |[optional]|
**SerpItemTypes** | **IEnumerable<string>** | direct URL to Amazon results<br>contains types of all search results (items) found in the returned SERP;<br>possible item types:<br>amazon_serp, amazon_paid, editorial_recommendations, top_rated_from_our_brands, related_searches |[optional]|
**SeResultsCount** | **long?** | total number of results in Amazon SERP |[optional]|
**LastUpdatedTime** | **string** | date and time when SERP data was last updated<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**PreviousUpdatedTime** | **string** | previous to the most recent update of SERP data<br>in the ISO 8601 format: “YYYY-MM-DDThh:mm:ss.sssssssZ”<br>example:<br>2020-09-12T00:07:43.0733218Z |[optional]|