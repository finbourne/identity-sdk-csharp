# Finbourne.Identity.Sdk.Model.PasswordPolicyResponseConditions
Password policy conditions for a password policy

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Complexity** | [**PasswordPolicyResponseComplexity**](PasswordPolicyResponseComplexity.md) |  | 
**Age** | [**PasswordPolicyResponseAge**](PasswordPolicyResponseAge.md) |  | 
**Lockout** | [**PasswordPolicyResponseLockout**](PasswordPolicyResponseLockout.md) |  | 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

PasswordPolicyResponseComplexity complexity = new PasswordPolicyResponseComplexity();
PasswordPolicyResponseAge age = new PasswordPolicyResponseAge();
PasswordPolicyResponseLockout lockout = new PasswordPolicyResponseLockout();

PasswordPolicyResponseConditions passwordPolicyResponseConditionsInstance = new PasswordPolicyResponseConditions(
    complexity: complexity,
    age: age,
    lockout: lockout);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
