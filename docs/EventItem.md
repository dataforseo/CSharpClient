# EventItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP |[optional]|
**Position** | **string** | <em>the alignment of the element in SERP</em><br>can take the following values:<br><code>left</code>, <code>right</code> |[optional]|
**Xpath** | **string** | <em>the <a href='https://en.wikipedia.org/wiki/XPath' rel='noopener noreferrer' target='_blank'>XPath</a> of the element</em> |[optional]|
**Title** | **string** | <em>title of the element</em> |[optional]|
**Description** | **string** | <em>description of the results element in SERP</em> |[optional]|
**Url** | **string** | <em>search URL with refinement parameters</em> |[optional]|
**ImageUrl** | **string** | <em>URL of the image featured in the element</em> |[optional]|
**EventDates** | **EventDates** | <em>dates when the event takes place</em><br>if there are none, equals <code>null</code> |[optional]|
**LocationInfo** | **LocationInfo** | <em>information about the event's venue</em> |[optional]|
**InformationAndTickets** | **IEnumerable<AiModeLinkElementInfo>** | <em>additional information and ticket purchase options</em> |[optional]|