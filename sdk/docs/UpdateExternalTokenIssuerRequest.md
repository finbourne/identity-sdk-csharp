# Finbourne.Identity.Sdk.Model.UpdateExternalTokenIssuerRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Issuer** | **string** |  | [optional] 
**Audience** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**ClaimMappings** | [**ClaimMappings**](ClaimMappings.md) |  | [optional] 
**LogoutUrl** | **string** |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string issuer = "example issuer";
string audience = "example audience";
string description = "example description";
ClaimMappings? claimMappings = new ClaimMappings();

string logoutUrl = "example logoutUrl";

UpdateExternalTokenIssuerRequest updateExternalTokenIssuerRequestInstance = new UpdateExternalTokenIssuerRequest(
    issuer: issuer,
    audience: audience,
    description: description,
    claimMappings: claimMappings,
    logoutUrl: logoutUrl);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
