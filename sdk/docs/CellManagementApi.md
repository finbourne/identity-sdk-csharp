# Finbourne.Identity.Sdk.Api.CellManagementApi

All URIs are relative to *https://fbn-prd.lusid.com/identity*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AcceptCellAttachment**](CellManagementApi.md#acceptcellattachment) | **POST** /api/cellmanagement/acceptattachment | [EARLY ACCESS] AcceptCellAttachment: Accept (or retry) a cell attachment |
| [**DetachParentCell**](CellManagementApi.md#detachparentcell) | **PUT** /api/cellmanagement/detach | [EARLY ACCESS] DetachParentCell: Detach this cell from its parent |
| [**GetCellParentStatus**](CellManagementApi.md#getcellparentstatus) | **GET** /api/cellmanagement/parentcell | [EARLY ACCESS] GetCellParentStatus: Get cell parent status |
| [**RefuseCellAttachment**](CellManagementApi.md#refusecellattachment) | **POST** /api/cellmanagement/refuseattachment | [EARLY ACCESS] RefuseCellAttachment: Refuse a Proposed cell attachment |
| [**RemovePrimaryDomain**](CellManagementApi.md#removeprimarydomain) | **DELETE** /api/cellmanagement/primarydomain | [EARLY ACCESS] RemovePrimaryDomain: Remove primary domain |
| [**SetAttachingKey**](CellManagementApi.md#setattachingkey) | **PUT** /api/cellmanagement/attachingkey | [EARLY ACCESS] SetAttachingKey: Store the Attaching Key pasted from the parent admin portal |
| [**SetParentCell**](CellManagementApi.md#setparentcell) | **PUT** /api/cellmanagement/parentcell | [EARLY ACCESS] SetParentCell: Set parent cell |
| [**SetPrimaryDomain**](CellManagementApi.md#setprimarydomain) | **PUT** /api/cellmanagement/primarydomain | [EARLY ACCESS] SetPrimaryDomain: Set primary domain |

<a id="acceptcellattachment"></a>
# **AcceptCellAttachment**
> CellParentStatusResponse AcceptCellAttachment ()

[EARLY ACCESS] AcceptCellAttachment: Accept (or retry) a cell attachment

Confirms a Proposed attachment, or retries one that previously failed: transitions the cell to Attaching and runs the shared registration service to provision the parent-cell service user, mint a PAT, and push it to the parent admin domain. Accepted starting states are `Proposed` (the normal first confirm — anti-circumvention is enforced by requiring a prior `SetAttachingKey`) and `Failed` (recovery from a previous failed attempt). The registration service is idempotent and resumes from the persisted `RegistrationStep` checkpoint, so this is safe to call any number of times after a failure. To abandon a failed attempt instead of retrying, call `Detach`. Only the designated primary domain may call this. Requires JWT authentication.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CellManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CellManagementApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // CellParentStatusResponse result = apiInstance.AcceptCellAttachment(opts: opts);

                // [EARLY ACCESS] AcceptCellAttachment: Accept (or retry) a cell attachment
                CellParentStatusResponse result = apiInstance.AcceptCellAttachment();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CellManagementApi.AcceptCellAttachment: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the AcceptCellAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] AcceptCellAttachment: Accept (or retry) a cell attachment
    ApiResponse<CellParentStatusResponse> response = apiInstance.AcceptCellAttachmentWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CellManagementApi.AcceptCellAttachmentWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CellParentStatusResponse**](CellParentStatusResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated cell parent status |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="detachparentcell"></a>
# **DetachParentCell**
> CellParentStatusResponse DetachParentCell (DetachParentCellRequest detachParentCellRequest)

[EARLY ACCESS] DetachParentCell: Detach this cell from its parent

Double-invoke pattern. First call with `Confirm=false` transitions the cell into Detaching; second call with `Confirm=true` executes: deactivates the parent-cell service user, deletes the Attaching Key from ParameterStore, and best-effort notifies the parent admin domain. Accepts `Attached`, `Attaching`, `Failed`, and `Detaching` as valid starting states (call `AcceptAttachment` instead if you'd rather retry a Failed cell than abandon it). Only the designated primary domain may call this. Requires JWT authentication.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CellManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CellManagementApi>();
            var detachParentCellRequest = new DetachParentCellRequest(); // DetachParentCellRequest | 

            try
            {
                // uncomment the below to set overrides at the request level
                // CellParentStatusResponse result = apiInstance.DetachParentCell(detachParentCellRequest, opts: opts);

                // [EARLY ACCESS] DetachParentCell: Detach this cell from its parent
                CellParentStatusResponse result = apiInstance.DetachParentCell(detachParentCellRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CellManagementApi.DetachParentCell: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DetachParentCellWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DetachParentCell: Detach this cell from its parent
    ApiResponse<CellParentStatusResponse> response = apiInstance.DetachParentCellWithHttpInfo(detachParentCellRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CellManagementApi.DetachParentCellWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **detachParentCellRequest** | [**DetachParentCellRequest**](DetachParentCellRequest.md) |  |  |

### Return type

[**CellParentStatusResponse**](CellParentStatusResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated cell parent status |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getcellparentstatus"></a>
# **GetCellParentStatus**
> CellParentStatusResponse GetCellParentStatus ()

[EARLY ACCESS] GetCellParentStatus: Get cell parent status

Returns the current cell parent relationship status including primary domain, admin domain name, and attachment status.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CellManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CellManagementApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // CellParentStatusResponse result = apiInstance.GetCellParentStatus(opts: opts);

                // [EARLY ACCESS] GetCellParentStatus: Get cell parent status
                CellParentStatusResponse result = apiInstance.GetCellParentStatus();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CellManagementApi.GetCellParentStatus: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCellParentStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetCellParentStatus: Get cell parent status
    ApiResponse<CellParentStatusResponse> response = apiInstance.GetCellParentStatusWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CellManagementApi.GetCellParentStatusWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CellParentStatusResponse**](CellParentStatusResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The cell parent status |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="refusecellattachment"></a>
# **RefuseCellAttachment**
> CellParentStatusResponse RefuseCellAttachment ()

[EARLY ACCESS] RefuseCellAttachment: Refuse a Proposed cell attachment

Rejects a Proposed attachment, deletes the Attaching Key from ParameterStore, and returns the cell to Standalone. Only the designated primary domain may call this. Requires JWT authentication.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CellManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CellManagementApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // CellParentStatusResponse result = apiInstance.RefuseCellAttachment(opts: opts);

                // [EARLY ACCESS] RefuseCellAttachment: Refuse a Proposed cell attachment
                CellParentStatusResponse result = apiInstance.RefuseCellAttachment();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CellManagementApi.RefuseCellAttachment: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefuseCellAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] RefuseCellAttachment: Refuse a Proposed cell attachment
    ApiResponse<CellParentStatusResponse> response = apiInstance.RefuseCellAttachmentWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CellManagementApi.RefuseCellAttachmentWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CellParentStatusResponse**](CellParentStatusResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated cell parent status |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="removeprimarydomain"></a>
# **RemovePrimaryDomain**
> CellParentStatusResponse RemovePrimaryDomain ()

[EARLY ACCESS] RemovePrimaryDomain: Remove primary domain

Removes the primary domain designation for this cell. Only the current primary domain or FINBOURNE staff can perform this. Requires JWT authentication (PAT tokens are rejected).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CellManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CellManagementApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // CellParentStatusResponse result = apiInstance.RemovePrimaryDomain(opts: opts);

                // [EARLY ACCESS] RemovePrimaryDomain: Remove primary domain
                CellParentStatusResponse result = apiInstance.RemovePrimaryDomain();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CellManagementApi.RemovePrimaryDomain: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemovePrimaryDomainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] RemovePrimaryDomain: Remove primary domain
    ApiResponse<CellParentStatusResponse> response = apiInstance.RemovePrimaryDomainWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CellManagementApi.RemovePrimaryDomainWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CellParentStatusResponse**](CellParentStatusResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated cell parent status |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="setattachingkey"></a>
# **SetAttachingKey**
> CellParentStatusResponse SetAttachingKey (SetAttachingKeyRequest setAttachingKeyRequest)

[EARLY ACCESS] SetAttachingKey: Store the Attaching Key pasted from the parent admin portal

Persists the Attaching Key PAT to the cell's ParameterStore / Azure Key Vault and records a Proposed attachment against the provided parent admin domain. Only the designated primary domain may call this. Requires JWT authentication (PAT tokens are rejected).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CellManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CellManagementApi>();
            var setAttachingKeyRequest = new SetAttachingKeyRequest(); // SetAttachingKeyRequest | 

            try
            {
                // uncomment the below to set overrides at the request level
                // CellParentStatusResponse result = apiInstance.SetAttachingKey(setAttachingKeyRequest, opts: opts);

                // [EARLY ACCESS] SetAttachingKey: Store the Attaching Key pasted from the parent admin portal
                CellParentStatusResponse result = apiInstance.SetAttachingKey(setAttachingKeyRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CellManagementApi.SetAttachingKey: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetAttachingKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] SetAttachingKey: Store the Attaching Key pasted from the parent admin portal
    ApiResponse<CellParentStatusResponse> response = apiInstance.SetAttachingKeyWithHttpInfo(setAttachingKeyRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CellManagementApi.SetAttachingKeyWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setAttachingKeyRequest** | [**SetAttachingKeyRequest**](SetAttachingKeyRequest.md) |  |  |

### Return type

[**CellParentStatusResponse**](CellParentStatusResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated cell parent status |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="setparentcell"></a>
# **SetParentCell**
> CellParentStatusResponse SetParentCell (SetParentCellRequest setParentCellRequest)

[EARLY ACCESS] SetParentCell: Set parent cell

Sets the parent cell for this cell. Uses a double-invoke pattern: first call (confirm=false) sets status to Proposed, second call (confirm=true) transitions to Attaching. Only the designated primary domain can call this. Requires JWT authentication (PAT tokens are rejected).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CellManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CellManagementApi>();
            var setParentCellRequest = new SetParentCellRequest(); // SetParentCellRequest | 

            try
            {
                // uncomment the below to set overrides at the request level
                // CellParentStatusResponse result = apiInstance.SetParentCell(setParentCellRequest, opts: opts);

                // [EARLY ACCESS] SetParentCell: Set parent cell
                CellParentStatusResponse result = apiInstance.SetParentCell(setParentCellRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CellManagementApi.SetParentCell: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetParentCellWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] SetParentCell: Set parent cell
    ApiResponse<CellParentStatusResponse> response = apiInstance.SetParentCellWithHttpInfo(setParentCellRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CellManagementApi.SetParentCellWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **setParentCellRequest** | [**SetParentCellRequest**](SetParentCellRequest.md) |  |  |

### Return type

[**CellParentStatusResponse**](CellParentStatusResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated cell parent status |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="setprimarydomain"></a>
# **SetPrimaryDomain**
> CellParentStatusResponse SetPrimaryDomain ()

[EARLY ACCESS] SetPrimaryDomain: Set primary domain

Designates the calling domain as the primary domain for this cell. Requires JWT authentication (PAT tokens are rejected).

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<CellManagementApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<CellManagementApi>();

            try
            {
                // uncomment the below to set overrides at the request level
                // CellParentStatusResponse result = apiInstance.SetPrimaryDomain(opts: opts);

                // [EARLY ACCESS] SetPrimaryDomain: Set primary domain
                CellParentStatusResponse result = apiInstance.SetPrimaryDomain();
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling CellManagementApi.SetPrimaryDomain: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPrimaryDomainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] SetPrimaryDomain: Set primary domain
    ApiResponse<CellParentStatusResponse> response = apiInstance.SetPrimaryDomainWithHttpInfo();
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling CellManagementApi.SetPrimaryDomainWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CellParentStatusResponse**](CellParentStatusResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated cell parent status |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

