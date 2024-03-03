# SerpScreenshotRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class SerpScreenshotRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SerpScreenshotRequestInfo](./dataforseo.client.models.requests.serpscreenshotrequestinfo.md)

## Properties

### **TaskId**

task identifier
 <br>required field
 <br>unique identifier of the associated task in the UUID format
 <br>you will be able to use it within 7 days to request the results of the task at any time

```csharp
public string TaskId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **BrowserPreset**

browser resolution preset
 <br>optional field
 <br>browser preset associated with a certain device type
 <br>can take the following values: desktop, tablet, mobile
 <br>note: by default, browser preset corresponds to the device type specified in the POST request

```csharp
public string BrowserPreset { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **BrowserScreenWidth**

width of the browser resolution
 <br>optional field
 <br>can be specified in the following range: 240-9999

```csharp
public Nullable<long> BrowserScreenWidth { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BrowserScreenHeight**

height of the browser resolution
 <br>optional field
 <br>can be specified in the following range: 240-9999

```csharp
public Nullable<int> BrowserScreenHeight { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BrowserScreenScaleFactor**

browser scale factor
 <br>optional field
 <br>can be specified in the following range: 0.5-3

```csharp
public Nullable<float> BrowserScreenScaleFactor { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **SerpScreenshotRequestInfo()**

```csharp
public SerpScreenshotRequestInfo()
```
