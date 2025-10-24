# ItemsGoogleBusinessInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **int?** | absolute rank among all the elements |[optional]|
**Position** | **string** | the alignment in SERP |[optional]|
**Title** | **string** | title of the element in SERP<br>the name of the business entity for which the results are collected |[optional]|
**OriginalTitle** | **string** | original title of the element<br>original title not translated by Google |[optional]|
**Description** | **string** | description of the element in SERP<br>the description of the business entity for which the results are collected |[optional]|
**Category** | **string** | business category<br>Google My Business general category that best describes the services provided by the business entity |[optional]|
**CategoryIds** | **IEnumerable<string>** | global category IDs<br>universal category IDs that do not change based on the selected country |[optional]|
**AdditionalCategories** | **IEnumerable<string>** | additional business categories<br>additional Google My Business categories that describe the services provided by the business entity in more detail |[optional]|
**Cid** | **string** | google-defined client id<br>unique id of a local establishment;<br>can be used with Google Reviews API to get a full list of reviews<br>learn more about the identifier in this help center article |[optional]|
**FeatureId** | **string** | the unique identifier of the element in SERP<br>learn more about the identifier in this help center article |[optional]|
**Address** | **string** | address of the business entity |[optional]|
**AddressInfo** | **AddressInfo** | object containing address components of the business entity |[optional]|
**PlaceId** | **string** | unique place identifier<br>place id of the local establishment featured in the element<br>learn more about the identifier in this help center article |[optional]|
**Phone** | **string** | phone number of the business entity |[optional]|
**Url** | **string** | absolute url of the business entity |[optional]|
**ContactUrl** | **string** | URL of the preferred contact page |[optional]|
**ContributorUrl** | **string** | URL of the user’s or entity’s Local Guides profile, if available |[optional]|
**BookOnlineUrl** | **string** | URL in the ‘book online’ button of the element<br>URL directing users to the online booking or order page of the business entity |[optional]|
**Domain** | **string** | domain of the business entity |[optional]|
**Logo** | **string** | URL of the logo featured in Google My Business profile |[optional]|
**MainImage** | **string** | URL of the main image featured in Google My Business profile |[optional]|
**TotalPhotos** | **long?** | total count of images featured in Google My Business profile |[optional]|
**Snippet** | **string** | additional information on the business entity |[optional]|
**Latitude** | **double?** | latitude coordinate of the local establishments in google maps<br>example:<br>'latitude': 51.584091 |[optional]|
**Longitude** | **double?** | longitude coordinate of the local establishment in google maps<br>example:<br>'longitude': -0.31365919999999997 |[optional]|
**IsClaimed** | **bool?** | shows whether the entity is verified by its owner on Google Maps |[optional]|
**Attributes** | **BusinessDataAttributesInfo** | service details in a form of user-reviewed checks;<br>service details of a business entity displayed in a form of checks and based on user feedback and business category |[optional]|
**PlaceTopics** | **IDictionary<string, long?>** | keywords mentioned in customer reviews<br>contains most popular keywords related to products/services mentioned in customer reviews of a business entity and the number of reviews mentioning each keyword<br>example: <br>'place_topics': {<br>'egg roll': 48,<br>'birthday': 33<br>} |[optional]|
**Rating** | **RatingInfo** | the element’s rating <br>the popularity rate based on reviews and displayed in SERP |[optional]|
**HotelRating** | **string** | hotel class rating<br>class ratings range between 1-5 stars, learn more<br>if there is no hotel class rating information, the value will be null |[optional]|
**PriceLevel** | **string** | property price level<br>can take values: inexpensive, moderate, expensive, very_expensive<br>if there is no price level information, the value will be null |[optional]|
**RatingDistribution** | **IDictionary<string, int?>** | the distribution of ratings of the business entity<br>the object displays the number of 1-star to 5-star ratings, as reviewed by users |[optional]|
**PeopleAlsoSearch** | **IEnumerable<PeopleAlsoSearch>** | related business entities |[optional]|
**WorkTime** | **BusinessWorkHoursInfo** | work time details<br>information related to operational hours of the business entity |[optional]|
**PopularTimes** | **object** | popular times<br>information related to busy hours of the business entity |[optional]|
**LocalBusinessLinks** | **object** | available interactions with the business<br>list of options to interact with the business directly from search results |[optional]|
**IsDirectoryItem** | **bool?** | business establishment is a part of the directory<br>indicates whether the business establishment is a part of the directory;<br>if true, the item is a part of the larger directory of businesses with the same address (e.g., a mall or a business centre);<br>note: if the business establishment is a parent item in the directory, the value will be null |[optional]|
**Directory** | **object** | items of the directory<br>includes information about businesses that are located within the target business establishment and have the same address |[optional]|