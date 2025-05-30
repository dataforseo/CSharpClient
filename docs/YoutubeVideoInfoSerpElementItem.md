# YoutubeVideoInfoSerpElementItem


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**VideoId** | **string** | ID of the video received in a POST array |[optional]|
**Title** | **string** | title of the video |[optional]|
**Url** | **string** | URL of the video |[optional]|
**ThumbnailUrl** | **string** | the URL of the page where the thumbnail is hosted |[optional]|
**ChannelId** | **string** | the ID of the channel where the video is published |[optional]|
**ChannelName** | **string** | the name of the channel where the video is published |[optional]|
**ChannelUrl** | **string** | the URL of the channel where the video is published |[optional]|
**ChannelLogo** | **string** | the URL of the page where the logo image of the channel is hosted |[optional]|
**Description** | **string** | description of the video |[optional]|
**ViewsCount** | **double?** | number of views of the video |[optional]|
**LikesCount** | **double?** | number of likes on the video |[optional]|
**CommentsCount** | **double?** | number of comments on the video |[optional]|
**ChannelSubscribersCount** | **ChannelSubscribersCount** | number of subscribers of the channel |[optional]|
**PublicationDate** | **string** | the date when the video is published |[optional]|
**Timestamp** | **string** | date and time when the result is published<br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”<br>example:<br>2022-11-15 12:57:46 +00:00 |[optional]|
**Keywords** | **IEnumerable<string>** | keywords relevant to the video |[optional]|
**Category** | **string** | the category the video belongs to |[optional]|
**IsLive** | **bool?** | indicates whether the video is on live |[optional]|
**IsEmbeddable** | **bool?** | indicates whether the video is embeddable |[optional]|
**DurationTime** | **string** | duration of the video |[optional]|
**DurationTimeSeconds** | **double?** | duration of the video in seconds |[optional]|
**Subtitles** | **IEnumerable<Subtitles>** | array of elements describing properties of subtitles in the video |[optional]|
**StreamingQuality** | **IEnumerable<StreamingQualityElement>** | array of elements that contain information about all possible streaming qualities of the video |[optional]|