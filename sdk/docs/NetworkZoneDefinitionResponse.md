# Finbourne.Identity.Sdk.Model.NetworkZoneDefinitionResponse
The Client facing representation of a NetworkZone

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The Network Zone Code | [optional] 
**Hierarchy** | **int** | Hierarchy of the Network Zone | [optional] 
**Description** | **string** | The Description of the Network Zone | [optional] 
**CreatedAt** | **DateTimeOffset** | Network Zone Creation timestamp | [optional] 
**UpdatedAt** | **DateTimeOffset** | Timestamp of the last update | [optional] 
**NetworkZoneIPs** | [**List&lt;IpAddressDefinition&gt;**](IpAddressDefinition.md) | Network zone IP information (IPs and CIDR ranges) | [optional] 
**Action** | **string** | Kind of action to apply when a request matches this Network Zone (Block/Allow/NoOp) | [optional] 
**ApplyRules** | [**NetworkZonesApplyRules**](NetworkZonesApplyRules.md) |  | [optional] 
**CreatedBy** | **string** | User Id that created the Network Zone | [optional] 
**UpdatedBy** | **string** | User Id of the last update on the Network Zone | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string code = "example code";
string description = "example description";
List<IpAddressDefinition> networkZoneIPs = new List<IpAddressDefinition>();
string action = "example action";
NetworkZonesApplyRules? applyRules = new NetworkZonesApplyRules();

string createdBy = "example createdBy";
string updatedBy = "example updatedBy";

NetworkZoneDefinitionResponse networkZoneDefinitionResponseInstance = new NetworkZoneDefinitionResponse(
    code: code,
    hierarchy: hierarchy,
    description: description,
    createdAt: createdAt,
    updatedAt: updatedAt,
    networkZoneIPs: networkZoneIPs,
    action: action,
    applyRules: applyRules,
    createdBy: createdBy,
    updatedBy: updatedBy);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
