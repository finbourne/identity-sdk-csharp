# Finbourne.Identity.Sdk.Model.ListUsersResponse
Users directory query response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | Uri of this response | [optional] 
**Values** | [**Dictionary&lt;string, UserSummary&gt;**](UserSummary.md) | Successful entities, indexed by their id | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | Failed entities, indexed by their id | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string href = "example href";
Dictionary<string, UserSummary> values = new Dictionary<string, UserSummary>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();
List<Link> links = new List<Link>();

ListUsersResponse listUsersResponseInstance = new ListUsersResponse(
    href: href,
    values: values,
    failed: failed,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
