# Finbourne.Identity.Sdk.Model.SupportAccessExpiryWithRole
Time at which the support access granted for a role expires

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Expiry** | **DateTimeOffset** | DateTimeOffset at which the access will be revoked | 
**PermittedRole** | **string** | Unique identifier for permitted role.   Use GET /identity/api/authentication/support-roles to lookup role label/code from identifier. | 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string permittedRole = "permittedRole";

SupportAccessExpiryWithRole supportAccessExpiryWithRoleInstance = new SupportAccessExpiryWithRole(
    expiry: expiry,
    permittedRole: permittedRole);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
