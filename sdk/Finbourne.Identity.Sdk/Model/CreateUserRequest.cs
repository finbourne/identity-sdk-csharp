/*
 * FINBOURNE Identity Service API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Identity.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Identity.Sdk.Model
{
    /// <summary>
    /// Details necessary for creating a new user
    /// </summary>
    [DataContract(Name = "CreateUserRequest")]
    public partial class CreateUserRequest : IEquatable<CreateUserRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateUserRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserRequest" /> class.
        /// </summary>
        /// <param name="firstName">The first name of the user (required).</param>
        /// <param name="lastName">The last name of the user (required).</param>
        /// <param name="emailAddress">The user&#39;s email address - to which the account validation email will be sent. For user accounts  this should exactly match the Login. (required).</param>
        /// <param name="secondEmailAddress">The user&#39;s second email address. Only allowed for Service users.</param>
        /// <param name="login">The user&#39;s login username, in the form of an email address, which must be unique within the system.  For user accounts this should exactly match the user&#39;s email address. (required).</param>
        /// <param name="alternativeUserIds">alternativeUserIds.</param>
        /// <param name="roles">Optional. Any known roles the user should be created with..</param>
        /// <param name="type">The type of user (e.g. Personal or Service) (required).</param>
        public CreateUserRequest(string firstName = default(string), string lastName = default(string), string emailAddress = default(string), string secondEmailAddress = default(string), string login = default(string), Dictionary<string, string> alternativeUserIds = default(Dictionary<string, string>), List<RoleId> roles = default(List<RoleId>), string type = default(string))
        {
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName is a required property for CreateUserRequest and cannot be null");
            }
            this.FirstName = firstName;
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new ArgumentNullException("lastName is a required property for CreateUserRequest and cannot be null");
            }
            this.LastName = lastName;
            // to ensure "emailAddress" is required (not null)
            if (emailAddress == null)
            {
                throw new ArgumentNullException("emailAddress is a required property for CreateUserRequest and cannot be null");
            }
            this.EmailAddress = emailAddress;
            // to ensure "login" is required (not null)
            if (login == null)
            {
                throw new ArgumentNullException("login is a required property for CreateUserRequest and cannot be null");
            }
            this.Login = login;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for CreateUserRequest and cannot be null");
            }
            this.Type = type;
            this.SecondEmailAddress = secondEmailAddress;
            this.AlternativeUserIds = alternativeUserIds;
            this.Roles = roles;
        }

        /// <summary>
        /// The first name of the user
        /// </summary>
        /// <value>The first name of the user</value>
        [DataMember(Name = "firstName", IsRequired = true, EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the user
        /// </summary>
        /// <value>The last name of the user</value>
        [DataMember(Name = "lastName", IsRequired = true, EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// The user&#39;s email address - to which the account validation email will be sent. For user accounts  this should exactly match the Login.
        /// </summary>
        /// <value>The user&#39;s email address - to which the account validation email will be sent. For user accounts  this should exactly match the Login.</value>
        [DataMember(Name = "emailAddress", IsRequired = true, EmitDefaultValue = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The user&#39;s second email address. Only allowed for Service users
        /// </summary>
        /// <value>The user&#39;s second email address. Only allowed for Service users</value>
        [DataMember(Name = "secondEmailAddress", EmitDefaultValue = true)]
        public string SecondEmailAddress { get; set; }

        /// <summary>
        /// The user&#39;s login username, in the form of an email address, which must be unique within the system.  For user accounts this should exactly match the user&#39;s email address.
        /// </summary>
        /// <value>The user&#39;s login username, in the form of an email address, which must be unique within the system.  For user accounts this should exactly match the user&#39;s email address.</value>
        [DataMember(Name = "login", IsRequired = true, EmitDefaultValue = true)]
        public string Login { get; set; }

        /// <summary>
        /// Gets or Sets AlternativeUserIds
        /// </summary>
        [DataMember(Name = "alternativeUserIds", EmitDefaultValue = true)]
        public Dictionary<string, string> AlternativeUserIds { get; set; }

        /// <summary>
        /// Optional. Any known roles the user should be created with.
        /// </summary>
        /// <value>Optional. Any known roles the user should be created with.</value>
        [DataMember(Name = "roles", EmitDefaultValue = true)]
        public List<RoleId> Roles { get; set; }

        /// <summary>
        /// The type of user (e.g. Personal or Service)
        /// </summary>
        /// <value>The type of user (e.g. Personal or Service)</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateUserRequest {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  SecondEmailAddress: ").Append(SecondEmailAddress).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  AlternativeUserIds: ").Append(AlternativeUserIds).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateUserRequest);
        }

        /// <summary>
        /// Returns true if CreateUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUserRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.SecondEmailAddress == input.SecondEmailAddress ||
                    (this.SecondEmailAddress != null &&
                    this.SecondEmailAddress.Equals(input.SecondEmailAddress))
                ) && 
                (
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
                ) && 
                (
                    this.AlternativeUserIds == input.AlternativeUserIds ||
                    this.AlternativeUserIds != null &&
                    input.AlternativeUserIds != null &&
                    this.AlternativeUserIds.SequenceEqual(input.AlternativeUserIds)
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.EmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddress.GetHashCode();
                }
                if (this.SecondEmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.SecondEmailAddress.GetHashCode();
                }
                if (this.Login != null)
                {
                    hashCode = (hashCode * 59) + this.Login.GetHashCode();
                }
                if (this.AlternativeUserIds != null)
                {
                    hashCode = (hashCode * 59) + this.AlternativeUserIds.GetHashCode();
                }
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // FirstName (string) maxLength
            if (this.FirstName != null && this.FirstName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 50.", new [] { "FirstName" });
            }

            // FirstName (string) minLength
            if (this.FirstName != null && this.FirstName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be greater than 1.", new [] { "FirstName" });
            }

            // FirstName (string) pattern
            Regex regexFirstName = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexFirstName.Match(this.FirstName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, must match a pattern of " + regexFirstName, new [] { "FirstName" });
            }

            // LastName (string) maxLength
            if (this.LastName != null && this.LastName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 50.", new [] { "LastName" });
            }

            // LastName (string) minLength
            if (this.LastName != null && this.LastName.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be greater than 2.", new [] { "LastName" });
            }

            // LastName (string) pattern
            Regex regexLastName = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexLastName.Match(this.LastName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, must match a pattern of " + regexLastName, new [] { "LastName" });
            }

            // EmailAddress (string) maxLength
            if (this.EmailAddress != null && this.EmailAddress.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmailAddress, length must be less than 80.", new [] { "EmailAddress" });
            }

            // EmailAddress (string) minLength
            if (this.EmailAddress != null && this.EmailAddress.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmailAddress, length must be greater than 5.", new [] { "EmailAddress" });
            }

            // SecondEmailAddress (string) maxLength
            if (this.SecondEmailAddress != null && this.SecondEmailAddress.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecondEmailAddress, length must be less than 80.", new [] { "SecondEmailAddress" });
            }

            // SecondEmailAddress (string) minLength
            if (this.SecondEmailAddress != null && this.SecondEmailAddress.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecondEmailAddress, length must be greater than 5.", new [] { "SecondEmailAddress" });
            }

            // Login (string) maxLength
            if (this.Login != null && this.Login.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Login, length must be less than 80.", new [] { "Login" });
            }

            // Login (string) minLength
            if (this.Login != null && this.Login.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Login, length must be greater than 5.", new [] { "Login" });
            }

            // Type (string) maxLength
            if (this.Type != null && this.Type.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be less than 20.", new [] { "Type" });
            }

            // Type (string) minLength
            if (this.Type != null && this.Type.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^[a-zA-Z]*$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
