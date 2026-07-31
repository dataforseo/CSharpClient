# ProductInfoElement


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank on the product specification page</em><br>absolute position among all the elements found on the product specification page |[optional]|
**Position** | **string** | <em>alignment of the element on the product specification page</em><br>can take the following values:<br><code>right</code>, <code>left</code> |[optional]|
**ProductId** | **string** | <em>product_id received in a POST array</em><br>ilearn more about the parameter in <a href='https://dataforseo.com/help-center/product-id-google-shopping' rel='noopener noreferrer' target='_blank'>this help center guide</a> |[optional]|
**Title** | **string** | <em>title of the product</em> |[optional]|
**Description** | **string** | <em>description of the product</em> |[optional]|
**Url** | **string** | <em>product url</em><br>url of the product on Google Shopping |[optional]|
**Images** | **IEnumerable<string>** | <em>product images</em><br>contains urls to product images |[optional]|
**Features** | **IEnumerable<string>** | <em>product features</em><br>contains snippets with the description of product features |[optional]|
**Rating** | **RatingElement** | <em>product rating </em><br>the popularity rate based on reviews |[optional]|
**SellerReviewsCount** | **long?** | <em>number of seller reviews</em><br>number of reviews on the product seller's account |[optional]|
**DataDocid** | **string** | <em>unique identifier of the SERP data element</em><br>note that there is no full list of possible values as the <code>data_docid</code> is a dynamic value assigned by Google<br>example:<br><code>17363035694596624076</code> |[optional]|
**Gid** | **string** | <em>global product identifier on Google Shopping</em><br>note that there is no full list of possible values as the gid is a dynamic value assigned by Google<br>if there are no values, you will get <code>null</code><br>example:<br><code>4702526954592161872</code><br>learn more about <code>gid</code> in <a href='https://dataforseo.com/help-center/whats-a-gid-in-google-shopping-api' target='_blank'>this help center guide</a> |[optional]|
**Specifications** | **IEnumerable<ShoppingSpecification>** | <em>product specifications</em><br>contains all product attributes and related data listed on the product specification page |[optional]|
**Sellers** | **IEnumerable<ProductSeller>** | <em>sellers of the product</em><br>number of reviews on the product seller's account |[optional]|
**Variations** | **IEnumerable<ProductVariation>** | <em>variations of the product</em><br>contains brief information about different product variations |[optional]|