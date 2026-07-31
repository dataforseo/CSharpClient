# AppStoreInfoOrganic


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank among all the listed apps</em><br>absolute position among all apps on the list |[optional]|
**Position** | **string** | <em>the alignment of the element in SERP</em><br>can take the following values: <code>left</code> |[optional]|
**AppId** | **string** | <em>ID of the app</em> |[optional]|
**Title** | **string** | <em>title of the app</em> |[optional]|
**Subtitle** | **string** | <em>subtitle of the app</em> |[optional]|
**Url** | **string** | <em>URL to the app page on App Store</em> |[optional]|
**Icon** | **string** | <em>URL to the app icon</em> |[optional]|
**Description** | **string** | <em>description of the app</em> |[optional]|
**ReviewsCount** | **long?** | <em>the total number of reviews of the app</em> |[optional]|
**Rating** | **RatingInfo** | <em>average rating of the app</em> |[optional]|
**Price** | **PriceInfo** | <em>price of the app</em> |[optional]|
**IsFree** | **bool?** | <em>indicates whether the app is free</em> |[optional]|
**MainCategory** | **string** | <em>main category/genre of the app</em> |[optional]|
**Categories** | **IEnumerable<string>** | <em>all relevant categories/genres of the app</em><br><strong>Note:</strong> this field returns only one relevant category in the array |[optional]|
**Languages** | **IEnumerable<string>** | <em>languages supported in the app</em><br><strong>Note:</strong> this field returns only one supported language in the array |[optional]|
**Advisories** | **IEnumerable<string>** | <em>age rating and age-based content advisories</em> |[optional]|
**Developer** | **string** | <em>name of the app developer</em> |[optional]|
**DeveloperId** | **string** | <em>ID of the app developer</em> |[optional]|
**DeveloperUrl** | **string** | <em>URL to the developer page on App Store</em> |[optional]|
**Version** | **string** | <em>current version of the app</em> |[optional]|
**MinimumOsVersion** | **string** | <em>minimum OS version required to install the app</em> |[optional]|
**Size** | **string** | <em>size of the app</em> |[optional]|
**ReleasedDate** | **string** | <em>date and time when the app was released</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;<br>example:<br><code>2019-11-15 12:57:46 +00:00</code><br><strong>Note:</strong> this field is deprecated and always returns <code>null</code> |[optional]|
**LastUpdateDate** | **string** | <em>date and time when the app was last updated</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**UpdateNotes** | **string** | <em>update notes</em><br>contains the latest update notes from the developer |[optional]|
**Images** | **IEnumerable<string>** | <em>app images</em><br>contains URLs to the images used on the app page on App Store |[optional]|
**SimilarApps** | **IEnumerable<AppsInfo>** | <em>similar apps</em><br>displays apps similar to the app in a POST request |[optional]|
**MoreAppsByDeveloper** | **IEnumerable<AppsInfo>** | <em>similar apps</em><br>information about apps built by the same developer |[optional]|