# BusinessDataSocialMediaFacebookLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BusinessDataSocialMediaFacebookLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataSocialMediaFacebookLiveResultInfo](./dataforseo.client.models.responses.businessdatasocialmediafacebookliveresultinfo.md)

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

### **LikeCount**

number of likes for the related page_url
 <br>this field shows the number of likes a page received through the Facebook Like Button embed

```csharp
public Nullable<long> LikeCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BusinessDataSocialMediaFacebookLiveResultInfo()**

```csharp
public BusinessDataSocialMediaFacebookLiveResultInfo()
```
