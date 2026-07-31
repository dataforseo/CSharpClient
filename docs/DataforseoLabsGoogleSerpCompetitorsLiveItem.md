# DataforseoLabsGoogleSerpCompetitorsLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**SeType** | **string** | <em>search engine type</em> |[optional]|
**Domain** | **string** | <em>domain name of the detected SERP competitor</em> |[optional]|
**AvgPosition** | **float?** | <em>the average position of the domain for the specified keywords</em><br>the arithmetic mean of values in the <code>keywords_positions</code> array |[optional]|
**MedianPosition** | **double?** | <em>the median position of the domain for the specified keywords</em><br>the median of the values in the <code>keywords_positions</code> array |[optional]|
**Rating** | **double?** | <em>the margin between the greatest possible and actual keyword positions</em><br>represents the relative visibility rate of the domain in SERP for the specified keywords<br>calculated as <em>sum(100-<code>keywords_positions</code>)</em> |[optional]|
**Etv** | **double?** | <em>estimated traffic volume</em><br>represents the estimated monthly traffic that specified keywords are driving to the website<br>calculated as the sum of the products of the specified keywords' search volume values and CTR (click-through-rate) rates at certain positions in SERP<br>learn more about how the metric is calculated in <a href='https://dataforseo.com/help-center/how-is-etv-calculated' rel='noopener noreferrer' target='_blank'>this help center article</a> |[optional]|
**KeywordsCount** | **long?** | <em>the number of specified keywords the domain has positions for in SERPs</em> |[optional]|
**Visibility** | **double?** | <em>SERP visibility rate</em><br>represents the website visibility rate based on the SERP positions of the specified keywords<br>Keywords with positions in the range from <strong>1 to 10</strong> are assigned the visibility index from 1 to 0.1, respectively<br>Keywords with positions in the range from <strong>11 to 20</strong> have the fixed visibility index of 0.05<br>keywords with positions from <strong>20 to 100</strong> have the visibility index equal to 0 |[optional]|
**RelevantSerpItems** | **int?** | <em>the number of SERP elements relevant to the domain</em><br>represents the number of search results in SERP relevant to the domain for the specified keywords |[optional]|
**KeywordsPositions** | **IDictionary<string, IEnumerable<int?>>** | <em>keyword positions</em><br>SERP positions the related domain holds in SERP for the specified keywords |[optional]|