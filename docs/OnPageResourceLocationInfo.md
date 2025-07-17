# OnPageResourceLocationInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Line** | **int?** | line number<br>the number of the line on which the resource is located |[optional]|
**OffsetLeft** | **int?** | position in line<br>the number of line characters before the resource;<br>sometimes referred to as column<br>Note: counts from 1, i.e. if the resource doesn’t have any characters to the left, the value will be 1 |[optional]|
**OffsetTop** | **int?** | position in the document<br>the total number of characters between the resource and the top of HTML |[optional]|