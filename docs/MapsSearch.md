# MapsSearch


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | position within a group of elements with identical type values<br>positions of elements with different type values are omitted from the rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank among all the elements |[optional]|
**Domain** | **string** | domain of the business entity |[optional]|
**Title** | **string** | directory title<br>can take the following values: At this place, Directory |[optional]|
**Url** | **string** | URL to view the menu |[optional]|
**Rating** | **RatingElement** | the element’s rating <br>the popularity rate based on reviews and displayed in SERP |[optional]|
**RatingDistribution** | **IDictionary<string, int?>** | the distribution of ratings of the business entity<br>the object displays the number of 1-star to 5-star ratings, as reviewed by users |[optional]|
**Snippet** | **string** | additional information about the business entity |[optional]|
**Address** | **string** | address of the business entity |[optional]|
**AddressInfo** | **AddressInfo** | object containing address components of the business entity |[optional]|
**PlaceId** | **string** | unique place identifier<br>place id of the local establishment featured in the element<br>learn more about the identifier in this help center article |[optional]|
**Phone** | **string** | phone number of the business entity |[optional]|
**MainImage** | **string** | URL of the main image featured in Google My Business profile |[optional]|
**TotalPhotos** | **string** | total count of images featured in Google My Business profile |[optional]|
**Category** | **string** | business category<br>Google My Business general category that best describes the services provided by the business entity |[optional]|
**AdditionalCategories** | **IEnumerable<string>** | additional business categories<br>additional Google My Business categories that describe the services provided by the business entity in more detail |[optional]|
**PriceLevel** | **string** | property price level<br>can take values: inexpensive, moderate, expensive, very_expensive<br>if there is no price level information, the value will be null |[optional]|
**HotelRating** | **string** | hotel class rating<br>class ratings range between 1-5 stars, learn more<br>if there is no hotel class rating information, the value will be null |[optional]|
**CategoryIds** | **IEnumerable<string>** | global category IDs<br>universal category IDs that do not change based on the selected country |[optional]|
**WorkHours** | **BusinessWorkHoursInfo** | open hours<br>information about work hours of the local establishment |[optional]|
**FeatureId** | **string** | the unique identifier of the element in SERP<br>learn more about the identifier in this help center article |[optional]|
**Cid** | **string** | google-defined client id<br>unique id of a local establishment;<br>can be used with Google Reviews API to get a full list of reviews<br>learn more about the identifier in this help center article |[optional]|
**Latitude** | **double?** | latitude coordinate of the local establishments in google maps<br>example:<br>'latitude': 51.584091 |[optional]|
**Longitude** | **double?** | longitude coordinate of the local establishment in google maps<br>example:<br>'longitude': -0.31365919999999997 |[optional]|
**IsClaimed** | **bool?** | shows whether the entity is verified by its owner on Google Maps |[optional]|
**LocalJustifications** | **IEnumerable<string>** | Google local justifications<br>snippets of text that “justify” why the business is showing up for search query |[optional]|
**IsDirectoryItem** | **bool?** | business establishment is a part of the directory<br>indicates whether the business establishment is a part of the directory;<br>if true, the item is a part of the larger directory of businesses with the same address (e.g., a mall or a business centre);<br>note: if the business establishment is a parent item in the directory, the value will be null |[optional]|