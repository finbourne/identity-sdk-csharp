# Finbourne.Identity.Sdk.Model.LogIpChainEntry
Represents a LogIpChainEntry resource in the Okta API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ip** | **string** |  | [optional] 
**GeographicalContext** | [**LogGeographicalContext**](LogGeographicalContext.md) |  | [optional] 
**VarVersion** | **string** |  | [optional] 
**Source** | **string** |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string ip = "example ip";
LogGeographicalContext? geographicalContext = new LogGeographicalContext();

string varVersion = "example varVersion";
string source = "example source";

LogIpChainEntry logIpChainEntryInstance = new LogIpChainEntry(
    ip: ip,
    geographicalContext: geographicalContext,
    varVersion: varVersion,
    source: source);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
