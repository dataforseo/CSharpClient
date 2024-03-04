[`< Back`](./)

---

# ScoreByCategories

Namespace: DataForSeo.Client.Models

```csharp
public class ScoreByCategories
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ScoreByCategories](./dataforseo.client.models.scorebycategories)

## Properties

### **Overall**

overall score of the hotel location
 <br>indicates the overall score of the hotel’s location in the range from 1 to 5;
 <br>calculated based on data from the hotel’s proximity to nearby things to do and restaurants, transportation, and airports;
 <br>note that the criteria are not weighted equally in the overall score

```csharp
public Nullable<float> Overall { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ThingsToDo**

score relative to nearby things to do
 <br>indicates the score of the hotel’s location in the range from 1 to 5;
 <br>calculated based on data from the hotel’s proximity to nearby things to do

```csharp
public Nullable<float> ThingsToDo { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Restaurants**

score relative to nearby restaurants
 <br>indicates the score of the hotel’s location in the range from 1 to 5;
 <br>calculated based on data from the hotel’s proximity to nearby restaurants

```csharp
public Nullable<float> Restaurants { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Transit**

score relative to nearby transit options
 <br>indicates the score of the hotel’s location in the range from 1 to 5;
 <br>calculated based on data from the hotel’s proximity to nearby transit options

```csharp
public Nullable<float> Transit { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AirportAccess**

score relative to nearby airports
 <br>indicates the score of the hotel’s location in the range from 1 to 5;
 <br>calculated based on data from the hotel’s proximity to nearby airports

```csharp
public Nullable<float> AirportAccess { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **ScoreByCategories()**

```csharp
public ScoreByCategories()
```

---

[`< Back`](./)
