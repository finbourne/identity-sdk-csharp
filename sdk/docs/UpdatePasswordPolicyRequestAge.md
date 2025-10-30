# Finbourne.Identity.Sdk.Model.UpdatePasswordPolicyRequestAge

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxAgeDays** | **int** | The maximum age (in days) a password can be before expiring and needing to be changed. 0 indicates no limit | 
**HistoryCount** | **int** | The number of unique passwords that need to be used before a previous password is permitted again. 0 indicates none | 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;


UpdatePasswordPolicyRequestAge updatePasswordPolicyRequestAgeInstance = new UpdatePasswordPolicyRequestAge(
    maxAgeDays: maxAgeDays,
    historyCount: historyCount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
