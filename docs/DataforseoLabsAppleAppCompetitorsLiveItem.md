# DataforseoLabsAppleAppCompetitorsLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**AppId** | **string** | id of the competitor app |[optional]|
**AvgPosition** | **float?** | average position of the app in App Store SERP<br>Note: average position is calculated for intersected keywords only;<br>the value for a given application may differ when combined with different target applications |[optional]|
**SumPosition** | **double?** | sum of all app positions in App Store SERP<br>Note: sum position is calculated for intersected keywords only;<br>the value for a given application may differ when combined with different target applications |[optional]|
**Intersections** | **double?** | number of intersecting keywords |[optional]|
**CompetitorMetrics** | **AppStoreMetricsBundleInfo** | metrics for intersecting keywords<br>ranking data relevant to the keywords that the provided competitor application shares with the app in a POST request;<br>note: in this array ranking data is provided for the returned competitor’s app_id |[optional]|
**FullMetrics** | **AppStoreMetricsBundleInfo** | metrics for all keywords of the application<br>full overview of ranking data relevant to all keywords that the provided app_id is ranking for |[optional]|