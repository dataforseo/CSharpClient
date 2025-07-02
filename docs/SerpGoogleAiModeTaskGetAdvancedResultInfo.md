# SerpGoogleAiModeTaskGetAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | keyword received in a POST array<br>the keyword is returned with decoded %## (plus symbol ‘+’ will be decoded to a space character) |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**LocationCode** | **double?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine results<br>you can use it to make sure that we provided exact results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Spell** | **SpellInfo** | autocorrection of the search engine<br>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection |[optional]|
**RefinementChips** | **RefinementChipsInfo** | search refinement chips |[optional]|
**ItemTypes** | **IEnumerable<string>** | types of search results in SERP<br>contains types of search results (items) found in SERP.<br>possible item types:<br>ai_overview |[optional]|
**SeResultsCount** | **double?** | total number of results in SERP |[optional]|
**ItemsCount** | **double?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<AiModeAiOverview>** | elements of search results found in SERP |[optional]|