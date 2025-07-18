# SerpGoogleDatasetSearchLiveAdvancedRequestInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | keyword<br>required field<br>you can specify up to 700 characters in the keyword field<br>all %## will be decoded (plus character ‘+’ will be decoded to a space character)<br>if you need to use the “%” character for your keyword, please specify it as “%25”;<br>if you need to use the “+” character for your keyword, please specify it as “%2B”;<br>learn more about rules and limitations of keyword and keywords fields in DataForSEO APIs in this Help Center article |[optional]|
**LanguageName** | **string** | full name of search engine language<br>optional field<br>if you use this field, you don’t need to specify language_code<br>possible value:<br>English |[optional]|
**LanguageCode** | **string** | search engine language code<br>optional field if you don’t specify language_name<br>if you use this field, you don’t need to specify language_name<br>possible value:<br>en |[optional]|
**Device** | **string** | device type<br>optional field<br>possible value: desktop |[optional]|
**Os** | **string** | device operating system<br>optional field<br>choose from the following values: windows, macos<br>default value: windows |[optional]|
**Depth** | **int?** | parsing depth<br>optional field<br>number of results in SERP<br>default value: 20<br>max value: 700<br>Note: your account will be billed per each SERP containing up to 20 results;<br>thus, setting a depth above 20 may result in additional charges if the search engine returns more than 20 results;<br>if the specified depth is higher than the number of results in the response, the difference will be refunded automatically to your account balance |[optional]|
**LastUpdated** | **string** | last time the dataset was updated<br>optional field<br>possible values: 1m, 1y, 3y |[optional]|
**FileFormats** | **IEnumerable<string>** | file formats of the dataset<br>optional field<br>possible values: other, archive, text, image, document, tabular |[optional]|
**UsageRights** | **string** | usage rights of the dataset<br>optional field<br>possible values: commercial, noncommercial |[optional]|
**IsFree** | **bool?** | indicates whether displayed datasets are free<br>optional field<br>possible values: true, false |[optional]|
**Topics** | **IEnumerable<string>** | dataset topics<br>optional field<br>possible values: humanities, social_sciences, life_sciences, agriculture, natural_sciences, geo, computer, architecture_and_urban_planning, engineering |[optional]|
**Tag** | **string** | user-defined task identifier<br>optional field<br>the character limit is 255<br>you can use this parameter to identify the task and match it with the result<br>you will find the specified tag value in the data object of the response |[optional]|