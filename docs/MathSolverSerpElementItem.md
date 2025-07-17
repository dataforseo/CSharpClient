# MathSolverSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**RankGroup** | **int?** | group rank in SERP<br>position within a group of elements with identical type values;<br>positions of elements with different type values are omitted from rank_group;<br>always equals 0 for desktop |[optional]|
**RankAbsolute** | **int?** | absolute rank in SERP<br>absolute position among all the elements in SERP<br>always equals 0 for desktop |[optional]|
**Title** | **string** | reference page title |[optional]|
**Result** | **string** | solution to the equation<br>solution to the mathematical equation specified in the keyword field when setting a task |[optional]|
**Items** | **IEnumerable<MathSolverElement>** | contains arrays of specific images |[optional]|
**Links** | **IEnumerable<LinkElement>** | link of the element |[optional]|