# EventItemSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of the element |[optional]|
**Description** | **string** | description of the results element in SERP |[optional]|
**Url** | **string** | search URL with refinement parameters |[optional]|
**ImageUrl** | **string** | URL of the image featured in the element |[optional]|
**EventDates** | **EventDates** | dates when the event takes place<br>if there are none, equals null |[optional]|
**LocationInfo** | **LocationInfo** | information about the event’s venue |[optional]|
**InformationAndTickets** | **IEnumerable<InformationAndTicketsElement>** | additional information and ticket purchase options |[optional]|