# MerchantGoogleSellersAdUrlResultInfo

Namespace: DataForSeo.Client.Models.Responses

```csharp
public class MerchantGoogleSellersAdUrlResultInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [MerchantGoogleSellersAdUrlResultInfo](./dataforseo.client.models.responses.merchantgooglesellersadurlresultinfo.md)

## Properties

### **AdAclk**

unique ad click referral parameter

```csharp
public string AdAclk { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdUrl**

full URL of the advertisement

```csharp
public string AdUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AdUrlRedirects**

URLs where the link from Google Shopping redirects before reaching a final URL
 <br>includes up to 10 URLs of the ad’s redirect path to the seller’s ad_url

```csharp
public ICollection<string> AdUrlRedirects { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **MerchantGoogleSellersAdUrlResultInfo()**

```csharp
public MerchantGoogleSellersAdUrlResultInfo()
```
