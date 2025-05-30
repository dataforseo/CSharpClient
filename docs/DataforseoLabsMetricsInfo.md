# DataforseoLabsMetricsInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Pos1** | **double?** | number of organic SERPs where the domain or subdomain ranks #1 |[optional]|
**Pos23** | **double?** | number of organic SERPs where the domain or subdomain ranks #2-3 |[optional]|
**Pos410** | **double?** | number of organic SERPs where the domain or subdomain ranks #4-10 |[optional]|
**Pos1120** | **double?** | number of organic SERPs where the domain or subdomain ranks #11-20 |[optional]|
**Pos2130** | **double?** | number of organic SERPs where the domain or subdomain ranks #21-30 |[optional]|
**Pos3140** | **double?** | number of organic SERPs where the domain or subdomain ranks #31-40 |[optional]|
**Pos4150** | **double?** | number of organic SERPs where the domain or subdomain ranks #41-50 |[optional]|
**Pos5160** | **double?** | number of organic SERPs where the domain or subdomain ranks #51-60 |[optional]|
**Pos6170** | **double?** | number of organic SERPs where the domain or subdomain ranks #61-70 |[optional]|
**Pos7180** | **double?** | number of organic SERPs where the domain or subdomain ranks #71-80 |[optional]|
**Pos8190** | **double?** | number of organic SERPs where the domain or subdomain ranks #81-90 |[optional]|
**Pos91100** | **double?** | number of organic SERPs where the domain or subdomain ranks #91-100 |[optional]|
**Etv** | **float?** | estimated traffic volume<br>estimated organic monthly traffic to the domain or subdomain<br>calculated as the product of CTR (click-through-rate) and search volume values of all keywords in the category that the domain or subdomain ranks for<br>learn more about how the metric is calculated in this help center article |[optional]|
**Count** | **double?** | total count of organic SERPs that contain the domain or subdomain |[optional]|
**EstimatedPaidTrafficCost** | **float?** | estimated cost of converting organic search traffic into paid<br>represents the estimated monthly cost (USD) of running ads for all keywords in the category that the domain or subdomain ranks for<br>the metric is calculated as the product of organic etv and paid cpc values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search<br>learn more about how the metric is calculated in this help center article |[optional]|
**IsNew** | **double?** | number of new ranked elements<br>indicates how many new ranked elements were found for the indicated target |[optional]|
**IsUp** | **double?** | rank went up<br>indicates how many ranked elements of the indicated target went up |[optional]|
**IsDown** | **double?** | rank went down<br>indicates how many ranked elements of the indicated target went down |[optional]|
**IsLost** | **double?** | lost ranked elements<br>indicates how many ranked elements of the indicated target were previously presented in SERPs, but weren’t found during the last check |[optional]|
**ClickstreamEtv** | **double?** | estimated traffic volume based on clickstream data<br>calculated as the product of click-through-rate and clickstream search volume values of all keywords the domain ranks for<br>to retrieve results for this field, the parameter include_clickstream_data must be set to true<br>learn more about how the metric is calculated in this help center article |[optional]|
**ClickstreamGenderDistribution** | **IDictionary<string, long?>** | distribution of estimated clickstream-based metrics by gender<br>to retrieve results for this field, the parameter include_clickstream_data must be set to true<br>learn more about how the metric is calculated in this help center article |[optional]|
**ClickstreamAgeDistribution** | **IDictionary<string, long?>** | distribution of clickstream-based metrics by age<br>to retrieve results for this field, the parameter include_clickstream_data must be set to true<br>learn more about how the metric is calculated in this help center article |[optional]|