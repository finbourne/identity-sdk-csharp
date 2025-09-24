# Finbourne.Identity.Sdk.Model.LogOutcome
Represents a LogOutcome resource in the Okta API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Result** | **string** |  | [optional] 
**Reason** | **string** |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string result = "example result";
string reason = "example reason";

LogOutcome logOutcomeInstance = new LogOutcome(
    result: result,
    reason: reason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
