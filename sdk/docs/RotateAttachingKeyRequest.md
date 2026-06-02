# Finbourne.Identity.Sdk.Model.RotateAttachingKeyRequest
Request body for rotating the Attaching Key on a cell that is already Attached to a parent admin domain. Carries only the new PAT value — the parent identity is already pinned on the cell from the original `SetAttachingKey` handshake and the source of truth for all later operations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Pat** | **string** | New Attaching Key PAT to persist. Same length / content constraints as the original Finbourne.Lydia.WebApi.Dtos.CellManagement.SetAttachingKeyRequest.Pat: a &#x60;StringSecurityCheck&#x60; catch-all plus a strict opaque-token character set so the request body cannot smuggle in HTML / SQL / script content. | 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string pat = "pat";

RotateAttachingKeyRequest rotateAttachingKeyRequestInstance = new RotateAttachingKeyRequest(
    pat: pat);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
