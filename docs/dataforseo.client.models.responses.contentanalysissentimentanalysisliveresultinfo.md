# ContentAnalysisSentimentAnalysisLiveResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class ContentAnalysisSentimentAnalysisLiveResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentAnalysisSentimentAnalysisLiveResultInfo](./dataforseo.client.models.responses.contentanalysissentimentanalysisliveresultinfo.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **PositiveConnotationDistribution**

citation distribution by sentiment connotation types
 <br>contains objects with citation counts and relevant data distributed by types of sentiments (sentiment polarity);
 <br>possible sentiment connotation types: positive, negative, neutral

```csharp
public PositiveConnotationDistribution PositiveConnotationDistribution { get; set; }
```

#### Property Value

[PositiveConnotationDistribution](./dataforseo.client.models.positiveconnotationdistribution.md)<br>

### **SentimentConnotationDistribution**

citation distribution by sentiment connotations
 <br>contains objects with citation counts and relevant data distributed by sentiments (emotional reactions);
 <br>possible sentiment connotation types: anger, happiness, love, sadness, share, fun

```csharp
public SentimentConnotationDistribution SentimentConnotationDistribution { get; set; }
```

#### Property Value

[SentimentConnotationDistribution](./dataforseo.client.models.sentimentconnotationdistribution.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **ContentAnalysisSentimentAnalysisLiveResultInfo()**

```csharp
public ContentAnalysisSentimentAnalysisLiveResultInfo()
```
