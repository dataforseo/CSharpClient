# ProductInfoElementMerchantSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**ProductId** | **string** | product_id received in a POST array<br>ilearn more about the parameter in this help center guide |[optional]|
**Title** | **string** | title of the product |[optional]|
**Description** | **string** | description of the product |[optional]|
**Url** | **string** | product url<br>url of the product on Google Shopping |[optional]|
**Images** | **IEnumerable<string>** | product images<br>contains urls to product images |[optional]|
**Features** | **IEnumerable<string>** | product features<br>contains snippets with the description of product features |[optional]|
**Rating** | **RatingElement** | product rating <br>the popularity rate based on reviews |[optional]|
**SellerReviewsCount** | **long?** | number of seller reviews<br>number of reviews on the product seller’s account |[optional]|
**Sellers** | **IEnumerable<ProductSeller>** | sellers of the product<br>number of reviews on the product seller’s account |[optional]|
**Variations** | **IEnumerable<ProductVariation>** | variations of the product<br>contains brief information about different product variations |[optional]|