# LocalPackSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values;<br>positions of elements with different type values are omitted from rank_group;<br>always equals 0 for desktop |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP<br>always equals 0 for desktop |[optional]|
**Title** | **string** | title of the row |[optional]|
**Description** | **string** | description of the link |[optional]|
**Domain** | **string** | domain of the website hosting the video |[optional]|
**Phone** | **string** | phone number |[optional]|
**BookingUrl** | **string** | URL of the booking page |[optional]|
**Url** | **string** | URL of the third-party review source |[optional]|
**IsPaid** | **bool?** | indicates whether the element is an ad |[optional]|
**Rating** | **RatingInfo** | the element’s rating<br>the popularity rate based on reviews and displayed in SERP;<br>if there is none, equals null |[optional]|
**Cid** | **string** | google-defined client id |[optional]|