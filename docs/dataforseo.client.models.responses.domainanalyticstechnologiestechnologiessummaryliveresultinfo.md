[`< Back`](./)

---

# DomainAnalyticsTechnologiesTechnologiesSummaryLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class DomainAnalyticsTechnologiesTechnologiesSummaryLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DomainAnalyticsTechnologiesTechnologiesSummaryLiveResultInfo](./dataforseo.client.models.responses.domainanalyticstechnologiestechnologiessummaryliveresultinfo)

## Properties

### **Countries**

distribution of websites by country
 <br>contains country codes and number of websites per country

```csharp
public IDictionary<string, Nullable<long>> Countries { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **Languages**

distribution of websites by language
 <br>contains language codes and number of websites per language

```csharp
public IDictionary<string, Nullable<long>> Languages { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **ContentLanguages**

distribution of websites by content language
 <br>contains content language codes and number of websites per language

```csharp
public IDictionary<string, Nullable<long>> ContentLanguages { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **Keywords**

distribution of websites by keywords
 <br>contains keywords found in the websites’ titles, descriptions or meta keywords, and number of websites using each keyword

```csharp
public IDictionary<string, Nullable<long>> Keywords { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DomainAnalyticsTechnologiesTechnologiesSummaryLiveResultInfo()**

```csharp
public DomainAnalyticsTechnologiesTechnologiesSummaryLiveResultInfo()
```

---

[`< Back`](./)
