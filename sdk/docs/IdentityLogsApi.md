# Finbourne.Identity.Sdk.Api.IdentityLogsApi

All URIs are relative to *https://fbn-prd.lusid.com/identity*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListLogs**](IdentityLogsApi.md#listlogs) | **GET** /api/logs | [BETA] ListLogs: Lists system logs for a domain |
| [**ListUserLogs**](IdentityLogsApi.md#listuserlogs) | **GET** /api/logs/me | [BETA] ListUserLogs: Lists user logs |

<a id="listlogs"></a>
# **ListLogs**
> ResourceListOfSystemLog ListLogs (DateTimeOffset? oktaSince = null, DateTimeOffset? oktaUntil = null, string? oktaFilter = null, string? oktaQuery = null, int? oktaLimit = null, string? oktaSortOrder = null, string? oktaAfter = null)

[BETA] ListLogs: Lists system logs for a domain

Lists system logs for a domain

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IdentityLogsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IdentityLogsApi>();
            var oktaSince = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Lower bound of log events published property (optional) 
            var oktaUntil = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Upper bound of log events published property (optional) 
            var oktaFilter = "oktaFilter_example";  // string? | Okta filter expression (optional) 
            var oktaQuery = "oktaQuery_example";  // string? | Filters log events results by one or more case insensitive keywords (optional) 
            var oktaLimit = 56;  // int? | Max number of results returned (optional) 
            var oktaSortOrder = "oktaSortOrder_example";  // string? | Order of events by published property. Either ASCENDING or DESCENDING (optional) 
            var oktaAfter = "oktaAfter_example";  // string? | Okta Page token (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfSystemLog result = apiInstance.ListLogs(oktaSince, oktaUntil, oktaFilter, oktaQuery, oktaLimit, oktaSortOrder, oktaAfter, opts: opts);

                // [BETA] ListLogs: Lists system logs for a domain
                ResourceListOfSystemLog result = apiInstance.ListLogs(oktaSince, oktaUntil, oktaFilter, oktaQuery, oktaLimit, oktaSortOrder, oktaAfter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IdentityLogsApi.ListLogs: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [BETA] ListLogs: Lists system logs for a domain
    ApiResponse<ResourceListOfSystemLog> response = apiInstance.ListLogsWithHttpInfo(oktaSince, oktaUntil, oktaFilter, oktaQuery, oktaLimit, oktaSortOrder, oktaAfter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IdentityLogsApi.ListLogsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oktaSince** | **DateTimeOffset?** | Lower bound of log events published property | [optional]  |
| **oktaUntil** | **DateTimeOffset?** | Upper bound of log events published property | [optional]  |
| **oktaFilter** | **string?** | Okta filter expression | [optional]  |
| **oktaQuery** | **string?** | Filters log events results by one or more case insensitive keywords | [optional]  |
| **oktaLimit** | **int?** | Max number of results returned | [optional]  |
| **oktaSortOrder** | **string?** | Order of events by published property. Either ASCENDING or DESCENDING | [optional]  |
| **oktaAfter** | **string?** | Okta Page token | [optional]  |

### Return type

[**ResourceListOfSystemLog**](ResourceListOfSystemLog.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List Logs |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listuserlogs"></a>
# **ListUserLogs**
> ResourceListOfSystemLog ListUserLogs (DateTimeOffset? oktaSince = null, DateTimeOffset? oktaUntil = null, int? oktaLimit = null, string? oktaSortOrder = null, string? oktaAfter = null)

[BETA] ListUserLogs: Lists user logs

Lists account related system logs for the calling user

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<IdentityLogsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<IdentityLogsApi>();
            var oktaSince = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Lower bound of log events published property (optional) 
            var oktaUntil = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Upper bound of log events published property (optional) 
            var oktaLimit = 56;  // int? | Max number of results returned (optional) 
            var oktaSortOrder = "oktaSortOrder_example";  // string? | Order of events by published property. Either ASCENDING or DESCENDING (optional) 
            var oktaAfter = "oktaAfter_example";  // string? | Okta Page token (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfSystemLog result = apiInstance.ListUserLogs(oktaSince, oktaUntil, oktaLimit, oktaSortOrder, oktaAfter, opts: opts);

                // [BETA] ListUserLogs: Lists user logs
                ResourceListOfSystemLog result = apiInstance.ListUserLogs(oktaSince, oktaUntil, oktaLimit, oktaSortOrder, oktaAfter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling IdentityLogsApi.ListUserLogs: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListUserLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [BETA] ListUserLogs: Lists user logs
    ApiResponse<ResourceListOfSystemLog> response = apiInstance.ListUserLogsWithHttpInfo(oktaSince, oktaUntil, oktaLimit, oktaSortOrder, oktaAfter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling IdentityLogsApi.ListUserLogsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oktaSince** | **DateTimeOffset?** | Lower bound of log events published property | [optional]  |
| **oktaUntil** | **DateTimeOffset?** | Upper bound of log events published property | [optional]  |
| **oktaLimit** | **int?** | Max number of results returned | [optional]  |
| **oktaSortOrder** | **string?** | Order of events by published property. Either ASCENDING or DESCENDING | [optional]  |
| **oktaAfter** | **string?** | Okta Page token | [optional]  |

### Return type

[**ResourceListOfSystemLog**](ResourceListOfSystemLog.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List User Logs |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

