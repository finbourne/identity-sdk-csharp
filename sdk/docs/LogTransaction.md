# Finbourne.Identity.Sdk.Model.LogTransaction
Represents a LogTransaction resource in the Okta API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**Id** | **string** |  | [optional] 
**Detail** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string type = "example type";
string id = "example id";
Dictionary<string, Object> detail = new Dictionary<string, Object>();

LogTransaction logTransactionInstance = new LogTransaction(
    type: type,
    id: id,
    detail: detail);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
