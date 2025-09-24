# Finbourne.Identity.Sdk.Api.UsersApi

All URIs are relative to *https://fbn-prd.lusid.com/identity*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateUser**](UsersApi.md#createuser) | **POST** /api/users | CreateUser: Create User |
| [**DeleteUser**](UsersApi.md#deleteuser) | **DELETE** /api/users/{id} | DeleteUser: Delete User |
| [**ExpirePassword**](UsersApi.md#expirepassword) | **POST** /api/users/{id}/lifecycle/$expirepassword | ExpirePassword: Reset the user&#39;s password to a temporary one |
| [**FindUsersById**](UsersApi.md#findusersbyid) | **GET** /api/directory | FindUsersById: Find users by id endpoint |
| [**GetUser**](UsersApi.md#getuser) | **GET** /api/users/{id} | GetUser: Get User |
| [**GetUserSchema**](UsersApi.md#getuserschema) | **GET** /api/users/schema | [EARLY ACCESS] GetUserSchema: Get User Schema |
| [**ListRunnableUsers**](UsersApi.md#listrunnableusers) | **GET** /api/users/$runnable | [EARLY ACCESS] ListRunnableUsers: List Runable Users |
| [**ListUsers**](UsersApi.md#listusers) | **GET** /api/users | ListUsers: List Users |
| [**ResetFactors**](UsersApi.md#resetfactors) | **POST** /api/users/{id}/lifecycle/$resetfactors | ResetFactors: Reset MFA factors |
| [**ResetPassword**](UsersApi.md#resetpassword) | **POST** /api/users/{id}/lifecycle/$resetpassword | ResetPassword: Reset Password |
| [**SendActivationEmail**](UsersApi.md#sendactivationemail) | **POST** /api/users/{id}/lifecycle/$activate | SendActivationEmail: Sends an activation email to the User |
| [**UnlockUser**](UsersApi.md#unlockuser) | **POST** /api/users/{id}/lifecycle/$unlock | UnlockUser: Unlock User |
| [**UnsuspendUser**](UsersApi.md#unsuspenduser) | **POST** /api/users/{id}/lifecycle/$unsuspend | [EXPERIMENTAL] UnsuspendUser: Unsuspend user |
| [**UpdateUser**](UsersApi.md#updateuser) | **PUT** /api/users/{id} | UpdateUser: Update User |
| [**UpdateUserSchema**](UsersApi.md#updateuserschema) | **PUT** /api/users/schema | [EARLY ACCESS] UpdateUserSchema: Update User Schema |

<a id="createuser"></a>
# **CreateUser**
> UserResponse CreateUser (CreateUserRequest createUserRequest, bool? waitForReindex = null)

CreateUser: Create User

Create a new User

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<UsersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UsersApi>();
            var createUserRequest = new CreateUserRequest(); // CreateUserRequest | Details of the User to be created
            var waitForReindex = false;  // bool? | Should the request wait until the newly created User is indexed (available in List) before returning (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // UserResponse result = apiInstance.CreateUser(createUserRequest, waitForReindex, opts: opts);

                // CreateUser: Create User
                UserResponse result = apiInstance.CreateUser(createUserRequest, waitForReindex);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UsersApi.CreateUser: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateUser: Create User
    ApiResponse<UserResponse> response = apiInstance.CreateUserWithHttpInfo(createUserRequest, waitForReindex);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UsersApi.CreateUserWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createUserRequest** | [**CreateUserRequest**](CreateUserRequest.md) | Details of the User to be created |  |
| **waitForReindex** | **bool?** | Should the request wait until the newly created User is indexed (available in List) before returning | [optional] [default to false] |

### Return type

[**UserResponse**](UserResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Create a new user |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (string id, bool? purge = null)

DeleteUser: Delete User

By default the user will be de-provisioned and inactive, however their record will remain in the identity  provider for audit purposes. If this is not desirable and removal of all trace of the user is required,  the purge parameter can be specified to indicate the details should be purged completely.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<UsersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UsersApi>();
            var id = "id_example";  // string | The unique identifier for the user
            var purge = true;  // bool? | Whether to purge any trace of the user from the identity provider (will affect audit) (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.DeleteUser(id, purge, opts: opts);

                // DeleteUser: Delete User
                apiInstance.DeleteUser(id, purge);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UsersApi.DeleteUser: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteUser: Delete User
    apiInstance.DeleteUserWithHttpInfo(id, purge);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UsersApi.DeleteUserWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier for the user |  |
| **purge** | **bool?** | Whether to purge any trace of the user from the identity provider (will affect audit) | [optional]  |

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

<a id="expirepassword"></a>
# **ExpirePassword**
> TemporaryPassword ExpirePassword (string id)

ExpirePassword: Reset the user's password to a temporary one

Resets the user's password to a temporary one which is then expired

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<UsersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UsersApi>();
            var id = "id_example";  // string | The unique identifier for the User having its password reset

            try
            {
                // uncomment the below to set overrides at the request level
                // TemporaryPassword result = apiInstance.ExpirePassword(id, opts: opts);

                // ExpirePassword: Reset the user's password to a temporary one
                TemporaryPassword result = apiInstance.ExpirePassword(id);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UsersApi.ExpirePassword: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExpirePasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ExpirePassword: Reset the user's password to a temporary one
    ApiResponse<TemporaryPassword> response = apiInstance.ExpirePasswordWithHttpInfo(id);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UsersApi.ExpirePasswordWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier for the User having its password reset |  |

### Return type

[**TemporaryPassword**](TemporaryPassword.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Reset the user&#39;s password |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="findusersbyid"></a>
# **FindUsersById**
> ListUsersResponse FindUsersById (List<string> id)

FindUsersById: Find users by id endpoint

Finds a maximum of 50 users by ID

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<UsersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UsersApi>();
            var id = new List<string>(); // List<string> | A list of unique identifiers for the users

            try
            {
                // uncomment the below to set overrides at the request level
                // ListUsersResponse result = apiInstance.FindUsersById(id, opts: opts);

                // FindUsersById: Find users by id endpoint
                ListUsersResponse result = apiInstance.FindUsersById(id);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UsersApi.FindUsersById: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindUsersByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // FindUsersById: Find users by id endpoint
    ApiResponse<ListUsersResponse> response = apiInstance.FindUsersByIdWithHttpInfo(id);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UsersApi.FindUsersByIdWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | [**List&lt;string&gt;**](string.md) | A list of unique identifiers for the users |  |

### Return type

[**ListUsersResponse**](ListUsersResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getuser"></a>
# **GetUser**
> UserResponse GetUser (string id, bool? includeRoles = null)

GetUser: Get User

Get the specified User

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<UsersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UsersApi>();
            var id = "id_example";  // string | The unique identifier for the User
            var includeRoles = true;  // bool? | Flag indicating that the users roles should be included in the response (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // UserResponse result = apiInstance.GetUser(id, includeRoles, opts: opts);

                // GetUser: Get User
                UserResponse result = apiInstance.GetUser(id, includeRoles);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UsersApi.GetUser: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetUser: Get User
    ApiResponse<UserResponse> response = apiInstance.GetUserWithHttpInfo(id, includeRoles);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UsersApi.GetUserWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier for the User |  |
| **includeRoles** | **bool?** | Flag indicating that the users roles should be included in the response | [optional]  |

### Return type

[**UserResponse**](UserResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get the specified user |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getuserschema"></a>
# **GetUserSchema**
> UserSchemaResponse GetUserSchema ()

[EARLY ACCESS] GetUserSchema: Get User Schema

Get the User Schema

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<UsersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UsersApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // UserSchemaResponse result = apiInstance.GetUserSchema(opts: opts);

                // [EARLY ACCESS] GetUserSchema: Get User Schema
                UserSchemaResponse result = apiInstance.GetUserSchema();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UsersApi.GetUserSchema: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetUserSchema: Get User Schema
    ApiResponse<UserSchemaResponse> response = apiInstance.GetUserSchemaWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UsersApi.GetUserSchemaWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserSchemaResponse**](UserSchemaResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update the User Schema |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listrunnableusers"></a>
# **ListRunnableUsers**
> List&lt;UserResponse&gt; ListRunnableUsers ()

[EARLY ACCESS] ListRunnableUsers: List Runable Users

List the available runnable Users

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<UsersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UsersApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // List<UserResponse> result = apiInstance.ListRunnableUsers(opts: opts);

                // [EARLY ACCESS] ListRunnableUsers: List Runable Users
                List<UserResponse> result = apiInstance.ListRunnableUsers();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UsersApi.ListRunnableUsers: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRunnableUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListRunnableUsers: List Runable Users
    ApiResponse<List<UserResponse>> response = apiInstance.ListRunnableUsersWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UsersApi.ListRunnableUsersWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;UserResponse&gt;**](UserResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List the available runnable users |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listusers"></a>
# **ListUsers**
> List&lt;UserResponse&gt; ListUsers (bool? includeDeactivated = null)

ListUsers: List Users

List the available Users

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<UsersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UsersApi>();
            var includeDeactivated = false;  // bool? | Include previously deleted (not purged) users (optional)  (default to false)

            try
            {
                // uncomment the below to set overrides at the request level
                // List<UserResponse> result = apiInstance.ListUsers(includeDeactivated, opts: opts);

                // ListUsers: List Users
                List<UserResponse> result = apiInstance.ListUsers(includeDeactivated);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UsersApi.ListUsers: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListUsers: List Users
    ApiResponse<List<UserResponse>> response = apiInstance.ListUsersWithHttpInfo(includeDeactivated);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UsersApi.ListUsersWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeDeactivated** | **bool?** | Include previously deleted (not purged) users | [optional] [default to false] |

### Return type

[**List&lt;UserResponse&gt;**](UserResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List the available users |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="resetfactors"></a>
# **ResetFactors**
> void ResetFactors (string id)

ResetFactors: Reset MFA factors

Resets the MFA factors of the specified User

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<UsersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UsersApi>();
            var id = "id_example";  // string | The unique identifier for the User having their MFA factors reset

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.ResetFactors(id, opts: opts);

                // ResetFactors: Reset MFA factors
                apiInstance.ResetFactors(id);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UsersApi.ResetFactors: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResetFactorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ResetFactors: Reset MFA factors
    apiInstance.ResetFactorsWithHttpInfo(id);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UsersApi.ResetFactorsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier for the User having their MFA factors reset |  |

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

<a id="resetpassword"></a>
# **ResetPassword**
> void ResetPassword (string id)

ResetPassword: Reset Password

Resets the password of the specified User

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<UsersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UsersApi>();
            var id = "id_example";  // string | The unique identifier for the User having their password reset

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.ResetPassword(id, opts: opts);

                // ResetPassword: Reset Password
                apiInstance.ResetPassword(id);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UsersApi.ResetPassword: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResetPasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ResetPassword: Reset Password
    apiInstance.ResetPasswordWithHttpInfo(id);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UsersApi.ResetPasswordWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier for the User having their password reset |  |

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

<a id="sendactivationemail"></a>
# **SendActivationEmail**
> void SendActivationEmail (string id)

SendActivationEmail: Sends an activation email to the User

Sends an activation email to the specified User

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<UsersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UsersApi>();
            var id = "id_example";  // string | The unique identifier for the User to be activated

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.SendActivationEmail(id, opts: opts);

                // SendActivationEmail: Sends an activation email to the User
                apiInstance.SendActivationEmail(id);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UsersApi.SendActivationEmail: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendActivationEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // SendActivationEmail: Sends an activation email to the User
    apiInstance.SendActivationEmailWithHttpInfo(id);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UsersApi.SendActivationEmailWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier for the User to be activated |  |

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

<a id="unlockuser"></a>
# **UnlockUser**
> void UnlockUser (string id)

UnlockUser: Unlock User

Unlocks the specified User

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<UsersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UsersApi>();
            var id = "id_example";  // string | The unique identifier for the User to be unlocked

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.UnlockUser(id, opts: opts);

                // UnlockUser: Unlock User
                apiInstance.UnlockUser(id);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UsersApi.UnlockUser: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnlockUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UnlockUser: Unlock User
    apiInstance.UnlockUserWithHttpInfo(id);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UsersApi.UnlockUserWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier for the User to be unlocked |  |

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

<a id="unsuspenduser"></a>
# **UnsuspendUser**
> void UnsuspendUser (string id)

[EXPERIMENTAL] UnsuspendUser: Unsuspend user

Unsuspend the user

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<UsersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UsersApi>();
            var id = "id_example";  // string | The unique identifier for the User to Unsuspend

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.UnsuspendUser(id, opts: opts);

                // [EXPERIMENTAL] UnsuspendUser: Unsuspend user
                apiInstance.UnsuspendUser(id);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UsersApi.UnsuspendUser: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnsuspendUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UnsuspendUser: Unsuspend user
    apiInstance.UnsuspendUserWithHttpInfo(id);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UsersApi.UnsuspendUserWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier for the User to Unsuspend |  |

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

<a id="updateuser"></a>
# **UpdateUser**
> UserResponse UpdateUser (string id, UpdateUserRequest updateUserRequest)

UpdateUser: Update User

Updates the specified User

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<UsersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UsersApi>();
            var id = "id_example";  // string | The unique identifier for the User to be updated
            var updateUserRequest = new UpdateUserRequest(); // UpdateUserRequest | The new definition of the User

            try
            {
                // uncomment the below to set overrides at the request level
                // UserResponse result = apiInstance.UpdateUser(id, updateUserRequest, opts: opts);

                // UpdateUser: Update User
                UserResponse result = apiInstance.UpdateUser(id, updateUserRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UsersApi.UpdateUser: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateUser: Update User
    ApiResponse<UserResponse> response = apiInstance.UpdateUserWithHttpInfo(id, updateUserRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UsersApi.UpdateUserWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The unique identifier for the User to be updated |  |
| **updateUserRequest** | [**UpdateUserRequest**](UpdateUserRequest.md) | The new definition of the User |  |

### Return type

[**UserResponse**](UserResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update a user |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updateuserschema"></a>
# **UpdateUserSchema**
> UserSchemaResponse UpdateUserSchema (UpdateUserSchemaRequest updateUserSchemaRequest)

[EARLY ACCESS] UpdateUserSchema: Update User Schema

Update the User Schema

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<UsersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<UsersApi>();
            var updateUserSchemaRequest = new UpdateUserSchemaRequest(); // UpdateUserSchemaRequest | The new User Schema

            try
            {
                // uncomment the below to set overrides at the request level
                // UserSchemaResponse result = apiInstance.UpdateUserSchema(updateUserSchemaRequest, opts: opts);

                // [EARLY ACCESS] UpdateUserSchema: Update User Schema
                UserSchemaResponse result = apiInstance.UpdateUserSchema(updateUserSchemaRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling UsersApi.UpdateUserSchema: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserSchemaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpdateUserSchema: Update User Schema
    ApiResponse<UserSchemaResponse> response = apiInstance.UpdateUserSchemaWithHttpInfo(updateUserSchemaRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling UsersApi.UpdateUserSchemaWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateUserSchemaRequest** | [**UpdateUserSchemaRequest**](UpdateUserSchemaRequest.md) | The new User Schema |  |

### Return type

[**UserSchemaResponse**](UserSchemaResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update the User Schema |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

