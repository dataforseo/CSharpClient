# WaterfallResourceInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**ResourceType** | **string** |  |[optional]|
**Url** | **string** | resource URL |[optional]|
**Initiator** | **string** | resource initiator |[optional]|
**DurationTime** | **int?** | total time it takes until a browser receives a complete response from a server (in milliseconds) |[optional]|
**FetchStart** | **int?** | time to start downloading the resource<br>the amount of time the browser needs to start downloading a resource |[optional]|
**FetchEnd** | **int?** | time to complete downloading the resource<br>the amount of time the browser needs to complete downloading a resource |[optional]|
**Location** | **OnPageResourceLocationInfo** | location of the resource in the document<br>parameters defining the location of the specific resource within the document’s HTML |[optional]|
**IsRenderBlocking** | **bool?** | indicates whether the resource blocks rendering |[optional]|