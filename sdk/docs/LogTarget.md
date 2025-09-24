# Finbourne.Identity.Sdk.Model.LogTarget
Represents a LogTarget resource in the Okta API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**AlternateId** | **string** |  | [optional] 
**DisplayName** | **string** |  | [optional] 
**DetailEntry** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string id = "example id";
string type = "example type";
string alternateId = "example alternateId";
string displayName = "example displayName";
Dictionary<string, Object> detailEntry = new Dictionary<string, Object>();

LogTarget logTargetInstance = new LogTarget(
    id: id,
    type: type,
    alternateId: alternateId,
    displayName: displayName,
    detailEntry: detailEntry);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
