# AdsSearch


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**RankGroup** | **int?** | <em>group rank in SERP</em><br>position within a group of elements with identical <code>type</code> values<br>positions of elements with different <code>type</code> values are omitted from <code>rank_group</code> |[optional]|
**RankAbsolute** | **int?** | <em>absolute rank in SERP</em><br>absolute position among all the elements in SERP |[optional]|
**AdvertiserId** | **string** | <em>unique identifier of the advertiser account</em> |[optional]|
**CreativeId** | **string** | <em>unique identifier of the advertisement</em> |[optional]|
**Title** | **string** | <em>title of the element</em> |[optional]|
**Url** | **string** | <em>search URL with refinement parameters</em> |[optional]|
**Verified** | **bool?** | <em>verified advertiser account</em><br>equals <code>true</code> if advertiser account is verified by Google Ads |[optional]|
**Format** | **string** | <em>format of the advertisement</em><br>possible values: <code>text</code>, <code>image</code>, <code>video</code> |[optional]|
**PreviewImage** | **PreviewImage** | <em>preview image of the advertisement</em> |[optional]|
**PreviewUrl** | **string** | <em>url pointing to the ad preview</em> |[optional]|
**FirstShown** | **string** | <em>date and time when the ad was shown for the first time</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00” |[optional]|
**LastShown** | **string** | <em>date and time when the ad was shown the last time</em><br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00” |[optional]|