# SerpGoogleAdsSearchTaskGetAdvancedItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **double?** | group rank in SERP<br>position within a group of elements with identical type values<br>positions of elements with different type values are omitted from rank_group |[optional]|
**RankAbsolute** | **double?** | absolute rank in SERP<br>absolute position among all the elements in SERP |[optional]|
**AdvertiserId** | **string** | unique identifier of the advertiser account |[optional]|
**CreativeId** | **string** | unique identifier of the advertisement |[optional]|
**Title** | **string** | title of the element |[optional]|
**Url** | **string** | search URL with refinement parameters |[optional]|
**Verified** | **bool?** | verified advertiser account<br>equals true if advertiser account is verified by Google Ads |[optional]|
**Format** | **string** | format of the advertisement<br>possible values: text, image, video |[optional]|
**PreviewImage** | **PreviewImage** | preview image of the advertisement |[optional]|
**PreviewUrl** | **string** | url pointing to the ad preview |[optional]|
**FirstShown** | **string** | date and time when the ad was shown for the first time<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00” |[optional]|
**LastShown** | **string** | date and time when the ad was shown the last time<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00” |[optional]|