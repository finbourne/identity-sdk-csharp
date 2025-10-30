# Finbourne.Identity.Sdk.Model.UserResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The user&#39;s system supplied unique identifier | 
**AlternativeUserIds** | **Dictionary&lt;string, string&gt;** | The user&#39;s alternative IDs | [optional] 
**EmailAddress** | **string** | The user&#39;s emailAddress address, which must be unique within the system | 
**SecondEmailAddress** | **string** | The user&#39;s second email address. Only allowed for service users. | [optional] 
**Login** | **string** |  | 
**FirstName** | **string** | The user&#39;s first name | 
**LastName** | **string** | The user&#39;s last name | 
**Roles** | [**List&lt;RoleResponse&gt;**](RoleResponse.md) | The roles that the user has. | [optional] 
**Type** | **string** | The type of user (e.g. Personal or Service) | 
**Status** | **string** | The status of the user | 
**External** | **bool** | Whether or not the user originates from an external identity system | 
**LastLogin** | **DateTimeOffset?** | Last time the user logged in | [optional] 
**LastUpdated** | **DateTimeOffset?** | Last time the user was updated | [optional] 
**Created** | **DateTimeOffset?** | Date the user was created | [optional] 
**PasswordChanged** | **DateTimeOffset?** | Last time the password was changed for this user | [optional] 
**UserExpiry** | **DateTimeOffset?** | The user&#39;s expiry unix datetime | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string id = "id";
Dictionary<string, string> alternativeUserIds = new Dictionary<string, string>();
string emailAddress = "emailAddress";
string secondEmailAddress = "example secondEmailAddress";
string login = "login";
string firstName = "firstName";
string lastName = "lastName";
List<RoleResponse> roles = new List<RoleResponse>();
string type = "type";
string status = "status";
bool external = //"True";
List<Link> links = new List<Link>();

UserResponse userResponseInstance = new UserResponse(
    id: id,
    alternativeUserIds: alternativeUserIds,
    emailAddress: emailAddress,
    secondEmailAddress: secondEmailAddress,
    login: login,
    firstName: firstName,
    lastName: lastName,
    roles: roles,
    type: type,
    status: status,
    external: external,
    lastLogin: lastLogin,
    lastUpdated: lastUpdated,
    created: created,
    passwordChanged: passwordChanged,
    userExpiry: userExpiry,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
