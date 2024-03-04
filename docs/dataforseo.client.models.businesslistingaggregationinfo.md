[`< Back`](./)

---

# BusinessListingAggregationInfo

Namespace: DataForSeo.Client.Models

```csharp
public class BusinessListingAggregationInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessListingAggregationInfo](./dataforseo.client.models.businesslistingaggregationinfo)

## Properties

### **TopCategories**

the most mentioned related categories
 <br>top categories displayed with the number of businesses in each category

```csharp
public IDictionary<string, Nullable<long>> TopCategories { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **TopCountries**

the most mentioned counties
 <br>country codes with the biggest number of businesses in the category

```csharp
public IDictionary<string, Nullable<long>> TopCountries { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **WebsitesCount**

number of unique websites

```csharp
public Nullable<long> WebsitesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Count**

number of unique entities

```csharp
public Nullable<long> Count { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TopAttributes**

the most mentioned service details
 <br>service details of a business entity displayed in a form of checks and the number of entities mentioning each attribute

```csharp
public IDictionary<string, Nullable<long>> TopAttributes { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **TopPlaceTopics**

top keywords mentioned in customer reviews
 <br>contains most popular keywords related to products/services mentioned in customer reviews of a business entity and the number of reviews mentioning each keyword

```csharp
public IDictionary<string, Nullable<long>> TopPlaceTopics { get; set; }
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

### **BusinessListingAggregationInfo()**

```csharp
public BusinessListingAggregationInfo()
```

---

[`< Back`](./)
