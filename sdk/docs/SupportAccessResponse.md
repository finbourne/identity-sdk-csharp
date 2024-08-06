# Finbourne.Identity.Sdk.Model.SupportAccessResponse
Timestamped successful response to grant access to your account

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID of the support access request | 
**Duration** | **string** | The duration for which access is requested (in any ISO-8601 format) | 
**Description** | **string** | The description of why the support access has been granted (i.e. support ticket numbers) | [optional] 
**CreatedAt** | **DateTimeOffset** | DateTimeOffset at which the access was granted | 
**Expiry** | **DateTimeOffset** | DateTimeOffset at which the access will be revoked | 
**CreatedBy** | **string** | Obfuscated UserId of the user who granted the support access | 
**Terminated** | **bool** | Whether or not that access has been invalidated | [optional] 
**TerminatedAt** | **DateTimeOffset?** | DateTimeOffset at which the access was invalidated | [optional] 
**TerminatedBy** | **string** | Obfuscated UserId of the user who revoked the access | [optional] 
**PermittedRoles** | **List&lt;string&gt;** | A list of permitted roles, valid for support staff to assume, for the duration of the access request | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

