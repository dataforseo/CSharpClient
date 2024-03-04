[`< Back`](./)

---

# ContentGenerationCheckGrammarLiveItem

Namespace: DataForSeo.Client.Models

```csharp
public class ContentGenerationCheckGrammarLiveItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [ContentGenerationCheckGrammarLiveItem](./dataforseo.client.models.contentgenerationcheckgrammarliveitem)

## Properties

### **Message**

message of the grammar or spelling error

```csharp
public string Message { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Description**

description of the grammar or spelling error

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Suggestions**

suggested corrections

```csharp
public ICollection<string> Suggestions { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Offset**

offset token for subsequent requests

```csharp
public Nullable<int> Offset { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Length**

offset token for subsequent requests

```csharp
public Nullable<int> Length { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Type**

type of element

```csharp
public string Type { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RuleId**

id of the grammar or spelling rule
 <br>see the List of Grammar Rules for Content Generation API

```csharp
public string RuleId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RuleDescription**

description of the grammar or spelling rule

```csharp
public string RuleDescription { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RuleIssueType**

type of the issue found by the relevant rule

```csharp
public string RuleIssueType { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RuleCategoryId**

id of the rule category

```csharp
public string RuleCategoryId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **RuleCategoryName**

name of the rule category

```csharp
public string RuleCategoryName { get; set; }
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

### **ContentGenerationCheckGrammarLiveItem()**

```csharp
public ContentGenerationCheckGrammarLiveItem()
```

---

[`< Back`](./)
