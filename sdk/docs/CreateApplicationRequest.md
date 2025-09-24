# Finbourne.Identity.Sdk.Model.CreateApplicationRequest
A request to create an application for authenticating the source of token requests

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The Display Name of the application | 
**ClientId** | **string** | The OpenID Connect ClientId of the application | 
**Type** | **string** | The Type of the application. This must be either Native or Web | 
**RedirectUris** | **List&lt;string&gt;** | A web application&#39;s acceptable list of post-login redirect URIs | [optional] 
**PostLogoutRedirectUris** | **List&lt;string&gt;** | A web application&#39;s acceptable list of post-logout redirect URIs | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string displayName = "displayName";
string clientId = "clientId";
string type = "type";
List<string> redirectUris = new List<string>();
List<string> postLogoutRedirectUris = new List<string>();

CreateApplicationRequest createApplicationRequestInstance = new CreateApplicationRequest(
    displayName: displayName,
    clientId: clientId,
    type: type,
    redirectUris: redirectUris,
    postLogoutRedirectUris: postLogoutRedirectUris);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
