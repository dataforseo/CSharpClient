# AmazonDeliveryInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**DeliveryMessage** | **string** | message accompanying the delivery information as posted by the seller |[optional]|
**DeliveryDateFrom** | **string** | the earliest date when the product can be shipped |[optional]|
**DeliveryDateTo** | **string** | the latest date when the product can be delivered |[optional]|
**FastestDeliveryDateFrom** | **string** | the earliest date when the product can be delivered with a fast delivery option |[optional]|
**FastestDeliveryDateTo** | **string** | the latest date when the product can be delivered with a fast delivery option |[optional]|
**DeliveryPrice** | **PriceInfo** | price for the delivery<br>price of the delivery based on the location you specified in the POST request;<br>if free delivery is available, the value is null |[optional]|