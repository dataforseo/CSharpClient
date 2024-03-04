# BusinessDirectoryInfo

Namespace: DataForSeo.Client.Models

```csharp
public class BusinessDirectoryInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDirectoryInfo](./dataforseo.client.models.businessdirectoryinfo.md)

## Properties

### **Title**

title of the element
 <br>domain of the online menu system

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Items**

encountered item types
 <br>types of search engine results encountered in the items array;
 <br>possible item types: google_business_info

```csharp
public ICollection<BaseBusinessDataSerpElementItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BaseBusinessDataSerpElementItem&gt;](./dataforseo.client.models.basebusinessdataserpelementitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BusinessDirectoryInfo()**

```csharp
public BusinessDirectoryInfo()
```
