# ImpressionsInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**LastUpdatedTime** | **string** | date and time when the clickstream dataset was updated<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00” |[optional]|
**Bid** | **long?** | the maximum CPC<br>it stands for the price you are willing to pay for an ad. The higher value, the higher positions and price you will getwe return the results for the 999 bid value to provide the highest number of impressions and level down the account-specific factors |[optional]|
**MatchType** | **string** | type of keyword match<br>can take the following values: exact, broad, phrase |[optional]|
**AdPositionMin** | **float?** | the minimum ad position<br>represents the minimum position of the advertisement |[optional]|
**AdPositionMax** | **float?** | the maximum ad position<br>represents the maximum position of the advertisement |[optional]|
**AdPositionAverage** | **double?** | the average ad position<br>represents the average position of the advertisement |[optional]|
**CpcMin** | **float?** | the minimum value of cost-per-click<br>the minimum cost-per-click (USD) for the keyword given that a bid is set to 999;<br>note: this field does not represent an actual CPC value;<br>you can find an actual CPC value for a keyword in the cpc field of the keyword_info object |[optional]|
**CpcMax** | **float?** | the maximum value of cost-per-click<br>the maximum cost-per-click (USD) for the keyword given that a bid is set to 999;<br>note: this field does not represent an actual CPC value;<br>you can find an actual CPC value for a keyword in the cpc field of the keyword_info object |[optional]|
**CpcAverage** | **double?** | the average value of cost-per-click<br>the average cost-per-click (USD) for the keyword given that a bid is set to 999;<br>note: this field does not represent an actual CPC value;<br>you can find an actual CPC value for a keyword in the cpc field of the keyword_info object |[optional]|
**DailyImpressionsMin** | **float?** | the minimum value of daily impressions<br>represents the minimum number of daily impressions of the advertisement given that that a bid is set to 999; provides a more accurate alternative to Google search volume data |[optional]|
**DailyImpressionsMax** | **float?** | the maximum value of daily impressions<br>represents the maximum number of daily impressions of the advertisement given that that a bid is set to 999; provides a more accurate alternative to Google search volume data |[optional]|
**DailyImpressionsAverage** | **double?** | the average value of daily impressions<br>represents the average number of daily impressions of the advertisement given that that a bid is set to 999; provides a more accurate alternative to Google search volume data |[optional]|
**DailyClicksMin** | **float?** | the minimum value of daily clicks<br>represents the minimum number of daily clicks on the advertisement |[optional]|
**DailyClicksMax** | **float?** | the maximum value of daily clicks<br>represents the maximum number of daily clicks on the advertisement |[optional]|
**DailyClicksAverage** | **double?** | the average value of daily clicks<br>represents the average number of daily clicks on the advertisement |[optional]|
**DailyCostMin** | **float?** | the minimum daily charge value<br>represents the minimum daily cost of the advertisement (USD) |[optional]|
**DailyCostMax** | **float?** | the maximum daily charge value<br>represents the maximum daily cost of the advertisement (USD) |[optional]|
**DailyCostAverage** | **double?** | the average daily charge value<br>represents the average daily cost of the advertisement (USD) |[optional]|