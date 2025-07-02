# DataforseoLabsLocationsAndLanguagesResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**LocationCode** | **int?** | location code |[optional]|
**LocationName** | **string** | full name of the location |[optional]|
**LocationCodeParent** | **int?** | the code of the superordinate location<br>the value will be null as Country is the only supported location_type for this API |[optional]|
**CountryIsoCode** | **string** | ISO country code of the location |[optional]|
**LocationType** | **string** | location type<br>possible values:<br>Country |[optional]|
**AvailableLanguages** | **IEnumerable<AvailableLanguages>** | supported languages<br>contains the languages which are supported for a specific location |[optional]|