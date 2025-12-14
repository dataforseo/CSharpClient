# AiOptimizationGeminiLlmResponsesLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**ModelName** | **string** | name of the AI model used |[optional]|
**InputTokens** | **int?** | number of tokens in the input<br>total count of tokens processed |[optional]|
**OutputTokens** | **int?** | number of tokens in the output<br>total count of tokens generated in the AI response |[optional]|
**WebSearch** | **bool?** | indicates if web search was used |[optional]|
**MoneySpent** | **double?** | cost of AI tokens, USD<br>the price charged by the third-party AI model provider for according to its Pricing |[optional]|
**Datetime** | **string** | date and time when the result was received<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2019-11-15 12:57:46 +00:00 |[optional]|
**Items** | **IEnumerable<AiOptimizationItem>** | array of response items<br>contains structured AI response data |[optional]|
**FanOutQueries** | **IEnumerable<string>** | array of fan-out queries<br>contains related search queries derived from the main query to provide a more comprehensive response |[optional]|