# Finbourne.Identity.Sdk.Model.LogUserAgent
Represents a LogUserAgent resource in the Okta API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RawUserAgent** | **string** |  | [optional] 
**VarOperatingSystem** | **string** |  | [optional] 
**Browser** | **string** |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string rawUserAgent = "example rawUserAgent";
string varOperatingSystem = "example varOperatingSystem";
string browser = "example browser";

LogUserAgent logUserAgentInstance = new LogUserAgent(
    rawUserAgent: rawUserAgent,
    varOperatingSystem: varOperatingSystem,
    browser: browser);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
