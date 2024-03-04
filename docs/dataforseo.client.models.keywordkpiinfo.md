[`< Back`](./)

---

# KeywordKpiInfo

Namespace: DataForSeo.Client.Models

```csharp
public class KeywordKpiInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [KeywordKpiInfo](./dataforseo.client.models.keywordkpiinfo)

## Properties

### **AdPosition**

represents the position of the relevant ad in SERP
 <br>can take the following values:
 <br>FirstPage1: The first ad to appear on the right side of the first search results page
 <br>FirstPage2: The second ad to appear on the right side of the first search results page
 <br>FirstPage3: The third ad to appear on the right side of the first search results page
 <br>FirstPage4: The fourth ad to appear on the right side of the first search results page
 <br>FirstPage5: The fifth ad to appear on the right side of the first search results page
 <br>FirstPage6: The sixth ad to appear on the right side of the first search results page
 <br>FirstPage7: The seventh ad to appear on the right side of the first search results page
 <br>FirstPage8: The eighth ad to appear on the right side of the first search results page
 <br>FirstPage9: The ninth ad to appear on the right side of the first search results page
 <br>FirstPage10: The tenth ad to appear on the right side of the first search results page
 <br>MainLine1: The first ad to appear at the top of the search results page
 <br>MainLine2: The second ad to appear at the top of the search results page
 <br>MainLine3: The third ad to appear at the top of the search results page
 <br>MainLine4: The fourth ad to appear at the top of the search results page

```csharp
public string AdPosition { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Clicks**

ad clicks
 <br>the number of clicks that the keyword and match type generated during the last month

```csharp
public Nullable<int> Clicks { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Impressions**

ad impressions
 <br>the number of impressions that the keyword and match type generated during the last month

```csharp
public Nullable<int> Impressions { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AverageCpc**

average cost per click, USD
 <br>calculated by dividing the cost of all clicks by the number of clicks

```csharp
public Nullable<double> AverageCpc { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Ctr**

click-through rate as a percentage
 <br>calculated by dividing the number of clicks by the number of impressions and multiplying the result by 100

```csharp
public Nullable<double> Ctr { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TotalCost**

total cost of an ad, USD
 <br>the cost of using the specified keyword and match type during the last month

```csharp
public Nullable<long> TotalCost { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AverageBid**

average bid of the keyword

```csharp
public Nullable<double> AverageBid { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **KeywordKpiInfo()**

```csharp
public KeywordKpiInfo()
```

---

[`< Back`](./)
