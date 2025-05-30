# StoresCountInfo


## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
**Count** | **double?** | number of stores that offer the product |[optional]|
**DisplayedText** | **string** | text displayed on the Google Shopping page |[optional]|
**CountFromText** | **bool?** | whether the number of stores is taken from text<br>indicates whether the number of stores is taken from displayed_text;<br>if the API finds the exact number of stores in the HTML code of the Google Shopping page, this parameter is false;<br>if the API cannot find the number of stores in the HTML code of the page, it takes the number from the displayed_text;<br>in this case, the parameter is true |[optional]|