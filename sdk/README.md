<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://fbn-prd.lusid.com/identity*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ApplicationMetadataApi* | [**ListAccessControlledResources**](docs/ApplicationMetadataApi.md#listaccesscontrolledresources) | **GET** /api/metadata/access/resources | ListAccessControlledResources: Get resources available for access control
*ApplicationsApi* | [**CreateApplication**](docs/ApplicationsApi.md#createapplication) | **POST** /api/applications | [EARLY ACCESS] CreateApplication: Create Application
*ApplicationsApi* | [**DeleteApplication**](docs/ApplicationsApi.md#deleteapplication) | **DELETE** /api/applications/{id} | [EARLY ACCESS] DeleteApplication: Delete Application
*ApplicationsApi* | [**GetApplication**](docs/ApplicationsApi.md#getapplication) | **GET** /api/applications/{id} | GetApplication: Get Application
*ApplicationsApi* | [**ListApplications**](docs/ApplicationsApi.md#listapplications) | **GET** /api/applications | ListApplications: List Applications
*ApplicationsApi* | [**RotateApplicationSecrets**](docs/ApplicationsApi.md#rotateapplicationsecrets) | **POST** /api/applications/{id}/lifecycle/$newsecret | [EARLY ACCESS] RotateApplicationSecrets: Rotate Application Secrets
*AuthenticationApi* | [**GetAuthenticationInformation**](docs/AuthenticationApi.md#getauthenticationinformation) | **GET** /api/authentication/information | GetAuthenticationInformation: Gets AuthenticationInformation
*AuthenticationApi* | [**GetPasswordPolicy**](docs/AuthenticationApi.md#getpasswordpolicy) | **GET** /api/authentication/password-policy/{userType} | [EXPERIMENTAL] GetPasswordPolicy: Gets password policy for a user type
*AuthenticationApi* | [**GetSupportAccessHistory**](docs/AuthenticationApi.md#getsupportaccesshistory) | **GET** /api/authentication/support | GetSupportAccessHistory: Get the history of all support access granted and any information pertaining to their termination
*AuthenticationApi* | [**GetSupportRoles**](docs/AuthenticationApi.md#getsupportroles) | **GET** /api/authentication/support-roles | GetSupportRoles: Get mapping of support roles, the internal representation to a human friendly representation
*AuthenticationApi* | [**GrantSupportAccess**](docs/AuthenticationApi.md#grantsupportaccess) | **POST** /api/authentication/support | GrantSupportAccess: Grants FINBOURNE support access to your account
*AuthenticationApi* | [**InvalidateSupportAccess**](docs/AuthenticationApi.md#invalidatesupportaccess) | **DELETE** /api/authentication/support | InvalidateSupportAccess: Revoke any FINBOURNE support access to your account
*AuthenticationApi* | [**UpdatePasswordPolicy**](docs/AuthenticationApi.md#updatepasswordpolicy) | **PUT** /api/authentication/password-policy/{userType} | [EXPERIMENTAL] UpdatePasswordPolicy: Updates password policy for a user type
*IdentityProviderApi* | [**AddScim**](docs/IdentityProviderApi.md#addscim) | **PUT** /api/identityprovider/scim | AddScim: Add SCIM
*IdentityProviderApi* | [**RemoveScim**](docs/IdentityProviderApi.md#removescim) | **DELETE** /api/identityprovider/scim | RemoveScim: Remove SCIM
*MeApi* | [**GetUserInfo**](docs/MeApi.md#getuserinfo) | **GET** /api/me | GetUserInfo: Get User Info
*MeApi* | [**SetPassword**](docs/MeApi.md#setpassword) | **PUT** /api/me/password | SetPassword: Set password of current user
*NetworkZonesApi* | [**CreateNetworkZone**](docs/NetworkZonesApi.md#createnetworkzone) | **POST** /api/networkzones | [EARLY ACCESS] CreateNetworkZone: Creates a network zone
*NetworkZonesApi* | [**DeleteNetworkZone**](docs/NetworkZonesApi.md#deletenetworkzone) | **DELETE** /api/networkzones/{code} | [EARLY ACCESS] DeleteNetworkZone: Deletes a network zone
*NetworkZonesApi* | [**GetNetworkZone**](docs/NetworkZonesApi.md#getnetworkzone) | **GET** /api/networkzones/{code} | [EARLY ACCESS] GetNetworkZone: Retrieve a Network Zone
*NetworkZonesApi* | [**ListNetworkZones**](docs/NetworkZonesApi.md#listnetworkzones) | **GET** /api/networkzones | [EARLY ACCESS] ListNetworkZones: Lists all network zones for a domain
*NetworkZonesApi* | [**UpdateNetworkZone**](docs/NetworkZonesApi.md#updatenetworkzone) | **PUT** /api/networkzones/{code} | [EARLY ACCESS] UpdateNetworkZone: Updates an existing network zone
*PersonalAuthenticationTokensApi* | [**CreateApiKey**](docs/PersonalAuthenticationTokensApi.md#createapikey) | **POST** /api/keys | CreateApiKey: Create a Personal Access Token
*PersonalAuthenticationTokensApi* | [**DeleteApiKey**](docs/PersonalAuthenticationTokensApi.md#deleteapikey) | **DELETE** /api/keys/{id} | DeleteApiKey: Invalidate a Personal Access Token
*PersonalAuthenticationTokensApi* | [**ListOwnApiKeys**](docs/PersonalAuthenticationTokensApi.md#listownapikeys) | **GET** /api/keys | ListOwnApiKeys: Gets the meta data for all of the user's existing Personal Access Tokens.
*RolesApi* | [**AddUserToRole**](docs/RolesApi.md#addusertorole) | **PUT** /api/roles/{id}/users/{userId} | AddUserToRole: Add User to Role
*RolesApi* | [**CreateRole**](docs/RolesApi.md#createrole) | **POST** /api/roles | CreateRole: Create Role
*RolesApi* | [**DeleteRole**](docs/RolesApi.md#deleterole) | **DELETE** /api/roles/{id} | DeleteRole: Delete Role
*RolesApi* | [**GetRole**](docs/RolesApi.md#getrole) | **GET** /api/roles/{id} | GetRole: Get Role
*RolesApi* | [**ListRoles**](docs/RolesApi.md#listroles) | **GET** /api/roles | ListRoles: List Roles
*RolesApi* | [**ListUsersInRole**](docs/RolesApi.md#listusersinrole) | **GET** /api/roles/{id}/users | ListUsersInRole: Get the users in the specified role.
*RolesApi* | [**RemoveUserFromRole**](docs/RolesApi.md#removeuserfromrole) | **DELETE** /api/roles/{id}/users/{userId} | RemoveUserFromRole: Remove User from Role
*RolesApi* | [**UpdateRole**](docs/RolesApi.md#updaterole) | **PUT** /api/roles/{id} | UpdateRole: Update Role
*TokensApi* | [**InvalidateToken**](docs/TokensApi.md#invalidatetoken) | **DELETE** /api/tokens | InvalidateToken: Invalidate current JWT token (sign out)
*UsersApi* | [**CreateUser**](docs/UsersApi.md#createuser) | **POST** /api/users | CreateUser: Create User
*UsersApi* | [**DeleteUser**](docs/UsersApi.md#deleteuser) | **DELETE** /api/users/{id} | DeleteUser: Delete User
*UsersApi* | [**ExpirePassword**](docs/UsersApi.md#expirepassword) | **POST** /api/users/{id}/lifecycle/$expirepassword | ExpirePassword: Reset the user's password to a temporary one
*UsersApi* | [**FindUsersById**](docs/UsersApi.md#findusersbyid) | **GET** /api/directory | FindUsersById: Find users by id endpoint
*UsersApi* | [**GetUser**](docs/UsersApi.md#getuser) | **GET** /api/users/{id} | GetUser: Get User
*UsersApi* | [**GetUserSchema**](docs/UsersApi.md#getuserschema) | **GET** /api/users/schema | [EXPERIMENTAL] GetUserSchema: Get User Schema
*UsersApi* | [**ListRunnableUsers**](docs/UsersApi.md#listrunnableusers) | **GET** /api/users/$runnable | [EARLY ACCESS] ListRunnableUsers: List Runable Users
*UsersApi* | [**ListUsers**](docs/UsersApi.md#listusers) | **GET** /api/users | ListUsers: List Users
*UsersApi* | [**ResetFactors**](docs/UsersApi.md#resetfactors) | **POST** /api/users/{id}/lifecycle/$resetfactors | ResetFactors: Reset MFA factors
*UsersApi* | [**ResetPassword**](docs/UsersApi.md#resetpassword) | **POST** /api/users/{id}/lifecycle/$resetpassword | ResetPassword: Reset Password
*UsersApi* | [**SendActivationEmail**](docs/UsersApi.md#sendactivationemail) | **POST** /api/users/{id}/lifecycle/$activate | SendActivationEmail: Sends an activation email to the User
*UsersApi* | [**UnlockUser**](docs/UsersApi.md#unlockuser) | **POST** /api/users/{id}/lifecycle/$unlock | UnlockUser: Unlock User
*UsersApi* | [**UnsuspendUser**](docs/UsersApi.md#unsuspenduser) | **POST** /api/users/{id}/lifecycle/$unsuspend | [EXPERIMENTAL] UnsuspendUser: Unsuspend user
*UsersApi* | [**UpdateUser**](docs/UsersApi.md#updateuser) | **PUT** /api/users/{id} | UpdateUser: Update User
*UsersApi* | [**UpdateUserSchema**](docs/UsersApi.md#updateuserschema) | **PUT** /api/users/schema | [EXPERIMENTAL] UpdateUserSchema: Update User Schema


<a id="documentation-for-models"></a>
## Documentation for Models

 - [AccessControlledAction](docs/AccessControlledAction.md)
 - [AccessControlledResource](docs/AccessControlledResource.md)
 - [ActionId](docs/ActionId.md)
 - [AddScimResponse](docs/AddScimResponse.md)
 - [ApiKey](docs/ApiKey.md)
 - [AuthenticationInformation](docs/AuthenticationInformation.md)
 - [CreateApiKey](docs/CreateApiKey.md)
 - [CreateApplicationRequest](docs/CreateApplicationRequest.md)
 - [CreateNetworkZoneRequest](docs/CreateNetworkZoneRequest.md)
 - [CreateRoleRequest](docs/CreateRoleRequest.md)
 - [CreateUserRequest](docs/CreateUserRequest.md)
 - [CreatedApiKey](docs/CreatedApiKey.md)
 - [CurrentUserResponse](docs/CurrentUserResponse.md)
 - [ErrorDetail](docs/ErrorDetail.md)
 - [IdSelectorDefinition](docs/IdSelectorDefinition.md)
 - [IdentifierPartSchema](docs/IdentifierPartSchema.md)
 - [IpAddressDefinition](docs/IpAddressDefinition.md)
 - [Link](docs/Link.md)
 - [ListUsersResponse](docs/ListUsersResponse.md)
 - [LusidProblemDetails](docs/LusidProblemDetails.md)
 - [LusidValidationProblemDetails](docs/LusidValidationProblemDetails.md)
 - [NetworkZoneDefinitionResponse](docs/NetworkZoneDefinitionResponse.md)
 - [NetworkZonesApplyRules](docs/NetworkZonesApplyRules.md)
 - [OAuthApplication](docs/OAuthApplication.md)
 - [PasswordPolicyResponse](docs/PasswordPolicyResponse.md)
 - [PasswordPolicyResponseAge](docs/PasswordPolicyResponseAge.md)
 - [PasswordPolicyResponseComplexity](docs/PasswordPolicyResponseComplexity.md)
 - [PasswordPolicyResponseConditions](docs/PasswordPolicyResponseConditions.md)
 - [PasswordPolicyResponseLockout](docs/PasswordPolicyResponseLockout.md)
 - [ResourceListOfAccessControlledResource](docs/ResourceListOfAccessControlledResource.md)
 - [RoleId](docs/RoleId.md)
 - [RoleResponse](docs/RoleResponse.md)
 - [SetPassword](docs/SetPassword.md)
 - [SetPasswordResponse](docs/SetPasswordResponse.md)
 - [SupportAccessExpiry](docs/SupportAccessExpiry.md)
 - [SupportAccessExpiryWithRole](docs/SupportAccessExpiryWithRole.md)
 - [SupportAccessRequest](docs/SupportAccessRequest.md)
 - [SupportAccessResponse](docs/SupportAccessResponse.md)
 - [SupportRole](docs/SupportRole.md)
 - [SupportRolesResponse](docs/SupportRolesResponse.md)
 - [TemporaryPassword](docs/TemporaryPassword.md)
 - [UpdateNetworkZoneRequest](docs/UpdateNetworkZoneRequest.md)
 - [UpdatePasswordPolicyRequest](docs/UpdatePasswordPolicyRequest.md)
 - [UpdatePasswordPolicyRequestAge](docs/UpdatePasswordPolicyRequestAge.md)
 - [UpdatePasswordPolicyRequestComplexity](docs/UpdatePasswordPolicyRequestComplexity.md)
 - [UpdatePasswordPolicyRequestConditions](docs/UpdatePasswordPolicyRequestConditions.md)
 - [UpdatePasswordPolicyRequestLockout](docs/UpdatePasswordPolicyRequestLockout.md)
 - [UpdateRoleRequest](docs/UpdateRoleRequest.md)
 - [UpdateUserRequest](docs/UpdateUserRequest.md)
 - [UpdateUserSchemaRequest](docs/UpdateUserSchemaRequest.md)
 - [UserResponse](docs/UserResponse.md)
 - [UserSchemaProperty](docs/UserSchemaProperty.md)
 - [UserSchemaResponse](docs/UserSchemaResponse.md)
 - [UserSummary](docs/UserSummary.md)

