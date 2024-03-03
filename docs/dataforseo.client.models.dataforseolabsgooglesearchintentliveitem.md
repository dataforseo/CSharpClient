# DataforseoLabsGoogleSearchIntentLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsGoogleSearchIntentLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsGoogleSearchIntentLiveItem](./dataforseo.client.models.dataforseolabsgooglesearchintentliveitem.md)

## Properties

### **Keyword**

target keyword in a POST array

```csharp
public string Keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **KeywordIntent**

search intent data relevant for the specified keyword

```csharp
public KeywordIntentInfo KeywordIntent { get; set; }
```

#### Property Value

[KeywordIntentInfo](./dataforseo.client.models.keywordintentinfo.md)<br>

### **SecondaryKeywordIntents**

contains objects with other possible search intents for the specified keyword

```csharp
public ICollection<KeywordIntentInfo> SecondaryKeywordIntents { get; set; }
```

#### Property Value

[ICollection&lt;KeywordIntentInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsGoogleSearchIntentLiveItem()**

```csharp
public DataforseoLabsGoogleSearchIntentLiveItem()
```
