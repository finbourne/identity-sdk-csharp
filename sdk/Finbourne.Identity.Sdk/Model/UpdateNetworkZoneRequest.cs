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
    /// UpdateNetworkZoneRequest
    /// </summary>
    [DataContract(Name = "UpdateNetworkZoneRequest")]
    public partial class UpdateNetworkZoneRequest : IEquatable<UpdateNetworkZoneRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkZoneRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateNetworkZoneRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkZoneRequest" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="networkZoneIPs">networkZoneIPs (required).</param>
        /// <param name="action">action.</param>
        /// <param name="applyRules">applyRules (required).</param>
        /// <param name="hierarchy">hierarchy (required).</param>
        public UpdateNetworkZoneRequest(string description = default(string), List<IpAddressDefinition> networkZoneIPs = default(List<IpAddressDefinition>), string action = default(string), NetworkZonesApplyRules applyRules = default(NetworkZonesApplyRules), int hierarchy = default(int))
        {
            // to ensure "networkZoneIPs" is required (not null)
            if (networkZoneIPs == null)
            {
                throw new ArgumentNullException("networkZoneIPs is a required property for UpdateNetworkZoneRequest and cannot be null");
            }
            this.NetworkZoneIPs = networkZoneIPs;
            // to ensure "applyRules" is required (not null)
            if (applyRules == null)
            {
                throw new ArgumentNullException("applyRules is a required property for UpdateNetworkZoneRequest and cannot be null");
            }
            this.ApplyRules = applyRules;
            this.Hierarchy = hierarchy;
            this.Description = description;
            this.Action = action;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets NetworkZoneIPs
        /// </summary>
        [DataMember(Name = "networkZoneIPs", IsRequired = true, EmitDefaultValue = true)]
        public List<IpAddressDefinition> NetworkZoneIPs { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets ApplyRules
        /// </summary>
        [DataMember(Name = "applyRules", IsRequired = true, EmitDefaultValue = true)]
        public NetworkZonesApplyRules ApplyRules { get; set; }

        /// <summary>
        /// Gets or Sets Hierarchy
        /// </summary>
        [DataMember(Name = "hierarchy", IsRequired = true, EmitDefaultValue = true)]
        public int Hierarchy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateNetworkZoneRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  NetworkZoneIPs: ").Append(NetworkZoneIPs).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ApplyRules: ").Append(ApplyRules).Append("\n");
            sb.Append("  Hierarchy: ").Append(Hierarchy).Append("\n");
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
            return this.Equals(input as UpdateNetworkZoneRequest);
        }

        /// <summary>
        /// Returns true if UpdateNetworkZoneRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateNetworkZoneRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetworkZoneRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.NetworkZoneIPs == input.NetworkZoneIPs ||
                    this.NetworkZoneIPs != null &&
                    input.NetworkZoneIPs != null &&
                    this.NetworkZoneIPs.SequenceEqual(input.NetworkZoneIPs)
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.ApplyRules == input.ApplyRules ||
                    (this.ApplyRules != null &&
                    this.ApplyRules.Equals(input.ApplyRules))
                ) && 
                (
                    this.Hierarchy == input.Hierarchy ||
                    this.Hierarchy.Equals(input.Hierarchy)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.NetworkZoneIPs != null)
                {
                    hashCode = (hashCode * 59) + this.NetworkZoneIPs.GetHashCode();
                }
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.ApplyRules != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyRules.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Hierarchy.GetHashCode();
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