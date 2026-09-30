# SerpYoutubeVideoSubtitlesLiveAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**VideoId** | **string** | ID of the video received in a POST array |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine resultsyou can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | date and time when the result was receivedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2019-11-15 12:57:46 +00:00 |[optional]|
**Spell** | **SpellInfo** | autocorrection of the search engineif the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection |[optional]|
**ItemTypes** | **IEnumerable<string>** | types of search results in SERPcontains types of search results (items) found in SERP.possible item:youtube_subtitles |[optional]|
**UnsupportedLanguage** | **bool?** | indicates whether the language is unsupported by the system |[optional]|
**TranslateLanguage** | **string** | language code of translated text |[optional]|
**OriginLanguage** | **string** | language code of original text |[optional]|
**Category** | **string** | the category the video belongs toNote: this field is deprecated and always returns null |[optional]|
**SubtitlesCount** | **long?** | number of subtitles in the video |[optional]|
**Title** | **string** | title of the video |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<YoutubeSubtitles>** | elements of search results found in SERP |[optional]|