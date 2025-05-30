# TrendsMapDataInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**GeoId** | **string** | Google Trends location identifier<br>you can use this field for matching obtained results with location parameters specified in the request<br>example:<br>US-NY |[optional]|
**GeoName** | **string** | Google Trends location name<br>you can use this field for matching obtained results with location parameters specified in the request |[optional]|
**Values** | **IEnumerable<string>** | relative keyword popularity rate in a given location<br>represents the location-specific keyword popularity rate over the given time range<br>if you specify more than one keyword, the values will be averaged to the highest value across all specified keywords<br>a value of 100 is the peak popularity for the term<br>a value of 50 means that the term is half as popular<br>a value of 0 means there was not enough data for this term |[optional]|
**MaxValueIndex** | **double?** | max value among comparable terms<br>represents the maximum value if you specified more than two keywords in a POST array<br>if you specified only one keyword, the value will be null |[optional]|