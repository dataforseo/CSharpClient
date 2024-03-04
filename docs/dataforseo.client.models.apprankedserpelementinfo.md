[`< Back`](./)

---

# AppRankedSerpElementInfo

Namespace: DataForSeo.Client.Models

```csharp
public class AppRankedSerpElementInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AppRankedSerpElementInfo](./dataforseo.client.models.apprankedserpelementinfo)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SerpItem**

contains data on the SERP element
 <br>the list of supported SERP elements can be found below

```csharp
public BaseAppDataSerpElementItem SerpItem { get; set; }
```

#### Property Value

[BaseAppDataSerpElementItem](./dataforseo.client.models.baseappdataserpelementitem)<br>

### **CheckUrl**

direct URL to search engine results
 <br>you can use it to make sure that we provided accurate results

```csharp
public string CheckUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SeResultsCount**

number of search results for the returned keyword

```csharp
public string SeResultsCount { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LastUpdatedTime**

date and time when SERP data was updated
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string LastUpdatedTime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PreviousUpdatedTime**

previous to the most recent date and time when SERP data was updated
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-10-15 12:57:46 +00:00;
 <br>in this case, will equal null

```csharp
public string PreviousUpdatedTime { get; set; }
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

### **AppRankedSerpElementInfo()**

```csharp
public AppRankedSerpElementInfo()
```

---

[`< Back`](./)
