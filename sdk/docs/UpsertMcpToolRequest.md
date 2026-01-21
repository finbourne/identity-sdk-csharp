# Finbourne.Identity.Sdk.Model.UpsertMcpToolRequest
Request to create or update an MCP tool

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the MCP tool (alphanumeric, underscore, and hyphen) | 
**Title** | **string** | The title of the MCP tool | 
**Description** | **string** | The description of the MCP tool | 
**Destructive** | **bool** | Whether the tool is destructive | [optional] 
**Idempotent** | **bool** | Whether the tool is idempotent | [optional] 
**OpenWorld** | **bool** | Whether the tool operates in open world | [optional] 
**ReadOnly** | **bool** | Whether the tool is read-only | [optional] 
**Parameters** | [**List&lt;McpToolParameter&gt;**](McpToolParameter.md) | The parameters for this MCP tool | [optional] 
**LuminescePayload** | [**McpToolLuminescePayload**](McpToolLuminescePayload.md) |  | [optional] 
**SchedulerPayload** | [**McpToolSchedulerPayload**](McpToolSchedulerPayload.md) |  | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string name = "name";
string title = "title";
string description = "description";
bool destructive = //"True";
bool idempotent = //"True";
bool openWorld = //"True";
bool readOnly = //"True";
List<McpToolParameter> parameters = new List<McpToolParameter>();
McpToolLuminescePayload? luminescePayload = new McpToolLuminescePayload();

McpToolSchedulerPayload? schedulerPayload = new McpToolSchedulerPayload();


UpsertMcpToolRequest upsertMcpToolRequestInstance = new UpsertMcpToolRequest(
    name: name,
    title: title,
    description: description,
    destructive: destructive,
    idempotent: idempotent,
    openWorld: openWorld,
    readOnly: readOnly,
    parameters: parameters,
    luminescePayload: luminescePayload,
    schedulerPayload: schedulerPayload);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
