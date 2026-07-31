# ClickstreamKeywordInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SearchVolume** | **long?** | average monthly search volume raterepresents the (approximate) number of searches for the given keyword idea on google.com |[optional]|
**LastUpdatedTime** | **string** | date and time when keyword data was updatedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2019-11-15 12:57:46 +00:00 |[optional]|
**GenderDistribution** | **IDictionary<string, long?>** | distribution of estimated clickstream-based metrics by genderlearn more about how the metric is calculated in this help center article |[optional]|
**AgeDistribution** | **IDictionary<string, long?>** | distribution of clickstream-based metrics by agelearn more about how the metric is calculated in this help center article |[optional]|
**MonthlySearches** | **IEnumerable<MonthlySearchesInfo>** | monthly searchesrepresents the (approximate) number of searches on this keyword idea (as available for the past twelve months), targeted to the specified geographic locations |[optional]|