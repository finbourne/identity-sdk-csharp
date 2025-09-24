# Finbourne.Identity.Sdk.Model.CreateApiKey
Create an API key

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The display name for the API key | 
**DeactivationDate** | **DateTimeOffset?** | The optional date at which the key should deactivate | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string displayName = "displayName";

CreateApiKey createApiKeyInstance = new CreateApiKey(
    displayName: displayName,
    deactivationDate: deactivationDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
