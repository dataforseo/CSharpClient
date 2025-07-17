# LocalPack


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**Position** | **string** | the alignment of the element in SERP<br>can take the following values:<br>left, right |[optional]|
**Xpath** | **string** | the XPath of the element |[optional]|
**Title** | **string** | title of the element |[optional]|
**Description** | **string** | description of the results element in SERP |[optional]|
**Domain** | **string** | domain in SERP |[optional]|
**Phone** | **string** | phone number |[optional]|
**Url** | **string** | search URL with refinement parameters |[optional]|
**IsPaid** | **bool?** | indicates whether the element is an ad |[optional]|
**Rating** | **RatingElement** | the item’s rating <br>the popularity rate based on reviews and displayed in SERP |[optional]|
**Cid** | **string** | google-defined client id<br>unique id of a local establishment;<br>can be used with Google Reviews API to get a full list of reviews |[optional]|
**Rectangle** | **object** | rectangle parameters<br>contains cartesian coordinates and pixel dimensions of the result’s snippet in SERP<br>in this case, will equal null |[optional]|