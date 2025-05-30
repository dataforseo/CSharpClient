# ImageResourceElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Meta** | **ResourceMetaInfo** | page properties<br>the value depends on the resource_type |[optional]|
**FetchTiming** | **FetchTiming** | time range within which a result was fetched |[optional]|
**AcceptType** | **string** | indicates the expected type of resource<br>for example, if 'resource_type': 'broken', accept_type will indicate the type of the broken resource<br>possible values:<br>any, none, image, sitemap, robots, script, stylesheet, redirect, html, text, other, font |[optional]|