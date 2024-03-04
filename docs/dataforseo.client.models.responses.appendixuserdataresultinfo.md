[`< Back`](./)

---

# AppendixUserDataResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class AppendixUserDataResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [AppendixUserDataResultInfo](./dataforseo.client.models.responses.appendixuserdataresultinfo)

## Properties

### **Login**

your login

```csharp
public string Login { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Timezone**

your time zone
 <br>can be set in your profile settings

```csharp
public string Timezone { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Rates**

your API rates

```csharp
public AppendixRatesData Rates { get; set; }
```

#### Property Value

[AppendixRatesData](./dataforseo.client.models.appendixratesdata)<br>

### **Money**

section of your spending, USD

```csharp
public AppendixMoneyData Money { get; set; }
```

#### Property Value

[AppendixMoneyData](./dataforseo.client.models.appendixmoneydata)<br>

### **Price**

pricing

```csharp
public AppendixPriceData Price { get; set; }
```

#### Property Value

[AppendixPriceData](./dataforseo.client.models.appendixpricedata)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **AppendixUserDataResultInfo()**

```csharp
public AppendixUserDataResultInfo()
```

---

[`< Back`](./)
