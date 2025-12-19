# ResultAvailableLanguages


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**AvailablePlatforms** | **IEnumerable<string>** | supported LLM platforms<br>contains the sources of data supported for a specific location and language combination<br>only google and chat_gpt are currently available |[optional]|
**LanguageName** | **string** | language name |[optional]|
**LanguageCode** | **string** | language code according to ISO 639-1 |[optional]|
**ResponsesCount** | **long?** | number of LLM responses<br>the number of LLM responses available in the database for the certain location and language parameters |[optional]|