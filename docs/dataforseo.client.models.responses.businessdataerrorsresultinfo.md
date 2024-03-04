[`< Back`](./)

---

# BusinessDataErrorsResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class BusinessDataErrorsResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BusinessDataErrorsResultInfo](./dataforseo.client.models.responses.businessdataerrorsresultinfo)

## Properties

### **Id**

id of the task

```csharp
public string Id { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Datetime**

date and time when an error occurred
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string Datetime { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Function**

corresponding API function

```csharp
public string Function { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ErrorCode**

error code

```csharp
public Nullable<int> ErrorCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ErrorMessage**

error message or error URL
 <br>error message (see full list) or URL that caused an error

```csharp
public string ErrorMessage { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **HttpUrl**

URL that caused an error
 <br>URL you used for making an API call or pingback/postback URL

```csharp
public string HttpUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **HttpMethod**

HTTP method

```csharp
public string HttpMethod { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **HttpCode**

HTTP status code

```csharp
public Nullable<int> HttpCode { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **HttpTime**

time taken by HTTP request
 <br>for tasks set with a pingback/postback, this field will show the time it took your server to respond

```csharp
public Nullable<float> HttpTime { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **HttpResponse**

HTTP response
 <br>server response

```csharp
public string HttpResponse { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **BusinessDataErrorsResultInfo()**

```csharp
public BusinessDataErrorsResultInfo()
```

---

[`< Back`](./)
