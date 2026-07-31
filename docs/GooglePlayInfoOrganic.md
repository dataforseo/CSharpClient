# GooglePlayInfoOrganic


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank among all the listed apps</em><br>absolute position among all apps on the list |[optional]|
**Position** | **string** | <em>the alignment of the element in SERP</em><br>can take the following values: <code>left</code> |[optional]|
**AppId** | **string** | <em>ID of the app</em> |[optional]|
**Title** | **string** | <em>title of the app</em> |[optional]|
**Url** | **string** | <em>URL to the app page on Google Play</em> |[optional]|
**Icon** | **string** | <em>URL to the app icon</em> |[optional]|
**Description** | **string** | <em>description of the app</em> |[optional]|
**ReviewsCount** | **long?** | <em>the total number of reviews the app has</em> |[optional]|
**Rating** | **RatingInfo** | <em>average rating of the app</em> |[optional]|
**Price** | **PriceInfo** | <em>price of the app</em> |[optional]|
**IsFree** | **bool?** | <em>indicates whether the app is free</em> |[optional]|
**MainCategory** | **string** | <em>main category of the app</em> |[optional]|
**Installs** | **string** | <em>number of installs of the app</em><br>approximate number of installs as displayed on the app page |[optional]|
**InstallsCount** | **long?** | <em>number of installs of the app</em><br>the exact number of installs of the app |[optional]|
**Developer** | **string** | <em>name of the app developer</em> |[optional]|
**DeveloperId** | **string** | <em>ID of the app developer</em> |[optional]|
**DeveloperUrl** | **string** | <em>URL to the developer page on Google Play</em> |[optional]|
**DeveloperEmail** | **string** | <em>email address of the developer</em> |[optional]|
**DeveloperAddress** | **string** | <em>physical address of the developer</em> |[optional]|
**DeveloperWebsite** | **string** | <em>official website of the developer</em> |[optional]|
**Version** | **string** | <em>current version of the app</em> |[optional]|
**MinimumOsVersion** | **string** | <em>minimum OS version required to install the app</em> |[optional]|
**Size** | **string** | <em>size of the app</em> |[optional]|
**ReleasedDate** | **string** | <em>date and time when the app was released</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**LastUpdateDate** | **string** | <em>date and time when the app was last updated</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**UpdateNotes** | **string** | <em>update notes</em><br>contains the latest update notes from the developer |[optional]|
**Images** | **IEnumerable<string>** | <em>app images</em><br>contains URLs to the images published on the app page on Google Play |[optional]|
**Videos** | **IEnumerable<string>** | <em>app videos</em><br>contains URLs to the video published on the app page on Google Play |[optional]|
**SimilarApps** | **IEnumerable<AppsInfo>** | <em>similar apps</em><br>displays apps similar to the app in a POST request |[optional]|
**MoreAppsByDeveloper** | **IEnumerable<AppsInfo>** | <em>similar apps</em><br>information about apps built by the same developer |[optional]|
**Genres** | **IEnumerable<string>** | <em>app genres</em><br>contains relevant app categories |[optional]|
**Tags** | **IEnumerable<string>** | <em>app tags</em><br>contains relevant app tags |[optional]|