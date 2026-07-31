# BusinessDataGoogleMyBusinessInfoLiveResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Keyword** | **string** | <em>keyword received in a POST array</em><br><strong>keyword is returned with decoded %## (plus character '+' will be decoded to a space character)</strong><br>this field will contain the <code>cid</code> parameter if you specified it in the <code>keyword</code> field when setting a task;<br>example:<br><code>cid:2946633002421908862</code><br>learn more about the parameter in <a href='https://dataforseo.com/help-center/what-is-cid-place-id-feature-id' target='_blank' rel='noopener noreferrer'>this help center article</a> |[optional]|
**SeDomain** | **string** | <em>search engine domain as specified in a POST array</em> |[optional]|
**LocationCode** | **int?** | <em>location code in a POST array</em> |[optional]|
**LanguageCode** | **string** | <em>language code in a POST array</em> |[optional]|
**CheckUrl** | **string** | <em>direct URL to search engine results</em><br>you can use it to make sure that we provided accurate results |[optional]|
**Datetime** | **string** | <em>date and time when the result was received</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|
**ItemTypes** | **IEnumerable<string>** | <em>item types</em><br>types of search engine results encountered in the <code>items</code> array;<br>possible item types: <code>google_business_info</code> |[optional]|
**ItemsCount** | **long?** | <em>item types</em><br>the number of items in the <code>items</code> array |[optional]|
**Items** | **IEnumerable<ItemsGoogleBusinessInfo>** | <em>encountered item types</em><br>types of search engine results encountered in the <code>items</code> array;<br>possible item types: <code>google_business_info</code> |[optional]|