# AiOptimizationPerplexityLlmResponsesLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**ModelName** | **string** | name of the AI model used |[optional]|
**InputTokens** | **int?** | number of tokens in the inputtotal count of tokens processed |[optional]|
**OutputTokens** | **int?** | number of tokens in the outputtotal count of tokens generated in the AI response |[optional]|
**ReasoningTokens** | **int?** |  |[optional]|
**WebSearch** | **bool?** | indicates if web search was usedNote: web search is enabled by default in Perplexity Sonar models |[optional]|
**MoneySpent** | **double?** | cost of AI tokens, USDthe price charged by the third-party AI model provider for according to its Pricing |[optional]|
**Datetime** | **string** | date and time when the result was receivedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2019-11-15 12:57:46 +00:00 |[optional]|
**Items** | **IEnumerable<MessageAiOptimizationLlmResponseElementItem>** | array of response itemscontains structured AI response data |[optional]|
**FanOutQueries** | **object** | array of fan-out queriescontains related search queries derived from the main query to provide a more comprehensive response |[optional]|