# StocksBoxSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of the row |[optional]|
**Source** | **string** | reference source name or title |[optional]|
**Snippet** | **string** | text alongside the link title |[optional]|
**Price** | **PriceInfo** | price indicated in the element |[optional]|
**Url** | **string** | URL |[optional]|
**Domain** | **string** | domain in the URL |[optional]|
**Rectangle** | **Rectangle** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>equals null if calculate_rectangles in the POST request is not set to true |[optional]|
**Table** | **Table** | results table<br>if there are none, equals null |[optional]|
**Graph** | **Graph** | contains data provided in the graph of the element |[optional]|