# ItemsWithoutAnswers


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank among all the elements |[optional]|
**QuestionId** | **string** | ID of the question |[optional]|
**Url** | **string** | URL of the question |[optional]|
**ProfileImageUrl** | **string** | URL of the user’s profile image |[optional]|
**ProfileUrl** | **string** | URL of the user’s profile |[optional]|
**ProfileName** | **string** | displayed name of the user |[optional]|
**QuestionText** | **string** | current text of the question |[optional]|
**OriginalQuestionText** | **string** | original text of the question |[optional]|
**TimeAgo** | **string** | estimated time when the question was posted |[optional]|
**Timestamp** | **string** | exact time when the question was posted |[optional]|
**Items** | **GoogleBusinessAnswerElement** | array of items<br>items within google_business_question_item |[optional]|