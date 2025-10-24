# KnowledgeGraphHotelsBookingItemSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values;<br>positions of elements with different type values are omitted from rank_group;<br>always equals 0 for desktop |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP<br>always equals 0 for desktop |[optional]|
**Title** | **string** | title of a given link element |[optional]|
**DateFrom** | **string** | starting date of stay<br>in the format “year-month-date”<br>example:<br>2019-11-15 |[optional]|
**DateTo** | **string** | ending date of stay<br>in the format “year-month-date”<br>example:<br>2019-11-17 |[optional]|
**DataAttrid** | **string** | google defined data attribute ID<br>example:<br>action:listen_artist |[optional]|
**Items** | **IEnumerable<KnowledgeGraphHotelsBookingElement>** | contains arrays of elements available in the list |[optional]|