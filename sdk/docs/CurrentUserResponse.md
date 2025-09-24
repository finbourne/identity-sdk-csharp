# Finbourne.Identity.Sdk.Model.CurrentUserResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The user&#39;s system supplied unique identifier | 
**EmailAddress** | **string** | The user&#39;s email address which may be null depending on the authentication method | 
**Type** | **string** | The type of user (e.g. Personal or Service) | 
**DomainType** | **string** | The type of domain in which the user exists | [optional] 
**UserExpiry** | **DateTimeOffset?** | The user&#39;s user expiry datetime | [optional] 
**Groups** | **List&lt;string&gt;** | The groups this user belongs to | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string id = "id";
string emailAddress = "emailAddress";
string type = "type";
string domainType = "example domainType";
List<string> groups = new List<string>();
List<Link> links = new List<Link>();

CurrentUserResponse currentUserResponseInstance = new CurrentUserResponse(
    id: id,
    emailAddress: emailAddress,
    type: type,
    domainType: domainType,
    userExpiry: userExpiry,
    groups: groups,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
