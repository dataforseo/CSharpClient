# BusinessDataGoogleHotelInfoTaskGetHtmlResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | identifier received in a POST array<br>this field will contain the hotel_identifier parameter specified when setting a task;<br>example:<br>CgoI-KWyzenM_MV3EAE |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**ItemsCount** | **long?** | the number of results returned in the items array |[optional]|
**Items** | **IEnumerable<HtmlItem>** | HTML pages |[optional]|
**Type** | **string** |  |[optional]|
**SeDomain** | **string** |  |[optional]|