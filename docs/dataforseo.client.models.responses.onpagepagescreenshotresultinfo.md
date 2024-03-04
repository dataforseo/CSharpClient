[`< Back`](./)

---

# OnPagePageScreenshotResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class OnPagePageScreenshotResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPagePageScreenshotResultInfo](./dataforseo.client.models.responses.onpagepagescreenshotresultinfo)

## Properties

### **CrawlProgress**

status of the crawling session
 <br>possible values: in_progress, finished

```csharp
public string CrawlProgress { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ErrorMessage**

error message
 <br>if the url you indicated returns a 404 status code or is not a valid URL, you will obtain "error_message":"Screenshot is empty"
 <br>if no error is encountered, the value will be null

```csharp
public string ErrorMessage { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ItemsCount**

number of items in the results array

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

items array

```csharp
public ICollection<ScreenshotItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;ScreenshotItem&gt;](./dataforseo.client.models.screenshotitem)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPagePageScreenshotResultInfo()**

```csharp
public OnPagePageScreenshotResultInfo()
```

---

[`< Back`](./)
