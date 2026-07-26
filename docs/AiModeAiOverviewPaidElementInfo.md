# AiModeAiOverviewPaidElementInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**Title** | **string** | <em>title of the element in SERP</em> |[optional]|
**Url** | **string** | <em>reference page URL</em> |[optional]|
**Domain** | **string** | <em>domain name of the reference</em> |[optional]|
**AdAclk** | **string** | <em>unique ad click referral parameter</em><br>using this parameter you can get a URL of the advertisement in <a href='https://docs.dataforseo.com/v3/merchant/google/sellers/ad_url/' rel='noopener noreferrer' target='_blank'>Google Shopping Sellers Ad URL</a> |[optional]|
**WebsiteName** | **string** | <em>displayed name of the advertiser's website</em> |[optional]|
**Breadcrumb** | **string** | <em>breadcrumb path displayed in the ad</em> |[optional]|
**Snippet** | **string** | <em>description text of the ad</em> |[optional]|
**Images** | **IEnumerable<AiModeImagesElementInfo>** | <em>images present in the ad</em><br>if there are none, equals <code>null</code> |[optional]|