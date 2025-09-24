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

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

LogActor? actor = new LogActor();

LogAuthenticationContext? authenticationContext = new LogAuthenticationContext();

LogClientInfo? clientInfo = new LogClientInfo();

LogDebugContext? debugContext = new LogDebugContext();

string displayMessage = "example displayMessage";
string eventType = "example eventType";
string legacyEventType = "example legacyEventType";
LogOutcome? outcome = new LogOutcome();

LogRequest? request = new LogRequest();

LogSecurityContext? securityContext = new LogSecurityContext();

LogSeverity? severity = new LogSeverity();

List<LogTarget> target = new List<LogTarget>();
LogTransaction? transaction = new LogTransaction();

string uuid = "example uuid";
string varVersion = "example varVersion";

SystemLog systemLogInstance = new SystemLog(
    actor: actor,
    authenticationContext: authenticationContext,
    clientInfo: clientInfo,
    debugContext: debugContext,
    displayMessage: displayMessage,
    eventType: eventType,
    legacyEventType: legacyEventType,
    outcome: outcome,
    published: published,
    request: request,
    securityContext: securityContext,
    severity: severity,
    target: target,
    transaction: transaction,
    uuid: uuid,
    varVersion: varVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
