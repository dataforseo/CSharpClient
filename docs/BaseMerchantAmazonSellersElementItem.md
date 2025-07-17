# BaseMerchantAmazonSellersElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements found in Amazon Sellers SERP |[optional]|
**Position** | **string** | alignment of the element in SERP<br>possible values:<br>left, right |[optional]|
**Xpath** | **string** | XPath of the element |[optional]|
**SellerName** | **string** | business name of the seller |[optional]|
**SellerUrl** | **string** | url forwarding to the seller’s page on Amazon |[optional]|
**ShipsFrom** | **string** | sender company name |[optional]|
**Price** | **PriceInfo** | product pricing details<br>if there are no details, the value will be null |[optional]|
**Rating** | **RatingElement** | seller rating details<br>seller popularity rate based on customer reviews |[optional]|
**Condition** | **string** | product condition<br>condition of the product offered by the seller |[optional]|
**ConditionDescription** | **string** | product condition details<br>expanded details on the condition of the product offered by the seller |[optional]|
**DeliveryInfo** | **AmazonDeliveryInfo** | delivery information<br>delivery information including free and fast delivery date ranges |[optional]|