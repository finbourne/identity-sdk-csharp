# Finbourne.Identity.Sdk.Model.McpToolParameter
A parameter definition for an MCP tool

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the parameter (identifier format) | 
**DataType** | **string** | The data type of the parameter | 
**Description** | **string** | A description of what the parameter is used for | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string name = "name";
string dataType = "dataType";
string description = "example description";

McpToolParameter mcpToolParameterInstance = new McpToolParameter(
    name: name,
    dataType: dataType,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
