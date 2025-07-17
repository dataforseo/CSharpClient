# PageContentInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Header** | **PageSectionContentInfo** | content of the header of the table |[optional]|
**Footer** | **PageSectionContentInfo** | content of the footer of the table |[optional]|
**MainTopic** | **IEnumerable<TopicInfo>** | main topic on the page<br>you can find more information about topic priority calculation in this help center article |[optional]|
**SecondaryTopic** | **IEnumerable<TopicInfo>** | secondary topic on the page<br>you can find more information about topic priority calculation in this help center article |[optional]|
**Ratings** | **IEnumerable<ContentRatingInfo>** | contains objects with rating information for the products displayed on the page |[optional]|
**Offers** | **IEnumerable<ContentOfferInfo>** | array of products displayed on the page<br>contains objects with information on products displayed on the page |[optional]|
**Comments** | **IEnumerable<ContentCommentInfo>** | array of comments displayed on the page<br>contains objects with information on comments related to displayed products |[optional]|
**Contacts** | **Contacts** | contact information<br>contains contact information displayed on the page |[optional]|