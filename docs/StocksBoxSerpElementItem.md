# StocksBoxSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values;<br>positions of elements with different type values are omitted from rank_group;<br>always equals 0 for desktop |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP<br>always equals 0 for desktop |[optional]|
**Title** | **string** | reference page title |[optional]|
**Source** | **string** | reference source name or title |[optional]|
**Snippet** | **string** | text alongside the link title |[optional]|
**Price** | **PriceInfo** | price indicated in the element |[optional]|
**Url** | **string** | URL |[optional]|
**Domain** | **string** | domain name of the reference |[optional]|
**Table** | **Table** | table present in the element<br>the header and content of the table present in the element |[optional]|
**Graph** | **Graph** | contains data provided in the graph of the element |[optional]|