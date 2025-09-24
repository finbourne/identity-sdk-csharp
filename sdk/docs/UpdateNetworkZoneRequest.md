# Finbourne.Identity.Sdk.Model.UpdateNetworkZoneRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** |  | [optional] 
**NetworkZoneIPs** | [**List&lt;IpAddressDefinition&gt;**](IpAddressDefinition.md) |  | 
**Action** | **string** |  | [optional] 
**ApplyRules** | [**NetworkZonesApplyRules**](NetworkZonesApplyRules.md) |  | 
**Hierarchy** | **int** |  | 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string description = "example description";
List<IpAddressDefinition> networkZoneIPs = new List<IpAddressDefinition>();
string action = "example action";
NetworkZonesApplyRules applyRules = new NetworkZonesApplyRules();

UpdateNetworkZoneRequest updateNetworkZoneRequestInstance = new UpdateNetworkZoneRequest(
    description: description,
    networkZoneIPs: networkZoneIPs,
    action: action,
    applyRules: applyRules,
    hierarchy: hierarchy);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
