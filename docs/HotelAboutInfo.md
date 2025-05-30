# HotelAboutInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Description** | **string** | description of the hotel<br>the description of the hotel entity for which the results are collected |[optional]|
**SubDescriptions** | **IEnumerable<string>** | additional description of the hotel<br>details about the hotel provided in addition to the description |[optional]|
**CheckInTime** | **Info** | hotel check-in time<br>check-in time indicated in the hotel listing |[optional]|
**CheckOutTime** | **Info** | hotel check-out time<br>check-out time indicated in the hotel listing |[optional]|
**FullAddress** | **string** | full address of the hotel<br>address of the hotel indicated in the standardised format |[optional]|
**Domain** | **string** | hotel domain<br>domain of the hotel’s website |[optional]|
**Url** | **string** | hotel url<br>URL to the hotel’s website indicated in the listing |[optional]|
**Amenities** | **IEnumerable<HotelAmenityInfo>** | hotel amenities<br>information about hotel amenities |[optional]|
**PopularAmenities** | **IEnumerable<HotelAmenityItemInfo>** | hotel amenities<br>information about hotel amenities labelled as “popular” |[optional]|