# LocalPackSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values;<br>positions of elements with different type values are omitted from rank_group;<br>always equals 0 for desktop |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP<br>always equals 0 for desktop |[optional]|
**Title** | **string** | title of a given link element |[optional]|
**Description** | **string** | link description |[optional]|
**Domain** | **string** | domain name of the reference |[optional]|
**Phone** | **string** | phone number |[optional]|
**Url** | **string** | URL |[optional]|
**IsPaid** | **bool?** | indicates whether the element is an ad |[optional]|
**Rating** | **RatingInfo** | the item’s rating <br>the popularity rate based on reviews and displayed in SERP |[optional]|
**Cid** | **string** | google-defined client id |[optional]|