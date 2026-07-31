# DataforseoLabsleAppIntersectionLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**KeywordData** | **KeywordDataInfo** | <em>keyword data for the returned keyword</em> |[optional]|
**IntersectionResult** | **IDictionary<string, GooglePlaySearchOrganic>** | <em>contains SERP data for the returned <code>keyword</code></em><br>data will be provided in separate arrays for each app ID you specified in the <code>app_ids</code> object when setting a task;<br>depending on the number of specified app IDs, it can contain from 1 to 20 arrays named respectively |[optional]|