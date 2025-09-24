# Finbourne.Identity.Sdk.Model.LogRequest
Represents a LogRequest resource in the Okta API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpChain** | [**List&lt;LogIpChainEntry&gt;**](LogIpChainEntry.md) |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

List<LogIpChainEntry> ipChain = new List<LogIpChainEntry>();

LogRequest logRequestInstance = new LogRequest(
    ipChain: ipChain);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
