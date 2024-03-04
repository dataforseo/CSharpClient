# AppDataGooglePlaySearchOrganicSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class AppDataGooglePlaySearchOrganicSerpElementItem : BaseAppDataSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseAppDataSerpElementItem](./dataforseo.client.models.baseappdataserpelementitem.md) → [AppDataGooglePlaySearchOrganicSerpElementItem](./dataforseo.client.models.appdatagoogleplaysearchorganicserpelementitem.md)

## Properties

### **RankGroup**

position within a group of elements with identical type values
 <br>positions of elements with different type values are omitted from rank_group

```csharp
public Nullable<int> RankGroup { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RankAbsolute**

absolute rank in SERP
 <br>absolute position among all the elements in SERP

```csharp
public Nullable<int> RankAbsolute { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Position**

the alignment of the element in SERP
 <br>can take the following values:
 <br>left, right

```csharp
public string Position { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AppId**

id of the app

```csharp
public string AppId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the app

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

URL to the app page on Google Play

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Icon**

URL to the app icon

```csharp
public string Icon { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ReviewsCount**

the total number of reviews of the app

```csharp
public Nullable<long> ReviewsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Rating**

average rating of the app

```csharp
public RatingInfo Rating { get; set; }
```

#### Property Value

[RatingInfo](./dataforseo.client.models.ratinginfo.md)<br>

### **IsFree**

indicates whether the app is free

```csharp
public Nullable<bool> IsFree { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Price**

price of the app

```csharp
public PriceInfo Price { get; set; }
```

#### Property Value

[PriceInfo](./dataforseo.client.models.priceinfo.md)<br>

### **Developer**

name of the app developer

```csharp
public string Developer { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DeveloperUrl**

URL to the developer page on Google Play

```csharp
public string DeveloperUrl { get; set; }
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

### **AppDataGooglePlaySearchOrganicSerpElementItem()**

```csharp
public AppDataGooglePlaySearchOrganicSerpElementItem()
```
