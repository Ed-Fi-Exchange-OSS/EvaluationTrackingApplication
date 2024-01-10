// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.
/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// TpdmAidTypeDescriptor
    /// </summary>
    [DataContract(Name = "tpdm_aidTypeDescriptor")]
    public partial class TpdmAidTypeDescriptor : IEquatable<TpdmAidTypeDescriptor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmAidTypeDescriptor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmAidTypeDescriptor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmAidTypeDescriptor" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="aidTypeDescriptorId">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table..</param>
        /// <param name="codeValue">A code or abbreviation that is used to refer to the descriptor. (required).</param>
        /// <param name="description">The description of the descriptor..</param>
        /// <param name="effectiveBeginDate">The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness..</param>
        /// <param name="effectiveEndDate">The end date of the period when the descriptor is in effect..</param>
        /// <param name="_namespace">A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary. (required).</param>
        /// <param name="priorDescriptorId">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table..</param>
        /// <param name="shortDescription">A shortened description for the descriptor. (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmAidTypeDescriptor(string id = default, int aidTypeDescriptorId = default, string codeValue = default, string description = default, DateTime? effectiveBeginDate = default, DateTime? effectiveEndDate = default, string _namespace = default, int? priorDescriptorId = default, string shortDescription = default, string etag = default)
        {
            CodeValue = codeValue ?? throw new ArgumentNullException("codeValue is a required property for TpdmAidTypeDescriptor and cannot be null");
            Namespace = _namespace ?? throw new ArgumentNullException("_namespace is a required property for TpdmAidTypeDescriptor and cannot be null");
            ShortDescription = shortDescription ?? throw new ArgumentNullException("shortDescription is a required property for TpdmAidTypeDescriptor and cannot be null");
            Id = id;
            AidTypeDescriptorId = aidTypeDescriptorId;
            Description = description;
            EffectiveBeginDate = effectiveBeginDate;
            EffectiveEndDate = effectiveEndDate;
            PriorDescriptorId = priorDescriptorId;
            Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        /// <value>A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</value>
        [DataMember(Name = "aidTypeDescriptorId", EmitDefaultValue = false)]
        public int AidTypeDescriptorId { get; set; }

        /// <summary>
        /// A code or abbreviation that is used to refer to the descriptor.
        /// </summary>
        /// <value>A code or abbreviation that is used to refer to the descriptor.</value>
        [DataMember(Name = "codeValue", IsRequired = true, EmitDefaultValue = false)]
        public string CodeValue { get; set; }

        /// <summary>
        /// The description of the descriptor.
        /// </summary>
        /// <value>The description of the descriptor.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness.
        /// </summary>
        /// <value>The beginning date of the period when the descriptor is in effect. If omitted, the default is immediate effectiveness.</value>
        [DataMember(Name = "effectiveBeginDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EffectiveBeginDate { get; set; }

        /// <summary>
        /// The end date of the period when the descriptor is in effect.
        /// </summary>
        /// <value>The end date of the period when the descriptor is in effect.</value>
        [DataMember(Name = "effectiveEndDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EffectiveEndDate { get; set; }

        /// <summary>
        /// A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary.
        /// </summary>
        /// <value>A globally unique namespace that identifies this descriptor set. Author is strongly encouraged to use the Universal Resource Identifier (http, ftp, file, etc.) for the source of the descriptor definition. Best practice is for this source to be the descriptor file itself, so that it can be machine-readable and be fetched in real-time, if necessary.</value>
        [DataMember(Name = "namespace", IsRequired = true, EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.
        /// </summary>
        /// <value>A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</value>
        [DataMember(Name = "priorDescriptorId", EmitDefaultValue = true)]
        public int? PriorDescriptorId { get; set; }

        /// <summary>
        /// A shortened description for the descriptor.
        /// </summary>
        /// <value>A shortened description for the descriptor.</value>
        [DataMember(Name = "shortDescription", IsRequired = true, EmitDefaultValue = false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            _ = sb.Append("class TpdmAidTypeDescriptor {\n");
            _ = sb.Append("  Id: ").Append(Id).Append("\n");
            _ = sb.Append("  AidTypeDescriptorId: ").Append(AidTypeDescriptorId).Append("\n");
            _ = sb.Append("  CodeValue: ").Append(CodeValue).Append("\n");
            _ = sb.Append("  Description: ").Append(Description).Append("\n");
            _ = sb.Append("  EffectiveBeginDate: ").Append(EffectiveBeginDate).Append("\n");
            _ = sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
            _ = sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            _ = sb.Append("  PriorDescriptorId: ").Append(PriorDescriptorId).Append("\n");
            _ = sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            _ = sb.Append("  Etag: ").Append(Etag).Append("\n");
            _ = sb.Append("}\n");
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
            return Equals(input as TpdmAidTypeDescriptor);
        }

        /// <summary>
        /// Returns true if TpdmAidTypeDescriptor instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmAidTypeDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmAidTypeDescriptor input)
        {
            return input != null
&& (
                    Id == input.Id ||
                    (Id != null &&
                    Id.Equals(input.Id))
                ) &&
                (
                    AidTypeDescriptorId == input.AidTypeDescriptorId ||
                    AidTypeDescriptorId.Equals(input.AidTypeDescriptorId)
                ) &&
                (
                    CodeValue == input.CodeValue ||
                    (CodeValue != null &&
                    CodeValue.Equals(input.CodeValue))
                ) &&
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) &&
                (
                    EffectiveBeginDate == input.EffectiveBeginDate ||
                    (EffectiveBeginDate != null &&
                    EffectiveBeginDate.Equals(input.EffectiveBeginDate))
                ) &&
                (
                    EffectiveEndDate == input.EffectiveEndDate ||
                    (EffectiveEndDate != null &&
                    EffectiveEndDate.Equals(input.EffectiveEndDate))
                ) &&
                (
                    Namespace == input.Namespace ||
                    (Namespace != null &&
                    Namespace.Equals(input.Namespace))
                ) &&
                (
                    PriorDescriptorId == input.PriorDescriptorId ||
                    (PriorDescriptorId != null &&
                    PriorDescriptorId.Equals(input.PriorDescriptorId))
                ) &&
                (
                    ShortDescription == input.ShortDescription ||
                    (ShortDescription != null &&
                    ShortDescription.Equals(input.ShortDescription))
                ) &&
                (
                    Etag == input.Etag ||
                    (Etag != null &&
                    Etag.Equals(input.Etag))
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
                var hashCode = 41;
                if (Id != null)
                {
                    hashCode = (hashCode * 59) + Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + AidTypeDescriptorId.GetHashCode();
                if (CodeValue != null)
                {
                    hashCode = (hashCode * 59) + CodeValue.GetHashCode();
                }
                if (Description != null)
                {
                    hashCode = (hashCode * 59) + Description.GetHashCode();
                }
                if (EffectiveBeginDate != null)
                {
                    hashCode = (hashCode * 59) + EffectiveBeginDate.GetHashCode();
                }
                if (EffectiveEndDate != null)
                {
                    hashCode = (hashCode * 59) + EffectiveEndDate.GetHashCode();
                }
                if (Namespace != null)
                {
                    hashCode = (hashCode * 59) + Namespace.GetHashCode();
                }
                if (PriorDescriptorId != null)
                {
                    hashCode = (hashCode * 59) + PriorDescriptorId.GetHashCode();
                }
                if (ShortDescription != null)
                {
                    hashCode = (hashCode * 59) + ShortDescription.GetHashCode();
                }
                if (Etag != null)
                {
                    hashCode = (hashCode * 59) + Etag.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // CodeValue (string) maxLength
            if (CodeValue != null && CodeValue.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CodeValue, length must be less than 50.", new[] { "CodeValue" });
            }

            // Description (string) maxLength
            if (Description != null && Description.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 1024.", new[] { "Description" });
            }

            // Namespace (string) maxLength
            if (Namespace != null && Namespace.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Namespace, length must be less than 255.", new[] { "Namespace" });
            }

            // ShortDescription (string) maxLength
            if (ShortDescription != null && ShortDescription.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShortDescription, length must be less than 75.", new[] { "ShortDescription" });
            }

            yield break;
        }
    }

}
