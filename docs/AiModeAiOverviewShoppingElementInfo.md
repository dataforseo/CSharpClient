# AiModeAiOverviewShoppingElementInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**ProductId** | **string** | <em>unique product identifier on Google Shopping</em><br>learn more about the parameter in <a href='https://dataforseo.com/help-center/product-id-google-shopping' rel='noopener noreferrer' target='_blank'>this help center guide</a> |[optional]|
**DataDocid** | **string** | <em>unique identifier of the SERP data element</em> |[optional]|
**Gid** | **string** | <em>global product identifier on Google Shopping</em><br>learn more about the parameter in <a href='https://dataforseo.com/help-center/whats-a-gid-in-google-shopping-api' rel='noopener noreferrer' target='_blank'>this help center guide</a> |[optional]|
**Title** | **string** | <em>reference page title</em> |[optional]|
**Url** | **string** | <em>URL in link</em> |[optional]|
**Domain** | **string** | <em>domain in link</em> |[optional]|
**Rating** | **RatingInfo** | <em>product rating </em><br>the popularity rate based on reviews<br> if there is none, the value will be <code>null</code> |[optional]|
**Price** | **PriceInfo** | <em>product price</em><br>product price details on the seller's website;<br> if there is none, the value will be <code>null</code> |[optional]|
**Seller** | **string** | <em>product seller</em><br>name of the product's seller as displayed in search results |[optional]|
**Snippet** | **string** | <em>additional information about the result</em> |[optional]|
**Marketplace** | **string** | <em>merchant account provider</em><br>e-commerce site that hosts products or websites of individual sellers under the same merchant account<br>example:<br><code>by Google</code> |[optional]|
**MarketplaceUrl** | **string** | <em>URL to the merchant account provider</em><br>e-commerce site that hosts products or websites of individual sellers under the same merchant account |[optional]|
**ImageUrl** | **string** | <em>URL of the image</em><br>the URL leading to the image on the original resource or DataForSEO storage (in case the original source is not available) |[optional]|