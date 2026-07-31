# HotelPriceItemInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Title** | **string** | <em>title of the hotel</em> |[optional]|
**Price** | **double?** | <em>price per night</em> |[optional]|
**Currency** | **string** | <em>price currency</em><br><code>USD</code> is applied by default, unless specified in the POST array |[optional]|
**Url** | **string** | third-party page url<br>URL to the third-party website page with pricing information |[optional]|
**Domain** | **string** | third-party domain<br>domain of the third-party website page with pricing information |[optional]|
**IsPaid** | **bool?** | <em>indicates a paid hotel listing</strong></em><br>if <code>true</code>, related <code>hotel_search_item</code> is a paid ad<br>if <code>false</code>, related <code>hotel_search_item</code> is an organic hotel listing |[optional]|
**OfficialSite** | **bool?** |  |[optional]|
**FreeCancellationUntil** | **string** | date until which free cancellation is available<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>equals null if free cancellation is not available for the selected dates |[optional]|
**Offers** | **IEnumerable<HotelInfoPriceOffer>** |  |[optional]|