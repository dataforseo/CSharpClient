# AiOptimizationLLmMentionsMultiTargetRequestInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Target** | **IEnumerable<BaseAiOptimizationLLmMentionsTargetElement>** | array of objects containing target entities<br>required field<br>you can specify up to 10 entities (objects) in the target field<br>one target entity can contain either one domain or one keyword and related parameters<br>examples:<br><br>target array with a domain entity |[optional]|
**Key** | **string** | key for grouping the results<br>required field<br>groups results for comparison and serves as a label for the group;<br>you can specify up to 250 characters in the key field |[optional]|