# AppendixUserDataResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Login** | **string** | your login |[optional]|
**Timezone** | **string** | your time zone<br>can be set in your profile settings |[optional]|
**Rates** | **AppendixRatesData** | your API rates |[optional]|
**Money** | **AppendixMoneyData** | section of your spending, USD |[optional]|
**Price** | **AppendixPriceData** | pricing |[optional]|
**BacklinksSubscriptionExpiryDate** | **string** | expiry date of the backlinks api subscription<br>date and time when the current subscription to Backlinks API expires;<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2025-06-15 12:57:46 +00:00<br>Note: if there is no active subscription to Backlinks API, the value equals null |[optional]|