# Finbourne.Identity.Sdk.Model.SupportAccessRequest
A Request to grant support access to your account

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Duration** | **string** | The duration for which access is requested (in any ISO-8601 format) | 
**Description** | **string** | The description of why the support access has been granted (i.e. support ticket numbers) | [optional] 
**PermittedRoles** | **List&lt;string&gt;** |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string duration = "duration";
string description = "example description";
List<string> permittedRoles = new List<string>();

SupportAccessRequest supportAccessRequestInstance = new SupportAccessRequest(
    duration: duration,
    description: description,
    permittedRoles: permittedRoles);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
