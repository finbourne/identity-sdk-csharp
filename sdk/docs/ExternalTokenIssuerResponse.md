# Finbourne.Identity.Sdk.Model.ExternalTokenIssuerResponse
Response DTO exposed to client for an external token issuer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The External Token Issuer Code | [optional] 
**Issuer** | **string** | Issuer of the External Token Issuer | [optional] 
**Audience** | **string** | Audience of the External Token Issuer | [optional] 
**Description** | **string** | The Description of the External Token Issuer | [optional] 
**ClaimMappings** | [**ClaimMappings**](ClaimMappings.md) |  | [optional] 
**LogoutUrl** | **string** | The LogoutUrl of the External Token Issuer | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string code = "example code";
string issuer = "example issuer";
string audience = "example audience";
string description = "example description";
ClaimMappings? claimMappings = new ClaimMappings();

string logoutUrl = "example logoutUrl";

ExternalTokenIssuerResponse externalTokenIssuerResponseInstance = new ExternalTokenIssuerResponse(
    code: code,
    issuer: issuer,
    audience: audience,
    description: description,
    claimMappings: claimMappings,
    logoutUrl: logoutUrl);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
