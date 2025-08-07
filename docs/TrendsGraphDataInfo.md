# TrendsGraphDataInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**DateFrom** | **string** | start date of the corresponding time range<br>in the UTC format: “yyyy-mm-dd” |[optional]|
**DateTo** | **string** | end date of the corresponding time range<br>in the UTC format: “yyyy-mm-dd” |[optional]|
**Timestamp** | **int?** | a point in time in the Unix time format |[optional]|
**MissingData** | **bool?** | indicates whether the data is unavailable<br>if true the data on the graph in the Google Trends interface is missing and thus labelled with a dotted line |[optional]|
**Values** | **IEnumerable<double?>** | relative keyword popularity rate at a specific timestamp<br>represents the keyword popularity rate over the given time range<br>if you specify more than one keyword, the values will be averaged to the highest value across all specified keywords<br>a value of 100 is the peak popularity for the term. A value of 50 means that the term is half as popular. A score of 0 means there was not enough data for this term |[optional]|