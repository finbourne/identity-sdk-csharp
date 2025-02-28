# Finbourne.Identity.Sdk.Api.SystemLogsApi

All URIs are relative to *https://fbn-prd.lusid.com/identity*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListLogs**](SystemLogsApi.md#listlogs) | **GET** /api/logs | [BETA] ListLogs: Lists system logs for a domain |

<a id="listlogs"></a>
# **ListLogs**
> ResourceListOfSystemLog ListLogs (DateTimeOffset? since = null, DateTimeOffset? until = null, string? after = null, string? filter = null, string? query = null, int? limit = null, string? sortOrder = null)

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SystemLogsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SystemLogsApi>();
            var since = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Lower bound of log events published property (optional) 
            var until = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Upper bound of log events published property (optional) 
            var after = "after_example";  // string? | Page token (optional) 
            var filter = "filter_example";  // string? | Okta filter expression (optional) 
            var query = "query_example";  // string? | Filters log events results by one or more case insensitive keywords (optional) 
            var limit = 56;  // int? | Max number of results returned (optional) 
            var sortOrder = "sortOrder_example";  // string? | Order of events by published property. Either ASCENDING or DESCENDING (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfSystemLog result = apiInstance.ListLogs(since, until, after, filter, query, limit, sortOrder, opts: opts);

                // [BETA] ListLogs: Lists system logs for a domain
                ResourceListOfSystemLog result = apiInstance.ListLogs(since, until, after, filter, query, limit, sortOrder);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SystemLogsApi.ListLogs: " + e.Message);
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
    ApiResponse<ResourceListOfSystemLog> response = apiInstance.ListLogsWithHttpInfo(since, until, after, filter, query, limit, sortOrder);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SystemLogsApi.ListLogsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **since** | **DateTimeOffset?** | Lower bound of log events published property | [optional]  |
| **until** | **DateTimeOffset?** | Upper bound of log events published property | [optional]  |
| **after** | **string?** | Page token | [optional]  |
| **filter** | **string?** | Okta filter expression | [optional]  |
| **query** | **string?** | Filters log events results by one or more case insensitive keywords | [optional]  |
| **limit** | **int?** | Max number of results returned | [optional]  |
| **sortOrder** | **string?** | Order of events by published property. Either ASCENDING or DESCENDING | [optional]  |

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

