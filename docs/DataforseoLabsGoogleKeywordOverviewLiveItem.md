# DataforseoLabsGoogleKeywordOverviewLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**Keyword** | **string** | <em>keyword</em><br><strong>keyword is returned with decoded %## (plus character '+' will be decoded to a space character)</strong> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**SearchPartners** | **bool?** | <em>indicates data for Google and partner sites</em><br>if <code class='prettyprint'>true</code>, the results are returned for owned, operated, and syndicated networks across Google and partner sites that host Google search;<br>if <code>false</code>, the results are returned for Google search sites only |[optional]|
**KeywordInfo** | **KeywordInfo** | <em>keyword data for the returned keyword</em> |[optional]|
**KeywordInfoNormalizedWithBing** | **KeywordInfoNormalizedWithInfo** | <em>contains keyword search volume normalized with Bing search volume</em> |[optional]|
**KeywordInfoNormalizedWithClickstream** | **KeywordInfoNormalizedWithInfo** | <em>contains keyword search volume normalized with clickstream data<br></em> |[optional]|
**ClickstreamKeywordInfo** | **ClickstreamKeywordInfo** | <em>clickstream data for the returned keyword</em><br>to retrieve results for this field, the parameter <code>include_clickstream_data</code> must be set to <code>true</code> |[optional]|
**KeywordProperties** | **KeywordProperties** | <em>additional information about the keyword</em> |[optional]|
**SerpInfo** | **SerpInfo** | <em>SERP data</em><br>the value will be <code>null</code> if you didn't set the field <code>include_serp_info</code> to <code>true</code> in the POST array or if there is no SERP data for this keyword in our database |[optional]|
**AvgBacklinksInfo** | **AvgBacklinksInfo** | <em>backlink data for the returned keyword</em><br>this object provides the average number of backlinks, referring pages and domains, as well as the average rank values among the top-10 websites ranking organically for the keyword |[optional]|
**SearchIntentInfo** | **SearchIntentInfo** | <em>search intent info for the returned keyword</em><br>learn about search intent in this <a href='https://dataforseo.com/help-center/search-intent-and-its-types' rel='noopener noreferrer' target='_blank'>help center article</a> |[optional]|