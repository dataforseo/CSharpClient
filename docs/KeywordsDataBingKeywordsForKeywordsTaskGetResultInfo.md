# KeywordsDataBingKeywordsForKeywordsTaskGetResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | keyword in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**SearchPartners** | **bool?** | indicates whether data from partner networks included in the response |[optional]|
**Device** | **string** | device type<br>indicates for what device type the data is provided;<br>possible values: all, mobile, desktop, tablet |[optional]|
**Competition** | **double?** | competition<br>represents the relative amount of competition associated with the given keyword in paid SERP only. This value is based on Bing Ads data.<br>Possible values: 0.1, 0.5,0.9 <br>0.1 – low competition,<br>0.5 – medium competition,<br>0.9 – high competition;<br>if there is no data the value is null |[optional]|
**Cpc** | **double?** | cost-per-click<br>represents the average cost per click (USD) historically paid for the keyword.<br>if there is no data, then the value is null |[optional]|
**SearchVolume** | **long?** | monthly average search volume rate<br>represents the (approximate) number of searches for the keyword on the Bing search engine, depending on the user’s targeting<br>search volume is rounded to the closest decimal values<br>if there is no data, then the value is null |[optional]|
**Categories** | **IEnumerable<string>** | product and service categories<br>legacy field, the value will always be null |[optional]|
**MonthlySearches** | **IEnumerable<MonthlySearchesInfo>** | monthly searches<br>represents the (approximate) number of searches on this keyword (as available for the past twelve months), targeted to the specified geographic locations.<br>if there is no data, then the value is null |[optional]|