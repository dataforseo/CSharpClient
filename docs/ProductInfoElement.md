# ProductInfoElement


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank on the product specification page<br>absolute position among all the elements found on the product specification page |[optional]|
**Position** | **string** | alignment of the element on the product specification page<br>can take the following values:<br>right, left |[optional]|
**ProductId** | **string** | product_id received in a POST array<br>ilearn more about the parameter in this help center guide |[optional]|
**Title** | **string** | title of the product |[optional]|
**Description** | **string** | description of the product |[optional]|
**Url** | **string** | product url<br>url of the product on Google Shopping |[optional]|
**Images** | **IEnumerable<string>** | product images<br>contains urls to product images |[optional]|
**Features** | **IEnumerable<string>** | product features<br>contains snippets with the description of product features |[optional]|
**Rating** | **RatingElement** | product rating <br>the popularity rate based on reviews |[optional]|
**SellerReviewsCount** | **long?** | number of seller reviews<br>number of reviews on the product seller’s account |[optional]|
**DataDocid** | **string** | unique identifier of the SERP data element<br>note that there is no full list of possible values as the data_docid is a dynamic value assigned by Google<br>example:<br>17363035694596624076 |[optional]|
**Gid** | **string** | global product identifier on Google Shopping<br>note that there is no full list of possible values as the gid is a dynamic value assigned by Google<br>if there are no values, you will get null<br>example:<br>4702526954592161872<br>learn more about gid in this help center guide |[optional]|
**Specifications** | **IEnumerable<ShoppingSpecification>** | product specifications<br>contains all product attributes and related data listed on the product specification page |[optional]|
**Sellers** | **IEnumerable<ProductSeller>** | sellers of the product<br>number of reviews on the product seller’s account |[optional]|
**Variations** | **IEnumerable<ProductVariation>** | variations of the product<br>contains brief information about different product variations |[optional]|