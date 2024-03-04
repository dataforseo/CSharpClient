[`< Back`](./)

---

# SpellInfo

Namespace: DataForSeo.Client.Models

```csharp
public class SpellInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SpellInfo](./dataforseo.client.models.spellinfo)

## Properties

### **Keyword**

keyword obtained as a result of search engine autocorrection
 <br> the results will be provided for the corrected keyword

```csharp
public string Keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Type**

type of autocorrection
 <br> possible values:
 <br> did_you_mean, showing_results_for, no_results_found_for, including_results_for
 <br> note: Yahoo and Yandex support only the following autocorrection type:
 <br> including_results_for

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **SpellInfo()**

```csharp
public SpellInfo()
```

---

[`< Back`](./)
