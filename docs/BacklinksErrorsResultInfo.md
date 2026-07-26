# BacklinksErrorsResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Id** | **string** | <em>task identifier</em><br><strong>unique task identifier in our system in the <a href='https://en.wikipedia.org/wiki/Universally_unique_identifier'>UUID</a> format</strong> |[optional]|
**Datetime** | **string** | <em>date and time when an error occurred</em><br>in the UTC format: 'yyyy-mm-dd hh-mm-ss +00:00'<br>example:<br><code>2019-11-15 12:57:46 +00:00</code> |[optional]|
**Function** | **string** | <em>corresponding API function</em> |[optional]|
**ErrorCode** | **int?** | <em>error code</em> |[optional]|
**ErrorMessage** | **string** | <em>error message or error URL</em><br>error message <a href='https://docs.dataforseo.com/v3/appendix/errors/' rel='noopener noreferrer' target='_blank'>(see full list)</a> or URL that caused an error |[optional]|
**HttpUrl** | **string** | <em>URL that caused an error</em><br>URL you used for making an API call |[optional]|
**HttpMethod** | **string** | <em>HTTP method</em> |[optional]|
**HttpCode** | **int?** | <em>HTTP status code</em> |[optional]|
**HttpTime** | **int?** | <em>time taken by HTTP request</em> |[optional]|
**HttpResponse** | **string** | <em>HTTP response</em><br>server response |[optional]|