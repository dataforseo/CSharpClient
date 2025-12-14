# DataLabsMathSolverSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | title of the result in SERP |[optional]|
**Result** | **string** | solution to the equation<br>solution to the mathematical equation specified in the keyword field when setting a task |[optional]|
**Items** | **IEnumerable<MathSolverElement>** | historical SERPs and related data found in the database |[optional]|
**Links** | **IEnumerable<LinkElement>** | sitelinks<br>the links shown below some of Google’s search results<br>if there are none, equals null |[optional]|