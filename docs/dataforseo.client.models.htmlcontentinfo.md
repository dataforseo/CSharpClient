[`< Back`](./)

---

# HtmlContentInfo

Namespace: DataForSeo.Client.Models

```csharp
public class HtmlContentInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [HtmlContentInfo](./dataforseo.client.models.htmlcontentinfo)

## Properties

### **PlainTextSize**

total size of the text on the page measured in bytes

```csharp
public Nullable<int> PlainTextSize { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PlainTextRate**

plaintext rate value
 <br>plain_text_size to size ratio

```csharp
public Nullable<double> PlainTextRate { get; set; }
```

#### Property Value

[Nullable&lt;Double&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **PlainTextWordCount**

number of words on the page

```csharp
public Nullable<float> PlainTextWordCount { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AutomatedReadabilityIndex**

Automated Readability Index

```csharp
public Nullable<float> AutomatedReadabilityIndex { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ColemanLiauReadabilityIndex**

Coleman–Liau Index

```csharp
public Nullable<float> ColemanLiauReadabilityIndex { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DaleChallReadabilityIndex**

Dale–Chall Readability Index

```csharp
public Nullable<float> DaleChallReadabilityIndex { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FleschKincaidReadabilityIndex**

Flesch–Kincaid Readability Index

```csharp
public Nullable<float> FleschKincaidReadabilityIndex { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **SmogReadabilityIndex**

SMOG Readability Index

```csharp
public Nullable<float> SmogReadabilityIndex { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DescriptionToContentConsistency**

consistency of the meta description tag with the page content
 <br>measured from 0 to 1

```csharp
public Nullable<float> DescriptionToContentConsistency { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **TitleToContentConsistency**

consistency of the meta title tag with the page content
 <br>measured from 0 to 1

```csharp
public Nullable<float> TitleToContentConsistency { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **MetaKeywordsToContentConsistency**

consistency of meta keywordstag with the page content
 <br>measured from 0 to 1

```csharp
public Nullable<float> MetaKeywordsToContentConsistency { get; set; }
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

### **HtmlContentInfo()**

```csharp
public HtmlContentInfo()
```

---

[`< Back`](./)
