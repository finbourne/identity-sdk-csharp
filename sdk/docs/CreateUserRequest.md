# Finbourne.Identity.Sdk.Model.CreateUserRequest
Details necessary for creating a new user

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | The first name of the user | 
**LastName** | **string** | The last name of the user | 
**EmailAddress** | **string** | The user&#39;s email address - to which the account validation email will be sent. For user accounts  this should exactly match the Login. | 
**SecondEmailAddress** | **string** | The user&#39;s second email address. Only allowed for Service users | [optional] 
**Login** | **string** | The user&#39;s login username, in the form of an email address, which must be unique within the system.  For user accounts this should exactly match the user&#39;s email address. | 
**AlternativeUserIds** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Roles** | [**List&lt;RoleId&gt;**](RoleId.md) | Optional. Any known roles the user should be created with. | [optional] 
**Type** | **string** | The type of user (e.g. Personal or Service) | 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string firstName = "firstName";
string lastName = "lastName";
string emailAddress = "emailAddress";
string secondEmailAddress = "example secondEmailAddress";
string login = "login";
Dictionary<string, string> alternativeUserIds = new Dictionary<string, string>();
List<RoleId> roles = new List<RoleId>();
string type = "type";

CreateUserRequest createUserRequestInstance = new CreateUserRequest(
    firstName: firstName,
    lastName: lastName,
    emailAddress: emailAddress,
    secondEmailAddress: secondEmailAddress,
    login: login,
    alternativeUserIds: alternativeUserIds,
    roles: roles,
    type: type);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
