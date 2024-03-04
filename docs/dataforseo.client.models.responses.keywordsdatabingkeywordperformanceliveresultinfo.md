[`< Back`](./)

---

# KeywordsDataBingKeywordPerformanceLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class KeywordsDataBingKeywordPerformanceLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordsDataBingKeywordPerformanceLiveResultInfo](./dataforseo.client.models.responses.keywordsdatabingkeywordperformanceliveresultinfo)

## Properties

### **Keyword**

keyword in a POST array

```csharp
public string Keyword { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LocationCode**

location code in a POST array
 <br>if there is no data, then the value is null

```csharp
public Nullable<int> LocationCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LanguageCode**

language code in a POST array
 <br>if there is no data, then the value is null

```csharp
public string LanguageCode { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Year**

indicates the year for which the data is provided for
 <br>example:
 <br>2020

```csharp
public Nullable<int> Year { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Month**

indicates the month for which the data is provided for
 <br>example:
 <br>10

```csharp
public Nullable<int> Month { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **KeywordKpi**

object containing keyword metrics
 <br>if there is no data, then the value is null

```csharp
public KeywordKpi KeywordKpi { get; set; }
```

#### Property Value

[KeywordKpi](./dataforseo.client.models.keywordkpi)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **KeywordsDataBingKeywordPerformanceLiveResultInfo()**

```csharp
public KeywordsDataBingKeywordPerformanceLiveResultInfo()
```

---

[`< Back`](./)
