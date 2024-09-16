# Finbourne.Identity.Sdk.Api.PersonalAuthenticationTokensApi

All URIs are relative to *https://fbn-prd.lusid.com/identity*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateApiKey**](PersonalAuthenticationTokensApi.md#createapikey) | **POST** /api/keys | CreateApiKey: Create a Personal Access Token |
| [**DeleteApiKey**](PersonalAuthenticationTokensApi.md#deleteapikey) | **DELETE** /api/keys/{id} | DeleteApiKey: Invalidate a Personal Access Token |
| [**ListOwnApiKeys**](PersonalAuthenticationTokensApi.md#listownapikeys) | **GET** /api/keys | ListOwnApiKeys: Gets the meta data for all of the user&#39;s existing Personal Access Tokens. |

<a id="createapikey"></a>
# **CreateApiKey**
> CreatedApiKey CreateApiKey (CreateApiKey createApiKey)

CreateApiKey: Create a Personal Access Token

Generates a Personal Access Token and returns the new key and its associated metadata.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PersonalAuthenticationTokensApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PersonalAuthenticationTokensApi>();
            var createApiKey = new CreateApiKey(); // CreateApiKey | The request to create a new Personal Access Token

            try
            {
                // uncomment the below to set overrides at the request level
                // CreatedApiKey result = apiInstance.CreateApiKey(createApiKey, opts: opts);

                // CreateApiKey: Create a Personal Access Token
                CreatedApiKey result = apiInstance.CreateApiKey(createApiKey);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PersonalAuthenticationTokensApi.CreateApiKey: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateApiKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateApiKey: Create a Personal Access Token
    ApiResponse<CreatedApiKey> response = apiInstance.CreateApiKeyWithHttpInfo(createApiKey);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PersonalAuthenticationTokensApi.CreateApiKeyWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createApiKey** | [**CreateApiKey**](CreateApiKey.md) | The request to create a new Personal Access Token |  |

### Return type

[**CreatedApiKey**](CreatedApiKey.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Personal Access Token and associated meta data. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteapikey"></a>
# **DeleteApiKey**
> ApiKey DeleteApiKey (string id)

DeleteApiKey: Invalidate a Personal Access Token

Immediately invalidates the specified Personal Access Token

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PersonalAuthenticationTokensApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PersonalAuthenticationTokensApi>();
            var id = "id_example";  // string | The id of the Personal Access Token to delete

            try
            {
                // uncomment the below to set overrides at the request level
                // ApiKey result = apiInstance.DeleteApiKey(id, opts: opts);

                // DeleteApiKey: Invalidate a Personal Access Token
                ApiKey result = apiInstance.DeleteApiKey(id);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PersonalAuthenticationTokensApi.DeleteApiKey: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteApiKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteApiKey: Invalidate a Personal Access Token
    ApiResponse<ApiKey> response = apiInstance.DeleteApiKeyWithHttpInfo(id);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PersonalAuthenticationTokensApi.DeleteApiKeyWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the Personal Access Token to delete |  |

### Return type

[**ApiKey**](ApiKey.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Invalidates a Personal Access Token |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listownapikeys"></a>
# **ListOwnApiKeys**
> List&lt;ApiKey&gt; ListOwnApiKeys ()

ListOwnApiKeys: Gets the meta data for all of the user's existing Personal Access Tokens.

Gets the meta data for all of the user's Personal Access Tokens that have not been deleted. They may be  invalid due to the deactivation date having passed.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<PersonalAuthenticationTokensApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<PersonalAuthenticationTokensApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // List<ApiKey> result = apiInstance.ListOwnApiKeys(opts: opts);

                // ListOwnApiKeys: Gets the meta data for all of the user's existing Personal Access Tokens.
                List<ApiKey> result = apiInstance.ListOwnApiKeys();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling PersonalAuthenticationTokensApi.ListOwnApiKeys: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListOwnApiKeysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListOwnApiKeys: Gets the meta data for all of the user's existing Personal Access Tokens.
    ApiResponse<List<ApiKey>> response = apiInstance.ListOwnApiKeysWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling PersonalAuthenticationTokensApi.ListOwnApiKeysWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ApiKey&gt;**](ApiKey.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of user&#39;s existing Personal Access Tokens |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

