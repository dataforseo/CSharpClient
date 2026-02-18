# SerpGoogleLocationsResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**LocationCode** | **int?** | location code |[optional]|
**LocationName** | **string** | full name of the location |[optional]|
**LocationCodeParent** | **int?** | the code of the superordinate location<br>example:<br>'location_code': 9041134,<br>'location_name': 'Vienna International Airport,Lower Austria,Austria',<br>'location_code_parent': 20044<br>where location_code_parent corresponds to:<br>'location_code': 20044,<br>'location_name': 'Lower Austria,Austria' |[optional]|
**CountryIsoCode** | **string** | ISO country code of the location |[optional]|
**LocationType** | **string** | location type<br>indicates the geographic classification of the location<br>example:<br>'location_type': 'Country', or 'location_type': 'State' |[optional]|