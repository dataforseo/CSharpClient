# AiOptimizationChatGptLlmScraperLiveAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | <em>keyword received in a POST array<br></em><strong>the keyword is returned with decoded %## (plus symbol '+' will be decoded to a space character)</strong> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**Model** | **string** | <em>indicates the model version</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to search engine results<br></em>you can use it to make sure that we provided exact results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Markdown** | **string** | <em>content of the element in markdown format</em><br>content of the result formatted in the <a href='https://en.wikipedia.org/wiki/Markdown' target='_blank'>markdown markup language</a> |[optional]|
**SearchResults** | **IEnumerable<ChatgptSearchResult>** | <em>array of search results</em><br>all web search outputs the model retrieved when looking up information, including duplicates and unused entries |[optional]|
**Sources** | **IEnumerable<SourceInfo>** | <em>array of sources</em><br>the sources the model actually cited or relied on in its final answer |[optional]|
**FanOutQueries** | **IEnumerable<string>** | <em>array of fan-out queries</em><br>contains related search queries derived from the main query to provide a more comprehensive response |[optional]|
**BrandEntities** | **IEnumerable<ChatGptBrandEntity>** | <em>array of brand entities</em><br>contains information on brands mentioned in the response |[optional]|
**SeResultsCount** | **long?** | <em> total number of results</em> |[optional]|
**ItemTypes** | **IEnumerable<string>** | <em>types of search results</em><br>contains types of search results (<code>items</code>) found in SERP.<br>possible item types:<br><code>chat_gpt_text</code>, <code>chat_gpt_table</code>, <code>chat_gpt_navigation_list</code>, <code>chat_gpt_images</code>, <code>chat_gpt_local_businesses</code>, <code>chat_gpt_products</code> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <strong><code>items</code></strong> array</em> |[optional]|
**Items** | **IEnumerable<BaseChatGptLlmScraperElementItem>** | <em>elements of ChatGPT results</em> |[optional]|