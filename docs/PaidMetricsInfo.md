# PaidMetricsInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Timestamp** | **string** | date and time of the value readout<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2025-02-10 09:40:00 +00:00 |[optional]|
**Revenue** | **float?** | revenue value |[optional]|
**RevenueDelta** | **float?** | change in revenue |[optional]|
**OperatingExpense** | **float?** | operating expense value |[optional]|
**OperatingExpenseDelta** | **float?** | change in operating expense |[optional]|
**NetIncome** | **float?** | net income value |[optional]|
**NetIncomeDelta** | **float?** | change in net income |[optional]|
**NetProfitMargin** | **float?** | net profit margin value |[optional]|
**NetProfitMarginDelta** | **float?** | change in net profit margin |[optional]|
**EarningsPerShare** | **float?** | earnings per share value |[optional]|
**EarningsPerShareDelta** | **float?** | change in earnings per share |[optional]|
**Ebitda** | **float?** | earnings before interest, taxes, deprecation, amortisation |[optional]|
**EbitdaDelta** | **float?** | change in ebitda |[optional]|
**EffectiveTaxRate** | **float?** | effective tax rate value |[optional]|
**CashAndShortTermInvestments** | **float?** | cash and short-term investments value |[optional]|
**CashAndShortTermInvestmentsDelta** | **float?** | change in cash and short-term investments |[optional]|
**TotalAssets** | **float?** | total assets value |[optional]|
**TotalAssetsDelta** | **float?** | change in total assets |[optional]|
**TotalLiabilities** | **float?** | total liabilities value |[optional]|
**TotalLiabilitiesDelta** | **float?** | change in total liabilities |[optional]|
**TotalEquity** | **float?** | total equity value |[optional]|
**SharesOutstanding** | **float?** | outstanding shares value |[optional]|
**PriceToBook** | **float?** | price to book |[optional]|
**ReturnOnAssets** | **float?** | return on assets |[optional]|
**ReturnOnCapital** | **float?** | return on capital |[optional]|
**CashFromOperations** | **float?** | cash from operations |[optional]|
**CashFromOperationsDelta** | **float?** | change in cash from operations |[optional]|
**CashFromInvesting** | **float?** | cash from investing |[optional]|
**CashFromInvestingDelta** | **float?** | change in cash from investing |[optional]|
**CashFromFinancing** | **float?** | cash from financing/em> |[optional]|
**CashFromFinancingDelta** | **float?** | change in cash from financing |[optional]|
**NetChangeInCash** | **float?** | net change in cash |[optional]|
**NetChangeInCashDelta** | **float?** | change in net change in cash |[optional]|
**FreeCashFlow** | **float?** | free cash flow value |[optional]|
**FreeCashFlowDelta** | **float?** | change in free cash flow |[optional]|
**Pos1** | **double?** | number of paid SERPs where the domain ranks #1 |[optional]|
**Pos23** | **double?** | number of paid SERPs where the domain ranks #2-3 |[optional]|
**Pos410** | **double?** | number of paid SERPs where the domain ranks #4-10 |[optional]|
**Pos1120** | **double?** | number of paid SERPs where the domain ranks #11-20 |[optional]|
**Pos2130** | **double?** | number of paid SERPs where the domain ranks #21-30 |[optional]|
**Pos3140** | **double?** | number of paid SERPs where the domain ranks #31-40 |[optional]|
**Pos4150** | **double?** | number of paid SERPs where the domain ranks #41-50 |[optional]|
**Pos5160** | **double?** | number of paid SERPs where the domain ranks #51-60 |[optional]|
**Pos6170** | **double?** | number of paid SERPs where the domain ranks #61-70 |[optional]|
**Pos7180** | **double?** | number of paid SERPs where the domain ranks #71-80 |[optional]|
**Pos8190** | **double?** | number of paid SERPs where the domain ranks #81-90 |[optional]|
**Pos91100** | **double?** | number of paid SERPs where the domain ranks #91-100 |[optional]|
**Etv** | **float?** | estimated traffic volume<br>estimated paid monthly traffic to the domain<br>calculated as the product of CTR (click-through-rate) and search volume values of all keywords the domain ranks for<br>learn more about how the metric is calculated in this help center article |[optional]|
**Count** | **double?** | total count of paid SERPs that contain the domain |[optional]|
**EstimatedPaidTrafficCost** | **float?** | estimated cost of monthly search traffic<br>represents the estimated cost of paid monthly traffic (USD) based on etv and cpc values<br>learn more about how the metric is calculated in this help center article |[optional]|