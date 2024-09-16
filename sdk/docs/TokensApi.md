# Finbourne.Identity.Sdk.Api.TokensApi

All URIs are relative to *https://fbn-prd.lusid.com/identity*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InvalidateToken**](TokensApi.md#invalidatetoken) | **DELETE** /api/tokens | InvalidateToken: Invalidate current JWT token (sign out) |

<a id="invalidatetoken"></a>
# **InvalidateToken**
> void InvalidateToken ()

InvalidateToken: Invalidate current JWT token (sign out)

Log the current user out of all Finbourne platforms by invalidating the current token

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TokensApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TokensApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.InvalidateToken(opts: opts);

                // InvalidateToken: Invalidate current JWT token (sign out)
                apiInstance.InvalidateToken();
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TokensApi.InvalidateToken: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvalidateTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // InvalidateToken: Invalidate current JWT token (sign out)
    apiInstance.InvalidateTokenWithHttpInfo();
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TokensApi.InvalidateTokenWithHttpInfo: " + e.Message);
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

