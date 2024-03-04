# OnPageWaterfallItem

Namespace: DataForSeo.Client.Models

```csharp
public class OnPageWaterfallItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageWaterfallItem](./dataforseo.client.models.onpagewaterfallitem.md)

## Properties

### **PageUrl**

URL of the page

```csharp
public string PageUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TimeToInteractive**

Time To Interactive (TTI) metric
 <br>the time it takes until the user can interact with a page (in milliseconds)

```csharp
public Nullable<int> TimeToInteractive { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DomComplete**

time to load resources
 <br>the time it takes until the page and all of its subresources are downloaded (in milliseconds)

```csharp
public Nullable<int> DomComplete { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ConnectionTime**

time to connect to a server
 <br>the time it takes until the connection with a server is established (in milliseconds)

```csharp
public Nullable<int> ConnectionTime { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TimeToSecureConnection**

time to establish a secure connection
 <br>the time it takes until the secure connection with a server is established (in milliseconds)

```csharp
public Nullable<int> TimeToSecureConnection { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RequestSentTime**

time to send a request to a server
 <br>the time it takes until the request to a server is sent (in milliseconds)

```csharp
public Nullable<int> RequestSentTime { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **WaitingTime**

time to first byte (TTFB) in milliseconds

```csharp
public Nullable<int> WaitingTime { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DownloadTime**

time it takes for a browser to receive a response (in milliseconds)

```csharp
public Nullable<int> DownloadTime { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DurationTime**

total time it takes until a browser receives a complete response from a server (in milliseconds)

```csharp
public Nullable<int> DurationTime { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FetchStart**

time to start downloading the HTML resource
 <br>the amount of time the browser needs to start downloading a page

```csharp
public Nullable<int> FetchStart { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FetchEnd**

time to complete downloading the HTML resource
 <br>the amount of time the browser needs to complete downloading a page

```csharp
public Nullable<int> FetchEnd { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Resources**

resource-specific timing
 <br>contains separate arrays with timing for each resource found on the page

```csharp
public ICollection<BaseOnPageResourceItemInfo> Resources { get; set; }
```

#### Property Value

[ICollection&lt;BaseOnPageResourceItemInfo&gt;](./dataforseo.client.models.baseonpageresourceiteminfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPageWaterfallItem()**

```csharp
public OnPageWaterfallItem()
```
