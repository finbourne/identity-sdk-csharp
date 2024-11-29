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
    /// NetworkZonesApplyRules
    /// </summary>
    [DataContract(Name = "NetworkZonesApplyRules")]
    public partial class NetworkZonesApplyRules : IEquatable<NetworkZonesApplyRules>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkZonesApplyRules" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NetworkZonesApplyRules() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkZonesApplyRules" /> class.
        /// </summary>
        /// <param name="sessionType">sessionType (required).</param>
        /// <param name="userRoles">userRoles (required).</param>
        public NetworkZonesApplyRules(List<string> sessionType = default(List<string>), List<string> userRoles = default(List<string>))
        {
            // to ensure "sessionType" is required (not null)
            if (sessionType == null)
            {
                throw new ArgumentNullException("sessionType is a required property for NetworkZonesApplyRules and cannot be null");
            }
            this.SessionType = sessionType;
            // to ensure "userRoles" is required (not null)
            if (userRoles == null)
            {
                throw new ArgumentNullException("userRoles is a required property for NetworkZonesApplyRules and cannot be null");
            }
            this.UserRoles = userRoles;
        }

        /// <summary>
        /// Gets or Sets SessionType
        /// </summary>
        [DataMember(Name = "sessionType", IsRequired = true, EmitDefaultValue = true)]
        public List<string> SessionType { get; set; }

        /// <summary>
        /// Gets or Sets UserRoles
        /// </summary>
        [DataMember(Name = "userRoles", IsRequired = true, EmitDefaultValue = true)]
        public List<string> UserRoles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NetworkZonesApplyRules {\n");
            sb.Append("  SessionType: ").Append(SessionType).Append("\n");
            sb.Append("  UserRoles: ").Append(UserRoles).Append("\n");
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
            return this.Equals(input as NetworkZonesApplyRules);
        }

        /// <summary>
        /// Returns true if NetworkZonesApplyRules instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkZonesApplyRules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkZonesApplyRules input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SessionType == input.SessionType ||
                    this.SessionType != null &&
                    input.SessionType != null &&
                    this.SessionType.SequenceEqual(input.SessionType)
                ) && 
                (
                    this.UserRoles == input.UserRoles ||
                    this.UserRoles != null &&
                    input.UserRoles != null &&
                    this.UserRoles.SequenceEqual(input.UserRoles)
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
                if (this.SessionType != null)
                {
                    hashCode = (hashCode * 59) + this.SessionType.GetHashCode();
                }
                if (this.UserRoles != null)
                {
                    hashCode = (hashCode * 59) + this.UserRoles.GetHashCode();
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
