# ContentAnalysisCategoriesResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class ContentAnalysisCategoriesResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentAnalysisCategoriesResultInfo](./dataforseo.client.models.responses.contentanalysiscategoriesresultinfo.md)

## Properties

### **CategoryCode**

category code

```csharp
public Nullable<int> CategoryCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CategoryName**

full name of the category

```csharp
public string CategoryName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CategoryCodeParent**

the code of the superordinate category
 <br>example:
 <br>"category_code": 10178,
 <br>"category_name": "Apparel Accessories",
 <br>"category_code_parent": 10021
 <br>where category_code_parent
 <br>corresponds to:
 <br>"category_code": 10178,
 <br>"category_name": "Apparel Accessories"

```csharp
public Nullable<int> CategoryCodeParent { get; set; }
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

### **ContentAnalysisCategoriesResultInfo()**

```csharp
public ContentAnalysisCategoriesResultInfo()
```
