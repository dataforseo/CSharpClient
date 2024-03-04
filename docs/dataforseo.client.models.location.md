# Location

Namespace: DataForSeo.Client.Models

```csharp
public class Location
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Location](./dataforseo.client.models.location.md)

## Properties

### **Neighborhood**

name of the neighborhood where the hotel is located

```csharp
public string Neighborhood { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **NeighborhoodDescription**

description of the neighborhood where the hotel is located

```csharp
public string NeighborhoodDescription { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MapsUrl**

url to the location of the hotel in google maps

```csharp
public string MapsUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **OverallScore**

overall score of the hotel location
 <br>indicates the overall score of the hotel’s location in the range from 1 to 5;
 <br>calculated based on data from the hotel’s proximity to nearby things to do and restaurants, transportation, and airports;
 <br>note that the criteria are not weighted equally in the overall score

```csharp
public Nullable<float> OverallScore { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ScoreByCategories**

category scores of the hotel location
 <br>the scores of the hotel’s location tied to the categories that indicate the proximity to nearby things to do, restaurants, transportation, and airports;

```csharp
public ScoreByCategories ScoreByCategories { get; set; }
```

#### Property Value

[ScoreByCategories](./dataforseo.client.models.scorebycategories.md)<br>

### **Latitude**

hotel latitude
 <br>latitude coordinates of the hotel’s location
 <br>example:
 <br>39.4806397

```csharp
public Nullable<float> Latitude { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Longitude**

hotel longitude
 <br>latitude coordinates of the hotel’s location
 <br>example:
 <br>-106.0512973

```csharp
public Nullable<float> Longitude { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **LocationChain**

elements of the location chain
 <br>additional parameters of each element of the location chain

```csharp
public ICollection<LocationChain> LocationChain { get; set; }
```

#### Property Value

[ICollection&lt;LocationChain&gt;](./dataforseo.client.models.locationchain.md)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **Location()**

```csharp
public Location()
```
