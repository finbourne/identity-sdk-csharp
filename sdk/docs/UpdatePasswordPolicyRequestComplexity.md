# Finbourne.Identity.Sdk.Model.UpdatePasswordPolicyRequestComplexity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MinLength** | **int** | The minimum length for a password | 
**ExcludeFirstName** | **bool** | Rule determining whether a user&#39;s first name should be permitted in their password | 
**ExcludeLastName** | **bool** | Rule determining whether a user&#39;s last name should be permitted in their password | 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

bool excludeFirstName = //"True";
bool excludeLastName = //"True";

UpdatePasswordPolicyRequestComplexity updatePasswordPolicyRequestComplexityInstance = new UpdatePasswordPolicyRequestComplexity(
    minLength: minLength,
    excludeFirstName: excludeFirstName,
    excludeLastName: excludeLastName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
