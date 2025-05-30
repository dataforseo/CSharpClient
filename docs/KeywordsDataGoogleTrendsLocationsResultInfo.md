# KeywordsDataGoogleTrendsLocationsResultInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**LocationCode** | **double?** | location code |[optional]|
**LocationName** | **string** | full name of the location |[optional]|
**LocationCodeParent** | **double?** | the code of the superordinate location<br>example:<br>'location_code': 9041134,<br>'location_name': 'Vienna International Airport,Lower Austria,Austria',<br>'location_code_parent': 20044<br>where location_code_parent corresponds to:<br>'location_code': 20044,<br>'location_name': 'Lower Austria,Austria' |[optional]|
**CountryIsoCode** | **string** | ISO country code of the location |[optional]|
**LocationType** | **string** | location type<br>possible values according to Google’s target types |[optional]|
**GeoId** | **string** | google trends location identifier<br>you can use this field for matching obtained results with the location_code parameter specified in the request |[optional]|