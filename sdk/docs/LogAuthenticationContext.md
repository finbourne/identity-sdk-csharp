# Finbourne.Identity.Sdk.Model.LogAuthenticationContext
Represents a LogAuthenticationContext resource in the Okta API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthenticationProvider** | **string** |  | [optional] 
**CredentialProvider** | **List&lt;string&gt;** |  | [optional] 
**CredentialType** | **List&lt;string&gt;** |  | [optional] 
**Issuer** | [**LogIssuer**](LogIssuer.md) |  | [optional] 
**Interface** | **string** |  | [optional] 
**AuthenticationStep** | **int?** |  | [optional] 
**ExternalSessionId** | **string** |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string authenticationProvider = "example authenticationProvider";
List<string> credentialProvider = new List<string>();
List<string> credentialType = new List<string>();
LogIssuer? issuer = new LogIssuer();

string interface = "example interface";
string externalSessionId = "example externalSessionId";

LogAuthenticationContext logAuthenticationContextInstance = new LogAuthenticationContext(
    authenticationProvider: authenticationProvider,
    credentialProvider: credentialProvider,
    credentialType: credentialType,
    issuer: issuer,
    interface: interface,
    authenticationStep: authenticationStep,
    externalSessionId: externalSessionId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
