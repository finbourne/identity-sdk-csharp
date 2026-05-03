# Finbourne.Identity.Sdk.Model.DetachParentCellRequest
Request body for `DetachParentCell`. The endpoint uses a double-invoke pattern: the first call (Finbourne.Lydia.WebApi.Dtos.CellManagement.DetachParentCellRequest.Confirm=false) transitions the cell into Finbourne.Lydia.Postgres.Database.DTO.AttachmentStatus.Detaching; the second call (Finbourne.Lydia.WebApi.Dtos.CellManagement.DetachParentCellRequest.Confirm=true) performs the actual detach.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Confirm** | **bool** | False to mark the cell as &#x60;Detaching&#x60;; true to execute the detach. | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

bool confirm = //"True";

DetachParentCellRequest detachParentCellRequestInstance = new DetachParentCellRequest(
    confirm: confirm);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
