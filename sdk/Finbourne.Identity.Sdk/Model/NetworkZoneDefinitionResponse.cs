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
    /// The Client facing representation of a NetworkZone
    /// </summary>
    [DataContract(Name = "NetworkZoneDefinitionResponse")]
    public partial class NetworkZoneDefinitionResponse : IEquatable<NetworkZoneDefinitionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkZoneDefinitionResponse" /> class.
        /// </summary>
        /// <param name="code">The Network Zone Code.</param>
        /// <param name="hierarchy">Hierarchy of the Network Zone.</param>
        /// <param name="description">The Description of the Network Zone.</param>
        /// <param name="createdAt">Network Zone Creation timestamp.</param>
        /// <param name="updatedAt">Timestamp of the last update.</param>
        /// <param name="networkZoneIPs">Network zone IP information (IPs and CIDR ranges).</param>
        /// <param name="action">Kind of action to apply when a request matches this Network Zone (Block/Allow/NoOp).</param>
        /// <param name="applyRules">applyRules.</param>
        /// <param name="createdBy">User Id that created the Network Zone.</param>
        /// <param name="updatedBy">User Id of the last update on the Network Zone.</param>
        public NetworkZoneDefinitionResponse(string code = default(string), int hierarchy = default(int), string description = default(string), DateTimeOffset createdAt = default(DateTimeOffset), DateTimeOffset updatedAt = default(DateTimeOffset), List<IpAddressDefinition> networkZoneIPs = default(List<IpAddressDefinition>), string action = default(string), NetworkZonesApplyRules applyRules = default(NetworkZonesApplyRules), string createdBy = default(string), string updatedBy = default(string))
        {
            this.Code = code;
            this.Hierarchy = hierarchy;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.NetworkZoneIPs = networkZoneIPs;
            this.Action = action;
            this.ApplyRules = applyRules;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// The Network Zone Code
        /// </summary>
        /// <value>The Network Zone Code</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Hierarchy of the Network Zone
        /// </summary>
        /// <value>Hierarchy of the Network Zone</value>
        [DataMember(Name = "hierarchy", EmitDefaultValue = true)]
        public int Hierarchy { get; set; }

        /// <summary>
        /// The Description of the Network Zone
        /// </summary>
        /// <value>The Description of the Network Zone</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Network Zone Creation timestamp
        /// </summary>
        /// <value>Network Zone Creation timestamp</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of the last update
        /// </summary>
        /// <value>Timestamp of the last update</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Network zone IP information (IPs and CIDR ranges)
        /// </summary>
        /// <value>Network zone IP information (IPs and CIDR ranges)</value>
        [DataMember(Name = "networkZoneIPs", EmitDefaultValue = true)]
        public List<IpAddressDefinition> NetworkZoneIPs { get; set; }

        /// <summary>
        /// Kind of action to apply when a request matches this Network Zone (Block/Allow/NoOp)
        /// </summary>
        /// <value>Kind of action to apply when a request matches this Network Zone (Block/Allow/NoOp)</value>
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets ApplyRules
        /// </summary>
        [DataMember(Name = "applyRules", EmitDefaultValue = false)]
        public NetworkZonesApplyRules ApplyRules { get; set; }

        /// <summary>
        /// User Id that created the Network Zone
        /// </summary>
        /// <value>User Id that created the Network Zone</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// User Id of the last update on the Network Zone
        /// </summary>
        /// <value>User Id of the last update on the Network Zone</value>
        [DataMember(Name = "updatedBy", EmitDefaultValue = true)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NetworkZoneDefinitionResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Hierarchy: ").Append(Hierarchy).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  NetworkZoneIPs: ").Append(NetworkZoneIPs).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ApplyRules: ").Append(ApplyRules).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
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
            return this.Equals(input as NetworkZoneDefinitionResponse);
        }

        /// <summary>
        /// Returns true if NetworkZoneDefinitionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkZoneDefinitionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkZoneDefinitionResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Hierarchy == input.Hierarchy ||
                    this.Hierarchy.Equals(input.Hierarchy)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.UpdatedBy == input.UpdatedBy ||
                    (this.UpdatedBy != null &&
                    this.UpdatedBy.Equals(input.UpdatedBy))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Hierarchy.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.UpdatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedBy.GetHashCode();
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