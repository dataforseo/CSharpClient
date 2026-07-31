# KeywordInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**LastUpdatedTime** | **string** | date and time when keyword data was updatedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2019-11-15 12:57:46 +00:00 |[optional]|
**Competition** | **double?** | competitionrepresents the relative amount of competition associated with the given keyword. This value is based on Google Ads data and can be between 0 and 1 (inclusive) |[optional]|
**CompetitionLevel** | **string** | competition levelrepresents the relative level of competition associated with the given keyword in paid SERP only;possible values: LOW, MEDIUM, HIGHif competition level is unknown, the value is null;learn more about the metric in this help center article |[optional]|
**Cpc** | **double?** | cost-per-clickrepresents the average cost per click (USD) historically paid for the keyword |[optional]|
**SearchVolume** | **long?** | average monthly search volume raterepresents the (approximate) number of searches for the given keyword idea on google.com |[optional]|
**LowTopOfPageBid** | **double?** | minimum bid for the ad to be displayed at the top of the first pageindicates the value greater than about 20% of the lowest bids for which ads were displayed (based on Google Ads statistics for advertisers)the value may differ depending on the location specified in a POST request |[optional]|
**HighTopOfPageBid** | **double?** | maximum bid for the ad to be displayed at the top of the first pageindicates the value greater than about 80% of the lowest bids for which ads were displayed (based on Google Ads statistics for advertisers)the value may differ depending on the location specified in a POST request |[optional]|
**Categories** | **IEnumerable<int?>** | product and service categoriesyou can download the_full list of possible categoriesn |[optional]|
**MonthlySearches** | **IEnumerable<MonthlySearchesInfo>** | monthly searchesrepresents the (approximate) number of searches on this keyword idea (as available for the past twelve months), targeted to the specified geographic locations |[optional]|
**SearchVolumeTrend** | **SearchVolumeTrend** | search volume trend changesrepresents search volume change in percent compared to the previous period |[optional]|