# HotelsPackElement


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Price** | **PriceInfo** | <em>price indicated in the element</em> |[optional]|
**Title** | **string** | <em>title of a given link element</em> |[optional]|
**Description** | **string** | <em>link description</em> |[optional]|
**HotelIdentifier** | **string** | <em>unique hotel identifier</em><br>unique hotel identifier assigned by Google;<br>example: <code>'CgoIjaeSlI6CnNpVEAE'</code> |[optional]|
**Domain** | **string** | <em>domain where a link points</em> |[optional]|
**Url** | **string** | <em>source URL</em> |[optional]|
**IsPaid** | **bool?** | <em>indicates whether the element is an ad</em> |[optional]|
**Rating** | **RatingInfo** | <em>the item's rating </em><br>the popularity rate based on reviews and displayed in SERP;<br>if there is none, equals <code>null</code> |[optional]|
**GroupTitle** | **string** | <em>title of the hotel listing's group</em> |[optional]|
**GroupSource** | **string** | <em>domain or brand name of the hotel listing's group</em> |[optional]|