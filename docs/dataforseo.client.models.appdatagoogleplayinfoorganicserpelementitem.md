# AppDataGooglePlayInfoOrganicSerpElementItem

Namespace: DataForSeo.Client.Models

```csharp
public class AppDataGooglePlayInfoOrganicSerpElementItem : BaseAppDataSerpElementItem
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [BaseAppDataSerpElementItem](./dataforseo.client.models.baseappdataserpelementitem.md) → [AppDataGooglePlayInfoOrganicSerpElementItem](./dataforseo.client.models.appdatagoogleplayinfoorganicserpelementitem.md)

## Properties

### **RankGroup**

position within a group of elements with identical type values
 <br>positions of elements with different type values are omitted from rank_group

```csharp
public Nullable<int> RankGroup { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **RankAbsolute**

absolute rank among all the listed apps
 <br>absolute position among all apps on the list

```csharp
public Nullable<int> RankAbsolute { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Position**

the alignment of the element in SERP
 <br>can take the following values: left

```csharp
public string Position { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AppId**

ID of the app

```csharp
public string AppId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the app

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Url**

URL to the app page on Google Play

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Icon**

URL to the app icon

```csharp
public string Icon { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Description**

description of the app

```csharp
public string Description { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ReviewsCount**

the total number of reviews the app has

```csharp
public Nullable<long> ReviewsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Rating**

average rating of the app

```csharp
public RatingInfo Rating { get; set; }
```

#### Property Value

[RatingInfo](./dataforseo.client.models.ratinginfo.md)<br>

### **Price**

price of the app

```csharp
public PriceInfo Price { get; set; }
```

#### Property Value

[PriceInfo](./dataforseo.client.models.priceinfo.md)<br>

### **IsFree**

indicates whether the app is free

```csharp
public Nullable<bool> IsFree { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **MainCategory**

main category of the app

```csharp
public string MainCategory { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Installs**

number of installs of the app
 <br>approximate number of installs as displayed on the app page

```csharp
public string Installs { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **InstallsCount**

number of installs of the app
 <br>the exact number of installs of the app

```csharp
public Nullable<long> InstallsCount { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **Developer**

name of the app developer

```csharp
public string Developer { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DeveloperId**

ID of the app developer

```csharp
public string DeveloperId { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DeveloperUrl**

URL to the developer page on Google Play

```csharp
public string DeveloperUrl { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DeveloperEmail**

email address of the developer

```csharp
public string DeveloperEmail { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DeveloperAddress**

physical address of the developer

```csharp
public string DeveloperAddress { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **DeveloperWebsite**

official website of the developer

```csharp
public string DeveloperWebsite { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Version**

current version of the app

```csharp
public string Version { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **MinimumOsVersion**

minimum OS version required to install the app

```csharp
public string MinimumOsVersion { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Size**

size of the app

```csharp
public string Size { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ReleasedDate**

date and time when the app was released
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string ReleasedDate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **LastUpdateDate**

date and time when the app was last updated
 <br>in the UTC format: “yyyy-mm-dd hh-mm-ss +00:00”;
 <br>example:
 <br>2019-11-15 12:57:46 +00:00

```csharp
public string LastUpdateDate { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **UpdateNotes**

update notes
 <br>contains the latest update notes from the developer

```csharp
public string UpdateNotes { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Images**

app images
 <br>contains URLs to the images published on the app page on Google Play

```csharp
public ICollection<string> Images { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Videos**

app videos
 <br>contains URLs to the video published on the app page on Google Play

```csharp
public ICollection<string> Videos { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **SimilarApps**

similar apps
 <br>displays apps similar to the app in a POST request

```csharp
public ICollection<AppsInfo> SimilarApps { get; set; }
```

#### Property Value

[ICollection&lt;AppsInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **MoreAppsByDeveloper**

similar apps
 <br>information about apps built by the same developer

```csharp
public ICollection<AppsInfo> MoreAppsByDeveloper { get; set; }
```

#### Property Value

[ICollection&lt;AppsInfo&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Genres**

app genres
 <br>contains relevant app categories

```csharp
public ICollection<string> Genres { get; set; }
```

#### Property Value

[ICollection&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1)<br>

### **Tags**

app tags
 <br>contains relevant app tags

```csharp
public ICollection<string> Tags { get; set; }
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

### **AppDataGooglePlayInfoOrganicSerpElementItem()**

```csharp
public AppDataGooglePlayInfoOrganicSerpElementItem()
```
