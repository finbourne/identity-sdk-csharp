# Finbourne.Identity.Sdk.Model.McpToolSchedulerPayload
Payload data for a Scheduler job MCP tool

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JobScope** | **string** | The scope of the scheduler job to run | 
**JobCode** | **string** | The code of the scheduler job to run | 
**Arguments** | **Dictionary&lt;string, string&gt;** | Arguments to pass to the scheduler job (key-value pairs) | [optional] 
**RunAs** | **string** | Optional service user identifier to run the job as (if not the current user) | [optional] 
**Notifications** | [**List&lt;McpToolSchedulerNotification&gt;**](McpToolSchedulerNotification.md) | Optional additional notifications for the job | [optional] 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string jobScope = "jobScope";
string jobCode = "jobCode";
Dictionary<string, string> arguments = new Dictionary<string, string>();
string runAs = "example runAs";
List<McpToolSchedulerNotification> notifications = new List<McpToolSchedulerNotification>();

McpToolSchedulerPayload mcpToolSchedulerPayloadInstance = new McpToolSchedulerPayload(
    jobScope: jobScope,
    jobCode: jobCode,
    arguments: arguments,
    runAs: runAs,
    notifications: notifications);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
