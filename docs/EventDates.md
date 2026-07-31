# EventDates


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**StartDatetime** | **string** | <em>date and time when the event starts</em><br>if time zone is specified in the event, value will be returned in the UTC format:<br>'yyyy-mm-ddThh-mm-ss+00:00'<br>example:<br><code class='long-string'>2019-11-15T12:57:46+00:00</code><br>if time zone is not specified in the event, unspecified local time will be returned in the following format:<br>'yyyy-mm-ddThh-mm-ss' <br>example:<br><code class='long-string'>2019-11-15T12:57:46</code> |[optional]|
**EndDatetime** | **string** | <em>date and time when the event ends</em><br>if time zone is specified in the event, value will be returned in the UTC format:<br>'yyyy-mm-ddThh-mm-ss+00:00'<br>example:<br><code class='long-string'>2019-11-15T12:57:46+00:00</code><br>if time zone is not specified in the event, unspecified local time will be returned in the following format:<br>'yyyy-mm-ddThh-mm-ss' <br>example:<br><code class='long-string'>2019-11-15T12:57:46</code> |[optional]|
**DisplayedDates** | **string** | <em>date or date range as it is displayed in SERP</em> |[optional]|