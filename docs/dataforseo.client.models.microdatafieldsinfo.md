[`< Back`](./)

---

# MicrodataFieldsInfo

Namespace: DataForSeo.Client.Models

```csharp
public class MicrodataFieldsInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MicrodataFieldsInfo](./dataforseo.client.models.microdatafieldsinfo)

## Properties

### **Name**

field name
 <br>name of the data field

```csharp
public string Name { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Types**

parent microdata types
 <br>for a full list of available types, please visit schema.org

```csharp
public ICollection<string> Types { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Value**

microdata value
 <br>microdata value specified on a target web page

```csharp
public string Value { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TestResults**

microdata validation test results
 <br>sub-type microdata test results that contain detected errors and related messages

```csharp
public MicrodataTestResultsInfo TestResults { get; set; }
```

#### Property Value

[MicrodataTestResultsInfo](./dataforseo.client.models.microdatatestresultsinfo)<br>

### **Fields**

microdata fields
 <br>an array of objects containing data fields related to the certain microdata type

```csharp
public ICollection<MicrodataFieldsInfo> Fields { get; set; }
```

#### Property Value

[ICollection&lt;MicrodataFieldsInfo&gt;](./dataforseo.client.models.microdatafieldsinfo)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **MicrodataFieldsInfo()**

```csharp
public MicrodataFieldsInfo()
```

---

[`< Back`](./)
