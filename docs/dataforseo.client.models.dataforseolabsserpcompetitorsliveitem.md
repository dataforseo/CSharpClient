# DataforseoLabsSerpCompetitorsLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class DataforseoLabsSerpCompetitorsLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DataforseoLabsSerpCompetitorsLiveItem](./dataforseo.client.models.dataforseolabsserpcompetitorsliveitem.md)

## Properties

### **SeType**

search engine type

```csharp
public string SeType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Domain**

domain name of the detected SERP competitor

```csharp
public string Domain { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AvgPosition**

the average position of the domain for the specified keywords
 <br>the arithmetic mean of values in the keywords_positions array

```csharp
public Nullable<float> AvgPosition { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **MedianPosition**

the median position of the domain for the specified keywords
 <br>the median of the values in the keywords_positions array

```csharp
public Nullable<int> MedianPosition { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Rating**

the margin between the greatest possible and actual keyword positions
 <br>represents the relative visibility rate of the domain in SERP for the specified keywords
 <br>calculated as sum(100-keywords_positions)

```csharp
public Nullable<int> Rating { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Etv**

estimated traffic volume
 <br>represents the estimated monthly traffic that specified keywords are driving to the website
 <br>calculated as the sum of the products of the specified keywords’ search volume values and CTR (click-through-rate) rates at certain positions in SERP
 <br>learn more about how the metric is calculated in this help center article

```csharp
public Nullable<float> Etv { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **KeywordsCount**

the number of specified keywords the domain has positions for in SERPs

```csharp
public Nullable<long> KeywordsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Visibility**

SERP visibility rate
 <br>represents the website visibility rate based on the SERP positions of the specified keywords
 <br>Keywords with positions in the range from 1 to 10 are assigned the visibility index from 1 to 0.1, respectively
 <br>Keywords with positions in the range from 11 to 20 have the fixed visibility index of 0.05
 <br>keywords with positions from 20 to 100 have the visibility index equal to 0

```csharp
public Nullable<float> Visibility { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RelevantSerpItems**

the number of SERP elements relevant to the domain
 <br>represents the number of search results in SERP relevant to the domain for the specified keywords

```csharp
public Nullable<int> RelevantSerpItems { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **KeywordsPositions**

keyword positions
 <br>SERP positions the related domain holds in SERP for the specified keywords

```csharp
public IDictionary<string, ICollection<double>> KeywordsPositions { get; set; }
```

#### Property Value

[IDictionary&lt;String, ICollection&lt;Double&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **DataforseoLabsSerpCompetitorsLiveItem()**

```csharp
public DataforseoLabsSerpCompetitorsLiveItem()
```
