# Finbourne.Identity.Sdk.Model.UpdateUserRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** |  | 
**LastName** | **string** |  | 
**EmailAddress** | **string** |  | 
**SecondEmailAddress** | **string** |  | [optional] 
**Login** | **string** | The user&#39;s login username, in the form of an email address, which must be unique within the system.  For user accounts this should exactly match the user&#39;s email address. | 
**AlternativeUserIds** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Roles** | [**List&lt;RoleId&gt;**](RoleId.md) | Deprecated. To update a user&#39;s roles use the AddUserToRole and RemoveUserFromRole endpoints | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

