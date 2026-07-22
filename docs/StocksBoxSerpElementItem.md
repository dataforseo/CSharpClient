# StocksBoxSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values;<br>positions of elements with different type values are omitted from rank_group;<br>always equals 0 for desktop |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP<br>always equals 0 for desktop |[optional]|
**Title** | **string** | title of the row |[optional]|
**Source** | **string** | source of the element<br>indicates the source of information included in the recipes_element |[optional]|
**Snippet** | **string** | text alongside the link title |[optional]|
**Price** | **PriceInfo** | price indicated in the element |[optional]|
**Url** | **string** | URL of the third-party review source |[optional]|
**Domain** | **string** | domain of the website hosting the video |[optional]|
**Table** | **Table** | table present in the element<br>the header and content of the table present in the element |[optional]|
**Graph** | **Graph** | contains data provided in the graph of the element |[optional]|