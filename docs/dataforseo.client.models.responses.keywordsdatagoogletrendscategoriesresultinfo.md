# KeywordsDataGoogleTrendsCategoriesResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class KeywordsDataGoogleTrendsCategoriesResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordsDataGoogleTrendsCategoriesResultInfo](./dataforseo.client.models.responses.keywordsdatagoogletrendscategoriesresultinfo.md)

## Properties

### **CategoryCode**

unique google trends category identifier

```csharp
public Nullable<int> CategoryCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CategoryName**

name of the google trends category

```csharp
public string CategoryName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CategoryCodeParent**

the code of the superordinate category
 <br>example:
 <br>"category_code": 1100,
 <br>"category_name": "Superhero Films",
 <br>"category_code_parent": 1097
 <br>where category_code_parent corresponds to:
 <br>"category_code": 1097,
 <br>"category_name": "Action &amp; Adventure Films"

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

### **KeywordsDataGoogleTrendsCategoriesResultInfo()**

```csharp
public KeywordsDataGoogleTrendsCategoriesResultInfo()
```
