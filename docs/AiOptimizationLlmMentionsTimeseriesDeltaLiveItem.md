# AiOptimizationLlmMentionsTimeseriesDeltaLiveItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Date** | **string** | <em>date timestamp</em><br> date format: <code>'yyyy-mm-dd'</code> |[optional]|
**DeltaMentions** | **int?** | <em>LLM mentions count delta</em><br>the difference in <code>mentions</code> between the current timestamp and the previous one |[optional]|
**DeltaAiSearchVolume** | **long?** | <em>LLM mentions count delta</em><br>the difference in <code>ai_search_volume</code> values between the current timestamp and the previous one<br>learn more about this metric <a href='https://dataforseo.com/help-center/how-ai-search-volume-metrics-work-in-the-llm-mentions-timeseries-endpoints' rel='noopener noreferrer' target='_blank'>here</a> |[optional]|