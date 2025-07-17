# ContentGenerationGenerateTextLiveRequestInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Topic** | **string** | main topic of the content to generate<br>required field<br>main topic for generating content;<br>can contain from 1 to 50 tokens |[optional]|
**WordCount** | **long?** | number of words in content<br>required field<br>the number of tokens in the generated text;<br>can take values from 1 to 1000 |[optional]|
**SubTopics** | **IEnumerable<string>** | secondary topics of the content to generate<br>optional field<br>secondary topics for generating content;<br>can contain up to 10 terms;<br>example: 'sub_topics': ['Apple','Pixar','Amazing Products'] |[optional]|
**Description** | **string** | meta description of the content to generate<br>optional field<br>can contain from 1 to 1000 tokens<br>learn more about this parameter on our help center |[optional]|
**MetaKeywords** | **IEnumerable<string>** | keywords for the content to generate<br>optional field<br>can contain up to 10 terms;<br>learn more about this parameter on our help center<br>example: 'meta_keywords': ['iPhone','sell','CEO'] |[optional]|
**CreativityIndex** | **double?** | creativity of content generation<br>optional field<br>the randomness of the selection of equally probable subsequent tokens;<br>can take values from 0 to 1<br>default value: 0.8<br>learn more about this parameter on our help center |[optional]|
**IncludeConclusion** | **bool?** | include conclusion in generated text<br>optional field<br>if set to true, generated content will include a logical conclusion |[optional]|
**SupplementToken** | **string** | token for generating subsequent results<br>optional field<br>provided in the identical filed of the response to each request;<br>you can use this parameter to continue the generation of text from the initial response<br>supplement_token values are unique for each subsequent task |[optional]|
**Tag** | **string** | user-defined task identifier<br>optional field<br>the character limit is 255<br>you can use this parameter to identify the task and match it with the result<br>you will find the specified tag value in the data object of the response |[optional]|