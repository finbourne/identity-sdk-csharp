# Finbourne.Identity.Sdk.Model.ErrorDetail
Provides details about an entity error that occured

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Id of the entity this error relates to | [optional] 
**Type** | **string** | Error type | [optional] 
**Detail** | **string** | Human readable description of the error | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string id = "example id";
string type = "example type";
string detail = "example detail";

ErrorDetail errorDetailInstance = new ErrorDetail(
    id: id,
    type: type,
    detail: detail);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
