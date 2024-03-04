[`< Back`](./)

---

# MerchantAmazonProductsTaskGetAdvancedResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class MerchantAmazonProductsTaskGetAdvancedResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MerchantAmazonProductsTaskGetAdvancedResultInfo](./dataforseo.client.models.responses.merchantamazonproductstaskgetadvancedresultinfo)

## Properties

### **Keyword**

keyword received in a POST array
 <br>keyword is returned with decoded %## (plus symbol ‘+’ will be decoded to a space character)

```csharp
public string Keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SeDomain**

search engine domain in a POST array

```csharp
public string SeDomain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

location code in a POST array

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageCode**

language code in a POST array

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CheckUrl**

direct URL to Amazon results
 <br>you can use it to make sure that we provided accurate results

```csharp
public string CheckUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Datetime**

date and time when the result was received
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string Datetime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Spell**

autocorrection of the search engine
 <br>if the search engine provided results for a keyword that was corrected, we will specify the keyword corrected by the search engine and the type of autocorrection

```csharp
public SpellInfo Spell { get; set; }
```

#### Property Value

[SpellInfo](./dataforseo.client.models.spellinfo)<br>

### **ItemTypes**

types of search results found in Amazon SERP
 <br>contains types of all search results (items) found in the returned SERP
 <br>possible item types:
 <br>amazon_serp, amazon_paid, editorial_recommendations, top_rated_from_our_brands, related_searches

```csharp
public ICollection<string> ItemTypes { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **SeResultsCount**

search engine results count

```csharp
public Nullable<long> SeResultsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Categories**

amazon product departments and subcategories

```csharp
public ICollection<string> Categories { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **ItemsCount**

the number of results returned in the items array

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

Amazon product items within the editorial_recommendations element

```csharp
public ICollection<BaseAmazonSerpElementItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BaseAmazonSerpElementItem&gt;](./dataforseo.client.models.baseamazonserpelementitem)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **MerchantAmazonProductsTaskGetAdvancedResultInfo()**

```csharp
public MerchantAmazonProductsTaskGetAdvancedResultInfo()
```

---

[`< Back`](./)
