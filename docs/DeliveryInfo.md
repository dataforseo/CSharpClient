# DeliveryInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**DeliveryDateFrom** | **string** | earliest delivery datethe earliest date when the product can be shipped |[optional]|
**DeliveryDateTo** | **string** | latest delivery datethe latest date when the product can be delivered |[optional]|
**FastestDeliveryDateFrom** | **string** | earliest free delivery datethe earliest date when the product can be delivered with a fast delivery option |[optional]|
**FastestDeliveryDateTo** | **string** | latest free delivery datethe latest date when the product can be delivered with a fast delivery option |[optional]|
**DeliveryMessage** | **string** | delivery informationmessage accompanying the delivery information as posted by the seller |[optional]|
**DeliveryPrice** | **PriceInfo** | price for the deliveryprice of the delivery based on the location you specified in the POST request;if free delivery is available, the value is null |[optional]|