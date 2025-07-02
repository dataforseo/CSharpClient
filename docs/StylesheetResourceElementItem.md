# StylesheetResourceElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Meta** | **ResourceMetaInfo** | resource properties<br>the value depends on the resource_type<br>note that if you do not indicate a url when setting a task, resource’s meta is returned based on the data from the page where our crawler first saw the resource;<br>to obtain resource’s meta from a particular url, specify that URL when setting a task |[optional]|
**FetchTiming** | **FetchTiming** | resource fething time range |[optional]|
**AcceptType** | **string** | indicates the expected type of resource<br>for example, if 'resource_type': 'broken', accept_type will indicate the type of the broken resource<br>possible values:<br>any, none, image, sitemap, robots, script, stylesheet, redirect, html, text, other, font |[optional]|
**Initiator** | **string** | resource initiator |[optional]|
**DurationTime** | **int?** | total time it takes until a browser receives a complete response from a server (in milliseconds) |[optional]|
**FetchStart** | **int?** | time to start downloading the resource<br>the amount of time the browser needs to start downloading a resource |[optional]|
**FetchEnd** | **int?** | time to complete downloading the resource<br>the amount of time the browser needs to complete downloading a resource |[optional]|
**IsRenderBlocking** | **bool?** | indicates whether the resource blocks rendering |[optional]|