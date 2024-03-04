[`< Back`](./)

---

# BacklinksBulkNewLostReferringDomainsLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class BacklinksBulkNewLostReferringDomainsLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksBulkNewLostReferringDomainsLiveRequestInfo](./dataforseo.client.models.requests.backlinksbulknewlostreferringdomainsliverequestinfo)

## Properties

### **Targets**

domains, subdomains or webpages to get new &amp; lost referring domains for
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

### **DateFrom**

starting date of the time range
 <br>optional field
 <br>this field indicates the date which will be used as a threshold for new and lost referring domains;
 <br>the referring domains that appeared in our index after the specified date will be considered as new;
 <br>the referring domains that weren’t found after the specified date, but were present before, will be considered as lost;
 <br>default value: today’s date -(minus) one month;
 <br>e.g. if today is 2021-10-13, default date_from will be 2021-09-13.
 <br>minimum value equals today’s date -(minus) one year;
 <br>e.g. if today is 2021-10-13, minimum date_from will be 2020-10-13.
 <br>date format: "yyyy-mm-dd"
 <br>example:
 <br>"2021-01-01"

```csharp
public string DateFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

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

### **BacklinksBulkNewLostReferringDomainsLiveRequestInfo()**

```csharp
public BacklinksBulkNewLostReferringDomainsLiveRequestInfo()
```

---

[`< Back`](./)
