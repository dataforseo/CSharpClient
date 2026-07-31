# AmazonProductInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em> absolute rank</em><br>absolute position among all the elements in the response array |[optional]|
**Position** | **string** | <em>the alignment of the element in Amazon SERP</em><br>possible values:<br><code>left</code>, <code>right</code> |[optional]|
**Xpath** | **string** | <em>the <a href='https://en.wikipedia.org/wiki/XPath'>XPath</a> of the element</em> |[optional]|
**Title** | **string** | <em>product title</em> |[optional]|
**Details** | **string** | <em>product specs and other details</em> |[optional]|
**ImageUrl** | **string** | <em>the URL of the product image</em> |[optional]|
**Author** | **string** | <em>product brand name</em> |[optional]|
**DataAsin** | **string** | <em>ASIN of the product received in a POST array</em> |[optional]|
**ParentAsin** | **string** | <em><a href='https://sellercentral.amazon.com/gp/help/external/help.html?itemID=8831&amp;language=en-US&amp;ref=mpbc_200779220_cont_8831&amp;' target='_blank' rel='noopener noreferrer'>parent ASIN</a> of the product</em> |[optional]|
**ProductAsins** | **IEnumerable<string>** | <em>ASINs of all found product modifications</em> |[optional]|
**PriceFrom** | **double?** | <em>the lower limit of the product price range</em><br>example:<br><code>49.98</code> |[optional]|
**PriceTo** | **double?** | <em>the upper limit of the product price range</em><br>example:<br><code>384.99</code> |[optional]|
**PercentageDiscount** | **string** | <em>value of the percentage discount</em> |[optional]|
**Currency** | **string** | <em>currency in the <a href='https://en.wikipedia.org/wiki/ISO_4217'>ISO</a> format</em><br>example:<br><code>USD</code> |[optional]|
**IsAmazonChoice** | **bool?** | <em>'Amazon's choice' label</em><br>if the value is <code>true</code>, the product is marked with the 'Amazon's choice' label |[optional]|
**Rating** | **RatingElement** | <em>product rating info</em> |[optional]|
**IsNewerModelAvailable** | **bool?** | <em>indicates whether the newer model of the product is available</em> |[optional]|
**IsPrimeVideo** | **bool?** | <em>indicates whether a product has an Amazon Prime Video label</em><br>if <code>true</code>, specified product is a part of Amazon Prime Video service |[optional]|
**ApplicableVouchers** | **IEnumerable<AmazonApplicableVouchersItem>** | <em>array of objects containing information about applicable vouchers</em> |[optional]|
**NewerModel** | **NewerModel** | <em>information about the newer model of the product</em> |[optional]|
**Categories** | **IEnumerable<Categories>** | <em>contains related product categories</em> |[optional]|
**ProductInformation** | **IEnumerable<BaseMerchantAmazonProductInformationElementItem>** | <em>contains related product information</em> |[optional]|
**ProductImagesList** | **IEnumerable<string>** | <em>contains URLs for all images of the product displayed on the left side of the main image</em> |[optional]|
**ProductVideosList** | **IEnumerable<string>** | <em>contains URLs for all videos of the product displayed on the right side of the main video</em> |[optional]|
**Description** | **string** | <em>contains description of the product</em> |[optional]|
**IsAvailable** | **bool?** | <em>indicates whether the product is <a href='https://www.amazon.com/gp/help/customer/display.html?nodeId=201910280' rel='noopener noreferrer' target='_blank'>available for ordering</a></em><br>if the value is <code>true</code>, the product can be ordered |[optional]|
**TopLocalReviews** | **IEnumerable<AmazonReviewItem>** | <em>array of objects with top reviews from target location</em> |[optional]|
**TopGlobalReviews** | **IEnumerable<AmazonReviewItem>** | <em>array of objects with top reviews from around the world</em> |[optional]|