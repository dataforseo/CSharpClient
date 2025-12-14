# AppendixApi

All URIs are relative to *https://api.dataforseo.com*

| Method | HTTP request | Description |
|------------- | ------------- | -------------|
[**userData**](AppendixApi.md#userData) | **GET**  /v3/appendix/user_data  |
[**errors**](AppendixApi.md#errors) | **GET**  /v3/appendix/errors  |
[**webhookResend**](AppendixApi.md#webhookResend) | **POST**  /v3/appendix/webhook_resend  |
[**appendixStatus**](AppendixApi.md#appendixStatus) | **GET**  /v3/appendix/status  |

<a id="userData"></a>
# **userData**
> AppendixUserDataResponseInfo userData()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppendixApi.UserDataAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppendixUserDataResponseInfo**](AppendixUserDataResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="errors"></a>
# **errors**
> AppendixErrorsResponseInfo errors()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppendixApi.ErrorsAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppendixErrorsResponseInfo**](AppendixErrorsResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="webhookResend"></a>
# **webhookResend**
> AppendixWebhookResendResponseInfo webhookResend()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppendixApi.WebhookResendAsync(
    new AppendixWebhookResendRequestInfo[]
    {
        new AppendixWebhookResendRequestInfo()
        {
            Id = "08161139-0001-0066-1000-06491d097ed5",
        },
    });
```

### Parameters

| Name | Type | Description  | Notes |
|------------- | ------------- | ------------- | -------------|
| **** | [**List&lt;IEnumerable<AppendixWebhookResendRequestInfo>&gt;**](IEnumerable<AppendixWebhookResendRequestInfo>.md)|  | [optional] |



### Return type

[**AppendixWebhookResendResponseInfo**](AppendixWebhookResendResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

<a id="appendixStatus"></a>
# **appendixStatus**
> AppendixStatusResponseInfo appendixStatus()


### Example
```csharp
var dfsClient = new DataForSeoClient(new DataForSeoClientConfiguration()
{
    Username = "USERNAME",
    Password = "PASSWORD",
});
var result = await dfsClient.AppendixApi.AppendixStatusAsync();
```

### Parameters


    
This endpoint does not need any parameter.
    


### Return type

[**AppendixStatusResponseInfo**](AppendixStatusResponseInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |