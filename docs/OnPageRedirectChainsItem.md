# OnPageRedirectChainsItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**IsRedirectLoop** | **bool?** | indicates if redirects in chain start and end at the same URL<br>if true, the last URL from the chain redirects back to the original URL |[optional]|
**Chain** | **IEnumerable<BaseOnPageLinkItemInfo>** | contains links that form a chain |[optional]|