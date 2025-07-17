# SerpGoogleOrganicLiveRegularResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | keyword received in a POST array<br>keyword is returned with decoded %## (plus character ‘+’ will be decoded to a space character) |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine results<br>you can use it to make sure that we provided exact results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Spell** | **SpellInfo** | autocorrection of the search engine<br>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection |[optional]|
**RefinementChips** | **RefinementChipsInfo** | search refinement chips |[optional]|
**ItemTypes** | **IEnumerable<string>** | types of search results found in SERP<br>contains types of all search results (items) found in the returned SERP<br>possible item types:<br>answer_box, app, carousel, multi_carousel, featured_snippet, google_flights, google_reviews, images, jobs, knowledge_graph, local_pack, map, organic, paid, people_also_ask, related_searches, people_also_search, shopping, top_stories, twitter, video, events, mention_carousel, ai_overview<br>note that this array contains all types of search results found in the returned SERP;<br>however, this endpoint provides data for featured_snippet, organic and paid types only<br>to get all items (inlcuding SERP features and rich snippets) found in the returned SERP, please refer to the Google Organiс Advanced SERP endpoint |[optional]|
**SeResultsCount** | **long?** | total number of results in SERP |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<BaseSerpApiElementItem>** | items in SERP |[optional]|