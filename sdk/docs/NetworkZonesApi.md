# Finbourne.Identity.Sdk.Api.NetworkZonesApi

All URIs are relative to *https://fbn-prd.lusid.com/identity*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNetworkZone**](NetworkZonesApi.md#createnetworkzone) | **POST** /api/networkzones | [EARLY ACCESS] CreateNetworkZone: Creates a network zone |
| [**DeleteNetworkZone**](NetworkZonesApi.md#deletenetworkzone) | **DELETE** /api/networkzones/{code} | [EARLY ACCESS] DeleteNetworkZone: Deletes a network zone |
| [**GetNetworkZone**](NetworkZonesApi.md#getnetworkzone) | **GET** /api/networkzones/{code} | [EARLY ACCESS] GetNetworkZone: Retrieve a Network Zone |
| [**ListNetworkZones**](NetworkZonesApi.md#listnetworkzones) | **GET** /api/networkzones | [EARLY ACCESS] ListNetworkZones: Lists all network zones for a domain |
| [**UpdateNetworkZone**](NetworkZonesApi.md#updatenetworkzone) | **PUT** /api/networkzones/{code} | [EARLY ACCESS] UpdateNetworkZone: Updates an existing network zone |

<a id="createnetworkzone"></a>
# **CreateNetworkZone**
> NetworkZoneDefinitionResponse CreateNetworkZone (CreateNetworkZoneRequest createNetworkZoneRequest)

[EARLY ACCESS] CreateNetworkZone: Creates a network zone

By default, the network zone will have its hierarchy set to last on creation.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<NetworkZonesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<NetworkZonesApi>();
            var createNetworkZoneRequest = new CreateNetworkZoneRequest(); // CreateNetworkZoneRequest | The details of the network zone to define

            try
            {
                // uncomment the below to set overrides at the request level
                // NetworkZoneDefinitionResponse result = apiInstance.CreateNetworkZone(createNetworkZoneRequest, opts: opts);

                // [EARLY ACCESS] CreateNetworkZone: Creates a network zone
                NetworkZoneDefinitionResponse result = apiInstance.CreateNetworkZone(createNetworkZoneRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling NetworkZonesApi.CreateNetworkZone: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateNetworkZoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateNetworkZone: Creates a network zone
    ApiResponse<NetworkZoneDefinitionResponse> response = apiInstance.CreateNetworkZoneWithHttpInfo(createNetworkZoneRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling NetworkZonesApi.CreateNetworkZoneWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createNetworkZoneRequest** | [**CreateNetworkZoneRequest**](CreateNetworkZoneRequest.md) | The details of the network zone to define |  |

### Return type

[**NetworkZoneDefinitionResponse**](NetworkZoneDefinitionResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Create Network Zone |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletenetworkzone"></a>
# **DeleteNetworkZone**
> void DeleteNetworkZone (string code)

[EARLY ACCESS] DeleteNetworkZone: Deletes a network zone

Will return a success if network zone already deleted

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<NetworkZonesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<NetworkZonesApi>();
            var code = "code_example";  // string | The unique identifier of the network zone to delete

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.DeleteNetworkZone(code, opts: opts);

                // [EARLY ACCESS] DeleteNetworkZone: Deletes a network zone
                apiInstance.DeleteNetworkZone(code);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling NetworkZonesApi.DeleteNetworkZone: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteNetworkZoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteNetworkZone: Deletes a network zone
    apiInstance.DeleteNetworkZoneWithHttpInfo(code);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling NetworkZonesApi.DeleteNetworkZoneWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The unique identifier of the network zone to delete |  |

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

<a id="getnetworkzone"></a>
# **GetNetworkZone**
> NetworkZoneDefinitionResponse GetNetworkZone (string code)

[EARLY ACCESS] GetNetworkZone: Retrieve a Network Zone

Retrieves a Network Zone

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<NetworkZonesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<NetworkZonesApi>();
            var code = "code_example";  // string | The unique identifier of the network zone

            try
            {
                // uncomment the below to set overrides at the request level
                // NetworkZoneDefinitionResponse result = apiInstance.GetNetworkZone(code, opts: opts);

                // [EARLY ACCESS] GetNetworkZone: Retrieve a Network Zone
                NetworkZoneDefinitionResponse result = apiInstance.GetNetworkZone(code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling NetworkZonesApi.GetNetworkZone: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNetworkZoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetNetworkZone: Retrieve a Network Zone
    ApiResponse<NetworkZoneDefinitionResponse> response = apiInstance.GetNetworkZoneWithHttpInfo(code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling NetworkZonesApi.GetNetworkZoneWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The unique identifier of the network zone |  |

### Return type

[**NetworkZoneDefinitionResponse**](NetworkZoneDefinitionResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get Network Zone |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listnetworkzones"></a>
# **ListNetworkZones**
> List&lt;NetworkZoneDefinitionResponse&gt; ListNetworkZones ()

[EARLY ACCESS] ListNetworkZones: Lists all network zones for a domain

Lists all network zones for a domain

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<NetworkZonesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<NetworkZonesApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // List<NetworkZoneDefinitionResponse> result = apiInstance.ListNetworkZones(opts: opts);

                // [EARLY ACCESS] ListNetworkZones: Lists all network zones for a domain
                List<NetworkZoneDefinitionResponse> result = apiInstance.ListNetworkZones();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling NetworkZonesApi.ListNetworkZones: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListNetworkZonesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListNetworkZones: Lists all network zones for a domain
    ApiResponse<List<NetworkZoneDefinitionResponse>> response = apiInstance.ListNetworkZonesWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling NetworkZonesApi.ListNetworkZonesWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;NetworkZoneDefinitionResponse&gt;**](NetworkZoneDefinitionResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List Network Zones |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatenetworkzone"></a>
# **UpdateNetworkZone**
> NetworkZoneDefinitionResponse UpdateNetworkZone (string code, UpdateNetworkZoneRequest updateNetworkZoneRequest)

[EARLY ACCESS] UpdateNetworkZone: Updates an existing network zone

Updates an existing network zone

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<NetworkZonesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<NetworkZonesApi>();
            var code = "code_example";  // string | The unique identifier of the network zone
            var updateNetworkZoneRequest = new UpdateNetworkZoneRequest(); // UpdateNetworkZoneRequest | The updated definition of the network zone

            try
            {
                // uncomment the below to set overrides at the request level
                // NetworkZoneDefinitionResponse result = apiInstance.UpdateNetworkZone(code, updateNetworkZoneRequest, opts: opts);

                // [EARLY ACCESS] UpdateNetworkZone: Updates an existing network zone
                NetworkZoneDefinitionResponse result = apiInstance.UpdateNetworkZone(code, updateNetworkZoneRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling NetworkZonesApi.UpdateNetworkZone: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateNetworkZoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateNetworkZone: Updates an existing network zone
    ApiResponse<NetworkZoneDefinitionResponse> response = apiInstance.UpdateNetworkZoneWithHttpInfo(code, updateNetworkZoneRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling NetworkZonesApi.UpdateNetworkZoneWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | The unique identifier of the network zone |  |
| **updateNetworkZoneRequest** | [**UpdateNetworkZoneRequest**](UpdateNetworkZoneRequest.md) | The updated definition of the network zone |  |

### Return type

[**NetworkZoneDefinitionResponse**](NetworkZoneDefinitionResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update Network Zone |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

