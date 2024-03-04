# MicrodataInspectionInfo

Namespace: DataForSeo.Client.Models

```csharp
public class MicrodataInspectionInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MicrodataInspectionInfo](./dataforseo.client.models.microdatainspectioninfo.md)

## Properties

### **Types**

parent microdata types
 <br>for a full list of available types, please visit schema.org

```csharp
public ICollection<string> Types { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Fields**

microdata fields
 <br>an array of objects containing data fields related to the certain microdata type

```csharp
public ICollection<MicrodataFieldsInfo> Fields { get; set; }
```

#### Property Value

[ICollection&lt;MicrodataFieldsInfo&gt;](./dataforseo.client.models.microdatafieldsinfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **MicrodataInspectionInfo()**

```csharp
public MicrodataInspectionInfo()
```
