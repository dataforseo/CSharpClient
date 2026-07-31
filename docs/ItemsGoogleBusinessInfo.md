# ItemsGoogleBusinessInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>position within a group of elements with identical <code>type</code> values</em><br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank among all the elements</em> |[optional]|
**Position** | **string** | <em>the alignment in SERP</em> |[optional]|
**Title** | **string** | <em>title of the element in SERP</em><br>the name of the business entity for which the results are collected |[optional]|
**OriginalTitle** | **string** | <em>original title of the element</em><br>original title not translated by Google |[optional]|
**Description** | **string** | <em>description of the element in SERP</em><br>the description of the business entity for which the results are collected |[optional]|
**Category** | **string** | <em>business category</em><br>Google My Business general category that best describes the services provided by the business entity |[optional]|
**CategoryIds** | **IEnumerable<string>** | <em>global category IDs</em><br>universal category IDs that do not change based on the selected country |[optional]|
**AdditionalCategories** | **IEnumerable<string>** | <em>additional business categories</em><br>additional Google My Business categories that describe the services provided by the business entity in more detail |[optional]|
**Cid** | **string** | <em>google-defined client id</em><br>unique id of a local establishment;<br>can be used with <a href='/v3/reviews/google/overview/?php' target='_blank' rel='noopener noreferrer'>Google Reviews API</a> to get a full list of reviews<br>learn more about the identifier in <a href='https://dataforseo.com/help-center/what-is-cid-place-id-feature-id' target='_blank' rel='noopener noreferrer'>this help center article</a> |[optional]|
**FeatureId** | **string** | <em>the unique identifier of the element in SERP</em><br>learn more about the identifier in <a href='https://dataforseo.com/help-center/what-is-cid-place-id-feature-id' target='_blank' rel='noopener noreferrer'>this help center article</a> |[optional]|
**Address** | **string** | <em>address of the business entity</em> |[optional]|
**AddressInfo** | **AddressInfo** | <em>object containing address components of the business entity</em> |[optional]|
**PlaceId** | **string** | <em>unique place identifier</em><br><a href='https://developers.google.com/places/place-id'>place id</a> of the local establishment featured in the element<br>learn more about the identifier in <a href='https://dataforseo.com/help-center/what-is-cid-place-id-feature-id' target='_blank' rel='noopener noreferrer'>this help center article</a> |[optional]|
**Phone** | **string** | <em>phone number of the business entity</em> |[optional]|
**Url** | **string** | <em>absolute url of the business entity</em> |[optional]|
**ContactUrl** | **string** | <em>URL of the preferred contact page</em> |[optional]|
**ContributorUrl** | **string** | <em>URL of the user's or entity's Local Guides profile, if available</em> |[optional]|
**BookOnlineUrl** | **string** | <em>URL in the 'book online' button of the element</em><br>URL directing users to the online booking or order page of the business entity |[optional]|
**Domain** | **string** | <em>domain of the business entity</em> |[optional]|
**Logo** | **string** | <em>URL of the logo featured in Google My Business profile</em> |[optional]|
**MainImage** | **string** | <em>URL of the main image featured in Google My Business profile</em> |[optional]|
**TotalPhotos** | **long?** | <em>total count of images featured in Google My Business profile</em> |[optional]|
**Snippet** | **string** | <em>additional information on the business entity</em> |[optional]|
**Latitude** | **double?** | <i>latitude coordinate of the local establishments in google maps</i><br>example:<br><code>'latitude': 51.584091</code> |[optional]|
**Longitude** | **double?** | <i>longitude coordinate of the local establishment in google maps</i><br>example:<br><code>'longitude': -0.31365919999999997</code> |[optional]|
**IsClaimed** | **bool?** | <i>shows whether the entity is verified by its owner on Google Maps</i> |[optional]|
**Attributes** | **BusinessDataAttributesInfo** | <em>service details in a form of user-reviewed checks;</em><br>service details of a business entity displayed in a form of checks and based on user feedback and business <code>category</code> |[optional]|
**PlaceTopics** | **IDictionary<string, long?>** | <em>keywords mentioned in customer reviews</em><br>contains most popular keywords related to products/services mentioned in customer reviews of a business entity and the number of reviews mentioning each keyword<br>example:<br> <code><br>'place_topics': {<br>'egg roll': 48,<br>'birthday': 33<br>}</code> |[optional]|
**Rating** | **RatingInfo** | <em>the element's rating </em><br>the popularity rate based on reviews and displayed in SERP |[optional]|
**HotelRating** | **string** | <em>hotel class rating</em><br>class ratings range between 1-5 stars, <a href='https://support.google.com/business/answer/7660515?hl=en' rel='noopener noreferrer' target='_blank'>learn more</a><br>if there is no hotel class rating information, the value will be <code>null</code> |[optional]|
**PriceLevel** | **string** | <em>property price level</em><br>can take values: <code>inexpensive</code>, <code>moderate</code>, <code>expensive</code>, <code>very_expensive</code><br>if there is no price level information, the value will be <code>null</code> |[optional]|
**RatingDistribution** | **IDictionary<string, int?>** | <em>the distribution of ratings of the business entity</em><br>the object displays the number of 1-star to 5-star ratings, as reviewed by users |[optional]|
**PeopleAlsoSearch** | **IEnumerable<PeopleAlsoSearch>** | <em>related business entities</em> |[optional]|
**WorkTime** | **BusinessWorkHoursInfo** | <em>work time details</em><br>information related to operational hours of the business entity |[optional]|
**PopularTimes** | **object** | <em>popular times</em><br>information related to busy hours of the business entity |[optional]|
**LocalBusinessLinks** | **object** | <em>available interactions with the business</em><br>list of options to interact with the business directly from search results |[optional]|
**IsDirectoryItem** | **bool?** | <em>business establishment is a part of the directory</em><br>indicates whether the business establishment is a part of the directory;<br>if <code>true</code>, the item is a part of the larger directory of businesses with the same address (e.g., a mall or a business centre);<br><strong>note:</strong> if the business establishment is a parent item in the directory, the value will be <code>null</code> |[optional]|
**Directory** | **object** | <em>items of the directory</em><br>includes information about businesses that are located within the target business establishment and have the same address |[optional]|
**Services** | **IEnumerable<BusinessDataServiceInfo>** | <em>list of services offered by the business</em> |[optional]|