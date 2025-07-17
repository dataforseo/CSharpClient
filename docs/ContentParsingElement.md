# ContentParsingElement


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**FetchTime** | **string** | date and time when the content was fethced<br>example:<br>'2022-11-01 10:02:52 +00:00' |[optional]|
**StatusCode** | **int?** | status code of the page |[optional]|
**PageContent** | **PageContentInfo** | parsed content of the page |[optional]|
**PageAsMarkdown** | **string** | page content in the markdown format<br>page content in the text-to-HTML markdown format<br>specify markdown_view as true in the request to return the value |[optional]|