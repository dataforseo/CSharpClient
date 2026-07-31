# DataforseoLabsGoogleHistoricalKeywordDataLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**Keyword** | **string** | <em>keyword</em><br><strong>keyword is returned with decoded %## (plus character '+' will be decoded to a space character)</strong> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**History** | **IEnumerable<History>** | <em>array of objects with historical data for the keyword</em> |[optional]|