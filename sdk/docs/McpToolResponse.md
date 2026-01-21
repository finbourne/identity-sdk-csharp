# Finbourne.Identity.Sdk.Model.McpToolResponse
The response representation of an MCP tool

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope of the MCP tool | [optional] 
**Code** | **string** | The code of the MCP tool | [optional] 
**Name** | **string** | The name of the MCP tool | [optional] 
**VarVersion** | **int** | The version number of this MCP tool | [optional] 
**Title** | **string** | The title of the MCP tool | [optional] 
**Description** | **string** | The description of the MCP tool | [optional] 
**Destructive** | **bool** | Whether the tool is destructive | [optional] 
**Idempotent** | **bool** | Whether the tool is idempotent | [optional] 
**OpenWorld** | **bool** | Whether the tool operates in open world | [optional] 
**ReadOnly** | **bool** | Whether the tool is read-only | [optional] 
**Parameters** | [**List&lt;McpToolParameter&gt;**](McpToolParameter.md) | The parameters for this MCP tool | [optional] 
**PayloadType** | **string** | The type of payload (Luminesce or Scheduler) | [optional] 
**LuminescePayload** | [**McpToolLuminescePayload**](McpToolLuminescePayload.md) |  | [optional] 
**SchedulerPayload** | [**McpToolSchedulerPayload**](McpToolSchedulerPayload.md) |  | [optional] 
**CreatedAt** | **DateTimeOffset** | When the MCP tool was created | [optional] 
**CreatedBy** | **string** | Who created the MCP tool | [optional] 
**UpdatedAt** | **DateTimeOffset** | When the MCP tool was last updated | [optional] 
**UpdatedBy** | **string** | Who last updated the MCP tool | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string scope = "example scope";
string code = "example code";
string name = "example name";
string title = "example title";
string description = "example description";
bool destructive = //"True";
bool idempotent = //"True";
bool openWorld = //"True";
bool readOnly = //"True";
List<McpToolParameter> parameters = new List<McpToolParameter>();
string payloadType = "example payloadType";
McpToolLuminescePayload? luminescePayload = new McpToolLuminescePayload();

McpToolSchedulerPayload? schedulerPayload = new McpToolSchedulerPayload();

string createdBy = "example createdBy";
string updatedBy = "example updatedBy";

McpToolResponse mcpToolResponseInstance = new McpToolResponse(
    scope: scope,
    code: code,
    name: name,
    varVersion: varVersion,
    title: title,
    description: description,
    destructive: destructive,
    idempotent: idempotent,
    openWorld: openWorld,
    readOnly: readOnly,
    parameters: parameters,
    payloadType: payloadType,
    luminescePayload: luminescePayload,
    schedulerPayload: schedulerPayload,
    createdAt: createdAt,
    createdBy: createdBy,
    updatedAt: updatedAt,
    updatedBy: updatedBy);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
