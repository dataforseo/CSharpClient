# SerpYoutubeVideoSubtitlesLiveAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**VideoId** | **string** | <em>ID of the video received in a POST array</em> |[optional]|
**SeDomain** | **string** | <em>search engine domain in a POST array</em> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to search engine results<br></em>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Spell** | **SpellInfo** | <em>autocorrection of the search engine</em><br>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection |[optional]|
**ItemTypes** | **IEnumerable<string>** | <em>types of search results in SERP</em><br>contains types of search results (<code>items</code>) found in SERP.<br>possible item:<br><code>youtube_subtitles</code> |[optional]|
**UnsupportedLanguage** | **bool?** | <em>indicates whether the language is unsupported by the system</em> |[optional]|
**TranslateLanguage** | **string** | <em>language code of translated text</em> |[optional]|
**OriginLanguage** | **string** | <em>language code of original text</em> |[optional]|
**Category** | **string** | <em>the category the video belongs to</em><br><strong>Note:</strong> this field is deprecated and always returns <code>null</code> |[optional]|
**SubtitlesCount** | **long?** | <em>number of subtitles in the video</em> |[optional]|
**Title** | **string** | <em>title of the video</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <strong><code>items</code></strong> array</em> |[optional]|
**Items** | **IEnumerable<YoutubeSubtitles>** | <em>elements of search results found in SERP</em> |[optional]|