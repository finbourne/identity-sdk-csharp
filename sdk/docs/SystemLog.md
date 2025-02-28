# Finbourne.Identity.Sdk.Model.SystemLog
A system log event

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Actor** | [**LogActor**](LogActor.md) |  | [optional] 
**AuthenticationContext** | [**LogAuthenticationContext**](LogAuthenticationContext.md) |  | [optional] 
**ClientInfo** | [**LogClientInfo**](LogClientInfo.md) |  | [optional] 
**DebugContext** | [**LogDebugContext**](LogDebugContext.md) |  | [optional] 
**DisplayMessage** | **string** | Represents a DisplayMessage resource in the Okta API | [optional] 
**EventType** | **string** | Represents a EventType resource in the Okta API | [optional] 
**LegacyEventType** | **string** | Represents a LegacyEventType resource in the Okta API | [optional] 
**Outcome** | [**LogOutcome**](LogOutcome.md) |  | [optional] 
**Published** | **DateTimeOffset?** | Represents when Published in the Okta API | [optional] 
**Request** | [**LogRequest**](LogRequest.md) |  | [optional] 
**SecurityContext** | [**LogSecurityContext**](LogSecurityContext.md) |  | [optional] 
**Severity** | [**LogSeverity**](LogSeverity.md) |  | [optional] 
**Target** | [**List&lt;LogTarget&gt;**](LogTarget.md) | Represents a LogTarget resource in the Okta API | [optional] 
**Transaction** | [**LogTransaction**](LogTransaction.md) |  | [optional] 
**Uuid** | **string** | Represents Uuid in the Okta API | [optional] 
**VarVersion** | **string** | Represents a Version in the Okta API | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

