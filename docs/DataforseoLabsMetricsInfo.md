# DataforseoLabsMetricsInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Pos1** | **int?** | <em>number of organic SERPs where the domain or subdomain ranks #1</em> |[optional]|
**Pos23** | **int?** | <em>number of organic SERPs where the domain or subdomain ranks #2-3</em> |[optional]|
**Pos410** | **int?** | <em>number of organic SERPs where the domain or subdomain ranks #4-10</em> |[optional]|
**Pos1120** | **int?** | <em>number of organic SERPs where the domain or subdomain ranks #11-20</em> |[optional]|
**Pos2130** | **int?** | <em>number of organic SERPs where the domain or subdomain ranks #21-30</em> |[optional]|
**Pos3140** | **int?** | <em>number of organic SERPs where the domain or subdomain ranks #31-40</em> |[optional]|
**Pos4150** | **int?** | <em>number of organic SERPs where the domain or subdomain ranks #41-50</em> |[optional]|
**Pos5160** | **int?** | <em>number of organic SERPs where the domain or subdomain ranks #51-60</em> |[optional]|
**Pos6170** | **int?** | <em>number of organic SERPs where the domain or subdomain ranks #61-70</em> |[optional]|
**Pos7180** | **int?** | <em>number of organic SERPs where the domain or subdomain ranks #71-80</em> |[optional]|
**Pos8190** | **int?** | <em>number of organic SERPs where the domain or subdomain ranks #81-90</em> |[optional]|
**Pos91100** | **int?** | <em>number of organic SERPs where the domain or subdomain ranks #91-100</em> |[optional]|
**Etv** | **double?** | <em>estimated traffic volume</em><br>estimated organic monthly traffic to the domain or subdomain<br>calculated as the product of CTR (click-through-rate) and search volume values of all keywords in the category that the domain or subdomain ranks for<br>learn more about how the metric is calculated in <a href='https://dataforseo.com/help-center/how-is-etv-calculated' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**Count** | **long?** | <em>total count of organic SERPs that contain the domain or subdomain</em> |[optional]|
**EstimatedPaidTrafficCost** | **double?** | <em>estimated cost of converting organic search traffic into paid</em><br>represents the estimated monthly cost (USD) of running ads for all keywords in the category that the domain or subdomain ranks for<br>the metric is calculated as the product of organic <code>etv</code> and paid <code>cpc</code> values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search<br>learn more about how the metric is calculated in <a href='https://dataforseo.com/help-center/how-is-traffic-cost-calculated' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**IsNew** | **int?** | <em>number of new ranked elements</em><br>indicates how many new ranked elements were found for the indicated target |[optional]|
**IsUp** | **int?** | <em>rank went up</em><br>indicates how many ranked elements of the indicated target went up |[optional]|
**IsDown** | **int?** | <em>rank went down</em><br>indicates how many ranked elements of the indicated target went down |[optional]|
**IsLost** | **int?** | <em>lost ranked elements</em><br>indicates how many ranked elements of the indicated target were previously presented in SERPs, but weren't found during the last check |[optional]|
**ClickstreamEtv** | **double?** | <em>estimated traffic volume based on clickstream data</em><br>calculated as the product of click-through-rate and clickstream search volume values of all keywords the domain ranks for<br>to retrieve results for this field, the parameter <code>include_clickstream_data</code> must be set to <code>true</code><br>learn more about how the metric is calculated in this <a href='https://dataforseo.com/help-center/whats-clickstream-estimated-traffic-volume-and-how-is-it-calculated' rel='noopener noreferrer' target='_blank'>help center article</a> |[optional]|
**ClickstreamGenderDistribution** | **IDictionary<string, long?>** | <em>distribution of estimated clickstream-based metrics by gender</em><br>to retrieve results for this field, the parameter <code>include_clickstream_data</code> must be set to <code>true</code><br>learn more about how the metric is calculated in this <a href='https://dataforseo.com/help-center/what-are-clickstream-based-metrics-and-how-do-we-calculate-them' rel='noopener noreferrer' target='_blank'>help center article</a> |[optional]|
**ClickstreamAgeDistribution** | **IDictionary<string, long?>** | <em>distribution of clickstream-based metrics by age</em><br>to retrieve results for this field, the parameter <code>include_clickstream_data</code> must be set to <code>true</code><br>learn more about how the metric is calculated in this <a href='https://dataforseo.com/help-center/what-are-clickstream-based-metrics-and-how-do-we-calculate-them' rel='noopener noreferrer' target='_blank'>help center article</a> |[optional]|