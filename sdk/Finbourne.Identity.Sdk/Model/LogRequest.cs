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
    /// Represents a LogRequest resource in the Okta API
    /// </summary>
    [DataContract(Name = "LogRequest")]
    public partial class LogRequest : IEquatable<LogRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogRequest" /> class.
        /// </summary>
        /// <param name="ipChain">ipChain.</param>
        public LogRequest(List<LogIpChainEntry> ipChain = default(List<LogIpChainEntry>))
        {
            this.IpChain = ipChain;
        }

        /// <summary>
        /// Gets or Sets IpChain
        /// </summary>
        [DataMember(Name = "ipChain", EmitDefaultValue = true)]
        public List<LogIpChainEntry> IpChain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogRequest {\n");
            sb.Append("  IpChain: ").Append(IpChain).Append("\n");
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
            return this.Equals(input as LogRequest);
        }

        /// <summary>
        /// Returns true if LogRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LogRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IpChain == input.IpChain ||
                    this.IpChain != null &&
                    input.IpChain != null &&
                    this.IpChain.SequenceEqual(input.IpChain)
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
                if (this.IpChain != null)
                {
                    hashCode = (hashCode * 59) + this.IpChain.GetHashCode();
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
