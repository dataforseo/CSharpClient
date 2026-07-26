# OnPageUncrawlableResourcesItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Url** | **string** | <em>URL of the uncrawlable resource</em> |[optional]|
**Reason** | **string** | <em>reason the resource is uncrawlable</em><br>can take the following values: <code>content_type_inconsistency</code> |[optional]|
**StatusCode** | **int?** | <i>general status code</i><br>you can find the full list of the response codes <a href='/v3/appendix/errors'>here</a><br><strong>Note:</strong> we strongly recommend designing a necessary system for handling related exceptional or error conditions |[optional]|
**FetchTime** | **string** | <em>date and time when the resource was fetched</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code>2026-03-09 18:20:32 +00:00</code> |[optional]|
**Meta** | **UncrawlableResourcesMeta** | <em>metadata of the uncrawlable resource</em> |[optional]|