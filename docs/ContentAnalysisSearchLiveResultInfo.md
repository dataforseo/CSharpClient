# ContentAnalysisSearchLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**OffsetToken** | **string** | <em>offset token for subsequent requests</em><br>you can use the string provided in this field to get the subsequent results of the initial task;<br><strong>note:</strong> <code>offset_token</code> values are unique for each subsequent task |[optional]|
**TotalCount** | **long?** | <em>total amount of results in our database relevant to your request</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**Items** | **IEnumerable<ContentAnalysisSearchLiveItem>** | <em>contains citations and related data</em> |[optional]|