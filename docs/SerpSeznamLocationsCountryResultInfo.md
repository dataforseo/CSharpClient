# SerpSeznamLocationsCountryResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**LocationCode** | **int?** | location code |[optional]|
**LocationName** | **string** | full name of the location |[optional]|
**LocationCodeParent** | **int?** | the code of the superordinate location<br>only City location_type is supported for all countries except China (where Country is also supported);<br>don’t match locations by location_code_parent because the results for Region and Country-level results for most countries are not supported by Baidu SERP API |[optional]|
**CountryIsoCode** | **string** | ISO country code of the location |[optional]|
**LocationType** | **string** | location type |[optional]|