# ContentGenerationCheckGrammarLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**InputTokens** | **double?** | number of input tokens in the POST request |[optional]|
**OutputTokens** | **double?** | number of output tokens in the response |[optional]|
**NewTokens** | **double?** | number of new tokens in the response |[optional]|
**InitialText** | **string** | initial text in the POST request |[optional]|
**LanguageCode** | **string** | language code in the POST request |[optional]|
**ItemsCount** | **double?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<ContentGenerationCheckGrammarLiveItem>** | contains grammar or spelling errors and related data |[optional]|