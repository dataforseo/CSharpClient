[`< Back`](./)

---

# DomainAnalyticsTechnologiesTechnologyStatsLiveItem

Namespace: DataForSeo.Client.Models

items array

```csharp
public class DomainAnalyticsTechnologiesTechnologyStatsLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DomainAnalyticsTechnologiesTechnologyStatsLiveItem](./dataforseo.client.models.domainanalyticstechnologiestechnologystatsliveitem)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Date**

date for which the data is provided

```csharp
public string Date { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DomainsCount**

number of domains that use the specified technology

```csharp
public Nullable<long> DomainsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

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

### **DomainsRank**

distribution of websites by backlink rank
 <br>contains domain rank ranges and number of websites per range
 <br>learn more about rank and how it is calculated in this help center article

```csharp
public IDictionary<string, Nullable<long>> DomainsRank { get; set; }
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

### **DomainAnalyticsTechnologiesTechnologyStatsLiveItem()**

```csharp
public DomainAnalyticsTechnologiesTechnologyStatsLiveItem()
```

---

[`< Back`](./)
