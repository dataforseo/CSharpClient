# MerchantAmazonAsinTaskGetAdvancedResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class MerchantAmazonAsinTaskGetAdvancedResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MerchantAmazonAsinTaskGetAdvancedResultInfo](./dataforseo.client.models.responses.merchantamazonasintaskgetadvancedresultinfo.md)

## Properties

### **Asin**

ASIN received in a POST array
 <br>the unique product identifier in Amazon (ASIN) received in a POST array
 <br>learn more about the identified in this help center guide

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

Amazon domain in a POST array

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

### **ItemTypes**

types of search results found on Amazon
 <br>contains types of all search results (items) found in the returned SERP
 <br>possible item types:
 <br>amazon_product_info

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

Amazon product info items

```csharp
public ICollection<BaseAmazonSerpElementItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BaseAmazonSerpElementItem&gt;](./dataforseo.client.models.baseamazonserpelementitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **MerchantAmazonAsinTaskGetAdvancedResultInfo()**

```csharp
public MerchantAmazonAsinTaskGetAdvancedResultInfo()
```
