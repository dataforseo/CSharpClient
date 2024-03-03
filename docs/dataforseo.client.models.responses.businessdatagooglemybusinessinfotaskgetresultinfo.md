# BusinessDataGoogleMyBusinessInfoTaskGetResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BusinessDataGoogleMyBusinessInfoTaskGetResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataGoogleMyBusinessInfoTaskGetResultInfo](./dataforseo.client.models.responses.businessdatagooglemybusinessinfotaskgetresultinfo.md)

## Properties

### **Keyword**

keyword received in a POST array
 <br>keyword is returned with decoded %## (plus symbol ‘+’ will be decoded to a space character)
 <br>this field will contain the cid parameter if you specified it in the keyword field when setting a task;
 <br>example:
 <br>cid:2946633002421908862
 <br>learn more about the parameter in this help center article

```csharp
public string Keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SeDomain**

search engine domain as specified in a POST array

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

### **ItemTypes**

item types
 <br>types of search engine results encountered in the items array;
 <br>possible item types: google_business_info

```csharp
public ICollection<string> ItemTypes { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **ItemsCount**

item types
 <br>the number of items in the items array

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

array of directory items

```csharp
public ICollection<BaseBusinessDataSerpElementItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BaseBusinessDataSerpElementItem&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BusinessDataGoogleMyBusinessInfoTaskGetResultInfo()**

```csharp
public BusinessDataGoogleMyBusinessInfoTaskGetResultInfo()
```
