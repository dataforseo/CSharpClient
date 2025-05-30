# HotelPriceInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Price** | **double?** | price per night |[optional]|
**PriceWithoutDiscount** | **double?** | full price per night without a discount applied |[optional]|
**Currency** | **string** | price currency<br>USD is applied by default, unless specified in the POST array |[optional]|
**DiscountText** | **string** | text about a discount applied |[optional]|
**CheckIn** | **string** | check-in date and time<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**CheckOut** | **string** | check-out date and time<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Visitors** | **double?** | number of hotel visitors for this price |[optional]|
**Items** | **IEnumerable<HotelPriceItemInfo>** | encountered item types<br>types of search engine results encountered in the items array;<br>possible item types: hotel_search_item |[optional]|
**PricesByDates** | **IEnumerable<PricesByDates>** |  |[optional]|