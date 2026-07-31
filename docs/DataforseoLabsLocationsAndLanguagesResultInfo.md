# DataforseoLabsLocationsAndLanguagesResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**LocationCode** | **int?** | <em>location code</em> |[optional]|
**LocationName** | **string** | <em>full name of the location</em> |[optional]|
**LocationCodeParent** | **int?** | <em>the code of the superordinate location</em><br>the value will be <code>null</code> as <code>Country</code> is the only supported <code>location_type</code> for this API |[optional]|
**CountryIsoCode** | **string** | <em>ISO country code of the location</em> |[optional]|
**LocationType** | **string** | <em>location type</em><br>possible values:<br><code>Country</code> |[optional]|
**AvailableLanguages** | **IEnumerable<AvailableLanguages>** | <em>supported languages</em><br>contains the languages which are supported for a specific location |[optional]|