# ApiException&lt;TResult&gt;

Namespace: DataForSeo.Client.Models

```csharp
public class ApiException<TResult> : ApiException, System.Runtime.Serialization.ISerializable
```

#### Type Parameters

`TResult`<br>

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/Object) → [Exception](https://docs.microsoft.com/en-us/dotnet/api/Exception) → [ApiException](./ApiException.md) → [ApiException&lt;TResult&gt;](./ApiException-1.md)<br>
Implements [ISerializable](https://docs.microsoft.com/en-us/dotnet/api/ISerializable)

## Properties

### **Result**

```csharp
public TResult Result { get; private set; }
```

#### Property Value

TResult<br>

### **StatusCode**

```csharp
public int StatusCode { get; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/Int32)<br>

### **Response**

```csharp
public string Response { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>

### **Headers**

```csharp
public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;String, IEnumerable&lt;String&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]])<br>

### **TargetSite**

```csharp
public MethodBase TargetSite { get; }
```

#### Property Value

[MethodBase](https://docs.microsoft.com/en-us/dotnet/api/MethodBase)<br>

### **Message**

```csharp
public string Message { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>

### **Data**

```csharp
public IDictionary Data { get; }
```

#### Property Value

[IDictionary](https://docs.microsoft.com/en-us/dotnet/api/IDictionary)<br>

### **InnerException**

```csharp
public Exception InnerException { get; }
```

#### Property Value

[Exception](https://docs.microsoft.com/en-us/dotnet/api/Exception)<br>

### **HelpLink**

```csharp
public string HelpLink { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>

### **Source**

```csharp
public string Source { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>

### **HResult**

```csharp
public int HResult { get; set; }
```

#### Property Value

[Int32](https://docs.microsoft.com/en-us/dotnet/api/Int32)<br>

### **StackTrace**

```csharp
public string StackTrace { get; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>

## Constructors

### **ApiException(String, Int32, String, IReadOnlyDictionary&lt;String, IEnumerable&lt;String&gt;&gt;, TResult, Exception)**

```csharp
public ApiException(string message, int statusCode, string response, IReadOnlyDictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
```

#### Parameters

`message` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>

`statusCode` [Int32](https://docs.microsoft.com/en-us/dotnet/api/Int32)<br>

`response` [String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>

`headers` [IReadOnlyDictionary&lt;String, IEnumerable&lt;String&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]])<br>

`result` TResult<br>

`innerException` [Exception](https://docs.microsoft.com/en-us/dotnet/api/Exception)<br>
