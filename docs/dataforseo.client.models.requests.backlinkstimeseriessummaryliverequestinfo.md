[`< Back`](./)

---

# BacklinksTimeseriesSummaryLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class BacklinksTimeseriesSummaryLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BacklinksTimeseriesSummaryLiveRequestInfo](./dataforseo.client.models.requests.backlinkstimeseriessummaryliverequestinfo)

## Properties

### **Target**

domain to get data for
 <br>required field
 <br>a domain should be specified without https:// and www.
 <br>example:
 <br>"forbes.com"

```csharp
public string Target { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateFrom**

starting date of the time range
 <br>optional field
 <br>this field indicates the date which will be used as a threshold for summary data;
 <br>minimum value: 2019-01-30
 <br>maximum value shouldn’t exceed the date specified in the date_to
 <br>date format: "yyyy-mm-dd"
 <br>example:
 <br>"2021-01-01"

```csharp
public string DateFrom { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DateTo**

ending date of the time range
 <br>optional field
 <br>if you don’t specify this field, the today’s date will be used by default
 <br>minimum value shouldn’t preceed the date specified in the date_from
 <br>maximum value: today’s date
 <br>date format: "yyyy-mm-dd"
 <br>example:
 <br>"2021-01-15"

```csharp
public string DateTo { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **GroupRange**

time range which will be used to group the results
 <br>optional field
 <br>default value: month
 <br>possible values: day, week, month, year
 <br>note: for day, we will return items corresponding to all dates between and including date_from and date_to;
 <br>for week/month/year, we will return items corresponding to full weeks/months/years, where each item will indicate the last day of the week/month/year
 <br>for example, if you specify:
 <br>"group_range": "month",
 <br>"date_from": "2022-03-23",
 <br>"date_to": "2022-05-13"
 <br>we will return items falling between 2022-03-01 and 2022-05-31, namely, three items corresponding to the following dates: 2022-03-31, 2022-04-30, 2022-05-31
 <br>if there is no data for a certain day/week/month/year, we will return 0

```csharp
public string GroupRange { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Tag**

user-defined task identifier
 <br>optional field
 <br>the character limit is 255
 <br>you can use this parameter to identify the task and match it with the result
 <br>you will find the specified tag value in the data object of the response

```csharp
public string Tag { get; set; }
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

### **BacklinksTimeseriesSummaryLiveRequestInfo()**

```csharp
public BacklinksTimeseriesSummaryLiveRequestInfo()
```

---

[`< Back`](./)
