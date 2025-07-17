# KeywordsDataClickstreamDataDataforseoSearchVolumeLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**LocationCode** | **int?** | location code in a POST array<br>if there is no data, then the value is null |[optional]|
**LanguageCode** | **string** | language code in a POST array<br><br>Note:if the keyword in the POST array appears to be misspelled, data will be returned for the correctly spelled keyword;<br>we use the functionality of Google Ads API to check and validate the spelling of keywords, learn more by this link |[optional]|
**UseClickstream** | **bool?** | indicates if the use_clickstream parameter is active<br>possible values: true, false |[optional]|
**ItemsCount** | **int?** | ithe number of results returned in the items array |[optional]|
**Items** | **IEnumerable<KeywordsDataClickstreamDataSearchVolumeLiveItem>** | array of keywords<br>contains keywords and their search volume rates |[optional]|