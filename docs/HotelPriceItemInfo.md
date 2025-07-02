# HotelPriceItemInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Title** | **string** | title of the hotel |[optional]|
**Price** | **int?** | price per night |[optional]|
**Currency** | **string** | price currency<br>USD is applied by default, unless specified in the POST array |[optional]|
**Url** | **string** | third-party page url<br>URL to the third-party website page with pricing information |[optional]|
**Domain** | **string** | third-party domain<br>domain of the third-party website page with pricing information |[optional]|
**IsPaid** | **bool?** | indicates a paid hotel listing<br>if true, related hotel_search_item is a paid ad<br>if false, related hotel_search_item is an organic hotel listing |[optional]|
**FreeCancellationUntil** | **string** | date until which free cancellation is available<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>equals null if free cancellation is not available for the selected dates |[optional]|
**Offers** | **IEnumerable<HotelInfoPriceOffer>** | featured price offers |[optional]|