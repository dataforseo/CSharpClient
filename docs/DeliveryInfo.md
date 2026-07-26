# DeliveryInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**DeliveryDateFrom** | **string** | <em>earliest delivery date</em><br>the earliest date when the product can be shipped, in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example: <code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**DeliveryDateTo** | **string** | <em>latest delivery date</em><br>the latest date when the product can be delivered, in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example: <code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**FastestDeliveryDateFrom** | **string** | <em>earliest free delivery date</em><br>the earliest date when the product can be delivered with a fast delivery option, in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example: <code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**FastestDeliveryDateTo** | **string** | <em>latest free delivery date</em><br>the latest date when the product can be delivered with a fast delivery option, in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example: <code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**DeliveryMessage** | **string** | <em>delivery information</em><br>message accompanying the delivery information as posted by the seller |[optional]|
**DeliveryPrice** | **PriceInfo** | <em>price for the delivery</em><br>price of the delivery based on the location you specified in the POST request;<br>if free delivery is available, the value is <code>null</code> |[optional]|