# SerpGoogleDatasetInfoLiveAdvancedRequestInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**DatasetId** | **string** | ID of the dataset<br>required field<br>you can find dataset ID in the dataset URL or dataset item of Google Dataset Search result<br>example:<br>L2cvMTFqbl85ZHN6MQ== |[optional]|
**LanguageName** | **string** | full name of search engine language<br>optional field<br>if you use this field, you don’t need to specify language_code<br>possible value:<br>English |[optional]|
**LanguageCode** | **string** | search engine language code<br>optional field<br>if you use this field, you don’t need to specify language_name<br>possible value:<br>en |[optional]|
**Device** | **string** | device type<br>optional field<br>possible value: desktop |[optional]|
**Os** | **string** | device operating system<br>optional field<br>possible values: windows, macos<br>default value: windows |[optional]|
**Tag** | **string** | user-defined task identifier<br>optional field<br>the character limit is 255<br>you can use this parameter to identify the task and match it with the result<br>you will find the specified tag value in the data object of the response |[optional]|