[`< Back`](./)

---

# OnPageInstantPagesRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class OnPageInstantPagesRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPageInstantPagesRequestInfo](./dataforseo.client.models.requests.onpageinstantpagesrequestinfo)

## Properties

### **Url**

target page url
 <br>required field
 <br>absolute URL of the target page
 <br>Note: results will be returned for the specified URL only
 <br>Note: to prevent denial-of-service events, tasks that contain a duplicate crawl host will be returned with a 40501 error;
 <br>to prevent this error from occuring, avoid setting tasks with the same domain if at least one of your previous tasks with this domain (including a page URL on the domain) is still in a crawling queue

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
 <br>if you use this field, you don’t need to indicate browser_screen_width, browser_screen_height, browser_screen_scale_factorpossible values:
 <br>desktop, mobile, tabletdesktop preset will apply the following values:
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
 <br>if you use this field, you don’t need to indicate browser_preset as it will be ignored;Note: to use this parameter, set enable_javascript or enable_browser_rendering to trueminimum value, in pixels: 240
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
 <br>if you use this field, you don’t need to indicate browser_preset as it will be ignored;Note: to use this parameter, set enable_javascript or enable_browser_rendering to trueminimum value, in pixels: 240
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
 <br>if you use this field, you don’t need to indicate browser_preset as it will be ignored;Note: to use this parameter, set enable_javascript or enable_browser_rendering to trueminimum value: 0.5
 <br>maximum value: 3

```csharp
public Nullable<float> BrowserScreenScaleFactor { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **StoreRawHtml**

store HTML of a crawled page
 <br>optional field
 <br>set to true if you want get the HTML of the page using the OnPage Raw HTML endpoint
 <br>default value: false

```csharp
public Nullable<bool> StoreRawHtml { get; set; }
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

### **ReturnDespiteTimeout**

return data on pages despite the timeout error
 <br>optional field
 <br>if true, the data will be provided on pages that failed to load within 120 seconds and responded with a timeout error;
 <br>default value: false

```csharp
public Nullable<bool> ReturnDespiteTimeout { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **EnableXhr**

enable XMLHttpRequest on a page
 <br>optional field
 <br>set to true if you want our crawler to request data from a web server using the XMLHttpRequest object
 <br>default value:
 <br>falseif you use this field, enable_javascript must be set to true;

```csharp
public Nullable<bool> EnableXhr { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CustomJs**

custom javascript
 <br>optional fieldNote that the execution time for the script you enter here should be 700 ms maximumfor example, you can use the following JS snippet to check if the website contains Google Tag Manager as a scr attribute:
 <br>let meta = { haveGoogleAnalytics: false, haveTagManager: false };\r\nfor (var i = 0; i &lt; document.scripts.length; i++) {\r\n let src = document.scripts[i].getAttribute(\"src\");\r\n if (src != undefined) {\r\n if (src.indexOf(\"analytics.js\") &gt;= 0)\r\n meta.haveGoogleAnalytics = true;\r\n\tif (src.indexOf(\"gtm.js\") &gt;= 0)\r\n meta.haveTagManager = true;\r\n }\r\n}\r\nmeta;the returned value depends on what you specified in this field. For instance, if you specify the following script:
 <br>meta = {}; meta.url = document.URL; meta.test = 'test'; meta;
 <br>as a response you will receive the following data:
 <br>"custom_js_response": {
 <br>"url": "https://dataforseo.com/",
 <br>"test": "test"
 <br>}
 <br>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page

```csharp
public string CustomJs { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **ValidateMicromarkup**

enable microdata validation
 <br>optional field
 <br>if set to true, you can use the OnPage API Microdata endpoint with the id of the task;
 <br>default value: false

```csharp
public Nullable<bool> ValidateMicromarkup { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **CheckSpell**

check spelling
 <br>optional field
 <br>set to true to check spelling on a website using Hunspell library
 <br>default value: false

```csharp
public Nullable<bool> CheckSpell { get; set; }
```

#### Property Value

[Nullable&lt;Boolean&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **ChecksThreshold**

custom threshold values for checks
 <br>optional field
 <br>you can specify custom threshold values for the parameters included in the checks array of OnPage API responses;
 <br>Note: only integer threshold values can be modified;

```csharp
public IDictionary<string, Nullable<long>> ChecksThreshold { get; set; }
```

#### Property Value

[IDictionary&lt;String, Nullable&lt;Int64&gt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

### **AdditionalProperties**

```csharp
public IDictionary<string, object> AdditionalProperties { get; set; }
```

#### Property Value

[IDictionary&lt;String, Object&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2)<br>

## Constructors

### **OnPageInstantPagesRequestInfo()**

```csharp
public OnPageInstantPagesRequestInfo()
```

---

[`< Back`](./)
