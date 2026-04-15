# SerpGoogleDatasetInfoLiveAdvancedRequestInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**DatasetId** | **string** | ID of the datasetrequired fieldyou can find dataset ID in the dataset URL or dataset item of Google Dataset Search resultexample:L2cvMTFqbl85ZHN6MQ== |[optional]|
**LanguageCode** | **string** | search engine language codeoptional fieldif you use this field, you don't need to specify language_namepossible value:en |[optional]|
**Device** | **string** | device typeoptional fieldreturn results for a specific device typepossible value: desktop |[optional]|
**LanguageName** | **string** | full name of search engine languageoptional fieldif you use this field, you don't need to specify language_codepossible value:English |[optional]|
**Os** | **string** | device operating systemoptional fieldpossible values: windows, macosdefault value: windows |[optional]|
**Tag** | **string** | user-defined task identifieroptional fieldthe character limit is 255you can use this parameter to identify the task and match it with the resultyou will find the specified tag value in the data object of the response |[optional]|