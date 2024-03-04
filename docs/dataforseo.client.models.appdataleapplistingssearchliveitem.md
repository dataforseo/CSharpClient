# AppDataleAppListingsSearchLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class AppDataleAppListingsSearchLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AppDataleAppListingsSearchLiveItem](./dataforseo.client.models.appdataleapplistingssearchliveitem.md)

## Properties

### **AppId**

ID of the returned app

```csharp
public string AppId { get; set; }
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

### **TimeUpdate**

date and time when SERP data was last updated
 <br>in the ISO 8601 format: “YYYY-MM-DDThh:mm:ss.sssssssZ”
 <br>example:
 <br>2023-05-23 10:16:19 +00:00

```csharp
public string TimeUpdate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Item**

detailed information about the app

```csharp
public BaseAppDataSerpElementItem Item { get; set; }
```

#### Property Value

[BaseAppDataSerpElementItem](./dataforseo.client.models.baseappdataserpelementitem.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **AppDataleAppListingsSearchLiveItem()**

```csharp
public AppDataleAppListingsSearchLiveItem()
```
