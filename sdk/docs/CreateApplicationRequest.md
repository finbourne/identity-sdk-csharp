# Finbourne.Identity.Sdk.Model.CreateApplicationRequest
A request to create an application for authenticating the source of token requests

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The Display Name of the application | 
**ClientId** | **string** | The OpenID Connect ClientId of the application | 
**Type** | **string** | The Type of the application. This must be either Native or Web | 
**RedirectUris** | **List&lt;string&gt;** | A web application&#39;s acceptable list of post-login redirect URIs | [optional] 
**PostLogoutRedirectUris** | **List&lt;string&gt;** | A web application&#39;s acceptable list of post-logout redirect URIs | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

