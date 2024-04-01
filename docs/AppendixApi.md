# AppendixApi

Namespace: DataForSeo.Client.Api

```csharp
public class AppendixApi
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/Object) → [AppendixApi](./AppendixApi.md)

## Properties

### **BaseUrl**

```csharp
public string BaseUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/String)<br>

### **ReadResponseAsString**

```csharp
public bool ReadResponseAsString { get; set; }
```

#### Property Value

[Boolean](https://docs.microsoft.com/en-us/dotnet/api/Boolean)<br>

## Constructors

### **AppendixApi(HttpClient)**

```csharp
public AppendixApi(HttpClient httpClient)
```

#### Parameters

`httpClient` HttpClient<br>

## Methods

### **UserDataAsync()**

```csharp
public Task<AppendixUserDataResponseInfo> UserDataAsync()
```

#### Returns

[Task&lt;AppendixUserDataResponseInfo&gt;](./AppendixUserDataResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive detailed information about your API usage, prices, spending and other account details by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/appendix/user_data/?bash'

### **UserDataAsync(CancellationToken)**

```csharp
public Task<AppendixUserDataResponseInfo> UserDataAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppendixUserDataResponseInfo&gt;](./AppendixUserDataResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

You will receive detailed information about your API usage, prices, spending and other account details by calling this API.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/appendix/user_data/?bash'

### **AppendixErrorsAsync()**

```csharp
public Task<AppendixErrorsResponseInfo> AppendixErrorsAsync()
```

#### Returns

[Task&lt;AppendixErrorsResponseInfo&gt;](./AppendixErrorsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint returns a list of possible DataForSEO API errors and general status codes. Below you will find a list of HTTP response codes and internal messages. We recommend storing the data connected to error codes in your application log and designing a necessary system for handling related exceptional or error conditions.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/appendix/errors/?bash'

### **AppendixErrorsAsync(CancellationToken)**

```csharp
public Task<AppendixErrorsResponseInfo> AppendixErrorsAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppendixErrorsResponseInfo&gt;](./AppendixErrorsResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

This endpoint returns a list of possible DataForSEO API errors and general status codes. Below you will find a list of HTTP response codes and internal messages. We recommend storing the data connected to error codes in your application log and designing a necessary system for handling related exceptional or error conditions.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/appendix/errors/?bash'

### **WebhookResendAsync(IEnumerable&lt;AppendixWebhookResendRequestInfo&gt;)**

```csharp
public Task<AppendixWebhookResendResponseInfo> WebhookResendAsync(IEnumerable<AppendixWebhookResendRequestInfo> body)
```

#### Parameters

`body` [IEnumerable&lt;AppendixWebhookResendRequestInfo&gt;](./AppendixWebhookResendRequestInfo.md)<br>

#### Returns

[Task&lt;AppendixWebhookResendResponseInfo&gt;](./AppendixWebhookResendResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Using this endpoint you can resend webhooks (pingbacks and postbacks) for up to 100 specified tasks.
 <br>Note: Your account will not be double-charged for resending a webhook.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/appendix/webhook_resend/?bash'

### **WebhookResendAsync(IEnumerable&lt;AppendixWebhookResendRequestInfo&gt;, CancellationToken)**

```csharp
public Task<AppendixWebhookResendResponseInfo> WebhookResendAsync(IEnumerable<AppendixWebhookResendRequestInfo> body, CancellationToken cancellationToken)
```

#### Parameters

`body` [IEnumerable&lt;AppendixWebhookResendRequestInfo&gt;](./AppendixWebhookResendRequestInfo.md)<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppendixWebhookResendResponseInfo&gt;](./AppendixWebhookResendResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

Using this endpoint you can resend webhooks (pingbacks and postbacks) for up to 100 specified tasks.
 <br>Note: Your account will not be double-charged for resending a webhook.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/appendix/webhook_resend/?bash'

### **AppendixStatusAsync()**

```csharp
public Task<AppendixStatusResponseInfo> AppendixStatusAsync()
```

#### Returns

[Task&lt;AppendixStatusResponseInfo&gt;](./AppendixStatusResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this API you will receive detailed information about the current status of all our APIs and endpoints. You will also get a full issue description if a problem occurs.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/appendix/status/?bash'

### **AppendixStatusAsync(CancellationToken)**

```csharp
public Task<AppendixStatusResponseInfo> AppendixStatusAsync(CancellationToken cancellationToken)
```

#### Parameters

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>
A cancellation token that can be used by other objects or threads to receive notice of cancellation.

#### Returns

[Task&lt;AppendixStatusResponseInfo&gt;](./AppendixStatusResponseInfo.md)<br>
Successful operation

#### Exceptions

[ApiException](./ApiException.md)<br>
A server side error occurred.

**Remarks:**

By calling this API you will receive detailed information about the current status of all our APIs and endpoints. You will also get a full issue description if a problem occurs.
 <br>for more info please visit 'https://docs.dataforseo.com/v3/appendix/status/?bash'

### **ReadObjectResponseAsync&lt;T&gt;(HttpResponseMessage, IReadOnlyDictionary&lt;String, IEnumerable&lt;String&gt;&gt;, CancellationToken)**

```csharp
protected Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
```

#### Type Parameters

`T`<br>

#### Parameters

`response` HttpResponseMessage<br>

`headers` [IReadOnlyDictionary&lt;String, IEnumerable&lt;String&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]])<br>

`cancellationToken` [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/CancellationToken)<br>

#### Returns

Task&lt;ObjectResponseResult&lt;T&gt;&gt;<br>
