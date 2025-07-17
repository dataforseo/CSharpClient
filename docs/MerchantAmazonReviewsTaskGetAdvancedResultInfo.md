# MerchantAmazonReviewsTaskGetAdvancedResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Asin** | **string** | asin received in a POST array |[optional]|
**Type** | **string** | type of element |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine results<br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Spell** | **SpellInfo** | autocorrection of the search engine<br>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection |[optional]|
**Title** | **string** | title of the product on Amazon<br>the title of the product for which the reviews are collected |[optional]|
**Image** | **AiModeImagesElement** | product image data |[optional]|
**Rating** | **RatingElement** | rating of the product on Amazon<br>popularity rate based on reviews and displayed in SERP |[optional]|
**ReviewsCount** | **long?** | the total number of reviews |[optional]|
**ItemTypes** | **IEnumerable<string>** | type of search results in Amazon SERP<br>contains types of search results (items) found in Amazon SERP;<br>possible item types:<br>amazon_review_item |[optional]|
**ItemsCount** | **long?** | the number of reviews items in the results array<br>you can get more results by using the depth parameter when setting a task |[optional]|
**Items** | **IEnumerable<AmazonReviewItem>** | found reviews<br>you can get more results by using the depth parameter when setting a task |[optional]|