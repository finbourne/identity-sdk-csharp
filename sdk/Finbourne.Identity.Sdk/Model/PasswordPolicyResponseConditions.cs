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
    /// Password policy conditions for a password policy
    /// </summary>
    [DataContract(Name = "PasswordPolicyResponseConditions")]
    public partial class PasswordPolicyResponseConditions : IEquatable<PasswordPolicyResponseConditions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordPolicyResponseConditions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PasswordPolicyResponseConditions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordPolicyResponseConditions" /> class.
        /// </summary>
        /// <param name="complexity">complexity (required).</param>
        /// <param name="age">age (required).</param>
        /// <param name="lockout">lockout (required).</param>
        public PasswordPolicyResponseConditions(PasswordPolicyResponseComplexity complexity = default(PasswordPolicyResponseComplexity), PasswordPolicyResponseAge age = default(PasswordPolicyResponseAge), PasswordPolicyResponseLockout lockout = default(PasswordPolicyResponseLockout))
        {
            // to ensure "complexity" is required (not null)
            if (complexity == null)
            {
                throw new ArgumentNullException("complexity is a required property for PasswordPolicyResponseConditions and cannot be null");
            }
            this.Complexity = complexity;
            // to ensure "age" is required (not null)
            if (age == null)
            {
                throw new ArgumentNullException("age is a required property for PasswordPolicyResponseConditions and cannot be null");
            }
            this.Age = age;
            // to ensure "lockout" is required (not null)
            if (lockout == null)
            {
                throw new ArgumentNullException("lockout is a required property for PasswordPolicyResponseConditions and cannot be null");
            }
            this.Lockout = lockout;
        }

        /// <summary>
        /// Gets or Sets Complexity
        /// </summary>
        [DataMember(Name = "complexity", IsRequired = true, EmitDefaultValue = true)]
        public PasswordPolicyResponseComplexity Complexity { get; set; }

        /// <summary>
        /// Gets or Sets Age
        /// </summary>
        [DataMember(Name = "age", IsRequired = true, EmitDefaultValue = true)]
        public PasswordPolicyResponseAge Age { get; set; }

        /// <summary>
        /// Gets or Sets Lockout
        /// </summary>
        [DataMember(Name = "lockout", IsRequired = true, EmitDefaultValue = true)]
        public PasswordPolicyResponseLockout Lockout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PasswordPolicyResponseConditions {\n");
            sb.Append("  Complexity: ").Append(Complexity).Append("\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("  Lockout: ").Append(Lockout).Append("\n");
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
            return this.Equals(input as PasswordPolicyResponseConditions);
        }

        /// <summary>
        /// Returns true if PasswordPolicyResponseConditions instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordPolicyResponseConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordPolicyResponseConditions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Complexity == input.Complexity ||
                    (this.Complexity != null &&
                    this.Complexity.Equals(input.Complexity))
                ) && 
                (
                    this.Age == input.Age ||
                    (this.Age != null &&
                    this.Age.Equals(input.Age))
                ) && 
                (
                    this.Lockout == input.Lockout ||
                    (this.Lockout != null &&
                    this.Lockout.Equals(input.Lockout))
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
                if (this.Complexity != null)
                {
                    hashCode = (hashCode * 59) + this.Complexity.GetHashCode();
                }
                if (this.Age != null)
                {
                    hashCode = (hashCode * 59) + this.Age.GetHashCode();
                }
                if (this.Lockout != null)
                {
                    hashCode = (hashCode * 59) + this.Lockout.GetHashCode();
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
            yield break;
        }
    }
}
