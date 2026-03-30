# ChatGptGoogleShoppingProduct


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Ei** | **string** | event identifier<br>internal event identifier used by Google |[optional]|
**ProductId** | **string** | product identifier<br>can be used as a data_docid in Google Shopping API endpoints |[optional]|
**CatalogId** | **string** | Google Shopping catalog identifier of the product<br>can be used as a product_id in Google Shopping API endpoints |[optional]|
**Gpcid** | **string** | Google product cluster identifier<br>can be used as a gid in Google Shopping API endpoints |[optional]|
**HeadlineOfferDocid** | **string** | document identifier of the main offer in the headline<br>can be used as a data_docid in Google Shopping API endpoints |[optional]|
**ImageDocid** | **string** | identifier for the displayed product’s image |[optional]|
**Rds** | **string** | resource descriptor string <br>internal Google resource descriptor string that identifies the product within Google’s Shopping index |[optional]|
**Query** | **string** | search query<br>search query used by ChatGPT to retrieve the product from Google Shopping |[optional]|
**Mid** | **string** | merchant identifier<br>identifier of the seller or merchant account in Google Shopping |[optional]|
**Pvt** | **string** | product view type<br>internal Google parameter that specifies the product view type used when rendering the product item |[optional]|
**Uule** | **string** | encoded location parameter<br>indicates the location for a search |[optional]|
**Gl** | **string** | country code<br>indicates the location for which search results are displayed |[optional]|
**Hl** | **string** | host language code<br>indicates the language in which search results are displayed |[optional]|