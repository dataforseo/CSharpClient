# SerpIdListRequestInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**DatetimeFrom** | **string** | start time for filtering results<br>required field<br>if include_metadata is set to true, maximum value: a month from current datetime;<br>if include_metadata is set to false, maximum value: six months from current datetime;<br>must be specified in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2023-01-15 12:57:46 +00:00 |[optional]|
**DatetimeTo** | **string** | finish time for filtering results<br>required field<br>maximum value: current datetime;<br>must be specified in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2023-01-31 13:57:46 +00:00 |[optional]|
**Limit** | **int?** | the maximum number of returned task IDs<br>optional field<br>default value: 1000<br>maximum value: 1000 |[optional]|
**Offset** | **int?** | offset in the results array of returned task IDs<br>optional field<br>default value: 0<br>if you specify the 10 value, the first ten tasks in the results array will be omitted |[optional]|
**Sort** | **string** | sorting by task execution time<br>optional field<br>possible values: 'asc', 'desc'<br>default value: 'asc' |[optional]|
**IncludeMetadata** | **bool?** | include task metadata in the respond<br>optional field<br>default value: false |[optional]|