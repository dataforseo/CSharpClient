# BacklinksReferringDomainsLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Target** | **string** | <em><code>target</code> in a POST array</em> |[optional]|
**TotalCount** | **long?** | <em>total number of relevant items in the database</em><br>total number of main domains referring to your target;<br>example.com and blog.example.com are counted as one referring domain |[optional]|
**ItemsCount** | **long?** | <em>number of items in the <code>items</code> array</em> |[optional]|
**Items** | **IEnumerable<BacklinksReferringDomainsLiveItem>** | <em>items array</em> |[optional]|