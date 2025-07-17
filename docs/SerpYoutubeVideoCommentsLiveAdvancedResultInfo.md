# SerpYoutubeVideoCommentsLiveAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**VideoId** | **string** | ID of the video received in a POST array |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine results<br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Spell** | **SpellInfo** | autocorrection of the search engine<br>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection |[optional]|
**ItemTypes** | **IEnumerable<string>** | types of search results in SERP<br>contains types of search results (items) found in SERP.<br>possible item:<br>youtube_comment |[optional]|
**Title** | **string** | title of the video |[optional]|
**CommentsCount** | **long?** | number of comments on the video |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<YoutubeComment>** | elements of search results found in SERP |[optional]|