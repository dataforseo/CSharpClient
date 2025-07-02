# BusinessDataGoogleHotelSearchesItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**HotelIdentifier** | **string** | unique identifier of a hotel entity in Google search<br>example:<br>CgoI-KWyzenM_MV3EAE |[optional]|
**Title** | **string** | title of the hotel |[optional]|
**Stars** | **int?** | hotel class rating<br>class rating that ranges between 1-5 stars |[optional]|
**IsPaid** | **bool?** | indicates a paid hotel listing<br>if true, related hotel_search_item is a paid ad<br>if false, related hotel_search_item is an organic hotel listing |[optional]|
**Location** | **GpsCoordinatesLocationInfo** | GPS coordinates of the hotel’s location |[optional]|
**Reviews** | **HotelReviewInfo** | hotel reviews and rating information |[optional]|
**OverviewImages** | **IEnumerable<string>** | featured images for a hotel |[optional]|
**Prices** | **HotelPriceInfo** | hotel price |[optional]|