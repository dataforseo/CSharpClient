# PopularProductsElement


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Title** | **string** | <em>title of a given link element</em> |[optional]|
**Url** | **string** | <em>source URL</em> |[optional]|
**Domain** | **string** | <em>domain where a link points</em> |[optional]|
**Description** | **string** | <em>link description</em> |[optional]|
**MoreSellers** | **bool?** | <em>indicates whether the product is sold by multiple sellers</em> |[optional]|
**Seller** | **string** | <em>seller of the product</em> |[optional]|
**GroupTitle** | **string** | <em>title of the hotel listing's group</em> |[optional]|
**GroupSource** | **string** | <em>domain or brand name of the hotel listing's group</em> |[optional]|
**ImageUrl** | **string** | <em>URL of the image</em><br>the URL leading to the image on the original resource or DataForSEO storage (in case the original source is not available) |[optional]|
**Price** | **PriceInfo** | <em>price indicated in the element</em> |[optional]|
**Rating** | **RatingInfo** | <em>the item's rating </em><br>the popularity rate based on reviews and displayed in SERP;<br>if there is none, equals <code>null</code> |[optional]|
**ProductIdentifiers** | **ProductIdentifiers** | <em>identifiers of the product</em><br>can include the following identifiers: <code>product_id</code>, <code>data_docid</code>, <code>gid</code> |[optional]|