# Finbourne.Identity.Sdk.Model.OAuthApplication

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**Type** | **string** |  | 
**DisplayName** | **string** |  | 
**Secret** | **string** |  | [optional] 
**ClientId** | **string** |  | 
**Issuer** | **string** |  | 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string id = "id";
string type = "type";
string displayName = "displayName";
string secret = "example secret";
string clientId = "clientId";
string issuer = "issuer";

OAuthApplication oAuthApplicationInstance = new OAuthApplication(
    id: id,
    type: type,
    displayName: displayName,
    secret: secret,
    clientId: clientId,
    issuer: issuer);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
