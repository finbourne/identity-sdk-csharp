# Finbourne.Identity.Sdk.Model.McpToolSchedulerNotification
A notification configuration for a scheduler job

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of notification (e.g., \&quot;Email\&quot;, \&quot;Webhook\&quot;) | 
**Target** | **string** | The target of the notification (e.g., email address, webhook URL) | 
**Trigger** | **string** | When to send the notification (e.g., \&quot;OnSuccess\&quot;, \&quot;OnFailure\&quot;, \&quot;Always\&quot;) | 

```csharp
using Finbourne.Identity.Sdk.Model;
using System;

string type = "type";
string target = "target";
string trigger = "trigger";

McpToolSchedulerNotification mcpToolSchedulerNotificationInstance = new McpToolSchedulerNotification(
    type: type,
    target: target,
    trigger: trigger);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
