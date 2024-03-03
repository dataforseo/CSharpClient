# AmazonKeywordData

Namespace: DataForSeo.Client.Models

```csharp
public class AmazonKeywordData
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AmazonKeywordData](./dataforseo.client.models.amazonkeyworddata.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Keyword**

related keyword

```csharp
public string Keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

location code in a POST array

```csharp
public Nullable<long> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageCode**

language code in a POST array

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **KeywordInfo**

keyword info for the returned keyword

```csharp
public AmazonKeywordInfo KeywordInfo { get; set; }
```

#### Property Value

[AmazonKeywordInfo](./dataforseo.client.models.amazonkeywordinfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **AmazonKeywordData()**

```csharp
public AmazonKeywordData()
```
