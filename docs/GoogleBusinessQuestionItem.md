# GoogleBusinessQuestionItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank among all the elements</em> |[optional]|
**QuestionId** | **string** | <em>ID of the question</em> |[optional]|
**Url** | **string** | <em>URL of the question</em> |[optional]|
**ProfileImageUrl** | **string** | <em>URL of the user's profile image</em> |[optional]|
**ProfileUrl** | **string** | <em>URL of the user's profile</em> |[optional]|
**ProfileName** | **string** | <em>displayed name of the user</em> |[optional]|
**QuestionText** | **string** | <em>current text of the question</em> |[optional]|
**OriginalQuestionText** | **string** | <em>original text of the question</em> |[optional]|
**TimeAgo** | **string** | <em>estimated time when the question was posted</em> |[optional]|
**Timestamp** | **string** | <em>exact time when the question was posted</em> |[optional]|
**Items** | **IEnumerable<GoogleBusinessAnswerElement>** | <em>array of items</em><br>items within <code>google_business_question_item</code> |[optional]|