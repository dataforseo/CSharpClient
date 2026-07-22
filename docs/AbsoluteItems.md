# AbsoluteItems


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**GeoId** | **string** | location identifier<br>you can use this field for matching obtained results with location parameters specified in the request<br>see the full list of available locations with their geo_id here or by making a separate request to https://api.dataforseo.com/v3/keywords_data/dataforseo_trends/locations<br>example:<br>US-NY |[optional]|
**GeoName** | **string** | location name<br>you can use this field for matching obtained results with location parameters specified in the request<br>see the full list of available locations with their geo_name here or by making a separate request to https://api.dataforseo.com/v3/keywords_data/dataforseo_trends/locations<br>example:<br>Andorra |[optional]|
**Values** | **IEnumerable<string>** | contains data on relative keyword popularity by country or region |[optional]|