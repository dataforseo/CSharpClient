# ClickstreamKeywordInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SearchVolume** | **long?** | current search volume rate of a keyword |[optional]|
**LastUpdatedTime** | **string** | date and time when backlink data was updated<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**GenderDistribution** | **IDictionary<string, long?>** | distribution of estimated clickstream-based metrics by gender<br>learn more about how the metric is calculated in this help center article |[optional]|
**AgeDistribution** | **IDictionary<string, long?>** | distribution of clickstream-based metrics by age<br>learn more about how the metric is calculated in this help center article |[optional]|
**MonthlySearches** | **IEnumerable<MonthlySearchesInfo>** | monthly searches<br>represents the (approximate) number of searches on this keyword idea (as available for the past twelve months), targeted to the specified geographic locations |[optional]|