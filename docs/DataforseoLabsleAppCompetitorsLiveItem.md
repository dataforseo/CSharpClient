# DataforseoLabsleAppCompetitorsLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**AppId** | **string** | id of the competitor app |[optional]|
**AvgPosition** | **float?** | average position of the app in Google Play SERP<br>Note: average position is calculated for intersected keywords only;<br>the value for a given application may differ when combined with different target applications |[optional]|
**SumPosition** | **int?** | sum of all app positions in Google Play SERP<br>Note: sum position is calculated for intersected keywords only;<br>the value for a given application may differ when combined with different target applications |[optional]|
**Intersections** | **int?** | number of intersecting keywords |[optional]|
**CompetitorMetrics** | **IDictionary<string, AppMetricsInfo>** | metrics for intersecting keywords<br>ranking data relevant to the keywords that the provided competitor application shares with the app in a POST request;<br>note: in this array ranking data is provided for the returned competitor’s app_id |[optional]|
**FullMetrics** | **IDictionary<string, AppMetricsInfo>** | metrics for all keywords of the application<br>full overview of ranking data relevant to all keywords that the provided app_id is ranking for |[optional]|