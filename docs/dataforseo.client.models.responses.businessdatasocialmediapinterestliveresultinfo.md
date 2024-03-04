# BusinessDataSocialMediaPinterestLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BusinessDataSocialMediaPinterestLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataSocialMediaPinterestLiveResultInfo](./dataforseo.client.models.responses.businessdatasocialmediapinterestliveresultinfo.md)

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

### **PinsCount**

number of pins for the related page_url
 <br>pins on Pinterest correspond to content saves;
 <br>this field shows the number of content saves made from the related page_url using the Pinterest Save Button

```csharp
public Nullable<long> PinsCount { get; set; }
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

### **BusinessDataSocialMediaPinterestLiveResultInfo()**

```csharp
public BusinessDataSocialMediaPinterestLiveResultInfo()
```
