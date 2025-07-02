# MicrodataFieldsInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Name** | **string** | field name<br>name of the data field |[optional]|
**Types** | **IEnumerable<string>** | parent microdata types<br>for a full list of available types, please visit schema.org |[optional]|
**Value** | **string** | microdata value<br>microdata value specified on a target web page |[optional]|
**TestResults** | **MessageInfo** | microdata validation test results<br>sub-type microdata test results that contain detected errors and related messages |[optional]|
**Fields** | **IEnumerable<MicrodataFieldsInfo>** | microdata fields<br>an array of objects containing data fields related to the certain microdata type |[optional]|