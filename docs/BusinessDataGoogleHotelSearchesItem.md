# BusinessDataGoogleHotelSearchesItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**HotelIdentifier** | **string** | <em>unique identifier of a hotel entity in Google search</em><br>example:<br><code>CgoI-KWyzenM_MV3EAE</code> |[optional]|
**Title** | **string** | <em>title of the hotel</em> |[optional]|
**Stars** | **int?** | <em>hotel class rating</em><br>class rating that ranges between 1-5 stars |[optional]|
**IsPaid** | **bool?** | <em>indicates a paid hotel listing</strong></em><br>if <code>true</code>, related <code>hotel_search_item</code> is a paid ad<br>if <code>false</code>, related <code>hotel_search_item</code> is an organic hotel listing |[optional]|
**Location** | **GpsCoordinatesLocationInfo** | <em>GPS coordinates of the hotel's location</em> |[optional]|
**Reviews** | **HotelReviewInfo** | <em>hotel reviews and rating information</em> |[optional]|
**OverviewImages** | **IEnumerable<string>** | <em>featured images for a hotel</em> |[optional]|
**Prices** | **HotelPriceInfo** | <em>hotel price</em> |[optional]|