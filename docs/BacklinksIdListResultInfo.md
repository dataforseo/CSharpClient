# BacklinksIdListResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Id** | **string** | <em>task identifier</em><br><strong>unique task identifier in our system in the <a href='https://en.wikipedia.org/wiki/Universally_unique_identifier'>UUID</a> format</strong> |[optional]|
**Url** | **string** | <em>URL of the task</em><br>URL you used for making an API call |[optional]|
**DatetimePosted** | **string** | <em>date and time when the task was made</em><br>in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'<br>example:<br><code>2023-01-15 12:57:46 +00:00</code> |[optional]|
**DatetimeDone** | **string** | <em>date and time when the task was completed</em><br>in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'<br>example:<br><code>2023-01-15 12:57:46 +00:00</code> |[optional]|
**Status** | **string** | <em>informational message of the task</em><br>you can find the full list of general informational messages <a href='/v3/appendix-errors/'>here</a> |[optional]|
**Cost** | **double?** | <em>total tasks cost, USD</em> |[optional]|
**Metadata** | **IDictionary<string, object>** | <em>contains parameters you specified in the POST request</em> |[optional]|