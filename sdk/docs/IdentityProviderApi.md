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
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class AddScimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);
            var apiTokenAction = "apiTokenAction_example";  // string? | The action to take. For the API token. Defaults to \"ensure\" (optional) 
            var oldApiTokenDeactivation = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | Optional deactivation date for the old API token. Only used if apiTokenAction is \"regenerate\" (optional) 

            try
            {
                // AddScim: Add SCIM
                AddScimResponse result = apiInstance.AddScim(apiTokenAction, oldApiTokenDeactivation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.AddScim: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityProviderApi.AddScimWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiTokenAction** | **string?** | The action to take. For the API token. Defaults to \&quot;ensure\&quot; | [optional]  |
| **oldApiTokenDeactivation** | **DateTimeOffset?** | Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; | [optional]  |

### Return type

[**AddScimResponse**](AddScimResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The base URL and API token to be used |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removescim"></a>
# **RemoveScim**
> void RemoveScim ()

RemoveScim: Remove SCIM

Deactivates any existing SCIM API token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class RemoveScimExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityProviderApi(config);

            try
            {
                // RemoveScim: Remove SCIM
                apiInstance.RemoveScim();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityProviderApi.RemoveScim: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    Debug.Print("Exception when calling IdentityProviderApi.RemoveScimWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

