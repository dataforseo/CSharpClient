# BacklinksPageMeta


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | <em>page title</em> |[optional]|
**Canonical** | **string** | <em>canonical page</em> |[optional]|
**InternalLinksCount** | **long?** | <em>number of internal links on the page</em> |[optional]|
**ExternalLinksCount** | **long?** | <em>number of external links on the page</em> |[optional]|
**ImagesCount** | **long?** | <em>number of images on the page</em> |[optional]|
**WordsCount** | **long?** | <em>number of words on the page</em> |[optional]|
**PageSpamScore** | **int?** | <em>spam score of the page</em><br>learn more about how the metric is calculated on <a href='https://dataforseo.com/help-center/what-is-spam-score-and-how-is-it-calculated' rel='noopener noreferrer' target='_blank'>this help center page</a> |[optional]|
**SocialMediaTags** | **IDictionary<string, string>** | <em>array of social media tags found on the page</em><br>contains social media tags and their content<br>supported tags include but are not limited to <a href='https://ogp.me/'>Open Graph</a> and <a href='https://developer.twitter.com/en/docs/twitter-for-websites/cards/guides/getting-started'>Twitter card</a> |[optional]|
**H1** | **IEnumerable<string>** | <em>h1 tag</em><br>content of <code>h1</code> tags |[optional]|
**H2** | **IEnumerable<string>** | <em>h2 tag</em><br>content of <code>h2</code> tags |[optional]|
**H3** | **IEnumerable<string>** | <em>h3 tag</em><br>content of <code>h3</code> tags |[optional]|
**ImagesAlt** | **IEnumerable<string>** | <em>content of <code>alt</code> tags</em> |[optional]|
**PoweredBy** | **IEnumerable<string>** | <em>CMS details</em> |[optional]|
**Language** | **string** | <em>page content language</em><br>example:<br><code>en</code> |[optional]|
**Charset** | **string** | <em>character encoding</em><br>examples:<br><code>utf-8</code> |[optional]|
**PlatformType** | **IEnumerable<string>** | <em>type of a platform</em> |[optional]|
**Technologies** | **IDictionary<string, string>** | <em>website technologies</em> |[optional]|