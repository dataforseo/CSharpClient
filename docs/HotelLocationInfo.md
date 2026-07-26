# HotelLocationInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Neighborhood** | **string** | <em>name of the neighborhood where the hotel is located</em> |[optional]|
**NeighborhoodDescription** | **string** | <em>description of the neighborhood where the hotel is located</em> |[optional]|
**MapsUrl** | **string** | <em>url to the location of the hotel in google maps</em> |[optional]|
**OverallScore** | **double?** | <em>overall score of the hotel location</em><br>indicates the overall score of the hotel's location in the range from 1 to 5;<br>calculated based on data from the hotel's proximity to nearby things to do and restaurants, transportation, and airports;<br>note that the criteria are not weighted equally in the overall score |[optional]|
**ScoreByCategories** | **IDictionary<string, double?>** | <em>category scores of the hotel location</em><br>the scores of the hotel's location tied to the categories that indicate the proximity to nearby things to do, restaurants, transportation, and airports; |[optional]|
**Latitude** | **double?** | <em>hotel latitude</em><br>latitude coordinates of the hotel's location<br>example:<br><code>39.4806397</code> |[optional]|
**Longitude** | **double?** | <em>hotel longitude</em><br>latitude coordinates of the hotel's location<br>example:<br><code>-106.0512973</code> |[optional]|
**LocationChain** | **IEnumerable<LocationChain>** | <em>elements of the location chain</em><br>additional parameters of each element of the location chain |[optional]|