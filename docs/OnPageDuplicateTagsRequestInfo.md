# OnPageDuplicateTagsRequestInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Id** | **string** | ID of the task<br>required field<br>you can get this ID in the response of the Task POST endpoint<br>example:<br>“07131248-1535-0216-1000-17384017ad04” |[optional]|
**Type** | **string** | type of element |[optional]|
**Accumulator** | **string** | tag value<br>optional field<br>specify a title or description here if you want to receive a list of duplicate pages that contains this tag |[optional]|
**Limit** | **int?** | the maximum number of returned pages<br>optional field<br>default value: 100<br>maximum value: 1000 |[optional]|
**Offset** | **int?** | offset in the results array of returned pages<br>optional field<br>default value: 0<br>if you specify the 10 value, the first ten pages in the results array will be omitted and the data will be provided for the successive pages |[optional]|
**Tag** | **string** | user-defined task identifier<br>optional field<br>the character limit is 255<br>you can use this parameter to identify the task and match it with the result<br>you will find the specified tag value in the data object of the response |[optional]|