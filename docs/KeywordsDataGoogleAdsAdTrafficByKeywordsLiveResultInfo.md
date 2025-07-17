# KeywordsDataGoogleAdsAdTrafficByKeywordsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | keyword in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array<br>if there is no data, then the value is null |[optional]|
**LanguageCode** | **string** | language code in a POST array<br>if there is no data, then the value is null |[optional]|
**DateInterval** | **string** | forecasting date interval in a POST array |[optional]|
**SearchPartners** | **bool?** | include Google search partners<br>the value you specified when setting the task<br>if true, the results are returned for owned, operated, and syndicated networks across Google and partner sites that host Google search;<br>if false, the results are returned for Google search sites only |[optional]|
**Bid** | **double?** | the maximum custom bid<br>the bid you have specified when setting the task<br>represents the price you are willing to pay for an ad<br>the higher value you have specified, the higher metrics and cost you receive in response<br>learn more in this help center article |[optional]|
**Match** | **string** | keywords match-type<br>can take the following values: exact, broad, phrase |[optional]|
**Impressions** | **int?** | projected number of ad impressions<br>number of impressions an ad is projected to get within the specified time period<br>if there is no data, then the value is null<br>learn more about impressions in this help center article |[optional]|
**Ctr** | **double?** | projected click through rate (CTR) of the advertisement<br>number of clicks an ad is projected to receive divided by the number of ad impressions; the CTR is projected for the specified time period<br>if there is no data, then the value is null |[optional]|
**AverageCpc** | **double?** | the average cost-per-click value<br>represents the cost-per-click (USD) estimated for a keyword based on the specified time period and historical data;<br>if there is no data, then the value is null |[optional]|
**Cost** | **double?** | charge for an ad<br>amount that will be charged for running an ad within the specified time period<br>if there is no data, then the value is null |[optional]|
**Clicks** | **double?** | number of clicks on an ad<br>number of clicks an ad is projected to get within the specified time period<br>if there is no data, then the value is null |[optional]|