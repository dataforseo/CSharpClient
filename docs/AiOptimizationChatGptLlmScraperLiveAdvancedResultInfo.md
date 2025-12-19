# AiOptimizationChatGptLlmScraperLiveAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | keyword received in a POST array<br>the keyword is returned with decoded %## (plus symbol ‘+’ will be decoded to a space character) |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**Model** | **string** | indicates the model version |[optional]|
**CheckUrl** | **string** | direct URL to search engine results<br>you can use it to make sure that we provided exact results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Markdown** | **string** | content of the element in markdown format<br>content of the result formatted in the markdown markup language |[optional]|
**SearchResults** | **IEnumerable<ChatgptSearchResult>** | array of search results<br>all web search outputs the model retrieved when looking up information, including duplicates and unused entries |[optional]|
**Sources** | **IEnumerable<ChatGptSource>** | array of sources<br>the sources the model actually cited or relied on in its final answer |[optional]|
**FanOutQueries** | **IEnumerable<string>** | array of fan-out queries<br>contains related search queries derived from the main query to provide a more comprehensive response |[optional]|
**BrandEntities** | **IEnumerable<ChatGptBrandEntity>** | array of brand entities<br>contains information on brands mentioned in the response |[optional]|
**SeResultsCount** | **long?** | total number of results |[optional]|
**ItemTypes** | **IEnumerable<string>** | types of search results<br>contains types of search results (items) found in SERP.<br>possible item types:<br>chat_gpt_text, chat_gpt_table, chat_gpt_navigation_list, chat_gpt_images, chat_gpt_local_businesses, chat_gpt_products |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<BaseChatGptLlmScraperElementItem>** | items present in the element |[optional]|