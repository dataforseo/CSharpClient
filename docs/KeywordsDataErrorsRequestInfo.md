# KeywordsDataErrorsRequestInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Limit** | **int?** | the maximum number of returned tasks that responded with an error<br>optional field<br>default value: 1000<br>maximum value: 1000 |[optional]|
**Offset** | **int?** | offset in the results array of returned tasks<br>optional field<br>default value: 0<br>if you specify the 10 value, the first ten tasks in the results array will be omitted and the data will be provided for the successive tasks |[optional]|
**FilteredFunction** | **string** | return tasks with a certain function<br>use this field to obtain a list of tasks that returned an error filtered by a certain function<br>you can filter the results by the values you receive in the function fields of the API response<br>i.e., once you receive unfiltered results, you can call this API again to filter them by function<br>example: keywords_data/keywords_for_site/task_post, postback_url, pingback_url |[optional]|
**DatetimeFrom** | **string** | start time for filtering results<br>optional field<br>allows filtering results by the datetime parameter within the range of the last 7 days;<br>must be specified in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2021-11-15 12:57:46 +00:00 |[optional]|
**DatetimeTo** | **string** | finish time for filtering results<br>optional field<br>allows filtering results by the datetime parameter within the range of the last 7 days;<br>must be specified in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2021-11-15 13:57:46 +00:00 |[optional]|