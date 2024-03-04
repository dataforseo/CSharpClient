# IndexHistory

Namespace: DataForSeo.Client.Models

```csharp
public class IndexHistory
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [IndexHistory](./dataforseo.client.models.indexhistory.md)

## Properties

### **Date**

date for which index volume data is provided
 <br>in the UTC format: “yyyy-mm-dd”
 <br>example:
 <br>2021-10-01

```csharp
public string Date { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TotalBacklinks**

total number of backlinks our database contained on the given date

```csharp
public Nullable<long> TotalBacklinks { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TotalPages**

total number of pages our database contained on the given date

```csharp
public Nullable<long> TotalPages { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TotalDomains**

total number of domains our database contained on the given date

```csharp
public Nullable<long> TotalDomains { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **IndexHistory()**

```csharp
public IndexHistory()
```
