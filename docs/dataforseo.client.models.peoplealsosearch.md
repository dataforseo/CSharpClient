[`< Back`](./)

---

# PeopleAlsoSearch

Namespace: DataForSeo.Client.Models

```csharp
public class PeopleAlsoSearch
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [PeopleAlsoSearch](./dataforseo.client.models.peoplealsosearch)

## Properties

### **Cid**

google-defined client id
 <br>unique id of a local establishment
 <br>learn more about the identifier in this help center article

```csharp
public string Cid { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **FeatureId**

the unique identifier of the element in SERP
 <br>learn more about the identifier in this help center article

```csharp
public string FeatureId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the element in SERP
 <br>the name of the business entity for which the results are collected

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Rating**

the element’s rating 
 <br>the popularity rate based on reviews and displayed in SERP

```csharp
public RatingInfo Rating { get; set; }
```

#### Property Value

[RatingInfo](./dataforseo.client.models.ratinginfo)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **PeopleAlsoSearch()**

```csharp
public PeopleAlsoSearch()
```

---

[`< Back`](./)
