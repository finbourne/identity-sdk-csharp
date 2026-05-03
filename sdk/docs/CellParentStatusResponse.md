# Finbourne.Identity.Sdk.Model.CellParentStatusResponse
Response containing the current cell parent status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The current attachment status of the cell. | [optional] 
**AdminDomainName** | **string** | The name of the admin domain in the parent cell, if any. | [optional] 
**PrimaryDomainName** | **string** | The domain designated as the primary domain for this cell, if any. | [optional] 
**RegistrationStep** | **string** | The most recently reached registration checkpoint, or null if no registration has started. One of &#x60;UserEnsured&#x60;, &#x60;PATGenerated&#x60;, &#x60;PATPushed&#x60;. | [optional] 
**RegistrationError** | **string** | Operator-readable message describing the most recent registration failure, or null on success. | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string status = "example status";
string adminDomainName = "example adminDomainName";
string primaryDomainName = "example primaryDomainName";
string registrationStep = "example registrationStep";
string registrationError = "example registrationError";

CellParentStatusResponse cellParentStatusResponseInstance = new CellParentStatusResponse(
    status: status,
    adminDomainName: adminDomainName,
    primaryDomainName: primaryDomainName,
    registrationStep: registrationStep,
    registrationError: registrationError);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
