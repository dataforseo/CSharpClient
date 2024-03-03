# OnPagePageScreenshotRequestInfo

Namespace: DataForSeo.Client.Models.Requests

```csharp
public class OnPagePageScreenshotRequestInfo
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [OnPagePageScreenshotRequestInfo](./dataforseo.client.models.requests.onpagepagescreenshotrequestinfo.md)

## Properties

### **Url**

page url
 <br>required field
 <br>absolute URL of the page to snap
 <br>note: if the URL you indicate here returns a 404 status code or the indicated value is not a valid URL, you will obtain "error_message":"Screenshot is empty" in the response array

```csharp
public string Url { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **AcceptLanguage**

language header for accessing the website
 <br>optional field
 <br>all locale formats are supported (xx, xx-XX, xxx-XX, etc.)
 <br>note: if you do not specify this parameter, some websites may deny access; in this case, you will obtain "error_message":"Screenshot is empty" in the response array

```csharp
public string AcceptLanguage { get; set; }
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
 <br>minimum value: 0.5
 <br>maximum value: 3

```csharp
public Nullable<float> BrowserScreenScaleFactor { get; set; }
```

#### Property Value

[Nullable&lt;Single&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **FullPageScreenshot**

take a screenshot of the full page
 <br>optional field
 <br>set to false if you want to capture only the part of the page displayed before scrolling
 <br>default value: true

```csharp
public Nullable<bool> FullPageScreenshot { get; set; }
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

### **CustomJs**

custom javascript
 <br>optional field
 <br>Note that the execution time for the script you enter here should be 700 ms maximum
 <br>for example, you can use the following JS snippet to check if the website contains Google Tag Manager as a scr attribute:
 <br>let meta = { haveGoogleAnalytics: false, haveTagManager: false };\r\nfor (var i = 0; i &lt; document.scripts.length; i++) {\r\n let src = document.scripts[i].getAttribute(\"src\");\r\n if (src != undefined) {\r\n if (src.indexOf(\"analytics.js\") &gt;= 0)\r\n meta.haveGoogleAnalytics = true;\r\n\tif (src.indexOf(\"gtm.js\") &gt;= 0)\r\n meta.haveTagManager = true;\r\n }\r\n}\r\nmeta;
 <br>the returned value depends on what you specified in this field. For instance, if you specify the following script:
 <br>meta = {}; meta.url = document.URL; meta.test = 'test'; meta;
 <br>as a response you will receive the following data:
 <br>"custom_js_response": {
 <br> "url": "https://dataforseo.com/",
 <br> "test": "test"
 <br>}
 <br>Note: if you use this parameter, additional charges will apply; learn more about the cost of tasks with this parameter in our help article; the cost can be calculated on the Pricing Page

```csharp
public string CustomJs { get; set; }
```

#### Property Value

[String](https://docs.microsoft.com/en-us/dotnet/api/system.string)<br>

### **IpPoolForScan**

proxy pool
 <br>optional field
 <br>you can choose a location of the proxy pool that will be used to obtain the requested data;
 <br>the parameter can be used if page content is inaccessible in one of the locations, resulting in occasional site_unreachable errors
 <br>possible values: us, de

```csharp
public string IpPoolForScan { get; set; }
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

### **OnPagePageScreenshotRequestInfo()**

```csharp
public OnPagePageScreenshotRequestInfo()
```
