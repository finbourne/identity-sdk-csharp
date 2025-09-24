# Finbourne.Identity.Sdk.Model.UpdatePasswordPolicyRequestConditions
Password policy conditions for a password policy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Complexity** | [**UpdatePasswordPolicyRequestComplexity**](UpdatePasswordPolicyRequestComplexity.md) |  | 
**Age** | [**UpdatePasswordPolicyRequestAge**](UpdatePasswordPolicyRequestAge.md) |  | 
**Lockout** | [**UpdatePasswordPolicyRequestLockout**](UpdatePasswordPolicyRequestLockout.md) |  | 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

UpdatePasswordPolicyRequestComplexity complexity = new UpdatePasswordPolicyRequestComplexity();
UpdatePasswordPolicyRequestAge age = new UpdatePasswordPolicyRequestAge();
UpdatePasswordPolicyRequestLockout lockout = new UpdatePasswordPolicyRequestLockout();

UpdatePasswordPolicyRequestConditions updatePasswordPolicyRequestConditionsInstance = new UpdatePasswordPolicyRequestConditions(
    complexity: complexity,
    age: age,
    lockout: lockout);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
