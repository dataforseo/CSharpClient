# AppDataGooglePlayInfoOrganicSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**AppId** | **string** | ID of the app |[optional]|
**Url** | **string** | URL to the app page on Google Play |[optional]|
**Icon** | **string** | URL to the app icon |[optional]|
**Description** | **string** | description of the app |[optional]|
**ReviewsCount** | **long?** | the total number of reviews the app has |[optional]|
**Price** | **PriceInfo** | price of the app |[optional]|
**IsFree** | **bool?** | indicates whether the app is free |[optional]|
**MainCategory** | **string** | main category of the app |[optional]|
**Installs** | **string** | number of installs of the app<br>approximate number of installs as displayed on the app page |[optional]|
**InstallsCount** | **long?** | number of installs of the app<br>the exact number of installs of the app |[optional]|
**Developer** | **string** | name of the app developer |[optional]|
**DeveloperId** | **string** | ID of the app developer |[optional]|
**DeveloperUrl** | **string** | URL to the developer page on Google Play |[optional]|
**DeveloperEmail** | **string** | email address of the developer |[optional]|
**DeveloperAddress** | **string** | physical address of the developer |[optional]|
**DeveloperWebsite** | **string** | official website of the developer |[optional]|
**Version** | **string** | current version of the app |[optional]|
**MinimumOsVersion** | **string** | minimum OS version required to install the app |[optional]|
**Size** | **string** | size of the app |[optional]|
**ReleasedDate** | **string** | date and time when the app was released<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**LastUpdateDate** | **string** | date and time when the app was last updated<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**UpdateNotes** | **string** | update notes<br>contains the latest update notes from the developer |[optional]|
**Images** | **IEnumerable<string>** | app images<br>contains URLs to the images published on the app page on Google Play |[optional]|
**Videos** | **IEnumerable<string>** | app videos<br>contains URLs to the video published on the app page on Google Play |[optional]|
**SimilarApps** | **IEnumerable<AppsInfo>** | similar apps<br>displays apps similar to the app in a POST request |[optional]|
**MoreAppsByDeveloper** | **IEnumerable<AppsInfo>** | similar apps<br>information about apps built by the same developer |[optional]|
**Genres** | **IEnumerable<string>** | app genres<br>contains relevant app categories |[optional]|
**Tags** | **IEnumerable<string>** | app tags<br>contains relevant app tags |[optional]|