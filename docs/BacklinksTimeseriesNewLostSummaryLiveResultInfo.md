# BacklinksTimeseriesNewLostSummaryLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Target** | **string** | <em><code>target</code> from a POST array</em> |[optional]|
**DateFrom** | **string** | <em>starting date of the time range</em><br>in the UTC format: “yyyy-mm-dd”<br>example:<br><code>2019-01-01</code> |[optional]|
**DateTo** | **string** | <em>ending date of the time range</em><br>in the UTC format: <code>'yyyy-mm-dd'</code><br>example:<br><code>'2019-01-15'</code> |[optional]|
**GroupRange** | **string** | <em><code>group_range</code> from the POST array</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**Items** | **IEnumerable<BacklinksTimeseriesNewLostSummaryLiveItem>** | <em>contains relevant backlinks and referring domains data</em> |[optional]|