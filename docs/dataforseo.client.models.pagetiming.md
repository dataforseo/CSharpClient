# PageTiming

Namespace: DataForSeo.Client.Models

```csharp
public class PageTiming
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PageTiming](./dataforseo.client.models.pagetiming.md)

## Properties

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

### **LargestContentfulPaint**

Core Web Vitals metric measuring how fast the largest above-the-fold content element is displayed
 <br>The amount of time (in milliseconds) to render the largest content element visible in the viewport, from when the user requests the URL. Learn more.

```csharp
public Nullable<float> LargestContentfulPaint { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FirstInputDelay**

Core Web Vitals metric indicating the responsiveness of a page
 <br>The time (in milliseconds) from when a user first interacts with your page to the time when the browser responds to that interaction. Learn more.

```csharp
public Nullable<float> FirstInputDelay { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

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

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **PageTiming()**

```csharp
public PageTiming()
```
