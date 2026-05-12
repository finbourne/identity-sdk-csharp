# Finbourne.Identity.Sdk.Model.SessionPolicyResponse
Session timing settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxSessionIdleMinutes** | **long?** | Maximum minutes a user&#39;s session can be idle before re-authentication is required. | [optional] 
**MaxSessionLifetimeMinutes** | **long?** | Maximum minutes a user&#39;s session can live in total. When absent, sessions do not expire. | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;


SessionPolicyResponse sessionPolicyResponseInstance = new SessionPolicyResponse(
    maxSessionIdleMinutes: maxSessionIdleMinutes,
    maxSessionLifetimeMinutes: maxSessionLifetimeMinutes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
