# PageMetaInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Title** | **string** | page title |[optional]|
**Charset** | **int?** | code page<br>example: 65001 |[optional]|
**Follow** | **bool?** | indicates whether a page’s ‘meta robots’ allows crawlers to follow the links on the page<br>if false, the page’s ‘meta robots’ tag contains “nofollow” parameter instructing crawlers not to follow the links on the page |[optional]|
**Generator** | **string** | meta tag generator |[optional]|
**Htags** | **IDictionary<string, IEnumerable<string>>** | HTML header tags |[optional]|
**Description** | **string** | content of the meta description tag |[optional]|
**Favicon** | **string** | favicon of the page |[optional]|
**MetaKeywords** | **string** | content of the keywords meta tag |[optional]|
**Canonical** | **string** | canonical page |[optional]|
**InternalLinksCount** | **long?** | number of internal links on the page |[optional]|
**ExternalLinksCount** | **long?** | number of external links on the page |[optional]|
**InboundLinksCount** | **long?** | number of internal links pointing at the page |[optional]|
**ImagesCount** | **long?** | number of images on the page |[optional]|
**ImagesSize** | **int?** | total size of images on the page measured in bytes |[optional]|
**ScriptsCount** | **long?** | number of scripts on the page |[optional]|
**ScriptsSize** | **int?** | total size of scripts on the page measured in bytes |[optional]|
**StylesheetsCount** | **long?** | number of stylesheets on the page |[optional]|
**StylesheetsSize** | **int?** | total size of stylesheets on the page measured in bytes |[optional]|
**TitleLength** | **int?** | length of the title tag in characters |[optional]|
**DescriptionLength** | **int?** | length of the description tag in characters |[optional]|
**RenderBlockingScriptsCount** | **long?** | number of scripts on the page that block page rendering |[optional]|
**RenderBlockingStylesheetsCount** | **long?** | number of CSS styles on the page that block page rendering |[optional]|
**CumulativeLayoutShift** | **float?** | Core Web Vitals metric measuring the layout stability of the page<br>measures the sum total of all individual layout shift scores for every unexpected layout shift that occurs during the entire lifespan of the page. Learn more. |[optional]|
**MetaTitle** | **string** | meta title of the page<br>meta tag in the head section of an HTML document that defines the title of a page |[optional]|
**Content** | **HtmlContentInfo** | overall information about content of the page |[optional]|
**DeprecatedTags** | **IEnumerable<string>** | deprecated tags on the page |[optional]|
**DuplicateMetaTags** | **IEnumerable<string>** | duplicate meta tags on the page |[optional]|
**Spell** | **SpellInfo** | autocorrection of the search engine<br>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection |[optional]|
**SocialMediaTags** | **IDictionary<string, string>** | object of social media tags found on the page<br>contains social media tags and their content<br>supported tags include but are not limited to Open Graph and Twitter card |[optional]|
**BrokenHtml** | **OnPageResourceIssueInfo** | resource errors and warnings |[optional]|