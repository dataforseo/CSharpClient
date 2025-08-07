# EventItem


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
**Url** | **string** | search URL with refinement parameters |[optional]|
**ImageUrl** | **string** | URL of the image featured in the element |[optional]|
**EventDates** | **EventDates** | dates when the event takes place<br>if there are none, equals null |[optional]|
**LocationInfo** | **LocationInfo** | information about the event’s venue |[optional]|
**InformationAndTickets** | **IEnumerable<AiModeLinkElementInfo>** | additional information and ticket purchase options |[optional]|