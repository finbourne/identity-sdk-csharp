# Finbourne.Identity.Sdk.Model.AuthenticationInformation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IssuerUrl** | **string** |  | 
**FallbackIssuerUrls** | **List&lt;string&gt;** |  | [optional] 
**SamlIdentityProviderId** | **string** |  | [optional] 
**Support** | [**SupportAccessExpiry**](SupportAccessExpiry.md) |  | [optional] 
**SupportAccessExpiryWithRole** | [**List&lt;SupportAccessExpiryWithRole&gt;**](SupportAccessExpiryWithRole.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string issuerUrl = "issuerUrl";
List<string> fallbackIssuerUrls = new List<string>();
string samlIdentityProviderId = "example samlIdentityProviderId";
SupportAccessExpiry? support = new SupportAccessExpiry();

List<SupportAccessExpiryWithRole> supportAccessExpiryWithRole = new List<SupportAccessExpiryWithRole>();
List<Link> links = new List<Link>();

AuthenticationInformation authenticationInformationInstance = new AuthenticationInformation(
    issuerUrl: issuerUrl,
    fallbackIssuerUrls: fallbackIssuerUrls,
    samlIdentityProviderId: samlIdentityProviderId,
    support: support,
    supportAccessExpiryWithRole: supportAccessExpiryWithRole,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
