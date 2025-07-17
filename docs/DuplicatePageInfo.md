# DuplicatePageInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Similarity** | **int?** | content similarity score<br>by default, the content is considered duplicate if the value is greater than or equals 6<br>can take values from 0 to 10 |[optional]|
**Page** | **IEnumerable<BaseOnPageResourceItem>** | information about the page with duplicate content |[optional]|