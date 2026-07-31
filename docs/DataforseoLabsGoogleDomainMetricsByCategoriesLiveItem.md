# DataforseoLabsGoogleDomainMetricsByCategoriesLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**TopCategories** | **IEnumerable<int?>** | <em>categories for which domains are collected</em> |[optional]|
**OrganicEtv** | **double?** | <em>current organic ETV of the domain</em> |[optional]|
**OrganicCount** | **long?** | <em>current total count of organic SERPs that contain the domain</em> |[optional]|
**OrganicIsLost** | **int?** | <em>current number of lost ranked elements</em><br>indicates how many ranked elements of the domain were previously presented in SERPs, but weren’t found during the last check |[optional]|
**OrganicIsNew** | **int?** | <em>current number of new ranked elements</em><br>indicates how many new ranked elements were found for the domain |[optional]|
**Domain** | **string** | <em>domain found for the specified category</em> |[optional]|
**MainDomain** | **string** | <em>primary domain</em> |[optional]|
**MetricsHistory** | **IDictionary<string, IDictionary<string, DataforseoLabsMetricsInfo>>** | <em>historical ranking and traffic data of the domain</em> |[optional]|
**MetricsDifference** | **IDictionary<string, DataforseoLabsMetricsInfo>** | <em>metrics difference between <code>first_date</code> and <code>second_date</code></em><br>calculated by subtracting domain metrics as of the greater date from domain metrics as of the smaller date |[optional]|