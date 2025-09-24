# Finbourne.Identity.Sdk.Model.UserSummary
Lightweight view of an user details

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The user id | [optional] 
**Login** | **string** | The user login | [optional] 
**Email** | **string** | The email address registered for that user | [optional] 
**SecondEmail** | **string** |  | [optional] 
**FirstName** | **string** | User&#39;s first name | [optional] 
**LastName** | **string** | User&#39;s last name | [optional] 
**Type** | **string** | User&#39;s type (Personal, Service...) | [optional] 
**AlternativeUserIds** | **Dictionary&lt;string, string&gt;** | User&#39;s alternative user IDs. Only returned for the current user | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string id = "example id";
string login = "example login";
string email = "example email";
string secondEmail = "example secondEmail";
string firstName = "example firstName";
string lastName = "example lastName";
string type = "example type";
Dictionary<string, string> alternativeUserIds = new Dictionary<string, string>();
List<Link> links = new List<Link>();

UserSummary userSummaryInstance = new UserSummary(
    id: id,
    login: login,
    email: email,
    secondEmail: secondEmail,
    firstName: firstName,
    lastName: lastName,
    type: type,
    alternativeUserIds: alternativeUserIds,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
