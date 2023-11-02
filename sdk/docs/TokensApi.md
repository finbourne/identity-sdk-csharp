# Finbourne.Identity.Sdk.Api.TokensApi

All URIs are relative to *https://fbn-ci.lusid.com/identity*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InvalidateToken**](TokensApi.md#invalidatetoken) | **DELETE** /api/tokens | [EARLY ACCESS] InvalidateToken: Invalidate current JWT token (sign out) |

<a id="invalidatetoken"></a>
# **InvalidateToken**
> void InvalidateToken ()

[EARLY ACCESS] InvalidateToken: Invalidate current JWT token (sign out)

Log the current user out of all Finbourne platforms by invalidating the current token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class InvalidateTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TokensApi(config);

            try
            {
                // [EARLY ACCESS] InvalidateToken: Invalidate current JWT token (sign out)
                apiInstance.InvalidateToken();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokensApi.InvalidateToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] InvalidateToken: Invalidate current JWT token (sign out)
    apiInstance.InvalidateTokenWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokensApi.InvalidateTokenWithHttpInfo: " + e.Message);
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

