# BacklinksPageMeta


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | page title |[optional]|
**Canonical** | **string** | canonical page |[optional]|
**InternalLinksCount** | **long?** | number of internal links on the page |[optional]|
**ExternalLinksCount** | **long?** | number of external links on the page |[optional]|
**ImagesCount** | **long?** | number of images on the page |[optional]|
**WordsCount** | **long?** | number of words on the page |[optional]|
**PageSpamScore** | **int?** | spam score of the page<br>learn more about how the metric is calculated on this help center page |[optional]|
**SocialMediaTags** | **IDictionary<string, string>** | array of social media tags found on the page<br>contains social media tags and their content<br>supported tags include but are not limited to Open Graph and Twitter card |[optional]|
**H1** | **IEnumerable<string>** | h1 tag<br>content of h1 tags |[optional]|
**H2** | **IEnumerable<string>** | h2 tag<br>content of h2 tags |[optional]|
**H3** | **IEnumerable<string>** | h3 tag<br>content of h3 tags |[optional]|
**ImagesAlt** | **IEnumerable<string>** | content of alt tags |[optional]|
**PoweredBy** | **IEnumerable<string>** | CMS details |[optional]|
**Language** | **string** | page content language<br>example:<br>en |[optional]|
**Charset** | **string** | character encoding<br>examples:<br>utf-8 |[optional]|
**PlatformType** | **IEnumerable<string>** | type of a platform |[optional]|
**Technologies** | **IDictionary<string, string>** | website technologies |[optional]|