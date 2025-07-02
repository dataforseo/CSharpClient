# BaseOnPageLinkItemInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Type** | **string** | type of element |[optional]|
**DomainFrom** | **string** | referring domain<br>the link was found on this domain |[optional]|
**DomainTo** | **string** | referenced domain<br>the link is pointing to this domain |[optional]|
**PageFrom** | **string** | referring page<br>relative URL of the page on which the link was found |[optional]|
**PageTo** | **string** | referenced page<br>relative URL of the page to which the link is pointing |[optional]|
**LinkFrom** | **string** | referring page<br>absolute URL of the page on which the link was found |[optional]|
**LinkTo** | **string** | referenced page<br>absolute URL of the page to which the link is pointing |[optional]|
**Dofollow** | **bool?** | indicates whether the link is dofollow<br>if the value is true, the link doesn’t have a rel='nofollow' attribute |[optional]|
**PageFromScheme** | **string** | url scheme of the referring page |[optional]|
**PageToScheme** | **string** | url scheme of the referenced page |[optional]|
**Direction** | **string** | direction of the link<br>possible values: internal, external |[optional]|
**IsBroken** | **bool?** | link is broken<br>indicates whether a link is directing to a broken page or resource |[optional]|
**IsLinkRelationConflict** | **bool?** | indicates that the link may have a conflict with another link<br>if true, at least one link pointing to link_to has a rel='nofollow' attribute and at least one is dofollow |[optional]|