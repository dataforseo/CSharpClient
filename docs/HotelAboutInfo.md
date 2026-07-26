# HotelAboutInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Description** | **string** | <em>description of the hotel</em><br>the description of the hotel entity for which the results are collected |[optional]|
**SubDescriptions** | **IEnumerable<string>** | <em>additional description of the hotel</em><br>details about the hotel provided in addition to the description |[optional]|
**CheckInTime** | **TimeInfo** | <em>hotel check-in time</em><br>check-in time indicated in the hotel listing |[optional]|
**CheckOutTime** | **TimeInfo** | <em>hotel check-out time</em><br>check-out time indicated in the hotel listing |[optional]|
**FullAddress** | **string** | <em>full address of the hotel</em><br>address of the hotel indicated in the standardised format |[optional]|
**Domain** | **string** | <em>hotel domain</em><br>domain of the hotel's website |[optional]|
**Url** | **string** | <em>hotel url</em><br>URL to the hotel's website indicated in the listing |[optional]|
**Amenities** | **IEnumerable<HotelAmenityInfo>** | <em>hotel amenities</em><br>information about hotel amenities |[optional]|
**PopularAmenities** | **IEnumerable<HotelAmenityItemInfo>** | <em>hotel amenities</em><br>information about hotel amenities labelled as 'popular' |[optional]|