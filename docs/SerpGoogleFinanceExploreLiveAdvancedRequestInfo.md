# SerpGoogleFinanceExploreLiveAdvancedRequestInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**LocationCode** | **int?** | search engine location coderequired field if you don't specify location_nameif you use this field, you don't need to specify location_nameyou can receive the list of available locations of the search engines with their location_code by making a separate request to https://api.dataforseo.com/v3/serp/google/locationsexample:2840 |[optional]|
**LanguageCode** | **string** | search engine language coderequired field if you don't specify language_nameif you use this field, you don't need to specify language_nameyou can receive the list of available languages of the search engine with their language_code by making a separate request to the https://api.dataforseo.com/v3/serp/google/languagesexample:en |[optional]|
**Device** | **string** | device typeoptional fieldreturn results for a specific device typepossible value: desktop |[optional]|
**LocationName** | **string** | full name of search engine locationrequired field if you don't specify location_codeif you use this field, you don't need to specify location_codeyou can receive the list of available locations of the search engine with their location_name by making a separate request to https://api.dataforseo.com/v3/serp/google/locationsexample:London,England,United Kingdom |[optional]|
**LanguageName** | **string** | full name of search engine languagerequired field if you don't specify language_codeif you use this field, you don't need to specify language_codeyou can receive the list of available languages of the search engine with their language_name by making a separate request to the https://api.dataforseo.com/v3/serp/google/languagesexample:English |[optional]|
**Os** | **string** | device operating systemoptional fieldpossible values: windows |[optional]|
**Tag** | **string** | user-defined task identifieroptional fieldthe character limit is 255you can use this parameter to identify the task and match it with the resultyou will find the specified tag value in the data object of the response |[optional]|
**NewsType** | **string** | financial news filtersoptional fieldpossible values: top_stories, local_market, world_marketsdefault value: top_storiesNote: if you specify local_market or world_markets, the charge per task will be multiplied by 2 |[optional]|