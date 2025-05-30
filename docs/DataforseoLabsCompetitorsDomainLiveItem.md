# DataforseoLabsCompetitorsDomainLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**Domain** | **string** | domain name |[optional]|
**AvgPosition** | **float?** | average position of the domain in SERP<br>Note: average position is calculated for intersected keywords only;<br>the value for a given domain may differ when combined with different target websites |[optional]|
**SumPosition** | **double?** | sum of all domain positions in SERP<br>Note: average position is calculated for intersected keywords only;<br>the value for a given domain may differ when combined with different target websites |[optional]|
**Intersections** | **double?** | number of intersecting keywords |[optional]|
**FullDomainMetrics** | **IDictionary<string, DataforseoLabsMetricsInfo>** | metrics for all keywords of the domain<br>full overview of ranking and traffic data relevant to all keywords that the provided domain is ranking for |[optional]|
**Metrics** | **IDictionary<string, DataforseoLabsMetricsInfo>** | metrics for intersecting keywords<br>ranking and traffic data relevant to the keywords that the provided domain shares with the target domain<br>note: in this array ranking and traffic data is provided for the target considering the keywords target shares in search with the competitor’s domain |[optional]|
**CompetitorMetrics** | **IDictionary<string, DataforseoLabsMetricsInfo>** | metrics for intersecting keywords<br>ranking and traffic data relevant to the keywords that the provided domain shares with the target domain<br>note: in this array ranking and traffic data is provided for the returned competitor’s domain |[optional]|