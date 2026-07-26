# BusinessDataGoogleHotelInfoLiveAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**HotelIdentifier** | **string** | <em>identifier received in a POST array</em><br>this field will contain the <code>hotel_identifier</code> parameter specified when setting a task;<br>example:<br><code>CgoI-KWyzenM_MV3EAE</code> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to search engine results</em><br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Title** | **string** | <em>hotel title</em><br>the title of the hotel entity for which the results are collected |[optional]|
**Stars** | **int?** | <em>hotel class rating</em><br>class rating that ranges between 1-5 stars and displayed after review ratings in hotel summary |[optional]|
**StarsDescription** | **string** | <em>hotel class rating</em><br>class rating that ranges between 1-5 stars and displayed after review ratings in the hotel summary |[optional]|
**Address** | **string** | <em>hotel address</em><br>physical address of the hotel |[optional]|
**Phone** | **string** | <em>hotel phone number</em><br>contact phone number of the hotel |[optional]|
**About** | **HotelAboutInfo** | <em>information about the hotel</em> |[optional]|
**Location** | **HotelLocationInfo** | <em>information about the hotel location</em><br>information about the location where the hotel is located |[optional]|
**Reviews** | **HotelReviewInfo** | <em>hotel reviews by criteria</em><br>information about reviews of the hotel entity |[optional]|
**OverviewImages** | **IEnumerable<string>** | <em>images displayed in the hotel overview</em><br>array containing URLs to images displayed in the hotel overview |[optional]|
**Prices** | **HotelPriceInfo** | <em>pricing details of the hotel entity</em><br>contains information about the hotel's prices |[optional]|