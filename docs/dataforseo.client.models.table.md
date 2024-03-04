[`< Back`](./)

---

# Table

Namespace: DataForSeo.Client.Models

```csharp
public class Table
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [Table](./dataforseo.client.models.table)

## Properties

### **TableElement**

name assigned to the table element
 <br>possible values:
 <br>table_element

```csharp
public string TableElement { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **TableHeader**

column names

```csharp
public ICollection<string> TableHeader { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **TableContent**

the content of the table
 <br>one line of the table in this element of the array

```csharp
public ICollection<ICollection<string>> TableContent { get; set; }
```

#### Property Value

[ICollection&lt;ICollection&lt;String&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **Table()**

```csharp
public Table()
```

---

[`< Back`](./)
