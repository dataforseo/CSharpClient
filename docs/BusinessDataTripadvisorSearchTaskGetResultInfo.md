# BusinessDataTripadvisorSearchTaskGetResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | <em>keyword received in a POST array</em><br>this field will contain the <code>alias</code> parameter if it was specified in a POST array |[optional]|
**SeDomain** | **string** | <em>search engine domain in a POST array</em> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to Tripadvisor results</em><br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**ItemTypes** | **IEnumerable<string>** | <em>item types encountered in the result</em><br>possible item types: <code>tripadvisor_search_organic</code> |[optional]|
**SeResultsCount** | **long?** | <em>the total number of results</em> |[optional]|
**ItemsCount** | **long?** | <em>the number of items in the results array</em><br>you can get more results by using the <code>depth</code> parameter when setting a task |[optional]|
**Items** | **IEnumerable<TripadvisorSearchOrganic>** | <em>Tripadvisor search listing results</em><br>you can get more results by using the <code>depth</code> parameter when setting a task |[optional]|