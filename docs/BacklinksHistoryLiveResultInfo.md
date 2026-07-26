# BacklinksHistoryLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Target** | **string** | <em><code>target</code> from the POST array</em> |[optional]|
**DateFrom** | **string** | <em>starting date of the time range</em><br>in the UTC format: “yyyy-mm-dd”<br>example:<br><code>2019-01-01</code> |[optional]|
**DateTo** | **string** | <em>ending date of the time range</em><br>in the UTC format: <code>'yyyy-mm-dd'</code><br>example:<br><code>'2019-01-15'</code> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**Items** | **IEnumerable<BacklinksHistoryLiveItem>** | <em>contains historical backlink data for the specified domain</em><br>the data is provided month-by-month;<br>the metrics are aggregated according to the backlinks the specified domain had on the first day of each given month |[optional]|