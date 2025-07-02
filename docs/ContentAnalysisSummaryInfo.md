# ContentAnalysisSummaryInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**TotalCount** | **long?** | total amount of results in our database relevant to your request |[optional]|
**Rank** | **int?** | rank of all URLs citing the keyword<br>normalized sum of ranks of all URLs citing the target keyword |[optional]|
**TopDomains** | **IEnumerable<TopDomainInfo>** | top domains citing the target keyword<br>contains objects with top domains citing the target keword and citation count per each domain |[optional]|
**SentimentConnotations** | **IDictionary<string, long?>** | sentiment connotations<br>contains sentiments (emotional reactions) related to the target keyword citation and the number of citations per each sentiment<br>possible sentiment connotations: anger, happiness, love, sadness, share, fun |[optional]|
**ConnotationTypes** | **IDictionary<string, long?>** | connotation types<br>contains types of sentiments (sentiment polarity) related to the keyword citation and citation count per each sentiment type<br>possible sentiment connotation types: positive, negative, neutral |[optional]|
**TextCategories** | **IEnumerable<ContentAnalysisCategoriesInfo>** | text categories<br>contains objects with text categories and citation count in each text category<br>to obtain a full list of available categories, refer to the Categories endpoint |[optional]|
**PageCategories** | **IEnumerable<ContentAnalysisCategoriesInfo>** | page categories<br>contains objects with page categories and citation count in each page category<br>to obtain a full list of available categories, refer to the Categories endpoint |[optional]|
**PageTypes** | **IDictionary<string, long?>** | page types<br>contains page types and citation count per each page type |[optional]|
**Countries** | **IDictionary<string, long?>** | countries<br>contains countries and citation count in each country<br>to obtain a full list of available countries, refer to the Locations endpoint |[optional]|
**Languages** | **IDictionary<string, long?>** | languages<br>contains languages and citation count in each language<br>to obtain a full list of available languages, refer to the Languages endpoint |[optional]|