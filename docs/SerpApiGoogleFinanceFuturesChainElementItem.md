# SerpApiGoogleFinanceFuturesChainElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Markets** | **IEnumerable<GoogleFinanceFuturesChainElement>** | financial markets data<br>array of items containing market indexes and other financial information related to these indexes |[optional]|