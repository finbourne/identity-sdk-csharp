# Finbourne.Identity.Sdk.Model.LogClientInfo
Represents a LogClientInfo resource in the Okta API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserAgent** | [**LogUserAgent**](LogUserAgent.md) |  | [optional] 
**Zone** | **string** |  | [optional] 
**Device** | **string** |  | [optional] 
**Id** | **string** |  | [optional] 
**IpAddress** | **string** |  | [optional] 
**GeographicalContext** | [**LogGeographicalContext**](LogGeographicalContext.md) |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

LogUserAgent? userAgent = new LogUserAgent();

string zone = "example zone";
string device = "example device";
string id = "example id";
string ipAddress = "example ipAddress";
LogGeographicalContext? geographicalContext = new LogGeographicalContext();


LogClientInfo logClientInfoInstance = new LogClientInfo(
    userAgent: userAgent,
    zone: zone,
    device: device,
    id: id,
    ipAddress: ipAddress,
    geographicalContext: geographicalContext);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
