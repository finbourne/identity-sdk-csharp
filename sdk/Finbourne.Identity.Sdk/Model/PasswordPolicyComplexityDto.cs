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
    /// PasswordPolicyComplexityDto
    /// </summary>
    [DataContract(Name = "PasswordPolicyComplexityDto")]
    public partial class PasswordPolicyComplexityDto : IEquatable<PasswordPolicyComplexityDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordPolicyComplexityDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PasswordPolicyComplexityDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordPolicyComplexityDto" /> class.
        /// </summary>
        /// <param name="minLength">The minimum length for a password (required).</param>
        /// <param name="excludeFirstName">Rule determining whether a user&#39;s first name should be permitted in their password (required).</param>
        /// <param name="excludeLastName">Rule determining whether a user&#39;s last name should be permitted in their password (required).</param>
        public PasswordPolicyComplexityDto(int minLength = default(int), bool excludeFirstName = default(bool), bool excludeLastName = default(bool))
        {
            this.MinLength = minLength;
            this.ExcludeFirstName = excludeFirstName;
            this.ExcludeLastName = excludeLastName;
        }

        /// <summary>
        /// The minimum length for a password
        /// </summary>
        /// <value>The minimum length for a password</value>
        [DataMember(Name = "minLength", IsRequired = true, EmitDefaultValue = true)]
        public int MinLength { get; set; }

        /// <summary>
        /// Rule determining whether a user&#39;s first name should be permitted in their password
        /// </summary>
        /// <value>Rule determining whether a user&#39;s first name should be permitted in their password</value>
        [DataMember(Name = "excludeFirstName", IsRequired = true, EmitDefaultValue = true)]
        public bool ExcludeFirstName { get; set; }

        /// <summary>
        /// Rule determining whether a user&#39;s last name should be permitted in their password
        /// </summary>
        /// <value>Rule determining whether a user&#39;s last name should be permitted in their password</value>
        [DataMember(Name = "excludeLastName", IsRequired = true, EmitDefaultValue = true)]
        public bool ExcludeLastName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PasswordPolicyComplexityDto {\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("  ExcludeFirstName: ").Append(ExcludeFirstName).Append("\n");
            sb.Append("  ExcludeLastName: ").Append(ExcludeLastName).Append("\n");
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
            return this.Equals(input as PasswordPolicyComplexityDto);
        }

        /// <summary>
        /// Returns true if PasswordPolicyComplexityDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordPolicyComplexityDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordPolicyComplexityDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MinLength == input.MinLength ||
                    this.MinLength.Equals(input.MinLength)
                ) && 
                (
                    this.ExcludeFirstName == input.ExcludeFirstName ||
                    this.ExcludeFirstName.Equals(input.ExcludeFirstName)
                ) && 
                (
                    this.ExcludeLastName == input.ExcludeLastName ||
                    this.ExcludeLastName.Equals(input.ExcludeLastName)
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
                hashCode = (hashCode * 59) + this.MinLength.GetHashCode();
                hashCode = (hashCode * 59) + this.ExcludeFirstName.GetHashCode();
                hashCode = (hashCode * 59) + this.ExcludeLastName.GetHashCode();
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
            yield break;
        }
    }
}