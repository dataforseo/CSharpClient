# SerpBaiduLocationsResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**LocationCode** | **int?** | <em>location code</em> |[optional]|
**LocationName** | **string** | <em>full name of the location</em> |[optional]|
**LocationCodeParent** | **int?** | <em>the code of the superordinate location</em><br>only <code>City</code> <code>location_type</code> is supported for all countries except China (where <code>Country</code> is also supported);<br>don't match locations by <code>location_code_parent</code> because the results for <code>Region</code> and <code>Country</code>-level results for most countries are not supported by Baidu SERP API |[optional]|
**CountryIsoCode** | **string** | <em>ISO country code of the location</em> |[optional]|
**LocationType** | **string** | <em>location type</em><br>only <code>City</code> is supported for all countries except China (where <code>Country</code> is also supported) |[optional]|