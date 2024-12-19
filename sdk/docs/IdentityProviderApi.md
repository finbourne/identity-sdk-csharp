# Finbourne.Identity.Sdk.Api.IdentityProviderApi

All URIs are relative to *https://fbn-prd.lusid.com/identity*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddScim**](IdentityProviderApi.md#addscim) | **PUT** /api/identityprovider/scim | AddScim: Add SCIM |
| [**RemoveScim**](IdentityProviderApi.md#removescim) | **DELETE** /api/identityprovider/scim | RemoveScim: Remove SCIM |

<a id="addscim"></a>
# **AddScim**
> AddScimResponse AddScim (string? apiTokenAction = null, DateTimeOffset? oldApiTokenDeactivation = null)

AddScim: Add SCIM

Generates an API token to be used for SCIM

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IdentityProviderApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IdentityProviderApi>();
            var apiTokenAction = "apiTokenAction_example";  // string? | The action to take. For the API token. Defaults to \"ensure\" (optional) 
            var oldApiTokenDeactivation = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional deactivation date for the old API token. Only used if apiTokenAction is \"regenerate\" (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // AddScimResponse result = apiInstance.AddScim(apiTokenAction, oldApiTokenDeactivation, opts: opts);

                // AddScim: Add SCIM
                AddScimResponse result = apiInstance.AddScim(apiTokenAction, oldApiTokenDeactivation);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IdentityProviderApi.AddScim: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddScimWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // AddScim: Add SCIM
    ApiResponse<AddScimResponse> response = apiInstance.AddScimWithHttpInfo(apiTokenAction, oldApiTokenDeactivation);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IdentityProviderApi.AddScimWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiTokenAction** | **string?** | The action to take. For the API token. Defaults to \&quot;ensure\&quot; | [optional]  |
| **oldApiTokenDeactivation** | **DateTimeOffset?** | Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; | [optional]  |

### Return type

[**AddScimResponse**](AddScimResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The base URL and API token to be used |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="removescim"></a>
# **RemoveScim**
> void RemoveScim ()

RemoveScim: Remove SCIM

Deactivates any existing SCIM API token

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IdentityProviderApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IdentityProviderApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.RemoveScim(opts: opts);

                // RemoveScim: Remove SCIM
                apiInstance.RemoveScim();
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IdentityProviderApi.RemoveScim: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveScimWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // RemoveScim: Remove SCIM
    apiInstance.RemoveScimWithHttpInfo();
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IdentityProviderApi.RemoveScimWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

