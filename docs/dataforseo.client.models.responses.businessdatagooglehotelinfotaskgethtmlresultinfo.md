[`< Back`](./)

---

# BusinessDataGoogleHotelInfoTaskGetHtmlResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BusinessDataGoogleHotelInfoTaskGetHtmlResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataGoogleHotelInfoTaskGetHtmlResultInfo](./dataforseo.client.models.responses.businessdatagooglehotelinfotaskgethtmlresultinfo)

## Properties

### **Keyword**

identifier received in a POST array
 <br>this field will contain the hotel_identifier parameter specified when setting a task;
 <br>example:
 <br>CgoI-KWyzenM_MV3EAE

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

the number of results returned in the items array

```csharp
public Nullable<long> ItemsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Items**

HTML pages

```csharp
public ICollection<HtmlItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;HtmlItem&gt;](./dataforseo.client.models.htmlitem)<br>

### **Type**

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SeDomain**

```csharp
public string SeDomain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BusinessDataGoogleHotelInfoTaskGetHtmlResultInfo()**

```csharp
public BusinessDataGoogleHotelInfoTaskGetHtmlResultInfo()
```

---

[`< Back`](./)
