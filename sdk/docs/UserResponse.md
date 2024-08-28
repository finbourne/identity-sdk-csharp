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
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

