# BacklinksHistoryLiveRequestInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Target** | **string** | domain<br>required field<br>a domain should be specified without https:// and www. |[optional]|
**DateFrom** | **string** | starting date of the time range<br>optional field<br>minimum value 2019-01-01<br>if you don’t specify this field, the minimum value will be used by default<br>date format: 'yyyy-mm-dd'<br>example:<br>'2019-01-15' |[optional]|
**DateTo** | **string** | ending date of the time range<br>optional field<br>if you don’t specify this field, the today’s date will be used by default<br>date format: 'yyyy-mm-dd'<br>example:<br>'2019-01-15' |[optional]|
**RankScale** | **string** | defines the scale used for calculating and displaying the rank, domain_from_rank, and page_from_rank values<br>optional field<br>you can use this parameter to choose whether rank values are presented on a 0–100 or 0–1000 scale<br>possible values:<br>one_hundred — rank values are displayed on a 0–100 scale<br>one_thousand — rank values are displayed on a 0–1000 scale<br>default value: one_thousand<br>learn more about how this parameter works and how ranking metrics are calculated in this Help Center article |[optional]|
**Tag** | **string** | user-defined task identifier<br>optional field<br>the character limit is 255<br>you can use this parameter to identify the task and match it with the result<br>you will find the specified tag value in the data object of the response |[optional]|