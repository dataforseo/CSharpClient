# MetricsInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Pos1** | **int?** | <em>number of organic SERPs where the domain ranks #1</em> |[optional]|
**Pos23** | **int?** | <em>number of organic SERPs where the domain ranks #2-3</em> |[optional]|
**Pos410** | **int?** | <em>number of organic SERPs where the domain ranks #4-10</em> |[optional]|
**Pos1120** | **int?** | <em>number of organic SERPs where the domain ranks #11-20</em> |[optional]|
**Pos2130** | **int?** | <em>number of organic SERPs where the domain ranks #21-30</em> |[optional]|
**Pos3140** | **int?** | <em>number of organic SERPs where the domain ranks #31-40</em> |[optional]|
**Pos4150** | **int?** | <em>number of organic SERPs where the domain ranks #41-50</em> |[optional]|
**Pos5160** | **int?** | <em>number of organic SERPs where the domain ranks #51-60</em> |[optional]|
**Pos6170** | **int?** | <em>number of organic SERPs where the domain ranks #61-70</em> |[optional]|
**Pos7180** | **int?** | <em>number of organic SERPs where the domain ranks #71-80</em> |[optional]|
**Pos8190** | **int?** | <em>number of organic SERPs where the domain ranks #81-90</em> |[optional]|
**Pos91100** | **int?** | <em>number of organic SERPs where the domain ranks #91-100</em> |[optional]|
**Etv** | **double?** | <em>estimated traffic volume</em><br>estimated organic monthly traffic to the domain<br>calculated as the product of CTR (click-through-rate) and search volume values of all keywords the domain ranks for<br>learn more about how the metric is calculated in <a href='https://dataforseo.com/help-center/how-is-etv-calculated' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**Count** | **long?** | <em>total count of organic SERPs that contain the domain</em> |[optional]|
**EstimatedPaidTrafficCost** | **double?** | <em>estimated cost of converting organic search traffic into paid</em><br>represents the estimated monthly cost of running ads (USD) for all keywords a domain ranks for<br>the metric is calculated as the product of organic <code>etv</code> and paid <code>cpc</code> values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search<br>learn more about how the metric is calculated in <a href='https://dataforseo.com/help-center/how-is-traffic-cost-calculated' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**IsNew** | **long?** | number of new ranked elements<br>indicates how many new ranked elements were found for this domain |[optional]|
**IsUp** | **long?** | rank went up<br>indicates how many ranked elements of this domain went up in Google Search |[optional]|
**IsDown** | **long?** | rank went down<br>indicates how many ranked elements of this domain went down in Google Search |[optional]|
**IsLost** | **long?** | lost ranked elements<br>indicates how many ranked elements of this domain were previously presented in SERPs, but weren’t found during the last check |[optional]|