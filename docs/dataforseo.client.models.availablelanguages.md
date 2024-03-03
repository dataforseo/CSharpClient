# AvailableLanguages

Namespace: DataForSeo.Client.Models

```csharp
public class AvailableLanguages
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AvailableLanguages](./dataforseo.client.models.availablelanguages.md)

## Properties

### **AvailableSources**

supported sources
 <br>contains the sources of data supported for a specific location and language combination
 <br>only google and bing are currently available

```csharp
public ICollection<string> AvailableSources { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **LanguageName**

language name

```csharp
public string LanguageName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageCode**

language code according to ISO 639-1

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Keywords**

the number of keywords available for the given location and language

```csharp
public Nullable<int> Keywords { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Serps**

the number of SERP pages available for the given location and language

```csharp
public Nullable<int> Serps { get; set; }
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

### **AvailableLanguages()**

```csharp
public AvailableLanguages()
```
