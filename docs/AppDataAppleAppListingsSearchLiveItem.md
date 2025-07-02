# AppDataAppleAppListingsSearchLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**AppId** | **string** | ID of the returned app |[optional]|
**SeDomain** | **string** | search engine domain in a POST array |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**CheckUrl** | **string** | direct URL to search engine results<br>you can use it to make sure that we provided accurate results |[optional]|
**TimeUpdate** | **string** | date and time when SERP data was last updated<br>in the ISO 8601 format: “YYYY-MM-DDThh:mm:ss.sssssssZ”<br>example:<br>2023-05-23 10:16:19 +00:00 |[optional]|
**Item** | **AppDataAppStoreInfoOrganicSerpElementItem** | detailed information about the app |[optional]|