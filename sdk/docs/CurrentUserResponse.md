# Finbourne.Identity.Sdk.Model.CurrentUserResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The user&#39;s system supplied unique identifier | 
**EmailAddress** | **string** | The user&#39;s email address which may be null depending on the authentication method | 
**Type** | **string** | The type of user (e.g. Personal or Service) | 
**DomainType** | **string** | The type of domain in which the user exists | [optional] 
**UserExpiry** | **DateTimeOffset** | The user&#39;s user expiry datetime | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

