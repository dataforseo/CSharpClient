# ShoppingSpecification


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank on the product specification page<br>absolute position among all the elements found on the product specification page |[optional]|
**Position** | **string** | alignment of the element on the product specification page<br>can take the following values:<br>right |[optional]|
**Xpath** | **string** | XPath of the element |[optional]|
**BlockName** | **string** | name of the block of product attributes<br>indicates the name of the product specification section in which the related element is listed |[optional]|
**SpecificationName** | **string** | product attribute<br>attribute name of the product data specification |[optional]|
**SpecificationValue** | **string** | content of the specification |[optional]|