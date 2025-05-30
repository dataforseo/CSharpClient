# OnPageWaterfallItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**PageUrl** | **string** | URL of the page |[optional]|
**TimeToInteractive** | **double?** | Time To Interactive (TTI) metric<br>the time it takes until the user can interact with a page (in milliseconds) |[optional]|
**DomComplete** | **double?** | time to load resources<br>the time it takes until the page and all of its subresources are downloaded (in milliseconds) |[optional]|
**ConnectionTime** | **double?** | time to connect to a server<br>the time it takes until the connection with a server is established (in milliseconds) |[optional]|
**TimeToSecureConnection** | **double?** | time to establish a secure connection<br>the time it takes until the secure connection with a server is established (in milliseconds) |[optional]|
**RequestSentTime** | **double?** | time to send a request to a server<br>the time it takes until the request to a server is sent (in milliseconds) |[optional]|
**WaitingTime** | **double?** | time to first byte (TTFB) in milliseconds |[optional]|
**DownloadTime** | **double?** | time it takes for a browser to receive a response (in milliseconds) |[optional]|
**DurationTime** | **double?** | total time it takes until a browser receives a complete response from a server (in milliseconds) |[optional]|
**FetchStart** | **double?** | time to start downloading the HTML resource<br>the amount of time the browser needs to start downloading a page |[optional]|
**FetchEnd** | **double?** | time to complete downloading the HTML resource<br>the amount of time the browser needs to complete downloading a page |[optional]|
**Resources** | **IEnumerable<WaterfallResourceInfo>** | resource-specific timing<br>contains separate arrays with timing for each resource found on the page |[optional]|