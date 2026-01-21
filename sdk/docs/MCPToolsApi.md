# Finbourne.Identity.Sdk.Api.MCPToolsApi

All URIs are relative to *https://fbn-prd.lusid.com/identity*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateMcpTool**](MCPToolsApi.md#createmcptool) | **POST** /api/mcptools/{scope}/{code} | [EARLY ACCESS] CreateMcpTool: Create an MCP Tool |
| [**DeleteMcpTool**](MCPToolsApi.md#deletemcptool) | **DELETE** /api/mcptools/{scope}/{code} | [EARLY ACCESS] DeleteMcpTool: Delete an MCP Tool |
| [**GetMcpTool**](MCPToolsApi.md#getmcptool) | **GET** /api/mcptools/{scope}/{code} | [EARLY ACCESS] GetMcpTool: Get an MCP Tool |
| [**ListMcpTools**](MCPToolsApi.md#listmcptools) | **GET** /api/mcptools | [EARLY ACCESS] ListMcpTools: List all MCP Tools |
| [**UpdateMcpTool**](MCPToolsApi.md#updatemcptool) | **PUT** /api/mcptools/{scope}/{code} | [EARLY ACCESS] UpdateMcpTool: Update an MCP Tool |

<a id="createmcptool"></a>
# **CreateMcpTool**
> McpToolResponse CreateMcpTool (string scope, string code, UpsertMcpToolRequest upsertMcpToolRequest)

[EARLY ACCESS] CreateMcpTool: Create an MCP Tool

Creates a new MCP tool definition

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Extensions;
using Finbourne.Identity.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""identityUrl"": ""https://<your-domain>.lusid.com/identity"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<MCPToolsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<MCPToolsApi>();
            var scope = "scope_example";  // string | The scope of the MCP tool
            var code = "code_example";  // string | The code of the MCP tool
            var upsertMcpToolRequest = new UpsertMcpToolRequest(); // UpsertMcpToolRequest | The MCP tool definition

            try
            {
                // uncomment the below to set overrides at the request level
                // McpToolResponse result = apiInstance.CreateMcpTool(scope, code, upsertMcpToolRequest, opts: opts);

                // [EARLY ACCESS] CreateMcpTool: Create an MCP Tool
                McpToolResponse result = apiInstance.CreateMcpTool(scope, code, upsertMcpToolRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling MCPToolsApi.CreateMcpTool: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateMcpToolWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateMcpTool: Create an MCP Tool
    ApiResponse<McpToolResponse> response = apiInstance.CreateMcpToolWithHttpInfo(scope, code, upsertMcpToolRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling MCPToolsApi.CreateMcpToolWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the MCP tool |  |
| **code** | **string** | The code of the MCP tool |  |
| **upsertMcpToolRequest** | [**UpsertMcpToolRequest**](UpsertMcpToolRequest.md) | The MCP tool definition |  |

### Return type

[**McpToolResponse**](McpToolResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Create MCP Tool |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletemcptool"></a>
# **DeleteMcpTool**
> void DeleteMcpTool (string scope, string code)

[EARLY ACCESS] DeleteMcpTool: Delete an MCP Tool

Deletes an MCP tool (soft delete - closes the current version)

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Extensions;
using Finbourne.Identity.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""identityUrl"": ""https://<your-domain>.lusid.com/identity"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<MCPToolsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<MCPToolsApi>();
            var scope = "scope_example";  // string | The scope of the MCP tool
            var code = "code_example";  // string | The code of the MCP tool

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.DeleteMcpTool(scope, code, opts: opts);

                // [EARLY ACCESS] DeleteMcpTool: Delete an MCP Tool
                apiInstance.DeleteMcpTool(scope, code);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling MCPToolsApi.DeleteMcpTool: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMcpToolWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteMcpTool: Delete an MCP Tool
    apiInstance.DeleteMcpToolWithHttpInfo(scope, code);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling MCPToolsApi.DeleteMcpToolWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the MCP tool |  |
| **code** | **string** | The code of the MCP tool |  |

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getmcptool"></a>
# **GetMcpTool**
> McpToolResponse GetMcpTool (string scope, string code, int? version = null)

[EARLY ACCESS] GetMcpTool: Get an MCP Tool

Retrieves an MCP tool. If version is specified, retrieves that specific version for audit purposes. Otherwise, retrieves the current version.

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Extensions;
using Finbourne.Identity.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""identityUrl"": ""https://<your-domain>.lusid.com/identity"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<MCPToolsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<MCPToolsApi>();
            var scope = "scope_example";  // string | The scope of the MCP tool
            var code = "code_example";  // string | The code of the MCP tool
            var version = 56;  // int? | Optional version number to retrieve. If not specified, returns the current version. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // McpToolResponse result = apiInstance.GetMcpTool(scope, code, version, opts: opts);

                // [EARLY ACCESS] GetMcpTool: Get an MCP Tool
                McpToolResponse result = apiInstance.GetMcpTool(scope, code, version);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling MCPToolsApi.GetMcpTool: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMcpToolWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetMcpTool: Get an MCP Tool
    ApiResponse<McpToolResponse> response = apiInstance.GetMcpToolWithHttpInfo(scope, code, version);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling MCPToolsApi.GetMcpToolWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the MCP tool |  |
| **code** | **string** | The code of the MCP tool |  |
| **version** | **int?** | Optional version number to retrieve. If not specified, returns the current version. | [optional]  |

### Return type

[**McpToolResponse**](McpToolResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get MCP Tool |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listmcptools"></a>
# **ListMcpTools**
> List&lt;McpToolResponse&gt; ListMcpTools ()

[EARLY ACCESS] ListMcpTools: List all MCP Tools

Lists all current MCP tools for the domain

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Extensions;
using Finbourne.Identity.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""identityUrl"": ""https://<your-domain>.lusid.com/identity"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<MCPToolsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<MCPToolsApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // List<McpToolResponse> result = apiInstance.ListMcpTools(opts: opts);

                // [EARLY ACCESS] ListMcpTools: List all MCP Tools
                List<McpToolResponse> result = apiInstance.ListMcpTools();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling MCPToolsApi.ListMcpTools: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMcpToolsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListMcpTools: List all MCP Tools
    ApiResponse<List<McpToolResponse>> response = apiInstance.ListMcpToolsWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling MCPToolsApi.ListMcpToolsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;McpToolResponse&gt;**](McpToolResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List MCP Tools |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatemcptool"></a>
# **UpdateMcpTool**
> McpToolResponse UpdateMcpTool (string scope, string code, UpsertMcpToolRequest upsertMcpToolRequest)

[EARLY ACCESS] UpdateMcpTool: Update an MCP Tool

Updates an existing MCP tool, creating a new version

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Extensions;
using Finbourne.Identity.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""identityUrl"": ""https://<your-domain>.lusid.com/identity"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<MCPToolsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<MCPToolsApi>();
            var scope = "scope_example";  // string | The scope of the MCP tool
            var code = "code_example";  // string | The code of the MCP tool
            var upsertMcpToolRequest = new UpsertMcpToolRequest(); // UpsertMcpToolRequest | The updated MCP tool definition

            try
            {
                // uncomment the below to set overrides at the request level
                // McpToolResponse result = apiInstance.UpdateMcpTool(scope, code, upsertMcpToolRequest, opts: opts);

                // [EARLY ACCESS] UpdateMcpTool: Update an MCP Tool
                McpToolResponse result = apiInstance.UpdateMcpTool(scope, code, upsertMcpToolRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling MCPToolsApi.UpdateMcpTool: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMcpToolWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateMcpTool: Update an MCP Tool
    ApiResponse<McpToolResponse> response = apiInstance.UpdateMcpToolWithHttpInfo(scope, code, upsertMcpToolRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling MCPToolsApi.UpdateMcpToolWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the MCP tool |  |
| **code** | **string** | The code of the MCP tool |  |
| **upsertMcpToolRequest** | [**UpsertMcpToolRequest**](UpsertMcpToolRequest.md) | The updated MCP tool definition |  |

### Return type

[**McpToolResponse**](McpToolResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update MCP Tool |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

