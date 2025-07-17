# MetricsInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Pos1** | **int?** | number of organic SERPs where the domain ranks #1 |[optional]|
**Pos23** | **int?** | number of organic SERPs where the domain ranks #2-3 |[optional]|
**Pos410** | **int?** | number of organic SERPs where the domain ranks #4-10 |[optional]|
**Pos1120** | **int?** | number of organic SERPs where the domain ranks #11-20 |[optional]|
**Pos2130** | **int?** | number of organic SERPs where the domain ranks #21-30 |[optional]|
**Pos3140** | **int?** | number of organic SERPs where the domain ranks #31-40 |[optional]|
**Pos4150** | **int?** | number of organic SERPs where the domain ranks #41-50 |[optional]|
**Pos5160** | **int?** | number of organic SERPs where the domain ranks #51-60 |[optional]|
**Pos6170** | **int?** | number of organic SERPs where the domain ranks #61-70 |[optional]|
**Pos7180** | **int?** | number of organic SERPs where the domain ranks #71-80 |[optional]|
**Pos8190** | **int?** | number of organic SERPs where the domain ranks #81-90 |[optional]|
**Pos91100** | **int?** | number of organic SERPs where the domain ranks #91-100 |[optional]|
**Etv** | **double?** | estimated traffic volume<br>estimated organic monthly traffic to the domain<br>calculated as the product of CTR (click-through-rate) and search volume values of all keywords the domain ranks for<br>learn more about how the metric is calculated in this help center article |[optional]|
**Count** | **long?** | total count of organic SERPs that contain the domain |[optional]|
**EstimatedPaidTrafficCost** | **double?** | estimated cost of converting organic search traffic into paid<br>represents the estimated monthly cost of running ads (USD) for all keywords a domain ranks for<br>the metric is calculated as the product of organic etv and paid cpc values and indicates the cost of driving the estimated volume of monthly organic traffic through PPC advertising in Google Search<br>learn more about how the metric is calculated in this help center article |[optional]|
**IsNew** | **long?** | number of new ranked elements<br>indicates how many new ranked elements were found for this domain |[optional]|
**IsUp** | **long?** | rank went up<br>indicates how many ranked elements of this domain went up in Google Search |[optional]|
**IsDown** | **long?** | rank went down<br>indicates how many ranked elements of this domain went down in Google Search |[optional]|
**IsLost** | **long?** | lost ranked elements<br>indicates how many ranked elements of this domain were previously presented in SERPs, but weren’t found during the last check |[optional]|