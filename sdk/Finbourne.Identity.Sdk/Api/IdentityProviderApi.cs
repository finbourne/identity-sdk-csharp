/*
 * FINBOURNE Identity Service API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using Object = System.Object;
using InvalidOperationException = System.InvalidOperationException;
using Exception = System.Exception;
using ArgumentNullException = System.ArgumentNullException;
using SystemEventHandler = System.EventHandler;
using DateTimeOffset = System.DateTimeOffset;
using Guid = System.Guid;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Finbourne.Identity.Sdk.Client;
using Finbourne.Identity.Sdk.Client.Auth;
using Finbourne.Identity.Sdk.Model;

namespace Finbourne.Identity.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIdentityProviderApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// AddScim: Add SCIM
        /// </summary>
        /// <remarks>
        /// Generates an API token to be used for SCIM
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiTokenAction">The action to take. For the API token. Defaults to \&quot;ensure\&quot; (optional)</param>
        /// <param name="oldApiTokenDeactivation">Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AddScimResponse</returns>
        AddScimResponse AddScim(string? apiTokenAction = default(string?), DateTimeOffset? oldApiTokenDeactivation = default(DateTimeOffset?), int operationIndex = 0);

        /// <summary>
        /// AddScim: Add SCIM
        /// </summary>
        /// <remarks>
        /// Generates an API token to be used for SCIM
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiTokenAction">The action to take. For the API token. Defaults to \&quot;ensure\&quot; (optional)</param>
        /// <param name="oldApiTokenDeactivation">Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AddScimResponse</returns>
        ApiResponse<AddScimResponse> AddScimWithHttpInfo(string? apiTokenAction = default(string?), DateTimeOffset? oldApiTokenDeactivation = default(DateTimeOffset?), int operationIndex = 0);
        /// <summary>
        /// RemoveScim: Remove SCIM
        /// </summary>
        /// <remarks>
        /// Deactivates any existing SCIM API token
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void RemoveScim(int operationIndex = 0);

        /// <summary>
        /// RemoveScim: Remove SCIM
        /// </summary>
        /// <remarks>
        /// Deactivates any existing SCIM API token
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RemoveScimWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIdentityProviderApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// AddScim: Add SCIM
        /// </summary>
        /// <remarks>
        /// Generates an API token to be used for SCIM
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiTokenAction">The action to take. For the API token. Defaults to \&quot;ensure\&quot; (optional)</param>
        /// <param name="oldApiTokenDeactivation">Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AddScimResponse</returns>
        System.Threading.Tasks.Task<AddScimResponse> AddScimAsync(string? apiTokenAction = default(string?), DateTimeOffset? oldApiTokenDeactivation = default(DateTimeOffset?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// AddScim: Add SCIM
        /// </summary>
        /// <remarks>
        /// Generates an API token to be used for SCIM
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiTokenAction">The action to take. For the API token. Defaults to \&quot;ensure\&quot; (optional)</param>
        /// <param name="oldApiTokenDeactivation">Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AddScimResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddScimResponse>> AddScimWithHttpInfoAsync(string? apiTokenAction = default(string?), DateTimeOffset? oldApiTokenDeactivation = default(DateTimeOffset?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// RemoveScim: Remove SCIM
        /// </summary>
        /// <remarks>
        /// Deactivates any existing SCIM API token
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RemoveScimAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// RemoveScim: Remove SCIM
        /// </summary>
        /// <remarks>
        /// Deactivates any existing SCIM API token
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RemoveScimWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIdentityProviderApi : IIdentityProviderApiSync, IIdentityProviderApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class IdentityProviderApi : IIdentityProviderApi
    {
        private Finbourne.Identity.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IdentityProviderApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IdentityProviderApi(string basePath)
        {
            this.Configuration = Finbourne.Identity.Sdk.Client.Configuration.MergeConfigurations(
                Finbourne.Identity.Sdk.Client.GlobalConfiguration.Instance,
                new Finbourne.Identity.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Finbourne.Identity.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Identity.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Finbourne.Identity.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public IdentityProviderApi(Finbourne.Identity.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Finbourne.Identity.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Identity.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Finbourne.Identity.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public IdentityProviderApi(Finbourne.Identity.Sdk.Client.ISynchronousClient client, Finbourne.Identity.Sdk.Client.IAsynchronousClient asyncClient, Finbourne.Identity.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Finbourne.Identity.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Finbourne.Identity.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Finbourne.Identity.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Finbourne.Identity.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Finbourne.Identity.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// AddScim: Add SCIM Generates an API token to be used for SCIM
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiTokenAction">The action to take. For the API token. Defaults to \&quot;ensure\&quot; (optional)</param>
        /// <param name="oldApiTokenDeactivation">Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AddScimResponse</returns>
        public AddScimResponse AddScim(string? apiTokenAction = default(string?), DateTimeOffset? oldApiTokenDeactivation = default(DateTimeOffset?), int operationIndex = 0)
        {
            Finbourne.Identity.Sdk.Client.ApiResponse<AddScimResponse> localVarResponse = AddScimWithHttpInfo(apiTokenAction, oldApiTokenDeactivation);
            return localVarResponse.Data;
        }

        /// <summary>
        /// AddScim: Add SCIM Generates an API token to be used for SCIM
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiTokenAction">The action to take. For the API token. Defaults to \&quot;ensure\&quot; (optional)</param>
        /// <param name="oldApiTokenDeactivation">Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AddScimResponse</returns>
        public Finbourne.Identity.Sdk.Client.ApiResponse<AddScimResponse> AddScimWithHttpInfo(string? apiTokenAction = default(string?), DateTimeOffset? oldApiTokenDeactivation = default(DateTimeOffset?), int operationIndex = 0)
        {
            Finbourne.Identity.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Identity.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiTokenAction != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "apiTokenAction", apiTokenAction));
            }
            if (oldApiTokenDeactivation != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "oldApiTokenDeactivation", oldApiTokenDeactivation));
            }

            localVarRequestOptions.Operation = "IdentityProviderApi.AddScim";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<AddScimResponse>("/api/identityprovider/scim", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddScim", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// AddScim: Add SCIM Generates an API token to be used for SCIM
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiTokenAction">The action to take. For the API token. Defaults to \&quot;ensure\&quot; (optional)</param>
        /// <param name="oldApiTokenDeactivation">Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AddScimResponse</returns>
        public async System.Threading.Tasks.Task<AddScimResponse> AddScimAsync(string? apiTokenAction = default(string?), DateTimeOffset? oldApiTokenDeactivation = default(DateTimeOffset?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Identity.Sdk.Client.ApiResponse<AddScimResponse> localVarResponse = await AddScimWithHttpInfoAsync(apiTokenAction, oldApiTokenDeactivation, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// AddScim: Add SCIM Generates an API token to be used for SCIM
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiTokenAction">The action to take. For the API token. Defaults to \&quot;ensure\&quot; (optional)</param>
        /// <param name="oldApiTokenDeactivation">Optional deactivation date for the old API token. Only used if apiTokenAction is \&quot;regenerate\&quot; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AddScimResponse)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Identity.Sdk.Client.ApiResponse<AddScimResponse>> AddScimWithHttpInfoAsync(string? apiTokenAction = default(string?), DateTimeOffset? oldApiTokenDeactivation = default(DateTimeOffset?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Finbourne.Identity.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Identity.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiTokenAction != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "apiTokenAction", apiTokenAction));
            }
            if (oldApiTokenDeactivation != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "oldApiTokenDeactivation", oldApiTokenDeactivation));
            }

            localVarRequestOptions.Operation = "IdentityProviderApi.AddScim";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PutAsync<AddScimResponse>("/api/identityprovider/scim", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddScim", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// RemoveScim: Remove SCIM Deactivates any existing SCIM API token
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void RemoveScim(int operationIndex = 0)
        {
            RemoveScimWithHttpInfo();
        }

        /// <summary>
        /// RemoveScim: Remove SCIM Deactivates any existing SCIM API token
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Finbourne.Identity.Sdk.Client.ApiResponse<Object> RemoveScimWithHttpInfo(int operationIndex = 0)
        {
            Finbourne.Identity.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Identity.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "IdentityProviderApi.RemoveScim";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/api/identityprovider/scim", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveScim", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// RemoveScim: Remove SCIM Deactivates any existing SCIM API token
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RemoveScimAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await RemoveScimWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// RemoveScim: Remove SCIM Deactivates any existing SCIM API token
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Finbourne.Identity.Sdk.Client.ApiResponse<Object>> RemoveScimWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Finbourne.Identity.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Identity.Sdk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Finbourne.Identity.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "IdentityProviderApi.RemoveScim";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/api/identityprovider/scim", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveScim", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}