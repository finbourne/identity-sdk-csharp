# Finbourne.Identity.Sdk.Model.CreateRoleRequest
Specifies the information required to create a new role.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The role name, which must be unique within the system. | 
**Description** | **string** | The description for this role | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string name = "name";
string description = "example description";

CreateRoleRequest createRoleRequestInstance = new CreateRoleRequest(
    name: name,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
