﻿/*
 * FINBOURNE Identity Service API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Finbourne.Identity.Sdk.Client;

namespace Finbourne.Identity.Sdk.Extensions
{
    /// <summary>
    /// Custom class, derived from the auto-generated Configuration, which allows the access token to be pulled from an ITokenProvider when required
    ///</summary>
    public class TokenProviderConfiguration : Client.Configuration
    {
        private readonly ITokenProvider _tokenProvider;

        /// <summary>
        /// Create a new Configuration using the supplied token provider
        ///</summary>
        public TokenProviderConfiguration(ITokenProvider tokenProvider)
        {
            _tokenProvider = tokenProvider;
        }

        /// <summary>
        /// Gets/sets the accesstoken
        ///</summary>
        public override string AccessToken
        {
            get => _tokenProvider.GetAuthenticationTokenAsync().Result;
            set => throw new InvalidOperationException("AccessToken is not assignable");
        }
    }

    /// <summary>
    /// Configuation methods extensions.
    /// </summary>
    public static class ConfigurationExtensionMethods
    {
        /// <summary>
        /// Merge configuration with the global config.
        /// </summary>
        public static void MergeWithGlobalConfiguration(this Client.Configuration config)
        {
            var global = GlobalConfiguration.Instance;

            Dictionary<string, string> apiKey = global.ApiKey.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Dictionary<string, string> apiKeyPrefix = global.ApiKeyPrefix.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Dictionary<string, string> defaultHeaders = global.DefaultHeaders.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in config.ApiKey) apiKey[kvp.Key] = kvp.Value;
            foreach (var kvp in config.ApiKeyPrefix) apiKeyPrefix[kvp.Key] = kvp.Value;
            foreach (var kvp in config.DefaultHeaders) defaultHeaders[kvp.Key] = kvp.Value;

            config.ApiKey = apiKey;
            config.ApiKeyPrefix = apiKeyPrefix;
            config.DefaultHeaders = defaultHeaders;
            config.BasePath = config.BasePath ?? global.BasePath;
            config.Timeout = config.Timeout;
            config.Proxy = config.Proxy ?? global.Proxy;
            config.UserAgent = config.UserAgent ?? global.UserAgent;
            config.Username = config.Username ?? global.Username;
            config.Password = config.Password ?? global.Password;
            config.OAuthTokenUrl = config.OAuthTokenUrl ?? global.OAuthTokenUrl;
            config.OAuthClientId = config.OAuthClientId ?? global.OAuthClientId;
            config.OAuthClientSecret = config.OAuthClientSecret ?? global.OAuthClientSecret;
            config.OAuthFlow = config.OAuthFlow ?? global.OAuthFlow;
            config.TempFolderPath = config.TempFolderPath ?? global.TempFolderPath;
            config.DateTimeFormat = config.DateTimeFormat ?? global.DateTimeFormat;
            config.ClientCertificates = config.ClientCertificates ?? global.ClientCertificates;
        }
    }
}
