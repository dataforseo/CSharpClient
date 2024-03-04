[`< Back`](./)

---

# OnPageContentParsingLiveRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class OnPageContentParsingLiveRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageContentParsingLiveRequestInfo](./dataforseo.client.models.requests.onpagecontentparsingliverequestinfo)

## Properties

### **Url**

URL of the content to parse
 <br>required field
 <br>URL of the page to parse
 <br>example:
 <br>https://www.fujielectric.com/

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **CustomUserAgent**

custom user agent
 <br>optional field
 <br>custom user agent for crawling a website
 <br>example: Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36
 <br><br>default value: Mozilla/5.0 (compatible; RSiteAuditor)

```csharp
public string CustomUserAgent { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **BrowserPreset**

preset for browser screen parameters
 <br>optional field
 <br>if you use this field, you don’t need to indicate browser_screen_width, browser_screen_height, browser_screen_scale_factor
 <br>possible values:
 <br>desktop, mobile, tablet
 <br>desktop preset will apply the following values:
 <br>browser_screen_width: 1920
 <br>browser_screen_height: 1080
 <br>browser_screen_scale_factor: 1
 <br>mobile preset will apply the following values:
 <br>browser_screen_width: 390
 <br>browser_screen_height: 844
 <br>browser_screen_scale_factor: 3
 <br>tablet preset will apply the following values:
 <br>browser_screen_width: 1024
 <br>browser_screen_height: 1366
 <br>browser_screen_scale_factor: 2
 <br>Note: to use this parameter, set enable_javascript or enable_browser_rendering to true

```csharp
public string BrowserPreset { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **BrowserScreenWidth**

browser screen width
 <br>optional field
 <br>you can set a custom browser screen width to perform audit for a particular device;
 <br>if you use this field, you don’t need to indicate browser_preset as it will be ignored;
 <br>Note: to use this parameter, set enable_javascript or enable_browser_rendering to true
 <br>minimum value, in pixels: 240
 <br>maximum value, in pixels: 9999

```csharp
public Nullable<long> BrowserScreenWidth { get; set; }
```

#### Property Value

[Nullable&lt;Int64&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BrowserScreenHeight**

browser screen height
 <br>optional field
 <br>you can set a custom browser screen height to perform audit for a particular device;
 <br>if you use this field, you don’t need to indicate browser_preset as it will be ignored;
 <br>Note: to use this parameter, set enable_javascript or enable_browser_rendering to true
 <br>minimum value, in pixels: 240
 <br>maximum value, in pixels: 9999

```csharp
public Nullable<int> BrowserScreenHeight { get; set; }
```

#### Property Value

[Nullable&lt;Int32&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **BrowserScreenScaleFactor**

browser screen scale factor
 <br>optional field
 <br>you can set a custom browser screen resolution ratio to perform audit for a particular device;
 <br>if you use this field, you don’t need to indicate browser_preset as it will be ignored;
 <br>Note: to use this parameter, set enable_javascript or enable_browser_rendering to true
 <br>minimum value: 0.5
 <br>maximum value: 3

```csharp
public Nullable<float> BrowserScreenScaleFactor { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **StoreRawHtml**

store HTML of a crawled page
 <br>optional field
 <br>set to true if you want to get the HTML of the page using the OnPage Raw HTML endpoint
 <br>default value: false

```csharp
public Nullable<bool> StoreRawHtml { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **DisableCookiePopup**

disable the cookie popup 
 <br>optional field
 <br>set to true if you want to disable the popup requesting cookie consent from the user;
 <br>default value:
 <br>false

```csharp
public Nullable<bool> DisableCookiePopup { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AcceptLanguage**

language header for accessing the website
 <br>optional field
 <br>all locale formats are supported (xx, xx-XX, xxx-XX, etc.)
 <br>Note: if you do not specify this parameter, some websites may deny access; in this case, pages will be returned with the "type":"broken in the response array

```csharp
public string AcceptLanguage { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **EnableJavascript**

load javascript on a page
 <br>optional field
 <br>set to true if you want to load the scripts available on a page
 <br>default value: false
 <br>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page

```csharp
public Nullable<bool> EnableJavascript { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **EnableBrowserRendering**

emulate browser rendering to measure Core Web Vitals
 <br>optional field
 <br>by using this parameter you will be able to emulate a browser when loading a web page;
 <br>enable_browser_rendering loads styles, images, fonts, animations, videos, and other resources on a page;
 <br>default value: false
 <br>set to true to obtain Core Web Vitals (FID, CLS, LCP) metrics in the response;
 <br>if you use this field, enable_javascript, and load_resources parameters must be set to true
 <br>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page

```csharp
public Nullable<bool> EnableBrowserRendering { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **EnableXhr**

enable XMLHttpRequest on a page
 <br>optional field
 <br>set to true if you want our crawler to request data from a web server using the XMLHttpRequest object
 <br>default value:
 <br>false
 <br>if you use this field, enable_javascript must be set to true;

```csharp
public Nullable<bool> EnableXhr { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPageContentParsingLiveRequestInfo()**

```csharp
public OnPageContentParsingLiveRequestInfo()
```

---

[`< Back`](./)
