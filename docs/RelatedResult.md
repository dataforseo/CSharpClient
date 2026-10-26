# RelatedResult


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Page** | **int?** | <em>search results page number</em><br>indicates the number of the SERP page on which the element is located |[optional]|
**Xpath** | **string** | <em>the <a href='https://en.wikipedia.org/wiki/XPath'>XPath</a> of the element</em> |[optional]|
**Domain** | **string** | <em>website domain</em> |[optional]|
**Title** | **string** | <em>title of a given link element</em> |[optional]|
**Url** | **string** | <em>URL</em> |[optional]|
**CacheUrl** | **string** | <em>cached version of the page</em> |[optional]|
**RelatedSearchUrl** | **string** | <em>URL to a similar search</em><br>URL to a new search for the same keyword(s) <a href='https://support.google.com/websearch/answer/2466433?hl=en#:~:text=Search%20for%20related%20sites'>on related sites</a> |[optional]|
**Breadcrumb** | **string** | <em>breadcrumb in SERP</em> |[optional]|
**WebsiteName** | **string** | <em>name of the website in the ad element</em> |[optional]|
**IsImage** | **bool?** | <em>indicates whether the element contains an <code class='prettyprint'>image</code></em><br><strong>Note:</strong> this check no longer appears in SERP |[optional]|
**IsVideo** | **bool?** | <em>indicates whether the element contains a <code class='prettyprint'>video</code></em><br><strong>Note:</strong> this check no longer appears in SERP |[optional]|
**Checks** | **IEnumerable<string>** | <em>array of properties detected for the SERP element</em><br>lists the properties that are true for this element<br>each value in the array represents a detected property <br>example:<br>if <code>is_image</code> is present in the array, the element contains an image<br>possible values in the array:<br><code>is_image</code>, <code>is_video</code>, <code>is_featured_snippet</code>, <code>amp_version</code>, <code>is_malicious</code>, <code>is_web_story</code>, <code>is_highly_cited</code><br>equals <code>null</code> if none of the properties are detected for the element<br>learn more about the <code>checks</code> array in <a href='https://dataforseo.com/help-center/whats-a-checks-array-in-the-google-organic-serp-api' target='_blank'>this Help Center article</a> |[optional]|
**Description** | **string** | <em>description of the results element in SERP</em> |[optional]|
**PreSnippet** | **string** | <em>includes additional information appended before the result description in SERP</em> |[optional]|
**ExtendedSnippet** | **string** | <em>includes additional information appended after the result description in SERP</em> |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | <em>images of the component</em><br>if there are none, equals <code>null</code> |[optional]|
**AmpVersion** | **bool?** | <em>Accelerated Mobile Pages</em><br>indicates whether an item has the Accelerated Mobile Page (AMP) version<br><strong>Note:</strong> this check no longer appears in SERP |[optional]|
**Rating** | **RatingInfo** | <em>the item's rating </em><br>the popularity rate based on reviews and displayed in SERP;<br>if there is none, equals <code>null</code> |[optional]|
**Price** | **PriceInfo** | <em>price of booking a place for the specified dates of stay</em> |[optional]|
**Highlighted** | **IEnumerable<string>** | <em>words highlighted in bold within the results <code>description</code></em> |[optional]|
**AboutThisResult** | **AboutThisResultElement** | <em>contains information from the 'About this result' panel</em><br><strong>Note:</strong> this object is deprecated and always returns <code>null</code> |[optional]|
**Timestamp** | **string** | <em>date and time when the result was published</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br><code class='long-string'>2019-11-15 12:57:46 +00:00</code> |[optional]|