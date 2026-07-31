# ProductSeller


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Title** | **string** | <em>product title</em> |[optional]|
**Url** | **string** | <em>seller url</em><br>url of the page where the product is sold |[optional]|
**SellerRating** | **RatingElement** | <em>rating of the seller</em> |[optional]|
**SellerReviewCount** | **int?** | number of seller reviews<br>number of reviews on the product seller’s account |[optional]|
**Price** | **PriceInfo** | <em>product price</em><br>product price details on the seller's website |[optional]|
**DeliveryInfo** | **DeliveryInfo** | <em>delivery information</em><br>product delivery information |[optional]|
**ProductAvailability** | **string** | <em>product availability information</em><br>can take the following values: <code>in_stock</code>, <code>limited_stock</code>, <code>out_of_stock</code>, <code>backordered</code>, <code>pre_order_available</code>, <code>on_display_to_order</code> |[optional]|