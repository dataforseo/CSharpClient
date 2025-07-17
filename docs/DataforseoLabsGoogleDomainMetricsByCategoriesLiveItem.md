# DataforseoLabsGoogleDomainMetricsByCategoriesLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | search engine type |[optional]|
**TopCategories** | **IEnumerable<int?>** | categories for which domains are collected |[optional]|
**OrganicEtv** | **double?** | current organic ETV of the domain |[optional]|
**OrganicCount** | **long?** | current total count of organic SERPs that contain the domain |[optional]|
**OrganicIsLost** | **int?** | current number of lost ranked elements<br>indicates how many ranked elements of the domain were previously presented in SERPs, but weren’t found during the last check |[optional]|
**OrganicIsNew** | **int?** | current number of new ranked elements<br>indicates how many new ranked elements were found for the domain |[optional]|
**Domain** | **string** | domain found for the specified category |[optional]|
**MainDomain** | **string** | primary domain |[optional]|
**MetricsHistory** | **IDictionary<string, IDictionary<string, DataforseoLabsMetricsInfo>>** | historical ranking and traffic data of the domain |[optional]|
**MetricsDifference** | **IDictionary<string, DataforseoLabsMetricsInfo>** | metrics difference between first_date and second_date<br>calculated by subtracting domain metrics as of the greater date from domain metrics as of the smaller date |[optional]|