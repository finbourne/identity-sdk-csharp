# Finbourne.Identity.Sdk.Model.LogSecurityContext
Represents a LogSecurityContext resource in the Okta API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsNumber** | **int?** |  | [optional] 
**AsOrg** | **string** |  | [optional] 
**Isp** | **string** |  | [optional] 
**Domain** | **string** |  | [optional] 
**IsProxy** | **bool?** |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string asOrg = "example asOrg";
string isp = "example isp";
string domain = "example domain";
bool? isProxy = //"True";

LogSecurityContext logSecurityContextInstance = new LogSecurityContext(
    asNumber: asNumber,
    asOrg: asOrg,
    isp: isp,
    domain: domain,
    isProxy: isProxy);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
