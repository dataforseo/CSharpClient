# CurrencyBoxSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**Value** | **int?** | the value of the rating |[optional]|
**ConvertedValue** | **float?** | value converted to a requested currency<br>indicates the exact value based on Google Fincance data at the time when our API pulled the results<br>note that exchange rates displayed in the currency_box element may be delayed according to the Google Finance disclaimer |[optional]|
**Currency** | **string** | currency of the listed price<br>ISO code of the currency applied to the price |[optional]|
**ConvertedCurrency** | **string** | converted currency |[optional]|
**Timestamp** | **string** | date and time when the result was published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Table** | **Table** | results table<br>if there are none, equals null |[optional]|
**Graph** | **Graph** | contains data provided in the graph of the element |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|