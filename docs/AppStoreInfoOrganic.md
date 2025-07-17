# AppStoreInfoOrganic


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank among all the listed apps<br>absolute position among all apps on the list |[optional]|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values: left |[optional]|
**AppId** | **string** | ID of the app |[optional]|
**Title** | **string** | title of the app |[optional]|
**Url** | **string** | URL to the app page on App Store |[optional]|
**Icon** | **string** | URL to the app icon |[optional]|
**Description** | **string** | description of the app |[optional]|
**ReviewsCount** | **long?** | the total number of reviews of the app |[optional]|
**Rating** | **RatingElement** | average rating of the app |[optional]|
**Price** | **PriceInfo** | price of the app |[optional]|
**IsFree** | **bool?** | indicates whether the app is free |[optional]|
**MainCategory** | **string** | main category/genre of the app |[optional]|
**Categories** | **IEnumerable<string>** | all relevant categories/genres of the app |[optional]|
**Languages** | **IEnumerable<string>** | languages supported in the app |[optional]|
**Advisories** | **IEnumerable<string>** | age rating and age-based content advisories |[optional]|
**Developer** | **string** | name of the app developer |[optional]|
**DeveloperId** | **string** | ID of the app developer |[optional]|
**DeveloperUrl** | **string** | URL to the developer page on App Store |[optional]|
**Version** | **string** | current version of the app |[optional]|
**MinimumOsVersion** | **string** | minimum OS version required to install the app |[optional]|
**Size** | **string** | size of the app |[optional]|
**ReleasedDate** | **string** | date and time when the app was released<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**LastUpdateDate** | **string** | date and time when the app was last updated<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**UpdateNotes** | **string** | update notes<br>contains the latest update notes from the developer |[optional]|
**Images** | **IEnumerable<string>** | app images<br>contains URLs to the images used on the app page on App Store |[optional]|
**SimilarApps** | **IEnumerable<AppsInfo>** | similar apps<br>displays apps similar to the app in a POST request |[optional]|
**MoreAppsByDeveloper** | **IEnumerable<AppsInfo>** | similar apps<br>information about apps built by the same developer |[optional]|