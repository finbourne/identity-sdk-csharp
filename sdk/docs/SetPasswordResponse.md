# Finbourne.Identity.Sdk.Model.SetPasswordResponse
The result of setting a password

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UpdatedAt** | **DateTimeOffset** | The date and time at which the password was successfully updated | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

List<Link> links = new List<Link>();

SetPasswordResponse setPasswordResponseInstance = new SetPasswordResponse(
    updatedAt: updatedAt,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
