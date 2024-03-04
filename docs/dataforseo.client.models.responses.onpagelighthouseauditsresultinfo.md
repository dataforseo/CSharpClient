[`< Back`](./)

---

# OnPageLighthouseAuditsResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class OnPageLighthouseAuditsResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageLighthouseAuditsResultInfo](./dataforseo.client.models.responses.onpagelighthouseauditsresultinfo)

## Properties

### **Audits**

the list of available lighthouse audits
 <br>an array containing the titles of available audits
 <br>Note: the titles can change depending on if the audit passed or failed and may contain markdown code

```csharp
public ICollection<string> Audits { get; set; }
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

### **OnPageLighthouseAuditsResultInfo()**

```csharp
public OnPageLighthouseAuditsResultInfo()
```

---

[`< Back`](./)
