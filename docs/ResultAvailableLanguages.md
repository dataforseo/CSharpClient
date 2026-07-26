# ResultAvailableLanguages


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**AvailablePlatforms** | **IEnumerable<string>** | <em>supported LLM platforms</em><br>contains the sources of data supported for a specific location and language combination<br>only <code>google</code> and <code>chat_gpt</code> are currently available |[optional]|
**LanguageName** | **string** | <em>language name</em> |[optional]|
**LanguageCode** | **string** | <em>language code according to <a href='https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes' target='_blank' rel='noopener noreferrer'>ISO 639-1</a></em> |[optional]|
**ResponsesCount** | **long?** | <em>number of LLM responses</em><br>the number of LLM responses available in the database for the certain location and language parameters |[optional]|