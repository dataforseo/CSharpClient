# StocksBoxSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**Title** | **string** | title of the row |[optional]|
**Source** | **string** | source of the element<br>indicates the source of the video |[optional]|
**Snippet** | **string** | text alongside the link title |[optional]|
**Price** | **PriceInfo** | price indicated in the element |[optional]|
**Url** | **string** | source URL |[optional]|
**Domain** | **string** | source domain |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|
**Table** | **Table** | results table<br>if there are none, equals null |[optional]|
**Graph** | **Graph** | contains data provided in the graph of the element |[optional]|