# OnPageUncrawlableResourcesItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Url** | **string** | URL of the uncrawlable resource |[optional]|
**Reason** | **string** | reason the resource is uncrawlablecan take the following values: content_type_inconsistency |[optional]|
**StatusCode** | **int?** | HTTP response code returned by the uncrawlable resourcepossible values: 200 |[optional]|
**FetchTime** | **string** | date and time when the resource was fetchedin the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”example:2026-03-09 18:20:32 +00:00 |[optional]|
**Meta** | **UncrawlableResourcesMeta** | metadata of the uncrawlable resource |[optional]|