# BusinessDataGoogleHotelSearchesTaskGetResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BusinessDataGoogleHotelSearchesTaskGetResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataGoogleHotelSearchesTaskGetResultInfo](./dataforseo.client.models.responses.businessdatagooglehotelsearchestaskgetresultinfo.md)

## Properties

### **Keyword**

keyword received in a POST array
 <br>keyword is returned with decoded %## (plus symbol ‘+’ will be decoded to a space character);
 <br>in order to obtain accurate search results, the location name is appended to the keyword automatically

```csharp
public string Keyword { get; set; }
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

### **ItemsCount**

item types
 <br>the number of items in the items array

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

array of items
 <br>note: this field always equals null; use it to facilitate integration and ensure interoperability with the Hotel Info endpoint

```csharp
public ICollection<BusinessDataGoogleHotelSearchesItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BusinessDataGoogleHotelSearchesItem&gt;](./dataforseo.client.models.businessdatagooglehotelsearchesitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BusinessDataGoogleHotelSearchesTaskGetResultInfo()**

```csharp
public BusinessDataGoogleHotelSearchesTaskGetResultInfo()
```
