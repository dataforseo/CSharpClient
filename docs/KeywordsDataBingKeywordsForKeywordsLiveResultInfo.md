# KeywordsDataBingKeywordsForKeywordsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | <em>keyword in a POST array</em> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em><br>if there is no data, then the value is_<code>null</code>n |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em><br>if there is no data, then the value is_<code>null</code>n |[optional]|
**SearchPartners** | **bool?** | <em>indicates whether data from partner networks is included in the response</em> |[optional]|
**Device** | **string** | <em>device type</em><br>indicates for what device type the data is provided;<br>possible values: <code>all</code>, <code>mobile</code>, <code>desktop</code>, <code>tablet</code> |[optional]|
**Competition** | **double?** | <em>competition</em><br>represents the relative amount of competition associated with the given keyword in paid SERP only. This value is based on Bing Ads data.<br>Possible values: <code>0.1</code>, <code>0.5</code>,<code>0.9</code><code>0.1</code> - low competition,<br><code>0.5</code> - medium competition,<br><code>0.9</code> - high competition;<br>if there is no data the value is <code>null</code> |[optional]|
**Cpc** | **double?** | <em>cost-per-click</em><br>represents the average cost per click (USD) historically paid for the keyword.<br>if there is no data, then the value is_<code>null</code>n |[optional]|
**SearchVolume** | **long?** | <em>monthly average search volume rate</em><br>represents the (approximate) number of searches for the keyword on the Bing search engine, depending on the user’s targetingsearch volume is rounded to the closest decimal values<p>if there is no data, then the value is_<code>null</code>n |[optional]|
**Categories** | **IEnumerable<string>** | <em>product and service categories</em><br>legacy field, the value will always be <code>null</code> |[optional]|
**MonthlySearches** | **IEnumerable<MonthlySearchesInfo>** | <em>monthly searches</em><br>represents the (approximate) number of searches on this keyword (as available for the past twelve months), targeted to the specified geographic locations.<br>if there is no data, then the value is_<code>null</code>n |[optional]|