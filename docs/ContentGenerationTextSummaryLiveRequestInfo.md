# ContentGenerationTextSummaryLiveRequestInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Text** | **string** | target text<br>required field<br>can contain from 1 to 10000 tokens<br>learn more about tokens on our help center |[optional]|
**LanguageName** | **string** | name of the text language<br>required field if you do not specify language_code<br>see the List of Languages for Content Generation Text Summary API |[optional]|
**LanguageCode** | **string** | code of the text language<br>required field if you do not specify language_name<br>see the List of Languages for Content Generation Text Summary API |[optional]|
**InternalListLimit** | **int?** | maximum number of elements within internal arrays<br>optional field<br>you can use this field to limit the number of elements within the keyword_density array<br>default value: 10 |[optional]|
**Tag** | **string** | user-defined task identifier<br>optional field<br>the character limit is 255<br>you can use this parameter to identify the task and match it with the result<br>you will find the specified tag value in the data object of the response |[optional]|