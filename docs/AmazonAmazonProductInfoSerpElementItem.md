# AmazonAmazonProductInfoSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | product title |[optional]|
**Details** | **string** | product specs and other details |[optional]|
**ImageUrl** | **string** | the URL of the product image |[optional]|
**Author** | **string** | product brand name |[optional]|
**DataAsin** | **string** | ASIN of the product received in a POST array |[optional]|
**ParentAsin** | **string** | parent ASIN of the product |[optional]|
**ProductAsins** | **IEnumerable<string>** | ASINs of all found product modifications |[optional]|
**PriceFrom** | **float?** | the lower limit of the product price range<br>example:<br>49.98 |[optional]|
**PriceTo** | **float?** | the upper limit of the product price range<br>example:<br>384.99 |[optional]|
**Currency** | **string** | currency in the ISO format<br>example:<br>USD |[optional]|
**IsAmazonChoice** | **bool?** | “Amazon’s choice” label<br>if the value is true, the product is marked with the “Amazon’s choice” label |[optional]|
**Rating** | **RatingElement** | product rating info |[optional]|
**IsNewerModelAvailable** | **bool?** | indicates whether the newer model of the product is available |[optional]|
**ApplicableVouchers** | **IEnumerable<AmazonApplicableVouchersItem>** | array of objects containing information about applicable vouchers |[optional]|
**NewerModel** | **AmazonProductNewerModelInfo** | information about the newer model of the product |[optional]|
**Categories** | **IEnumerable<ProductCategoryInfo>** | contains related product categories |[optional]|
**ProductInformation** | **IEnumerable<BaseProductInformationItem>** | contains related product information |[optional]|
**ProductImagesList** | **IEnumerable<string>** | contains URLs for all images of the product displayed on the left side of the main image |[optional]|
**ProductVideosList** | **IEnumerable<string>** | contains URLs for all videos of the product displayed on the right side of the main video |[optional]|
**Description** | **string** | contains description of the product |[optional]|
**IsAvailable** | **bool?** | indicates whether the product is available for ordering<br>if the value is true, the product can be ordered |[optional]|
**TopLocalReviews** | **IEnumerable<BaseAmazonSerpElementItem>** | array of objects with top reviews from target location<br>to obtain additional local reviews, you can specify the load_more_local_reviews parameter in Task POST |[optional]|
**TopGlobalReviews** | **IEnumerable<BaseAmazonSerpElementItem>** | array of objects with top reviews from around the world |[optional]|