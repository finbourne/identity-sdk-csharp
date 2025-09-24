# Finbourne.Identity.Sdk.Model.CreateNetworkZoneRequest
The Create Network Zone Request information

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** |  | 
**Description** | **string** |  | [optional] 
**NetworkZoneIPs** | [**List&lt;IpAddressDefinition&gt;**](IpAddressDefinition.md) |  | 
**Action** | **string** |  | [optional] 
**ApplyRules** | [**NetworkZonesApplyRules**](NetworkZonesApplyRules.md) |  | 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string code = "code";
string description = "example description";
List<IpAddressDefinition> networkZoneIPs = new List<IpAddressDefinition>();
string action = "example action";
NetworkZonesApplyRules applyRules = new NetworkZonesApplyRules();

CreateNetworkZoneRequest createNetworkZoneRequestInstance = new CreateNetworkZoneRequest(
    code: code,
    description: description,
    networkZoneIPs: networkZoneIPs,
    action: action,
    applyRules: applyRules);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
