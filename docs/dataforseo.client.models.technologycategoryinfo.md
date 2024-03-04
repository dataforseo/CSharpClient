[`< Back`](./)

---

# TechnologyCategoryInfo

Namespace: DataForSeo.Client.Models

```csharp
public class TechnologyCategoryInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [TechnologyCategoryInfo](./dataforseo.client.models.technologycategoryinfo)

## Properties

### **Id**

id of the technology category
 <br>example:
 <br>crm, cart_abandonment

```csharp
public string Id { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Path**

path to the technology category
 <br>example:
 <br>user_generated_content.content_curation

```csharp
public string Path { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the technology category

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Technologies**

list of technologies in this category
 <br>example:
 <br>"Salesforce", "CareCart"

```csharp
public ICollection<string> Technologies { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **TechnologyCategoryInfo()**

```csharp
public TechnologyCategoryInfo()
```

---

[`< Back`](./)
