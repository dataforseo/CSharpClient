# BacklinksTimeseriesSummaryLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Target** | **string** | target from a POST array |[optional]|
**DateFrom** | **string** | starting date of the time range<br>in the UTC format: “yyyy-mm-dd”<br>example:<br>2019-01-01 |[optional]|
**DateTo** | **string** | ending date of the time range<br>in the UTC format: 'yyyy-mm-dd'<br>example:<br>'2019-01-15' |[optional]|
**GroupRange** | **string** | group_range from a POST array |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<BacklinksTimeseriesSummaryLiveItem>** | contains relevant summary data |[optional]|