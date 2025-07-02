# GoogleFinanceAssetPairElement


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**BaseSymbol** | **string** | identifier of the base asset in a pair<br>example: EUR |[optional]|
**QuoteSymbol** | **string** | identifier of the quote asset in a pair<br>example: USD |[optional]|
**BaseDisplayName** | **string** | full name of the base asset in a pair<br>example: Euro |[optional]|
**QuoteDisplayName** | **string** | full name of the base asset in a pair<br>example: Euro |[optional]|
**Price** | **float?** | value of the base asset compared to the quote asset |[optional]|
**PriceDelta** | **float?** | change in price<br>change in price at a given timestamp |[optional]|
**Identifier** | **string** | identifier of the element<br>full identifier of the element that consists from ticker and market_identifier<br>example: PX1:INDEXDB |[optional]|
**DisplayedName** | **string** | name of the market index as displayed on Google Finance<br>example: CAC 40 |[optional]|
**Url** | **string** | URL to the page of the market index on Google Finance |[optional]|
**Location** | **string** | location of the market index<br>example: Europe/Paris |[optional]|
**Trend** | **string** | growth trend of the market index<br>possible values: up, down, stable |[optional]|
**Timestamp** | **string** | date and time of the value readout<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2025-02-10 09:40:00 +00:00 |[optional]|
**PercentageDelta** | **float?** | percentage of change in value of the market index |[optional]|