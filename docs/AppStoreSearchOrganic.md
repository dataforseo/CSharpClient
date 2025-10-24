# AppStoreSearchOrganic


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**AppId** | **string** | id of the app |[optional]|
**Title** | **string** | title of the app |[optional]|
**Url** | **string** | URL to the app page on App Store |[optional]|
**Icon** | **string** | URL to the app icon |[optional]|
**ReviewsCount** | **long?** | the total number of reviews of the app |[optional]|
**Rating** | **RatingInfo** | average rating of the app |[optional]|
**IsFree** | **bool?** | indicates whether the app is free |[optional]|
**Price** | **PriceInfo** | price of the app |[optional]|