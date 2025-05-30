# BacklinksHistoryLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Target** | **string** | target from the POST array |[optional]|
**DateFrom** | **string** | starting date of the time range<br>in the UTC format: “yyyy-mm-dd”<br>example:<br>2019-01-01 |[optional]|
**DateTo** | **string** | ending date of the time range<br>in the UTC format: 'yyyy-mm-dd'<br>example:<br>'2019-01-15' |[optional]|
**ItemsCount** | **double?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<BacklinksHistoryLiveItem>** | contains historical backlink data for the specified domain<br>the data is provided month-by-month;<br>the metrics are aggregated according to the backlinks the specified domain had on the first day of each given month |[optional]|