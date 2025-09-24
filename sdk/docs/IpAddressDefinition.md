# Finbourne.Identity.Sdk.Model.IpAddressDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Value** | **string** |  | 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string type = "example type";
string description = "example description";
string value = "value";

IpAddressDefinition ipAddressDefinitionInstance = new IpAddressDefinition(
    type: type,
    description: description,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
