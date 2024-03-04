# ResponseDataInfo

Namespace: DataForSeo.Client.Models

```csharp
public class ResponseDataInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ResponseDataInfo](./dataforseo.client.models.responsedatainfo.md)

## Properties

### **Author**

author of the response

```csharp
public string Author { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the response
 <br>in this case, will equal null

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Text**

content of the response

```csharp
public string Text { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Timestamp**

date and time when the response was published
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string Timestamp { get; set; }
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

### **ResponseDataInfo()**

```csharp
public ResponseDataInfo()
```
