# DataforseoLabsGoogleKeywordOverviewLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**Keyword** | **string** | keyword<br>keyword is returned with decoded %## (plus character ‘+’ will be decoded to a space character) |[optional]|
**LocationCode** | **int?** | location code in a POST array<br>if there is no data, then the value is null |[optional]|
**LanguageCode** | **string** | language code in a POST array |[optional]|
**SearchPartners** | **bool?** | indicates data for Google and partner sites<br>if true, the results are returned for owned, operated, and syndicated networks across Google and partner sites that host Google search;<br>if false, the results are returned for Google search sites only |[optional]|
**KeywordInfo** | **KeywordInfo** | keyword data for the returned keyword |[optional]|
**KeywordInfoNormalizedWithBing** | **KeywordInfoNormalizedWithInfo** | contains keyword search volume normalized with Bing search volume |[optional]|
**KeywordInfoNormalizedWithClickstream** | **KeywordInfoNormalizedWithInfo** | contains keyword search volume normalized with clickstream data |[optional]|
**ClickstreamKeywordInfo** | **ClickstreamKeywordInfo** | clickstream data for the returned keyword<br>to retrieve results for this field, the parameter include_clickstream_data must be set to true |[optional]|
**KeywordProperties** | **KeywordProperties** | additional information about the keyword |[optional]|
**SerpInfo** | **SerpInfo** | SERP data<br>the value will be null if you didn’t set the field include_serp_info to true in the POST array or if there is no SERP data for this keyword in our database |[optional]|
**AvgBacklinksInfo** | **AvgBacklinksInfo** | backlink data for the returned keyword<br>this object provides the average number of backlinks, referring pages and domains, as well as the average rank values among the top-10 websites ranking organically for the keyword |[optional]|
**SearchIntentInfo** | **SearchIntentInfo** | search intent info for the returned keyword<br>learn about search intent in this help center article |[optional]|