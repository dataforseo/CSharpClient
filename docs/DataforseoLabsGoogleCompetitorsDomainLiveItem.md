# DataforseoLabsGoogleCompetitorsDomainLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**Domain** | **string** | <em>domain name</em> |[optional]|
**AvgPosition** | **float?** | <em>average position of the domain in SERP</em><br><strong>Note:</strong> average position is calculated for intersected keywords only;<br>the value for a given domain may differ when combined with different target websites |[optional]|
**SumPosition** | **int?** | <em>sum of all domain positions in SERP</em><br><strong>Note:</strong> average position is calculated for intersected keywords only;<br>the value for a given domain may differ when combined with different target websites |[optional]|
**Intersections** | **int?** | <em>number of intersecting keywords</em> |[optional]|
**FullDomainMetrics** | **IDictionary<string, DataforseoLabsMetricsInfo>** | <em>metrics for all keywords of the domain</em><br>full overview of ranking and traffic data relevant to all keywords that the provided <code>domain</code> is ranking for |[optional]|
**Metrics** | **IDictionary<string, DataforseoLabsMetricsInfo>** | <em>metrics for intersecting keywords</em><br>ranking and traffic data relevant to the keywords that the provided <code>domain</code> shares with the <code>target</code> domain<br><strong>note:</strong> in this array ranking and traffic data is provided for the <code>target</code> considering the keywords <code>target</code> shares in search with the competitor's <code>domain</code> |[optional]|
**CompetitorMetrics** | **IDictionary<string, DataforseoLabsMetricsInfo>** | <em>metrics for intersecting keywords</em><br>ranking and traffic data relevant to the keywords that the provided <code>domain</code> shares with the <code>target</code> domain<br><strong>note:</strong> in this array ranking and traffic data is provided for the returned competitor's <code>domain</code> |[optional]|