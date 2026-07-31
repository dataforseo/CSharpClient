# ContentAnalysisSummaryInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**TotalCount** | **long?** | <em>total amount of results in our database relevant to your request</em> |[optional]|
**Rank** | **int?** | <em>rank of all URLs citing the <code>keyword</code></em><br>normalized sum of ranks of all URLs citing the target <code>keyword</code> |[optional]|
**TopDomains** | **IEnumerable<TopDomainInfo>** | <em>top domains citing the target keyword</em><br>contains objects with top domains citing the target keword and citation count per each domain |[optional]|
**SentimentConnotations** | **IDictionary<string, long?>** | <em>sentiment connotations</em><br>contains sentiments (emotional reactions) related to the target keyword citation and the number of citations per each sentiment<br>possible sentiment connotations: <code>anger</code>, <code>happiness</code>, <code>love</code>, <code>sadness</code>, <code>share</code>, <code>fun</code> |[optional]|
**ConnotationTypes** | **IDictionary<string, long?>** | <em>connotation types</em><br>contains types of sentiments (sentiment polarity) related to the keyword citation and citation count per each sentiment type<br>possible sentiment connotation types: <code>positive</code>, <code>negative</code>, <code>neutral</code> |[optional]|
**TextCategories** | **IEnumerable<ContentAnalysisCategoriesInfo>** | <em>text categories</em><br>contains objects with text categories and citation count in each text category<br>to obtain a full list of available categories, refer to the <a href='/v3/content_analysis/categories/' rel='noopener noreferrer' target='_blank'>Categories</a> endpoint |[optional]|
**PageCategories** | **IEnumerable<ContentAnalysisCategoriesInfo>** | <em>page categories</em><br>contains objects with page categories and citation count in each page category<br>to obtain a full list of available categories, refer to the <a href='/v3/content_analysis/categories/' rel='noopener noreferrer' target='_blank'>Categories</a> endpoint |[optional]|
**PageTypes** | **IDictionary<string, long?>** | <em>page types</em><br>contains page types and citation count per each page type |[optional]|
**Countries** | **IDictionary<string, long?>** | <em>countries</em><br>contains countries and citation count in each country<br>to obtain a full list of available countries, refer to the <a href='/v3/content_analysis/locations/' rel='noopener noreferrer' target='_blank'>Locations</a> endpoint |[optional]|
**Languages** | **IDictionary<string, long?>** | <em>languages</em><br>contains languages and citation count in each language<br>to obtain a full list of available languages, refer to the <a href='/v3/content_analysis/languages/' rel='noopener noreferrer' target='_blank'>Languages</a> endpoint |[optional]|