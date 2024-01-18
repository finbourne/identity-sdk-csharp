# Finbourne.Identity.Sdk.Api.AuthenticationApi

All URIs are relative to *https://fbn-prd.lusid.com/identity*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAuthenticationInformation**](AuthenticationApi.md#getauthenticationinformation) | **GET** /api/authentication/information | GetAuthenticationInformation: Gets AuthenticationInformation |
| [**GetPasswordPolicy**](AuthenticationApi.md#getpasswordpolicy) | **GET** /api/authentication/password-policy/{userType} | [EXPERIMENTAL] GetPasswordPolicy: Gets password policy for a user type |
| [**GetSupportAccessHistory**](AuthenticationApi.md#getsupportaccesshistory) | **GET** /api/authentication/support | [EARLY ACCESS] GetSupportAccessHistory: Get the history of all support access granted and any information pertaining to their termination |
| [**GetSupportRoles**](AuthenticationApi.md#getsupportroles) | **GET** /api/authentication/support-roles | [EARLY ACCESS] GetSupportRoles: Get mapping of support roles, the internal representation to a human friendly representation |
| [**GrantSupportAccess**](AuthenticationApi.md#grantsupportaccess) | **POST** /api/authentication/support | [EARLY ACCESS] GrantSupportAccess: Grants FINBOURNE support access to your account |
| [**InvalidateSupportAccess**](AuthenticationApi.md#invalidatesupportaccess) | **DELETE** /api/authentication/support | [EARLY ACCESS] InvalidateSupportAccess: Revoke any FINBOURNE support access to your account |
| [**UpdatePasswordPolicy**](AuthenticationApi.md#updatepasswordpolicy) | **PUT** /api/authentication/password-policy/{userType} | [EXPERIMENTAL] UpdatePasswordPolicy: Updates password policy for a user type |

<a id="getauthenticationinformation"></a>
# **GetAuthenticationInformation**
> AuthenticationInformation GetAuthenticationInformation ()

GetAuthenticationInformation: Gets AuthenticationInformation

Get the AuthenticationInformation associated with the current domain. This includes all the  necessary information to login to this domain.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class GetAuthenticationInformationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationApi(config);

            try
            {
                // GetAuthenticationInformation: Gets AuthenticationInformation
                AuthenticationInformation result = apiInstance.GetAuthenticationInformation();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetAuthenticationInformation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAuthenticationInformationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetAuthenticationInformation: Gets AuthenticationInformation
    ApiResponse<AuthenticationInformation> response = apiInstance.GetAuthenticationInformationWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.GetAuthenticationInformationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AuthenticationInformation**](AuthenticationInformation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get authentication information |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpasswordpolicy"></a>
# **GetPasswordPolicy**
> PasswordPolicyDto GetPasswordPolicy (string userType)

[EXPERIMENTAL] GetPasswordPolicy: Gets password policy for a user type

Get the password policy for a given user type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class GetPasswordPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationApi(config);
            var userType = "userType_example";  // string | The type of user (should only be personal or service)

            try
            {
                // [EXPERIMENTAL] GetPasswordPolicy: Gets password policy for a user type
                PasswordPolicyDto result = apiInstance.GetPasswordPolicy(userType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetPasswordPolicy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPasswordPolicyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetPasswordPolicy: Gets password policy for a user type
    ApiResponse<PasswordPolicyDto> response = apiInstance.GetPasswordPolicyWithHttpInfo(userType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.GetPasswordPolicyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userType** | **string** | The type of user (should only be personal or service) |  |

### Return type

[**PasswordPolicyDto**](PasswordPolicyDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get password policy |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsupportaccesshistory"></a>
# **GetSupportAccessHistory**
> List&lt;SupportAccessResponse&gt; GetSupportAccessHistory (DateTimeOffset? start = null, DateTimeOffset? end = null)

[EARLY ACCESS] GetSupportAccessHistory: Get the history of all support access granted and any information pertaining to their termination

The active and inactive support requests will be returned, inactive support requests will have information pertaining to their termination  including obfuscated userIds of those who created and terminated the request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class GetSupportAccessHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationApi(config);
            var start = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The start expiry date to query support access requests from (optional) 
            var end = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The end expiry date to query support access requests to (optional) 

            try
            {
                // [EARLY ACCESS] GetSupportAccessHistory: Get the history of all support access granted and any information pertaining to their termination
                List<SupportAccessResponse> result = apiInstance.GetSupportAccessHistory(start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetSupportAccessHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSupportAccessHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetSupportAccessHistory: Get the history of all support access granted and any information pertaining to their termination
    ApiResponse<List<SupportAccessResponse>> response = apiInstance.GetSupportAccessHistoryWithHttpInfo(start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.GetSupportAccessHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **DateTimeOffset?** | The start expiry date to query support access requests from | [optional]  |
| **end** | **DateTimeOffset?** | The end expiry date to query support access requests to | [optional]  |

### Return type

[**List&lt;SupportAccessResponse&gt;**](SupportAccessResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get support access history |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsupportroles"></a>
# **GetSupportRoles**
> SupportRolesResponse GetSupportRoles ()

[EARLY ACCESS] GetSupportRoles: Get mapping of support roles, the internal representation to a human friendly representation

Get mapping of support roles, the internal representation to a human friendly representation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class GetSupportRolesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationApi(config);

            try
            {
                // [EARLY ACCESS] GetSupportRoles: Get mapping of support roles, the internal representation to a human friendly representation
                SupportRolesResponse result = apiInstance.GetSupportRoles();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GetSupportRoles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSupportRolesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetSupportRoles: Get mapping of support roles, the internal representation to a human friendly representation
    ApiResponse<SupportRolesResponse> response = apiInstance.GetSupportRolesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.GetSupportRolesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SupportRolesResponse**](SupportRolesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get support roles |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="grantsupportaccess"></a>
# **GrantSupportAccess**
> SupportAccessResponse GrantSupportAccess (SupportAccessRequest supportAccessRequest)

[EARLY ACCESS] GrantSupportAccess: Grants FINBOURNE support access to your account

Granting support access will allow FINBOURNE employees full access to your data with the express intent to investigate support issues  You can revoke this (and all) access at any time using the InvalidateSupportAccess endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class GrantSupportAccessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationApi(config);
            var supportAccessRequest = new SupportAccessRequest(); // SupportAccessRequest | Request detailing the duration and reasons for supplying support access

            try
            {
                // [EARLY ACCESS] GrantSupportAccess: Grants FINBOURNE support access to your account
                SupportAccessResponse result = apiInstance.GrantSupportAccess(supportAccessRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.GrantSupportAccess: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GrantSupportAccessWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GrantSupportAccess: Grants FINBOURNE support access to your account
    ApiResponse<SupportAccessResponse> response = apiInstance.GrantSupportAccessWithHttpInfo(supportAccessRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.GrantSupportAccessWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **supportAccessRequest** | [**SupportAccessRequest**](SupportAccessRequest.md) | Request detailing the duration and reasons for supplying support access |  |

### Return type

[**SupportAccessResponse**](SupportAccessResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Grant Support Access |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="invalidatesupportaccess"></a>
# **InvalidateSupportAccess**
> List&lt;SupportAccessResponse&gt; InvalidateSupportAccess ()

[EARLY ACCESS] InvalidateSupportAccess: Revoke any FINBOURNE support access to your account

This will result in a loss of access to your data for all FINBOURNE support agents

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class InvalidateSupportAccessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationApi(config);

            try
            {
                // [EARLY ACCESS] InvalidateSupportAccess: Revoke any FINBOURNE support access to your account
                List<SupportAccessResponse> result = apiInstance.InvalidateSupportAccess();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.InvalidateSupportAccess: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InvalidateSupportAccessWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] InvalidateSupportAccess: Revoke any FINBOURNE support access to your account
    ApiResponse<List<SupportAccessResponse>> response = apiInstance.InvalidateSupportAccessWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.InvalidateSupportAccessWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;SupportAccessResponse&gt;**](SupportAccessResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Invalidate all currently active support requests |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatepasswordpolicy"></a>
# **UpdatePasswordPolicy**
> PasswordPolicyDto UpdatePasswordPolicy (string userType, PasswordPolicyDto? passwordPolicyDto = null)

[EXPERIMENTAL] UpdatePasswordPolicy: Updates password policy for a user type

Update the password policy for a given user type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Identity.Sdk.Api;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Model;

namespace Example
{
    public class UpdatePasswordPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/identity";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AuthenticationApi(config);
            var userType = "userType_example";  // string | The type of user (should only be personal or service)
            var passwordPolicyDto = new PasswordPolicyDto?(); // PasswordPolicyDto? | The password policy for the given user type (optional) 

            try
            {
                // [EXPERIMENTAL] UpdatePasswordPolicy: Updates password policy for a user type
                PasswordPolicyDto result = apiInstance.UpdatePasswordPolicy(userType, passwordPolicyDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.UpdatePasswordPolicy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePasswordPolicyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdatePasswordPolicy: Updates password policy for a user type
    ApiResponse<PasswordPolicyDto> response = apiInstance.UpdatePasswordPolicyWithHttpInfo(userType, passwordPolicyDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.UpdatePasswordPolicyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userType** | **string** | The type of user (should only be personal or service) |  |
| **passwordPolicyDto** | [**PasswordPolicyDto?**](PasswordPolicyDto?.md) | The password policy for the given user type | [optional]  |

### Return type

[**PasswordPolicyDto**](PasswordPolicyDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update password policy |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

