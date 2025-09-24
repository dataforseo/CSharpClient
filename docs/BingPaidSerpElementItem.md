# BingPaidSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Domain** | **string** | domain of the ad element in SERP |[optional]|
**Title** | **string** | title of the ad element in SERP |[optional]|
**Description** | **string** | description of the ad element in SERP |[optional]|
**Url** | **string** | relevant URL of the ad element in SERP |[optional]|
**Breadcrumb** | **string** | breadcrumb of the ad element in SERP |[optional]|
**WebsiteName** | **string** | website name in SERP |[optional]|
**IsImage** | **bool?** | indicates whether the element contains an image |[optional]|
**IsVideo** | **bool?** | indicates whether the element contains a video |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | images of the element |[optional]|
**Highlighted** | **IEnumerable<string>** | words highlighted in bold within the results description |[optional]|
**Extra** | **IDictionary<string, string>** | additional information about the result |[optional]|
**DescriptionRows** | **IEnumerable<string>** | extended description<br>if there is none, equals null |[optional]|
**Links** | **IEnumerable<AdLinkElement>** | links featured in the organic result |[optional]|
**Price** | **PriceInfo** | price of booking a place for the specified dates of stay |[optional]|
**Rating** | **RatingElement** | the item’s rating <br>the popularity rate based on reviews and displayed in SERP |[optional]|