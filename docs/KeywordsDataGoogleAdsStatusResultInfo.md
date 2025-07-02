# KeywordsDataGoogleAdsStatusResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**ActualData** | **bool?** | indicates whether Google updated keyword data for the previous month<br>generally, Google updates keyword data in the middle of the month<br>if the value is true, Google currently provides up-to-date data for the previous month<br>if the value is false, we are not able to provide data for the previous month |[optional]|
**DateUpdate** | **string** | date of the latest update of Google Ads data<br>indicates the latest date when Google updated search volume, CPC, and other keyword metrics<br>example:<br>2020-05-15 |[optional]|
**LastYearInMonthlySearches** | **int?** | the latest year for which search volume data is available |[optional]|
**LastMonthInMonthlySearches** | **int?** | the latest month for which search volume data is available |[optional]|