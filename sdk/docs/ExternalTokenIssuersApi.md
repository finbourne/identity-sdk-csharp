# Finbourne.Identity.Sdk.Api.ExternalTokenIssuersApi

All URIs are relative to *https://fbn-prd.lusid.com/identity*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateExternalTokenIssuer**](ExternalTokenIssuersApi.md#createexternaltokenissuer) | **POST** /api/externaltokenissuers | [EARLY ACCESS] CreateExternalTokenIssuer: Create an External Token Issuer |
| [**DeleteExternalTokenIssuer**](ExternalTokenIssuersApi.md#deleteexternaltokenissuer) | **DELETE** /api/externaltokenissuers/{code} | [EARLY ACCESS] DeleteExternalTokenIssuer: Deletes an External Token Issuer by code |
| [**GetExternalTokenIssuer**](ExternalTokenIssuersApi.md#getexternaltokenissuer) | **GET** /api/externaltokenissuers/{code} | [EARLY ACCESS] GetExternalTokenIssuer: Gets an External Token Issuer with code |
| [**ListExternalTokenIssuers**](ExternalTokenIssuersApi.md#listexternaltokenissuers) | **GET** /api/externaltokenissuers | [EARLY ACCESS] ListExternalTokenIssuers: Lists all External Token Issuers for a domain |
| [**UpdateExternalTokenIssuer**](ExternalTokenIssuersApi.md#updateexternaltokenissuer) | **PUT** /api/externaltokenissuers/{code} | [EARLY ACCESS] UpdateExternalTokenIssuer: Updates an existing External Token Issuer |

<a id="createexternaltokenissuer"></a>
# **CreateExternalTokenIssuer**
> ExternalTokenIssuerResponse CreateExternalTokenIssuer (CreateExternalTokenIssuerRequest createExternalTokenIssuerRequest)

[EARLY ACCESS] CreateExternalTokenIssuer: Create an External Token Issuer

Creates an External Token Issuer

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ExternalTokenIssuersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ExternalTokenIssuersApi>();
            var createExternalTokenIssuerRequest = new CreateExternalTokenIssuerRequest(); // CreateExternalTokenIssuerRequest | 

            try
            {
                // uncomment the below to set overrides at the request level
                // ExternalTokenIssuerResponse result = apiInstance.CreateExternalTokenIssuer(createExternalTokenIssuerRequest, opts: opts);

                // [EARLY ACCESS] CreateExternalTokenIssuer: Create an External Token Issuer
                ExternalTokenIssuerResponse result = apiInstance.CreateExternalTokenIssuer(createExternalTokenIssuerRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ExternalTokenIssuersApi.CreateExternalTokenIssuer: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateExternalTokenIssuerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateExternalTokenIssuer: Create an External Token Issuer
    ApiResponse<ExternalTokenIssuerResponse> response = apiInstance.CreateExternalTokenIssuerWithHttpInfo(createExternalTokenIssuerRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ExternalTokenIssuersApi.CreateExternalTokenIssuerWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createExternalTokenIssuerRequest** | [**CreateExternalTokenIssuerRequest**](CreateExternalTokenIssuerRequest.md) |  |  |

### Return type

[**ExternalTokenIssuerResponse**](ExternalTokenIssuerResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Create External Token Issuer |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteexternaltokenissuer"></a>
# **DeleteExternalTokenIssuer**
> void DeleteExternalTokenIssuer (string code)

[EARLY ACCESS] DeleteExternalTokenIssuer: Deletes an External Token Issuer by code

Deletes an External Token Issuer

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ExternalTokenIssuersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ExternalTokenIssuersApi>();
            var code = "code_example";  // string | Identifier of the External Token Issuer to delete

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.DeleteExternalTokenIssuer(code, opts: opts);

                // [EARLY ACCESS] DeleteExternalTokenIssuer: Deletes an External Token Issuer by code
                apiInstance.DeleteExternalTokenIssuer(code);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ExternalTokenIssuersApi.DeleteExternalTokenIssuer: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteExternalTokenIssuerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteExternalTokenIssuer: Deletes an External Token Issuer by code
    apiInstance.DeleteExternalTokenIssuerWithHttpInfo(code);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ExternalTokenIssuersApi.DeleteExternalTokenIssuerWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | Identifier of the External Token Issuer to delete |  |

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

<a id="getexternaltokenissuer"></a>
# **GetExternalTokenIssuer**
> ExternalTokenIssuerResponse GetExternalTokenIssuer (string code)

[EARLY ACCESS] GetExternalTokenIssuer: Gets an External Token Issuer with code

Gets an External Token Issuer

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ExternalTokenIssuersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ExternalTokenIssuersApi>();
            var code = "code_example";  // string | Identifier of the External Token Issuer

            try
            {
                // uncomment the below to set overrides at the request level
                // ExternalTokenIssuerResponse result = apiInstance.GetExternalTokenIssuer(code, opts: opts);

                // [EARLY ACCESS] GetExternalTokenIssuer: Gets an External Token Issuer with code
                ExternalTokenIssuerResponse result = apiInstance.GetExternalTokenIssuer(code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ExternalTokenIssuersApi.GetExternalTokenIssuer: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetExternalTokenIssuerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetExternalTokenIssuer: Gets an External Token Issuer with code
    ApiResponse<ExternalTokenIssuerResponse> response = apiInstance.GetExternalTokenIssuerWithHttpInfo(code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ExternalTokenIssuersApi.GetExternalTokenIssuerWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | Identifier of the External Token Issuer |  |

### Return type

[**ExternalTokenIssuerResponse**](ExternalTokenIssuerResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get External Token Issuer |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listexternaltokenissuers"></a>
# **ListExternalTokenIssuers**
> List&lt;ExternalTokenIssuerResponse&gt; ListExternalTokenIssuers ()

[EARLY ACCESS] ListExternalTokenIssuers: Lists all External Token Issuers for a domain

Lists all External Token Issuers

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ExternalTokenIssuersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ExternalTokenIssuersApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // List<ExternalTokenIssuerResponse> result = apiInstance.ListExternalTokenIssuers(opts: opts);

                // [EARLY ACCESS] ListExternalTokenIssuers: Lists all External Token Issuers for a domain
                List<ExternalTokenIssuerResponse> result = apiInstance.ListExternalTokenIssuers();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ExternalTokenIssuersApi.ListExternalTokenIssuers: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListExternalTokenIssuersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListExternalTokenIssuers: Lists all External Token Issuers for a domain
    ApiResponse<List<ExternalTokenIssuerResponse>> response = apiInstance.ListExternalTokenIssuersWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ExternalTokenIssuersApi.ListExternalTokenIssuersWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ExternalTokenIssuerResponse&gt;**](ExternalTokenIssuerResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List External Token Issuers |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updateexternaltokenissuer"></a>
# **UpdateExternalTokenIssuer**
> ExternalTokenIssuerResponse UpdateExternalTokenIssuer (string code, UpdateExternalTokenIssuerRequest updateExternalTokenIssuerRequest)

[EARLY ACCESS] UpdateExternalTokenIssuer: Updates an existing External Token Issuer

Updates an External Token Issuer

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<ExternalTokenIssuersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<ExternalTokenIssuersApi>();
            var code = "code_example";  // string | Identifier of the External Token Issuer to update
            var updateExternalTokenIssuerRequest = new UpdateExternalTokenIssuerRequest(); // UpdateExternalTokenIssuerRequest | 

            try
            {
                // uncomment the below to set overrides at the request level
                // ExternalTokenIssuerResponse result = apiInstance.UpdateExternalTokenIssuer(code, updateExternalTokenIssuerRequest, opts: opts);

                // [EARLY ACCESS] UpdateExternalTokenIssuer: Updates an existing External Token Issuer
                ExternalTokenIssuerResponse result = apiInstance.UpdateExternalTokenIssuer(code, updateExternalTokenIssuerRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ExternalTokenIssuersApi.UpdateExternalTokenIssuer: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateExternalTokenIssuerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateExternalTokenIssuer: Updates an existing External Token Issuer
    ApiResponse<ExternalTokenIssuerResponse> response = apiInstance.UpdateExternalTokenIssuerWithHttpInfo(code, updateExternalTokenIssuerRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling ExternalTokenIssuersApi.UpdateExternalTokenIssuerWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | Identifier of the External Token Issuer to update |  |
| **updateExternalTokenIssuerRequest** | [**UpdateExternalTokenIssuerRequest**](UpdateExternalTokenIssuerRequest.md) |  |  |

### Return type

[**ExternalTokenIssuerResponse**](ExternalTokenIssuerResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update External Token Issuer |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

