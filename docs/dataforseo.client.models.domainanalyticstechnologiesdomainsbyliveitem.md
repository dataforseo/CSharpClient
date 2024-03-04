# DomainAnalyticsTechnologiesDomainsByLiveItem

Namespace: DataForSeo.Client.Models

items array

```csharp
public class DomainAnalyticsTechnologiesDomainsByLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DomainAnalyticsTechnologiesDomainsByLiveItem](./dataforseo.client.models.domainanalyticstechnologiesdomainsbyliveitem.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Domain**

specified domain name

```csharp
public string Domain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

domain meta title

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Description**

domain meta description

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MetaKeywords**

domain meta keywords

```csharp
public ICollection<string> MetaKeywords { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **DomainRank**

backlink rank of the target domain
 <br>learn more about the metric and how it is calculated in this help center article

```csharp
public string DomainRank { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LastVisited**

most recent date when our crawler visited the domain
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2022-10-10 12:57:46 +00:00

```csharp
public string LastVisited { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CountryIsoCode**

domain ISO code
 <br>ISO code of the country that target domain is determined to belong to

```csharp
public string CountryIsoCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LanguageCode**

domain language
 <br>code of the language that target domain is determined to be associated with

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ContentLanguageCode**

content language
 <br>code of the language that content on the target domain is written with

```csharp
public string ContentLanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PhoneNumbers**

phone numbers of the target
 <br>contact phone numbers indicated on the target website

```csharp
public ICollection<string> PhoneNumbers { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Emails**

emails of the target
 <br>emails indicated on the target website

```csharp
public ICollection<string> Emails { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **SocialGraphUrls**

social media links and handles
 <br>social media URLs detected in the social graphs of the target website

```csharp
public ICollection<string> SocialGraphUrls { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Technologies**

technologies used by target domain
 <br>contains objects with the names of technologies used on the website;
 <br>to get a full list of technologies and their structure, refer to the technologies endpoint

```csharp
public TechnologiesInfo Technologies { get; set; }
```

#### Property Value

[TechnologiesInfo](./dataforseo.client.models.technologiesinfo.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DomainAnalyticsTechnologiesDomainsByLiveItem()**

```csharp
public DomainAnalyticsTechnologiesDomainsByLiveItem()
```
