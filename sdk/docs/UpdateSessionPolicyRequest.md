# Finbourne.Identity.Sdk.Model.UpdateSessionPolicyRequest
Session timing settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxSessionIdleMinutes** | **long** | Maximum minutes a user&#39;s session can be idle before re-authentication is required. Must be between 5 minutes and 12 hours (720 minutes). | 
**MaxSessionLifetimeMinutes** | **long?** | Maximum minutes a user&#39;s session can live in total. Omit to disable session expiry; otherwise must be between 5 minutes and 24 hours (1440 minutes). | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;


UpdateSessionPolicyRequest updateSessionPolicyRequestInstance = new UpdateSessionPolicyRequest(
    maxSessionIdleMinutes: maxSessionIdleMinutes,
    maxSessionLifetimeMinutes: maxSessionLifetimeMinutes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
