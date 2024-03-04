# RatingElement

Namespace: DataForSeo.Client.Models

```csharp
public class RatingElement
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RatingElement](./dataforseo.client.models.ratingelement.md)

## Properties

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Position**

the alignment of the element in Google Shopping SERP
 <br>possible values:
 <br>left, right

```csharp
public string Position { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RatingType**

the type of rating
 <br>here you can find the following elements: Max5, Percents, CustomMax

```csharp
public string RatingType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Value**

value of the rating

```csharp
public string Value { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **VotesCount**

the amount of feedback

```csharp
public Nullable<long> VotesCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RatingMax**

the maximum value for a rating_type

```csharp
public Nullable<int> RatingMax { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **RatingElement()**

```csharp
public RatingElement()
```
