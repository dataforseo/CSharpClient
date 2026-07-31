# BusinessDataGoogleHotelSearchesTaskGetResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | <em>keyword received in a POST array</em><br>keyword is returned with decoded %## (plus character '+' will be decoded to a space character);<br>in order to obtain accurate search results, the location name is appended to the keyword automatically |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to search engine results</em><br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**ItemsCount** | **long?** | <em>item types</em><br>the number of items in the <code>items</code> array |[optional]|
**Items** | **IEnumerable<BusinessDataGoogleHotelSearchesItem>** | <em>array of items</em><br><strong>note:</strong> this field always equals <code>null</code>; use it to facilitate integration and ensure interoperability with the <a href='/v3/business_data/google/hotel_info/live/advanced/'>Hotel Info</a> endpoint |[optional]|