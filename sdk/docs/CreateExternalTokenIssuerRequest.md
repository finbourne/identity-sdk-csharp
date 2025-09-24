# Finbourne.Identity.Sdk.Model.CreateExternalTokenIssuerRequest
Client input for creating an external token issuer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** |  | 
**Issuer** | **string** |  | 
**Audience** | **string** |  | 
**Description** | **string** |  | [optional] 
**ClaimMappings** | [**ClaimMappings**](ClaimMappings.md) |  | [optional] 
**LogoutUrl** | **string** |  | 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string code = "code";
string issuer = "issuer";
string audience = "audience";
string description = "example description";
ClaimMappings? claimMappings = new ClaimMappings();

string logoutUrl = "logoutUrl";

CreateExternalTokenIssuerRequest createExternalTokenIssuerRequestInstance = new CreateExternalTokenIssuerRequest(
    code: code,
    issuer: issuer,
    audience: audience,
    description: description,
    claimMappings: claimMappings,
    logoutUrl: logoutUrl);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
