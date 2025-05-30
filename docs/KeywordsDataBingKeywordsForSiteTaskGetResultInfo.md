# KeywordsDataBingKeywordsForSiteTaskGetResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | keyword in a POST array |[optional]|
**LocationCode** | **double?** | location code in a POST array<br>if there is no data the value is null |[optional]|
**LanguageCode** | **string** | language code in a POST array<br>if there is no data the value is null |[optional]|
**SearchPartners** | **bool?** | indicates whether data from partner networks included in the response |[optional]|
**Device** | **string** | device type in a POST array<br>if there is no data, then the value is null |[optional]|
**Competition** | **float?** | competition<br>represents the relative amount of competition associated with the given keyword in paid SERP only. This value is based on Bing Ads data.<br>Possible values: 0.1, 0.5,0.9 <br>0.1 – low competition,<br>0.5 – medium competition,<br>0.9 – high competition;<br>if there is no data the value is null |[optional]|
**Cpc** | **float?** | cost-per-click<br>represents the average cost per click (USD) historically paid for the keyword.<br>if there is no data the value is null |[optional]|
**SearchVolume** | **double?** | monthly average search volume rate<br>represents the (approximate) number of searches for the given keyword idea on Bing search engine depending on the user’s targeting<br>if there is no data then the value is null |[optional]|
**Categories** | **IEnumerable<string>** | product and service categories<br>legacy field, the value will always be null |[optional]|
**MonthlySearches** | **IEnumerable<MonthlySearches>** | monthly searches<br>represents the (approximate) number of searches on this keyword idea (as available for the past twelve months), targeted to the specified geographic locations<br>search volume is rounded to the closest decimal values<br>if there is no data the value is null |[optional]|