# ChatGptProductsElement


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**ProductId** | **string** | <em>product id</em> |[optional]|
**Merchants** | **string** | <em>merchant(s) offering the product</em> |[optional]|
**IdToTokenMap** | **string** | <em>product identifier token</em><br>Base64-encoded token containing Google Shopping product IDs associated with the product |[optional]|
**Title** | **string** | <em>title of the element</em> |[optional]|
**Rating** | **RatingInfo** | <em>rating of the corresponding local business</em><br>popularity rate based on reviews as displayed in the results |[optional]|
**Price** | **double?** | <em>product price</em> |[optional]|
**Currency** | **string** | <em>currency of the listed price</em><br>ISO code of the currency applied to the price |[optional]|
**Tag** | **string** | <em>tag text</em> |[optional]|
**Url** | **string** | <em>URL</em> |[optional]|
**Domain** | **string** | <em>domain</em> |[optional]|
**Images** | **IEnumerable<string>** | <em>image URLs of the element</em><br>contains URLs leading to the images on the original resource or DataForSEO storage (in case the original source is not available) |[optional]|
**ProductIds** | **IEnumerable<ChatGptGoogleShoppingProduct>** | <em>Google Shopping product identifiers</em><br>array of Google Shopping product IDs associated with the product |[optional]|