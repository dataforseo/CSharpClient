[`< Back`](./)

---

# BacklinksBulkReferringDomainsLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class BacklinksBulkReferringDomainsLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksBulkReferringDomainsLiveRequestInfo](./dataforseo.client.models.requests.backlinksbulkreferringdomainsliverequestinfo)

## Properties

### **Targets**

domains, subdomains or webpages to get the number of referring domains for
 <br>required field
 <br>you can set up to 1000 domains, subdomains or webpages
 <br>the domain or subdomain should be specified without https:// and www.
 <br>the page should be specified with absolute URL (including http:// or https://)
 <br>example:
 <br>"targets": [
 <br> "forbes.com",
 <br> "cnn.com",
 <br> "bbc.com",
 <br> "yelp.com",
 <br> "https://www.apple.com/iphone/",
 <br> "https://ahrefs.com/blog/",
 <br> "ibm.com",
 <br> "https://variety.com/",
 <br> "https://stackoverflow.com/",
 <br> "www.trustpilot.com"
 <br>]

```csharp
public ICollection<string> Targets { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Tag**

user-defined task identifier
 <br>optional field
 <br>the character limit is 255
 <br>you can use this parameter to identify the task and match it with the result
 <br>you will find the specified tag value in the data object of the response

```csharp
public string Tag { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BacklinksBulkReferringDomainsLiveRequestInfo()**

```csharp
public BacklinksBulkReferringDomainsLiveRequestInfo()
```

---

[`< Back`](./)
