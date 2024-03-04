[`< Back`](./)

---

# OnPageResourceIssueItemInfo

Namespace: DataForSeo.Client.Models

```csharp
public class OnPageResourceIssueItemInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageResourceIssueItemInfo](./dataforseo.client.models.onpageresourceissueiteminfo)

## Properties

### **Line**

line where the error was found

```csharp
public Nullable<int> Line { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Column**

column where the error was found

```csharp
public Nullable<int> Column { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Message**

text message of the error
 <br>the full list of possible HTML errors can be found here

```csharp
public string Message { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **StatusCode**

status code of the error
 <br>possible values:
 <br>0 — Unidentified Error;
 <br>501 — Html Parse Error;
 <br>1501 — JS Parse Error;
 <br>2501 — CSS Parse Error;
 <br>3501 — Image Parse Error;
 <br>3502 — Image Scale Is Zero;
 <br>3503 — Image Size Is Zero;
 <br>3504 — Image Format Invalid

```csharp
public Nullable<int> StatusCode { get; set; }
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

### **OnPageResourceIssueItemInfo()**

```csharp
public OnPageResourceIssueItemInfo()
```

---

[`< Back`](./)
