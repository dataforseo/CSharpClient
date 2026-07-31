# DataforseoLabsGoogleSerpCompetitorsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**SeedKeywords** | **IEnumerable<string>** | <em>keywords specified in the request</em><br><strong>keyword is returned with decoded %## (plus character '+' will be decoded to a space character)</strong> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em><br>if there is no data, then the value is_<code>null</code>n |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em><br>if there is no data, then the value is_<code>null</code>n |[optional]|
**TotalCount** | **long?** | <em>the total amount of results in our database relevant to your request</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of results returned in the <code>items</code> array</em> |[optional]|
**Items** | **IEnumerable<DataforseoLabsGoogleSerpCompetitorsLiveItem>** | <em>contains detected SERP competitors and related data</em> |[optional]|