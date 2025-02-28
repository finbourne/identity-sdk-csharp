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
    /// A system log event
    /// </summary>
    [DataContract(Name = "SystemLog")]
    public partial class SystemLog : IEquatable<SystemLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemLog" /> class.
        /// </summary>
        /// <param name="actor">actor.</param>
        /// <param name="authenticationContext">authenticationContext.</param>
        /// <param name="clientInfo">clientInfo.</param>
        /// <param name="debugContext">debugContext.</param>
        /// <param name="displayMessage">Represents a DisplayMessage resource in the Okta API.</param>
        /// <param name="eventType">Represents a EventType resource in the Okta API.</param>
        /// <param name="legacyEventType">Represents a LegacyEventType resource in the Okta API.</param>
        /// <param name="outcome">outcome.</param>
        /// <param name="published">Represents when Published in the Okta API.</param>
        /// <param name="request">request.</param>
        /// <param name="securityContext">securityContext.</param>
        /// <param name="severity">severity.</param>
        /// <param name="target">Represents a LogTarget resource in the Okta API.</param>
        /// <param name="transaction">transaction.</param>
        /// <param name="uuid">Represents Uuid in the Okta API.</param>
        /// <param name="varVersion">Represents a Version in the Okta API.</param>
        public SystemLog(LogActor actor = default(LogActor), LogAuthenticationContext authenticationContext = default(LogAuthenticationContext), LogClientInfo clientInfo = default(LogClientInfo), LogDebugContext debugContext = default(LogDebugContext), string displayMessage = default(string), string eventType = default(string), string legacyEventType = default(string), LogOutcome outcome = default(LogOutcome), DateTimeOffset? published = default(DateTimeOffset?), LogRequest request = default(LogRequest), LogSecurityContext securityContext = default(LogSecurityContext), LogSeverity severity = default(LogSeverity), List<LogTarget> target = default(List<LogTarget>), LogTransaction transaction = default(LogTransaction), string uuid = default(string), string varVersion = default(string))
        {
            this.Actor = actor;
            this.AuthenticationContext = authenticationContext;
            this.ClientInfo = clientInfo;
            this.DebugContext = debugContext;
            this.DisplayMessage = displayMessage;
            this.EventType = eventType;
            this.LegacyEventType = legacyEventType;
            this.Outcome = outcome;
            this.Published = published;
            this.Request = request;
            this.SecurityContext = securityContext;
            this.Severity = severity;
            this.Target = target;
            this.Transaction = transaction;
            this.Uuid = uuid;
            this.VarVersion = varVersion;
        }

        /// <summary>
        /// Gets or Sets Actor
        /// </summary>
        [DataMember(Name = "actor", EmitDefaultValue = false)]
        public LogActor Actor { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationContext
        /// </summary>
        [DataMember(Name = "authenticationContext", EmitDefaultValue = false)]
        public LogAuthenticationContext AuthenticationContext { get; set; }

        /// <summary>
        /// Gets or Sets ClientInfo
        /// </summary>
        [DataMember(Name = "clientInfo", EmitDefaultValue = false)]
        public LogClientInfo ClientInfo { get; set; }

        /// <summary>
        /// Gets or Sets DebugContext
        /// </summary>
        [DataMember(Name = "debugContext", EmitDefaultValue = false)]
        public LogDebugContext DebugContext { get; set; }

        /// <summary>
        /// Represents a DisplayMessage resource in the Okta API
        /// </summary>
        /// <value>Represents a DisplayMessage resource in the Okta API</value>
        [DataMember(Name = "displayMessage", EmitDefaultValue = true)]
        public string DisplayMessage { get; set; }

        /// <summary>
        /// Represents a EventType resource in the Okta API
        /// </summary>
        /// <value>Represents a EventType resource in the Okta API</value>
        [DataMember(Name = "eventType", EmitDefaultValue = true)]
        public string EventType { get; set; }

        /// <summary>
        /// Represents a LegacyEventType resource in the Okta API
        /// </summary>
        /// <value>Represents a LegacyEventType resource in the Okta API</value>
        [DataMember(Name = "legacyEventType", EmitDefaultValue = true)]
        public string LegacyEventType { get; set; }

        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name = "outcome", EmitDefaultValue = false)]
        public LogOutcome Outcome { get; set; }

        /// <summary>
        /// Represents when Published in the Okta API
        /// </summary>
        /// <value>Represents when Published in the Okta API</value>
        [DataMember(Name = "published", EmitDefaultValue = true)]
        public DateTimeOffset? Published { get; set; }

        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name = "request", EmitDefaultValue = false)]
        public LogRequest Request { get; set; }

        /// <summary>
        /// Gets or Sets SecurityContext
        /// </summary>
        [DataMember(Name = "securityContext", EmitDefaultValue = false)]
        public LogSecurityContext SecurityContext { get; set; }

        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name = "severity", EmitDefaultValue = false)]
        public LogSeverity Severity { get; set; }

        /// <summary>
        /// Represents a LogTarget resource in the Okta API
        /// </summary>
        /// <value>Represents a LogTarget resource in the Okta API</value>
        [DataMember(Name = "target", EmitDefaultValue = true)]
        public List<LogTarget> Target { get; set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public LogTransaction Transaction { get; set; }

        /// <summary>
        /// Represents Uuid in the Okta API
        /// </summary>
        /// <value>Represents Uuid in the Okta API</value>
        [DataMember(Name = "uuid", EmitDefaultValue = true)]
        public string Uuid { get; set; }

        /// <summary>
        /// Represents a Version in the Okta API
        /// </summary>
        /// <value>Represents a Version in the Okta API</value>
        [DataMember(Name = "version", EmitDefaultValue = true)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemLog {\n");
            sb.Append("  Actor: ").Append(Actor).Append("\n");
            sb.Append("  AuthenticationContext: ").Append(AuthenticationContext).Append("\n");
            sb.Append("  ClientInfo: ").Append(ClientInfo).Append("\n");
            sb.Append("  DebugContext: ").Append(DebugContext).Append("\n");
            sb.Append("  DisplayMessage: ").Append(DisplayMessage).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  LegacyEventType: ").Append(LegacyEventType).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  SecurityContext: ").Append(SecurityContext).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
            return this.Equals(input as SystemLog);
        }

        /// <summary>
        /// Returns true if SystemLog instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemLog input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Actor == input.Actor ||
                    (this.Actor != null &&
                    this.Actor.Equals(input.Actor))
                ) && 
                (
                    this.AuthenticationContext == input.AuthenticationContext ||
                    (this.AuthenticationContext != null &&
                    this.AuthenticationContext.Equals(input.AuthenticationContext))
                ) && 
                (
                    this.ClientInfo == input.ClientInfo ||
                    (this.ClientInfo != null &&
                    this.ClientInfo.Equals(input.ClientInfo))
                ) && 
                (
                    this.DebugContext == input.DebugContext ||
                    (this.DebugContext != null &&
                    this.DebugContext.Equals(input.DebugContext))
                ) && 
                (
                    this.DisplayMessage == input.DisplayMessage ||
                    (this.DisplayMessage != null &&
                    this.DisplayMessage.Equals(input.DisplayMessage))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.LegacyEventType == input.LegacyEventType ||
                    (this.LegacyEventType != null &&
                    this.LegacyEventType.Equals(input.LegacyEventType))
                ) && 
                (
                    this.Outcome == input.Outcome ||
                    (this.Outcome != null &&
                    this.Outcome.Equals(input.Outcome))
                ) && 
                (
                    this.Published == input.Published ||
                    (this.Published != null &&
                    this.Published.Equals(input.Published))
                ) && 
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && 
                (
                    this.SecurityContext == input.SecurityContext ||
                    (this.SecurityContext != null &&
                    this.SecurityContext.Equals(input.SecurityContext))
                ) && 
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
                ) && 
                (
                    this.Target == input.Target ||
                    this.Target != null &&
                    input.Target != null &&
                    this.Target.SequenceEqual(input.Target)
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.VarVersion == input.VarVersion ||
                    (this.VarVersion != null &&
                    this.VarVersion.Equals(input.VarVersion))
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
                if (this.Actor != null)
                {
                    hashCode = (hashCode * 59) + this.Actor.GetHashCode();
                }
                if (this.AuthenticationContext != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationContext.GetHashCode();
                }
                if (this.ClientInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ClientInfo.GetHashCode();
                }
                if (this.DebugContext != null)
                {
                    hashCode = (hashCode * 59) + this.DebugContext.GetHashCode();
                }
                if (this.DisplayMessage != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayMessage.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.LegacyEventType != null)
                {
                    hashCode = (hashCode * 59) + this.LegacyEventType.GetHashCode();
                }
                if (this.Outcome != null)
                {
                    hashCode = (hashCode * 59) + this.Outcome.GetHashCode();
                }
                if (this.Published != null)
                {
                    hashCode = (hashCode * 59) + this.Published.GetHashCode();
                }
                if (this.Request != null)
                {
                    hashCode = (hashCode * 59) + this.Request.GetHashCode();
                }
                if (this.SecurityContext != null)
                {
                    hashCode = (hashCode * 59) + this.SecurityContext.GetHashCode();
                }
                if (this.Severity != null)
                {
                    hashCode = (hashCode * 59) + this.Severity.GetHashCode();
                }
                if (this.Target != null)
                {
                    hashCode = (hashCode * 59) + this.Target.GetHashCode();
                }
                if (this.Transaction != null)
                {
                    hashCode = (hashCode * 59) + this.Transaction.GetHashCode();
                }
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                if (this.VarVersion != null)
                {
                    hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
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
