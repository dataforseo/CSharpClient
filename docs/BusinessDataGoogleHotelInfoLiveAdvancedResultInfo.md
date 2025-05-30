# BusinessDataGoogleHotelInfoLiveAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**HotelIdentifier** | **string** | identifier received in a POST array<br>this field will contain the hotel_identifier parameter specified when setting a task;<br>example:<br>CgoI-KWyzenM_MV3EAE |[optional]|
**LocationCode** | **double?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine results<br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Title** | **string** | hotel title<br>the title of the hotel entity for which the results are collected |[optional]|
**Stars** | **double?** | hotel class rating<br>class rating that ranges between 1-5 stars and displayed after review ratings in hotel summary |[optional]|
**StarsDescription** | **string** | hotel class rating<br>class rating that ranges between 1-5 stars and displayed after review ratings in the hotel summary |[optional]|
**Address** | **string** | hotel address<br>physical address of the hotel |[optional]|
**Phone** | **string** | hotel phone number<br>contact phone number of the hotel |[optional]|
**About** | **HotelAboutInfo** | information about the hotel |[optional]|
**Location** | **HotelLocationInfo** | information about the hotel location<br>information about the location where the hotel is located |[optional]|
**Reviews** | **HotelReviewInfo** | hotel reviews by criteria<br>information about reviews of the hotel entity |[optional]|
**OverviewImages** | **IEnumerable<string>** | images displayed in the hotel overview<br>array containing URLs to images displayed in the hotel overview |[optional]|
**Prices** | **HotelPriceInfo** | pricing details of the hotel entity<br>contains information about the hotel’s prices |[optional]|