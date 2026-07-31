# BusinessDataGoogleMyBusinessUpdatesTasksReadyResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Id** | **string** | <em>task identifier of the completed task</em><br><strong>unique task identifier in our system in the <a href='https://en.wikipedia.org/wiki/Universally_unique_identifier'>UUID</a> format</strong> |[optional]|
**Se** | **string** | <em>search engine specified when setting the task</em><br>can take the following values: <code>google</code> |[optional]|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**DatePosted** | **string** | <em>date when the task was posted (in the UTC format)</em> |[optional]|
**Tag** | **string** | <em>user-defined task identifier</em> |[optional]|
**Endpoint** | **string** | <em>URL for collecting the results of the task</em> |[optional]|