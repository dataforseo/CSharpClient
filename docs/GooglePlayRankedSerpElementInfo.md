# GooglePlayRankedSerpElementInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**SerpItem** | **GooglePlaySearchOrganic** | <em>contains data on the SERP element</em><br>the list of supported SERP elements can be found below |[optional]|
**CheckUrl** | **string** | <em>direct URL to search engine results</em><br>you can use it to make sure that we provided accurate results |[optional]|
**SeResultsCount** | **int?** | <em>number of search results for the returned keyword</em> |[optional]|
**LastUpdatedTime** | **string** | <em>date and time when keyword data was updated</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**PreviousUpdatedTime** | **string** | <em>previous to the most recent date and time when SERP data was updated</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-10-15 12:57:46 +00:00</code>;<br>in this case, will equal null |[optional]|