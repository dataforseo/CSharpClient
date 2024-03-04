[`< Back`](./)

---

# BusinessDataSocialMediaRedditLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BusinessDataSocialMediaRedditLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataSocialMediaRedditLiveResultInfo](./dataforseo.client.models.responses.businessdatasocialmediaredditliveresultinfo)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PageUrl**

URL of the page the data is provided for
 <br>corresponding URL you specified in the targets array when setting a task

```csharp
public string PageUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RedditReviews**

reddit reviews for the page_url

```csharp
public ICollection<RedditReviews> RedditReviews { get; set; }
```

#### Property Value

[ICollection&lt;RedditReviews&gt;](./dataforseo.client.models.redditreviews)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BusinessDataSocialMediaRedditLiveResultInfo()**

```csharp
public BusinessDataSocialMediaRedditLiveResultInfo()
```

---

[`< Back`](./)
