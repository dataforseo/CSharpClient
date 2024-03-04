# BusinessDataTrustpilotSearchTaskGetResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BusinessDataTrustpilotSearchTaskGetResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataTrustpilotSearchTaskGetResultInfo](./dataforseo.client.models.responses.businessdatatrustpilotsearchtaskgetresultinfo.md)

## Properties

### **Keyword**

keyword in a POST array

```csharp
public string Keyword { get; set; }
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

the number of items in the results array
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
public ICollection<BaseBusinessDataSerpElementItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BaseBusinessDataSerpElementItem&gt;](./dataforseo.client.models.basebusinessdataserpelementitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BusinessDataTrustpilotSearchTaskGetResultInfo()**

```csharp
public BusinessDataTrustpilotSearchTaskGetResultInfo()
```
