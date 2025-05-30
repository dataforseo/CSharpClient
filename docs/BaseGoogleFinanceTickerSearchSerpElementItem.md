# BaseGoogleFinanceTickerSearchSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **double?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **double?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Identifier** | **string** | identifier of the element<br>full identifier of the element that consists from ticker and market_identifier<br>example: PX1:INDEXDB |[optional]|
**DisplayedName** | **string** | name of the market index as displayed on Google Finance<br>example: CAC 40 |[optional]|
**Url** | **string** | URL to the page of the market index on Google Finance |[optional]|
**Location** | **string** | location of the market index<br>example: Europe/Paris |[optional]|
**Trend** | **string** | growth trend of the market index<br>possible values: up, down, stable |[optional]|
**Timestamp** | **string** | date and time of the value readout<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2025-02-10 09:40:00 +00:00 |[optional]|
**PercentageDelta** | **float?** | percentage of change in value of the market index |[optional]|