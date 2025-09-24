# Finbourne.Identity.Sdk.Model.ApiKey
The metadata of an API key

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique Id of the API key | 
**DisplayName** | **string** | The display name of the API key | 
**CreatedDate** | **DateTimeOffset** | The creation date of the API key | 
**DeactivationDate** | **DateTimeOffset?** | The deactivation date of the API key | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string id = "id";
string displayName = "displayName";

ApiKey apiKeyInstance = new ApiKey(
    id: id,
    displayName: displayName,
    createdDate: createdDate,
    deactivationDate: deactivationDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
