# Finbourne.Identity.Sdk.Model.SetParentCellRequest
Request body for setting the parent cell.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminDomainName** | **string** | The name of the admin domain in the parent cell. | 
**Confirm** | **bool** | Whether to confirm the parent cell attachment (second invocation). First call with false creates a Proposed state; second call with true transitions to Attaching. | 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string adminDomainName = "adminDomainName";
bool confirm = //"True";

SetParentCellRequest setParentCellRequestInstance = new SetParentCellRequest(
    adminDomainName: adminDomainName,
    confirm: confirm);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
