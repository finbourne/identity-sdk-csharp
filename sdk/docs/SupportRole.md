# Finbourne.Identity.Sdk.Model.SupportRole

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**RoleIdentifier** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**InternalIdentifier** | **string** |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string label = "example label";
string description = "example description";
Dictionary<string, string> roleIdentifier = new Dictionary<string, string>();
string internalIdentifier = "example internalIdentifier";

SupportRole supportRoleInstance = new SupportRole(
    label: label,
    description: description,
    roleIdentifier: roleIdentifier,
    internalIdentifier: internalIdentifier);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
