# SerpApiGoogleFinanceExploreMarketTrendsElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Title** | **string** | title of the market trends element<br>example: Europe, Middle East, and Africa |[optional]|
**SubTitle** | **string** | sub-title of the market trends element |[optional]|
**Url** | **string** | URL to finance pair on Google Finance |[optional]|
**Items** | **IEnumerable<BaseSerpApiGoogleFinanceElementItem>** | market indexes data<br>array of items containing market indexes data;<br>possible type of items: google_finance_asset_pair_element, google_finance_market_instrument_element, google_finance_market_index_element |[optional]|