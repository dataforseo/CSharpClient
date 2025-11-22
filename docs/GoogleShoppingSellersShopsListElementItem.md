# GoogleShoppingSellersShopsListElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**PriceMultiplier** | **int?** | monthly price multiplier<br>indicates the number of months covered by the monthly payment for the product |[optional]|
**DisplayedPaymentBreakdown** | **string** | installment details as displayed in the results<br>shows how the product price can be broken down into monthly payments, if applicable |[optional]|
**Rating** | **RatingElement** | shop rating<br>the shop popularity rate based on product reviews |[optional]|
**ProductCondition** | **string** | indicated condition of the product<br>possible values: Used, Refurbished, New, Pre-owned, null |[optional]|
**ProductAnnotation** | **string** | data from annotations and badges with special offers<br>if there is no annotation for this product, the value will be null<br>examples: LOW PRICE, SPECIAL OFFER, SALE, PRICE DROP |[optional]|
**ProductAvailability** | **string** | product availability information<br>product availability information<br>can take the following values: in_stock, limited_stock, out_of_stock, backordered, pre_order_available, on_display_to_order |[optional]|