# MerchantGoogleSellersTaskGetAdvancedResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class MerchantGoogleSellersTaskGetAdvancedResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MerchantGoogleSellersTaskGetAdvancedResultInfo](./dataforseo.client.models.responses.merchantgooglesellerstaskgetadvancedresultinfo.md)

## Properties

### **ProductId**

product_id received in a POST array
 <br>learn more about the parameter in this help center guide

```csharp
public string ProductId { get; set; }
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

direct URL to Google Shopping results
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

### **ItemTypes**

types of search results found in Google Shopping SERP
 <br>contains types of all search results (items) found in the returned SERP
 <br>possible item types:
 <br>shops_list, buy_on_google

```csharp
public ICollection<string> ItemTypes { get; set; }
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

items in SERP

```csharp
public ICollection<BaseMerchantSerpElementItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BaseMerchantSerpElementItem&gt;](./dataforseo.client.models.basemerchantserpelementitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **MerchantGoogleSellersTaskGetAdvancedResultInfo()**

```csharp
public MerchantGoogleSellersTaskGetAdvancedResultInfo()
```
