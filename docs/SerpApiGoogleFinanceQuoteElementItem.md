# SerpApiGoogleFinanceQuoteElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Quote** | **BaseSerpApiGoogleFinanceElementItem** | quoted market indexes |[optional]|
**GraphItems** | **IEnumerable<GraphItems>** | values on graph |[optional]|