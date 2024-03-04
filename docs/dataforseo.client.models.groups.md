[`< Back`](./)

---

# Groups

Namespace: DataForSeo.Client.Models

```csharp
public class Groups
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Groups](./dataforseo.client.models.groups)

## Properties

### **Id**

id of the technology group
 <br>example:
 <br>marketing, sales

```csharp
public string Id { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the technology group

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Categories**

technology categories in this group

```csharp
public ICollection<TechnologyCategoryInfo> Categories { get; set; }
```

#### Property Value

[ICollection&lt;TechnologyCategoryInfo&gt;](./dataforseo.client.models.technologycategoryinfo)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **Groups()**

```csharp
public Groups()
```

---

[`< Back`](./)
