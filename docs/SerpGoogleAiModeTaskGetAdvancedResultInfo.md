# SerpGoogleAiModeTaskGetAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | keyword received in a POST arraythe keyword is returned with decoded %## (plus symbol '+' will be decoded to a space character) |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine resultsyou can use it to make sure that we provided exact results |[optional]|
**Datetime** | **string** | date and time when the result was receivedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2019-11-15 12:57:46 +00:00 |[optional]|
**Spell** | **SpellInfo** | autocorrection of the search engineif the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection;in this case, the value will be null |[optional]|
**RefinementChips** | **RefinementChipsInfo** | search refinement chipsin this case, the value will be null |[optional]|
**ItemTypes** | **IEnumerable<string>** | types of search results in SERPcontains types of search results (items) found in SERP.possible item types:ai_overview |[optional]|
**SeResultsCount** | **long?** | total number of results in SERP |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<AiModeAiOverviewInfo>** | items present in the element |[optional]|