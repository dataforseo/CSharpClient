# RedditReviews

Namespace: DataForSeo.Client.Models

```csharp
public class RedditReviews
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [RedditReviews](./dataforseo.client.models.redditreviews.md)

## Properties

### **Subreddit**

the name of the subreddit

```csharp
public string Subreddit { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AuthorName**

nickname of the author
 <br>nicknname of the user who published the post in the subreddit and shared the URL

```csharp
public string AuthorName { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Title**

title of the subreddit post

```csharp
public string Title { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **Permalink**

URL to the subreddit post

```csharp
public string Permalink { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **SubredditMembers**

number of subreddit members

```csharp
public Nullable<int> SubredditMembers { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **RedditReviews()**

```csharp
public RedditReviews()
```
