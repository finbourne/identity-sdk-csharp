# Finbourne.Identity.Sdk.Model.ClaimMappings

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **string** |  | 
**Login** | **string** |  | 
**Email** | **string** |  | 
**FirstName** | **string** |  | 
**LastName** | **string** |  | 
**UserType** | **string** |  | 
**Groups** | **string** |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string userId = "userId";
string login = "login";
string email = "email";
string firstName = "firstName";
string lastName = "lastName";
string userType = "userType";
string groups = "example groups";

ClaimMappings claimMappingsInstance = new ClaimMappings(
    userId: userId,
    login: login,
    email: email,
    firstName: firstName,
    lastName: lastName,
    userType: userType,
    groups: groups);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
