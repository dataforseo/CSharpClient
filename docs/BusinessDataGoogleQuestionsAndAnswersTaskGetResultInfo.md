# BusinessDataGoogleQuestionsAndAnswersTaskGetResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | keyword received in a POST array<br>keyword is returned with decoded %## (plus character ‘+’ will be decoded to a space character)<br>this field will contain the cid parameter if you specified it in the keyword field when setting a task;<br>example:<br>cid:2946633002421908862<br>learn more about the parameter in this help center article |[optional]|
**SeDomain** | **string** | search engine domain as specified in a POST array |[optional]|
**LocationCode** | **double?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine results<br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Cid** | **string** | google-defined client id<br>unique id of a local establishment;<br>learn more about the identifier in this help center article |[optional]|
**FeatureId** | **string** | unique identifier of the SERP feature |[optional]|
**ItemTypes** | **IEnumerable<string>** | item types<br>types of search engine results encountered in the items array;<br>possible item types: google_business_question_item |[optional]|
**ItemsWithoutAnswers** | **IEnumerable<ItemsWithoutAnswers>** | array of google business question items without answers |[optional]|
**ItemsCount** | **double?** | the number of items in the items array |[optional]|
**Items** | **IEnumerable<BusinessDataGoogleQuestionsAndAnswersItem>** | array of items within google_business_question_item<br>contains answers to the google business questions;<br>the maximum number of answers returned for each question: 5<br>possible item types google_business_answer_element |[optional]|