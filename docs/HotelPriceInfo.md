# HotelPriceInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Price** | **double?** | <em>price per night</em> |[optional]|
**PriceWithoutDiscount** | **double?** | <em>full price per night without a discount applied</em> |[optional]|
**Currency** | **string** | <em>price currency</em><br><code>USD</code> is applied by default, unless specified in the POST array |[optional]|
**DiscountText** | **string** | <em>text about a discount applied</em> |[optional]|
**CheckIn** | **string** | <em>check-in date and time</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**CheckOut** | **string** | <em>check-out date and time</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Visitors** | **int?** | <em>number of hotel visitors for this price</em> |[optional]|
**Items** | **IEnumerable<HotelPriceItemInfo>** | <em>encountered item types</em><br>types of search engine results encountered in the <code>items</code> array;<br>possible item types: <code>hotel_search_item</code> |[optional]|
**PricesByDates** | **IEnumerable<PricesByDates>** |  |[optional]|