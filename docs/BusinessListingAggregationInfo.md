# BusinessListingAggregationInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**TopCategories** | **IDictionary<string, long?>** | <em>the most mentioned related categories</em><br>top categories displayed with the number of businesses in each category |[optional]|
**TopCountries** | **IDictionary<string, long?>** | <em>the most mentioned counties</em><br>country codes with the biggest number of businesses in the category |[optional]|
**WebsitesCount** | **long?** | <em>number of unique websites</em> |[optional]|
**Count** | **long?** | <em>item types</em><br>the number of items in the <code>items</code> array |[optional]|
**TopAttributes** | **IDictionary<string, long?>** | <em>the most mentioned service details</em><br>service details of a business entity displayed in a form of checks and the number of entities mentioning each attribute |[optional]|
**TopPlaceTopics** | **IDictionary<string, long?>** | <em>top keywords mentioned in customer reviews</em><br>contains most popular keywords related to products/services mentioned in customer reviews of a business entity and the number of reviews mentioning each keyword |[optional]|