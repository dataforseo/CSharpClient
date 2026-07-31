# AvailableLanguages


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**AvailableSources** | **IEnumerable<string>** | <em>supported sources</em><br>contains the sources of data supported for a specific location and language combination<br>only <code>google</code> and <code>bing</code> are currently available |[optional]|
**LanguageName** | **string** | <em>language name</em> |[optional]|
**LanguageCode** | **string** | <em>language code according to <a href='https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes' target='_blank' rel='noopener noreferrer'>ISO 639-1</a></em> |[optional]|
**Keywords** | **int?** | <em>the number of keywords available for the given location and language |[optional]|
**Serps** | **int?** | <em>the number of SERP pages available for the given location and language |[optional]|