[`< Back`](./)

---

# SslInfo

Namespace: DataForSeo.Client.Models

```csharp
public class SslInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [SslInfo](./dataforseo.client.models.sslinfo)

## Properties

### **ValidCertificate**

ssl certificate validity
 <br>indicates whether the ssl certificate detected on a website is not expired, suspended, revoked or invalid

```csharp
public Nullable<bool> ValidCertificate { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CertificateIssuer**

ssl certificate authority
 <br>the entity that issued the detected ssl certificate

```csharp
public string CertificateIssuer { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CertificateSubject**

ssl certificate subject
 <br>the entity associated with the public key

```csharp
public string CertificateSubject { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CertificateVersion**

ssl certificate version
 <br>indicates the version of X.509 used by an ssl certificate

```csharp
public string CertificateVersion { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CertificateHash**

ssl certificate hash
 <br>the version of the ssl certificate’s hash function

```csharp
public string CertificateHash { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CertificateExpirationDate**

ssl certificate expiration date
 <br>the date and time when the ssl certificate expires
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string CertificateExpirationDate { get; set; }
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

### **SslInfo()**

```csharp
public SslInfo()
```

---

[`< Back`](./)
