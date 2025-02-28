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
using IApiAccessor = Finbourne.Identity.Sdk.Client.IApiAccessor;
using Finbourne.Identity.Sdk.Extensions;
using Finbourne.Identity.Sdk.Client.Auth;
using Finbourne.Identity.Sdk.Model;

namespace Finbourne.Identity.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISystemLogsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [BETA] ListLogs: Lists system logs for a domain
        /// </summary>
        /// <remarks>
        /// Lists system logs for a domain
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since">Lower bound of log events published property (optional)</param>
        /// <param name="until">Upper bound of log events published property (optional)</param>
        /// <param name="after">Page token (optional)</param>
        /// <param name="filter">Okta filter expression (optional)</param>
        /// <param name="query">Filters log events results by one or more case insensitive keywords (optional)</param>
        /// <param name="limit">Max number of results returned (optional)</param>
        /// <param name="sortOrder">Order of events by published property. Either ASCENDING or DESCENDING (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="opts">Options for this request.</param>
        /// <returns>ResourceListOfSystemLog</returns>
        ResourceListOfSystemLog ListLogs(DateTimeOffset? since = default(DateTimeOffset?), DateTimeOffset? until = default(DateTimeOffset?), string? after = default(string?), string? filter = default(string?), string? query = default(string?), int? limit = default(int?), string? sortOrder = default(string?), int operationIndex = 0, ConfigurationOptions? opts = null);

        /// <summary>
        /// [BETA] ListLogs: Lists system logs for a domain
        /// </summary>
        /// <remarks>
        /// Lists system logs for a domain
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since">Lower bound of log events published property (optional)</param>
        /// <param name="until">Upper bound of log events published property (optional)</param>
        /// <param name="after">Page token (optional)</param>
        /// <param name="filter">Okta filter expression (optional)</param>
        /// <param name="query">Filters log events results by one or more case insensitive keywords (optional)</param>
        /// <param name="limit">Max number of results returned (optional)</param>
        /// <param name="sortOrder">Order of events by published property. Either ASCENDING or DESCENDING (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="opts">Options for this request.</param>
        /// <returns>ApiResponse of ResourceListOfSystemLog</returns>
        Finbourne.Identity.Sdk.Client.ApiResponse<ResourceListOfSystemLog> ListLogsWithHttpInfo(DateTimeOffset? since = default(DateTimeOffset?), DateTimeOffset? until = default(DateTimeOffset?), string? after = default(string?), string? filter = default(string?), string? query = default(string?), int? limit = default(int?), string? sortOrder = default(string?), int operationIndex = 0, ConfigurationOptions? opts = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISystemLogsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [BETA] ListLogs: Lists system logs for a domain
        /// </summary>
        /// <remarks>
        /// Lists system logs for a domain
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since">Lower bound of log events published property (optional)</param>
        /// <param name="until">Upper bound of log events published property (optional)</param>
        /// <param name="after">Page token (optional)</param>
        /// <param name="filter">Okta filter expression (optional)</param>
        /// <param name="query">Filters log events results by one or more case insensitive keywords (optional)</param>
        /// <param name="limit">Max number of results returned (optional)</param>
        /// <param name="sortOrder">Order of events by published property. Either ASCENDING or DESCENDING (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="opts">Options for this request.</param>
        /// <returns>Task of ResourceListOfSystemLog</returns>
        System.Threading.Tasks.Task<ResourceListOfSystemLog> ListLogsAsync(DateTimeOffset? since = default(DateTimeOffset?), DateTimeOffset? until = default(DateTimeOffset?), string? after = default(string?), string? filter = default(string?), string? query = default(string?), int? limit = default(int?), string? sortOrder = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), ConfigurationOptions? opts = null);

        /// <summary>
        /// [BETA] ListLogs: Lists system logs for a domain
        /// </summary>
        /// <remarks>
        /// Lists system logs for a domain
        /// </remarks>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since">Lower bound of log events published property (optional)</param>
        /// <param name="until">Upper bound of log events published property (optional)</param>
        /// <param name="after">Page token (optional)</param>
        /// <param name="filter">Okta filter expression (optional)</param>
        /// <param name="query">Filters log events results by one or more case insensitive keywords (optional)</param>
        /// <param name="limit">Max number of results returned (optional)</param>
        /// <param name="sortOrder">Order of events by published property. Either ASCENDING or DESCENDING (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="opts">Options for this request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfSystemLog)</returns>
        System.Threading.Tasks.Task<Finbourne.Identity.Sdk.Client.ApiResponse<ResourceListOfSystemLog>> ListLogsWithHttpInfoAsync(DateTimeOffset? since = default(DateTimeOffset?), DateTimeOffset? until = default(DateTimeOffset?), string? after = default(string?), string? filter = default(string?), string? query = default(string?), int? limit = default(int?), string? sortOrder = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), ConfigurationOptions? opts = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISystemLogsApi : ISystemLogsApiSync, ISystemLogsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SystemLogsApi : ISystemLogsApi
    {
        private Finbourne.Identity.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemLogsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SystemLogsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemLogsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SystemLogsApi(string basePath)
        {
            var globalConfiguration = Finbourne.Identity.Sdk.Client.GlobalConfiguration.Instance;
            this.Configuration = Finbourne.Identity.Sdk.Client.Configuration.MergeConfigurations(
                globalConfiguration,
                new Finbourne.Identity.Sdk.Client.Configuration
                {
                    BasePath = basePath,
                    TimeoutMs = globalConfiguration.TimeoutMs,
                    RateLimitRetries = globalConfiguration.RateLimitRetries
                }
            );
            this.Client = new Finbourne.Identity.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Identity.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Finbourne.Identity.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemLogsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SystemLogsApi(Finbourne.Identity.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Finbourne.Identity.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Identity.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Finbourne.Identity.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemLogsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SystemLogsApi(Finbourne.Identity.Sdk.Client.ISynchronousClient client, Finbourne.Identity.Sdk.Client.IAsynchronousClient asyncClient, Finbourne.Identity.Sdk.Client.IReadableConfiguration configuration)
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
        /// [BETA] ListLogs: Lists system logs for a domain Lists system logs for a domain
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since">Lower bound of log events published property (optional)</param>
        /// <param name="until">Upper bound of log events published property (optional)</param>
        /// <param name="after">Page token (optional)</param>
        /// <param name="filter">Okta filter expression (optional)</param>
        /// <param name="query">Filters log events results by one or more case insensitive keywords (optional)</param>
        /// <param name="limit">Max number of results returned (optional)</param>
        /// <param name="sortOrder">Order of events by published property. Either ASCENDING or DESCENDING (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="opts">Options for this request.</param>
        /// <returns>ResourceListOfSystemLog</returns>
        public ResourceListOfSystemLog ListLogs(DateTimeOffset? since = default(DateTimeOffset?), DateTimeOffset? until = default(DateTimeOffset?), string? after = default(string?), string? filter = default(string?), string? query = default(string?), int? limit = default(int?), string? sortOrder = default(string?), int operationIndex = 0, ConfigurationOptions? opts = null)
        {
            Finbourne.Identity.Sdk.Client.ApiResponse<ResourceListOfSystemLog> localVarResponse = ListLogsWithHttpInfo(since, until, after, filter, query, limit, sortOrder, opts: opts);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [BETA] ListLogs: Lists system logs for a domain Lists system logs for a domain
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since">Lower bound of log events published property (optional)</param>
        /// <param name="until">Upper bound of log events published property (optional)</param>
        /// <param name="after">Page token (optional)</param>
        /// <param name="filter">Okta filter expression (optional)</param>
        /// <param name="query">Filters log events results by one or more case insensitive keywords (optional)</param>
        /// <param name="limit">Max number of results returned (optional)</param>
        /// <param name="sortOrder">Order of events by published property. Either ASCENDING or DESCENDING (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="opts">Options for this request.</param>
        /// <returns>ApiResponse of ResourceListOfSystemLog</returns>
        public Finbourne.Identity.Sdk.Client.ApiResponse<ResourceListOfSystemLog> ListLogsWithHttpInfo(DateTimeOffset? since = default(DateTimeOffset?), DateTimeOffset? until = default(DateTimeOffset?), string? after = default(string?), string? filter = default(string?), string? query = default(string?), int? limit = default(int?), string? sortOrder = default(string?), int operationIndex = 0, ConfigurationOptions? opts = null)
        {
            Finbourne.Identity.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Identity.Sdk.Client.RequestOptions();

            if (opts is { TimeoutMs: not null })
            {
                localVarRequestOptions.TimeoutMs = opts.TimeoutMs.Value;
            }
            
            if (opts is { RateLimitRetries: not null })
            {
                localVarRequestOptions.RateLimitRetries = opts.RateLimitRetries.Value;
            }

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

            if (since != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "Since", since));
            }
            if (until != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "Until", until));
            }
            if (after != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "After", after));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "Filter", filter));
            }
            if (query != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "Query", query));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "Limit", limit));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "SortOrder", sortOrder));
            }

            localVarRequestOptions.Operation = "SystemLogsApi.ListLogs";
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
            var localVarResponse = this.Client.Get<ResourceListOfSystemLog>("/api/logs", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListLogs", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// [BETA] ListLogs: Lists system logs for a domain Lists system logs for a domain
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since">Lower bound of log events published property (optional)</param>
        /// <param name="until">Upper bound of log events published property (optional)</param>
        /// <param name="after">Page token (optional)</param>
        /// <param name="filter">Okta filter expression (optional)</param>
        /// <param name="query">Filters log events results by one or more case insensitive keywords (optional)</param>
        /// <param name="limit">Max number of results returned (optional)</param>
        /// <param name="sortOrder">Order of events by published property. Either ASCENDING or DESCENDING (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="opts">Options for this request.</param>
        /// <returns>Task of ResourceListOfSystemLog</returns>
        public async System.Threading.Tasks.Task<ResourceListOfSystemLog> ListLogsAsync(DateTimeOffset? since = default(DateTimeOffset?), DateTimeOffset? until = default(DateTimeOffset?), string? after = default(string?), string? filter = default(string?), string? query = default(string?), int? limit = default(int?), string? sortOrder = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), ConfigurationOptions? opts = null)
        {
            Finbourne.Identity.Sdk.Client.ApiResponse<ResourceListOfSystemLog> localVarResponse = await ListLogsWithHttpInfoAsync(since, until, after, filter, query, limit, sortOrder, operationIndex, cancellationToken, opts).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [BETA] ListLogs: Lists system logs for a domain Lists system logs for a domain
        /// </summary>
        /// <exception cref="Finbourne.Identity.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="since">Lower bound of log events published property (optional)</param>
        /// <param name="until">Upper bound of log events published property (optional)</param>
        /// <param name="after">Page token (optional)</param>
        /// <param name="filter">Okta filter expression (optional)</param>
        /// <param name="query">Filters log events results by one or more case insensitive keywords (optional)</param>
        /// <param name="limit">Max number of results returned (optional)</param>
        /// <param name="sortOrder">Order of events by published property. Either ASCENDING or DESCENDING (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="opts">Options for this request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfSystemLog)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Identity.Sdk.Client.ApiResponse<ResourceListOfSystemLog>> ListLogsWithHttpInfoAsync(DateTimeOffset? since = default(DateTimeOffset?), DateTimeOffset? until = default(DateTimeOffset?), string? after = default(string?), string? filter = default(string?), string? query = default(string?), int? limit = default(int?), string? sortOrder = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), ConfigurationOptions? opts = null)
        {

            Finbourne.Identity.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Identity.Sdk.Client.RequestOptions();

            if (opts is { TimeoutMs: not null })
            {
                localVarRequestOptions.TimeoutMs = opts.TimeoutMs.Value;
            }
            
            if (opts is { RateLimitRetries: not null })
            {
                localVarRequestOptions.RateLimitRetries = opts.RateLimitRetries.Value;
            }

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

            if (since != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "Since", since));
            }
            if (until != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "Until", until));
            }
            if (after != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "After", after));
            }
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "Filter", filter));
            }
            if (query != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "Query", query));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "Limit", limit));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Identity.Sdk.Client.ClientUtils.ParameterToMultiMap("", "SortOrder", sortOrder));
            }

            localVarRequestOptions.Operation = "SystemLogsApi.ListLogs";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfSystemLog>("/api/logs", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListLogs", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}