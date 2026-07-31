# GooglePlaySearchOrganic


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP |[optional]|
**Position** | **string** | <em>the alignment of the element in SERP</em><br>can take the following values:<br><code>left</code>, <code>right</code> |[optional]|
**AppId** | **string** | <em>id of the app in a POST array</em> |[optional]|
**Title** | **string** | <em>title of the app</em> |[optional]|
**Url** | **string** | <em>URL to the app page on Google Play</em> |[optional]|
**Icon** | **string** | <em>URL to the app icon</em> |[optional]|
**ReviewsCount** | **long?** | <em>the total number of reviews of the app</em> |[optional]|
**Rating** | **RatingInfo** | <em>average rating of the app</em> |[optional]|
**IsFree** | **bool?** |  |[optional]|
**Price** | **PriceInfo** |  |[optional]|
**Developer** | **string** | <em>name of the app developer</em> |[optional]|
**DeveloperUrl** | **string** | <em>URL to the developer page on Google Play</em> |[optional]|