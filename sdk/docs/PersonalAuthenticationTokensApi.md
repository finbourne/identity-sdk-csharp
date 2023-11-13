# Finbourne.Identity.Sdk.Api.PersonalAuthenticationTokensApi

All URIs are relative to *https://fbn-prd.lusid.com/identity*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateApiKey**](PersonalAuthenticationTokensApi.md#createapikey) | **POST** /api/keys | [EARLY ACCESS] CreateApiKey: Create a Personal Access Token |
| [**DeleteApiKey**](PersonalAuthenticationTokensApi.md#deleteapikey) | **DELETE** /api/keys/{id} | [EARLY ACCESS] DeleteApiKey: Invalidate a Personal Access Token |
| [**ListOwnApiKeys**](PersonalAuthenticationTokensApi.md#listownapikeys) | **GET** /api/keys | [EARLY ACCESS] ListOwnApiKeys: Gets the meta data for all of the user&#39;s existing Personal Access Tokens. |

<a id="createapikey"></a>
# **CreateApiKey**
> CreatedApiKey CreateApiKey (CreateApiKey createApiKey)

[EARLY ACCESS] CreateApiKey: Create a Personal Access Token

Generates a Personal Access Token and returns the new key and its associated metadata.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class CreateApiKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonalAuthenticationTokensApi(config);
            var createApiKey = new CreateApiKey(); // CreateApiKey | The request to create a new Personal Access Token

            try
            {
                // [EARLY ACCESS] CreateApiKey: Create a Personal Access Token
                CreatedApiKey result = apiInstance.CreateApiKey(createApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalAuthenticationTokensApi.CreateApiKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] CreateApiKey: Create a Personal Access Token
    ApiResponse<CreatedApiKey> response = apiInstance.CreateApiKeyWithHttpInfo(createApiKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonalAuthenticationTokensApi.CreateApiKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createApiKey** | [**CreateApiKey**](CreateApiKey.md) | The request to create a new Personal Access Token |  |

### Return type

[**CreatedApiKey**](CreatedApiKey.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Personal Access Token and associated meta data. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteapikey"></a>
# **DeleteApiKey**
> ApiKey DeleteApiKey (string id)

[EARLY ACCESS] DeleteApiKey: Invalidate a Personal Access Token

Immediately invalidates the specified Personal Access Token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class DeleteApiKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonalAuthenticationTokensApi(config);
            var id = "id_example";  // string | The id of the Personal Access Token to delete

            try
            {
                // [EARLY ACCESS] DeleteApiKey: Invalidate a Personal Access Token
                ApiKey result = apiInstance.DeleteApiKey(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalAuthenticationTokensApi.DeleteApiKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] DeleteApiKey: Invalidate a Personal Access Token
    ApiResponse<ApiKey> response = apiInstance.DeleteApiKeyWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonalAuthenticationTokensApi.DeleteApiKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The id of the Personal Access Token to delete |  |

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Invalidates a Personal Access Token |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listownapikeys"></a>
# **ListOwnApiKeys**
> List&lt;ApiKey&gt; ListOwnApiKeys ()

[EARLY ACCESS] ListOwnApiKeys: Gets the meta data for all of the user's existing Personal Access Tokens.

Gets the meta data for all of the user's Personal Access Tokens that have not been deleted. They may be  invalid due to the deactivation date having passed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class ListOwnApiKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonalAuthenticationTokensApi(config);

            try
            {
                // [EARLY ACCESS] ListOwnApiKeys: Gets the meta data for all of the user's existing Personal Access Tokens.
                List<ApiKey> result = apiInstance.ListOwnApiKeys();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalAuthenticationTokensApi.ListOwnApiKeys: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EARLY ACCESS] ListOwnApiKeys: Gets the meta data for all of the user's existing Personal Access Tokens.
    ApiResponse<List<ApiKey>> response = apiInstance.ListOwnApiKeysWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PersonalAuthenticationTokensApi.ListOwnApiKeysWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ApiKey&gt;**](ApiKey.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of user&#39;s existing Personal Access Tokens |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

