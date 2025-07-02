# SearchIntentInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type<br>possible values: google |[optional]|
**MainIntent** | **string** | main search intent<br>possible values: informational, navigational, commercial, transactional |[optional]|
**ForeignIntent** | **IEnumerable<string>** | supplementary search intents<br>possible values: informational, navigational, commercial, transactional |[optional]|
**LastUpdatedTime** | **string** | date and time when backlink data was updated<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|