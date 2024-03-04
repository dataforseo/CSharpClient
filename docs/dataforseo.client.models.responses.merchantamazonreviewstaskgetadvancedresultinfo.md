[`< Back`](./)

---

# MerchantAmazonReviewsTaskGetAdvancedResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class MerchantAmazonReviewsTaskGetAdvancedResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MerchantAmazonReviewsTaskGetAdvancedResultInfo](./dataforseo.client.models.responses.merchantamazonreviewstaskgetadvancedresultinfo)

## Properties

### **Asin**

asin received in a POST array

```csharp
public string Asin { get; set; }
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

direct URL to search engine results
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

### **Title**

title of the product on Amazon
 <br>the title of the product for which the reviews are collected

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Image**

product image data

```csharp
public ImagesElement Image { get; set; }
```

#### Property Value

[ImagesElement](./dataforseo.client.models.imageselement)<br>

### **Rating**

rating of the product on Amazon
 <br>popularity rate based on reviews and displayed in SERP

```csharp
public RatingElement Rating { get; set; }
```

#### Property Value

[RatingElement](./dataforseo.client.models.ratingelement)<br>

### **ReviewsCount**

the total number of reviews

```csharp
public Nullable<long> ReviewsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ItemTypes**

type of search results in Amazon SERP
 <br>contains types of search results (items) found in Amazon SERP;
 <br>possible item types:
 <br>amazon_review_item

```csharp
public ICollection<string> ItemTypes { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **ItemsCount**

the number of reviews items in the results array
 <br>you can get more results by using the depth parameter when setting a task

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

found reviews
 <br>you can get more results by using the depth parameter when setting a task

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

### **MerchantAmazonReviewsTaskGetAdvancedResultInfo()**

```csharp
public MerchantAmazonReviewsTaskGetAdvancedResultInfo()
```

---

[`< Back`](./)
