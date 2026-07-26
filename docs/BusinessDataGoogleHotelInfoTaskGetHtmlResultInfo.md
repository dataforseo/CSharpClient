# BusinessDataGoogleHotelInfoTaskGetHtmlResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** |  |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** |  |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <strong><code>items</code></strong> array</em> |[optional]|
**Items** | **IEnumerable<HtmlItemInfo>** | <em>HTML pages</em> |[optional]|