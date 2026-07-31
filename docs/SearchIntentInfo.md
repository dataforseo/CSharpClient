# SearchIntentInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**MainIntent** | **string** | main search intentpossible values: informational, navigational, commercial, transactional |[optional]|
**ForeignIntent** | **IEnumerable<string>** | supplementary search intentspossible values: informational, navigational, commercial, transactional |[optional]|
**LastUpdatedTime** | **string** | date and time when keyword data was updatedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2019-11-15 12:57:46 +00:00 |[optional]|