# KeywordDataInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**Keyword** | **string** | returned keyword idea |[optional]|
**LocationCode** | **int?** | location code in a POST array |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**KeywordInfo** | **KeywordInfo** | keyword data for the returned keyword idea |[optional]|
**KeywordInfoNormalizedWithBing** | **KeywordInfoNormalizedWithInfo** | contains keyword search volume normalized with Bing search volume |[optional]|
**KeywordInfoNormalizedWithClickstream** | **KeywordInfoNormalizedWithInfo** | contains keyword search volume normalized with clickstream data |[optional]|
**ClickstreamKeywordInfo** | **ClickstreamKeywordInfo** | clickstream data for the returned keyword<br>to retrieve results for this field, the parameter include_clickstream_data must be set to true |[optional]|
**KeywordProperties** | **KeywordProperties** | additional information about the keyword |[optional]|
**ImpressionsInfo** | **ImpressionsInfo** | impressions data for the returned keyword idea<br>Note that all data in the impressions_info object is deprecated and provided only as legacy to avoid maintenance issues<br>daily_impressions values provide a more accurate alternative to Google search volume data;<br>the 999 bid is used to mitigate account-specific factors Google considers when calculating impressions<br>learn more about impressions in this help center article |[optional]|
**SerpInfo** | **SerpInfo** | SERP data<br>the value will be null if you didn’t set the field include_serp_info to true in the POST array or if there is no SERP data for this keyword in our database |[optional]|
**AvgBacklinksInfo** | **AvgBacklinksInfo** | backlink data for the returned keyword<br>this object provides the average number of backlinks, referring pages and domains, as well as the average rank values among the top-10 webpages ranking organically for the keyword |[optional]|
**SearchIntentInfo** | **SearchIntentInfo** | search intent info for the returned keyword<br>learn about search intent in this help center article |[optional]|