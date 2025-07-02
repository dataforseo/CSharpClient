# HotelInfoPriceOffer


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Title** | **string** | title of the hotel |[optional]|
**Price** | **int?** | price per night |[optional]|
**Currency** | **string** | price currency<br>USD is applied by default, unless specified in the POST array |[optional]|
**Url** | **string** | url of the price offer<br>URL to the page of the website where price offer appears |[optional]|
**MaxVisitors** | **int?** | the maximal number of visitors<br>the maximum number of visitors for which the price offer is valid |[optional]|
**OfferImages** | **IEnumerable<string>** | price offer images<br>URLs of the images featured in the price offer |[optional]|
**FreeCancellationUntil** | **string** | date until free cancellation is available<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>equals null if free cancellation is not available for the selected dates |[optional]|