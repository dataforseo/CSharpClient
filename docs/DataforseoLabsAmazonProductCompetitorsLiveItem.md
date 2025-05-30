# DataforseoLabsAmazonProductCompetitorsLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**Asin** | **string** | ASIN of the product<br>unique product identifier on Amazon;<br>for more information, refer to this help center guide |[optional]|
**AvgPosition** | **float?** | average position of the product in Amazon SERP<br>Note: average position is calculated for intersected keywords only;<br>the value for a given product may differ when combined with different target products |[optional]|
**SumPosition** | **double?** | sum of all product positions in Amazon SERP<br>Note: average position is calculated for intersected keywords only;<br>the value for a given product may differ when combined with different target products |[optional]|
**Intersections** | **double?** | number of intersecting keywords |[optional]|
**CompetitorMetrics** | **AmazonMetricsBundleInfo** | metrics for intersecting keywords<br>ranking data relevant to the keywords that the provided asin shares with the target asin;<br>Note: in this object ranking data is provided for the returned competitor’s asin |[optional]|
**FullMetrics** | **AmazonMetricsBundleInfo** | metrics for all keywords of the product<br>full overview of ranking data relevant to all keywords that the provided asin is ranking for |[optional]|