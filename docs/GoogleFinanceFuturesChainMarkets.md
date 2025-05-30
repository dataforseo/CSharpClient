# GoogleFinanceFuturesChainMarkets


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**ExpirationTimestamp** | **string** | futures’ date and time of expiration<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2025-02-10 09:40:00 +00:00 |[optional]|
**Symbol** | **string** | futures’ symbol |[optional]|
**Price** | **float?** | price of the market instrument<br>price of the market instrument at a given timestamp |[optional]|
**PriceCurrency** | **string** | currency of the price value |[optional]|
**PriceDelta** | **float?** | change in price of the market instrument<br>change in price at a given timestamp |[optional]|
**PercentageDelta** | **float?** | percentage of change in value of the market index |[optional]|
**Trend** | **string** | growth trend of the market index<br>possible values: up, down, stable |[optional]|