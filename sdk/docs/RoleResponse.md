# Finbourne.Identity.Sdk.Model.RoleResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The role&#39;s system supplied unique identifier | 
**RoleId** | [**RoleId**](RoleId.md) |  | 
**Source** | **string** | The source of the role | 
**Name** | **string** | The role name, which must be unique within the system. | 
**Description** | **string** | The description for this role | [optional] 
**SamlName** | **string** | The name to use on the SAML request if assigning this role via SAML Just in Time (JIT) | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string id = "id";
RoleId roleId = new RoleId();
string source = "source";
string name = "name";
string description = "example description";
string samlName = "example samlName";

RoleResponse roleResponseInstance = new RoleResponse(
    id: id,
    roleId: roleId,
    source: source,
    name: name,
    description: description,
    samlName: samlName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
