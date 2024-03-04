# AppDataAppleAppReviewsTaskGetAdvancedResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class AppDataAppleAppReviewsTaskGetAdvancedResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AppDataAppleAppReviewsTaskGetAdvancedResultInfo](./dataforseo.client.models.responses.appdataappleappreviewstaskgetadvancedresultinfo.md)

## Properties

### **AppId**

application id received in a POST array

```csharp
public string AppId { get; set; }
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

### **Title**

title of the app
 <br>title of the application for which the reviews are collected

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Rating**

rating of the app
 <br>rating of the application for which the reviews are collected

```csharp
public RatingInfo Rating { get; set; }
```

#### Property Value

[RatingInfo](./dataforseo.client.models.ratinginfo.md)<br>

### **ReviewsCount**

the total number of reviews
 <br>in this case, the value will be null as App Store does not indicate the total number of app reviews

```csharp
public Nullable<long> ReviewsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

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

```csharp
public ICollection<BaseAppDataSerpElementItem> Items { get; set; }
```

#### Property Value

[ICollection&lt;BaseAppDataSerpElementItem&gt;](./dataforseo.client.models.baseappdataserpelementitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **AppDataAppleAppReviewsTaskGetAdvancedResultInfo()**

```csharp
public AppDataAppleAppReviewsTaskGetAdvancedResultInfo()
```
