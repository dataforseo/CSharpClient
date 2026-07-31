# DataforseoLabsAmazonProductCompetitorsLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**Asin** | **string** | <em>ASIN in a POST array</em> |[optional]|
**AvgPosition** | **float?** | <em>average position of the product in Amazon SERP</em><br><strong>Note:</strong> average position is calculated for intersected keywords only;<br>the value for a given product may differ when combined with different target products |[optional]|
**SumPosition** | **int?** | <em>sum of all product positions in Amazon SERP</em><br><strong>Note:</strong> average position is calculated for intersected keywords only;<br>the value for a given product may differ when combined with different target products |[optional]|
**Intersections** | **int?** | <em>number of intersecting keywords</em> |[optional]|
**CompetitorMetrics** | **AmazonMetricsBundleInfo** | <em>metrics for intersecting keywords</em><br>ranking data relevant to the keywords that the provided <code>asin</code> shares with the target <code>asin</code>;<br><strong>Note:</strong> in this object ranking data is provided for the returned competitor's <code>asin</code> |[optional]|
**FullMetrics** | **AmazonMetricsBundleInfo** | <em>metrics for all keywords of the product</em><br>full overview of ranking data relevant to all keywords that the provided <code>asin</code> is ranking for |[optional]|