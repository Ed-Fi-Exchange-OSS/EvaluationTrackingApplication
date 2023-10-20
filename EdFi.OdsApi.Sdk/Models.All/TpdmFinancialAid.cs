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


using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// TpdmFinancialAid
    /// </summary>
    [DataContract(Name = "tpdm_financialAid")]
    public partial class TpdmFinancialAid : IEquatable<TpdmFinancialAid>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmFinancialAid" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmFinancialAid() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmFinancialAid" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="aidTypeDescriptor">The classification of financial aid awarded to a person for the academic term/year. (required).</param>
        /// <param name="beginDate">The date the award was designated. (required).</param>
        /// <param name="studentReference">studentReference (required).</param>
        /// <param name="aidAmount">The amount of financial aid awarded to a person for the term/year..</param>
        /// <param name="aidConditionDescription">The description of the condition (e.g., placement in a high need school) under which the aid was given..</param>
        /// <param name="endDate">The date the award was removed..</param>
        /// <param name="pellGrantRecipient">Indicates a person who receives Pell Grant aid..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmFinancialAid(string id = default(string), string aidTypeDescriptor = default(string), DateTime beginDate = default(DateTime), EdFiStudentReference studentReference = default(EdFiStudentReference), double? aidAmount = default(double?), string aidConditionDescription = default(string), DateTime? endDate = default(DateTime?), bool? pellGrantRecipient = default(bool?), string etag = default(string))
        {
            // to ensure "aidTypeDescriptor" is required (not null)
            if (aidTypeDescriptor == null)
            {
                throw new ArgumentNullException("aidTypeDescriptor is a required property for TpdmFinancialAid and cannot be null");
            }
            this.AidTypeDescriptor = aidTypeDescriptor;
            this.BeginDate = beginDate;
            // to ensure "studentReference" is required (not null)
            if (studentReference == null)
            {
                throw new ArgumentNullException("studentReference is a required property for TpdmFinancialAid and cannot be null");
            }
            this.StudentReference = studentReference;
            this.Id = id;
            this.AidAmount = aidAmount;
            this.AidConditionDescription = aidConditionDescription;
            this.EndDate = endDate;
            this.PellGrantRecipient = pellGrantRecipient;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The classification of financial aid awarded to a person for the academic term/year.
        /// </summary>
        /// <value>The classification of financial aid awarded to a person for the academic term/year.</value>
        [DataMember(Name = "aidTypeDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string AidTypeDescriptor { get; set; }

        /// <summary>
        /// The date the award was designated.
        /// </summary>
        /// <value>The date the award was designated.</value>
        [DataMember(Name = "beginDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// Gets or Sets StudentReference
        /// </summary>
        [DataMember(Name = "studentReference", IsRequired = true, EmitDefaultValue = false)]
        public EdFiStudentReference StudentReference { get; set; }

        /// <summary>
        /// The amount of financial aid awarded to a person for the term/year.
        /// </summary>
        /// <value>The amount of financial aid awarded to a person for the term/year.</value>
        [DataMember(Name = "aidAmount", EmitDefaultValue = true)]
        public double? AidAmount { get; set; }

        /// <summary>
        /// The description of the condition (e.g., placement in a high need school) under which the aid was given.
        /// </summary>
        /// <value>The description of the condition (e.g., placement in a high need school) under which the aid was given.</value>
        [DataMember(Name = "aidConditionDescription", EmitDefaultValue = true)]
        public string AidConditionDescription { get; set; }

        /// <summary>
        /// The date the award was removed.
        /// </summary>
        /// <value>The date the award was removed.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Indicates a person who receives Pell Grant aid.
        /// </summary>
        /// <value>Indicates a person who receives Pell Grant aid.</value>
        [DataMember(Name = "pellGrantRecipient", EmitDefaultValue = true)]
        public bool? PellGrantRecipient { get; set; }

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
            StringBuilder sb = new StringBuilder();
            sb.Append("class TpdmFinancialAid {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AidTypeDescriptor: ").Append(AidTypeDescriptor).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  StudentReference: ").Append(StudentReference).Append("\n");
            sb.Append("  AidAmount: ").Append(AidAmount).Append("\n");
            sb.Append("  AidConditionDescription: ").Append(AidConditionDescription).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  PellGrantRecipient: ").Append(PellGrantRecipient).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as TpdmFinancialAid);
        }

        /// <summary>
        /// Returns true if TpdmFinancialAid instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmFinancialAid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmFinancialAid input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.AidTypeDescriptor == input.AidTypeDescriptor ||
                    (this.AidTypeDescriptor != null &&
                    this.AidTypeDescriptor.Equals(input.AidTypeDescriptor))
                ) &&
                (
                    this.BeginDate == input.BeginDate ||
                    this.BeginDate.Equals(input.BeginDate)
                ) &&
                (
                    this.StudentReference == input.StudentReference ||
                    (this.StudentReference != null &&
                    this.StudentReference.Equals(input.StudentReference))
                ) &&
                (
                    this.AidAmount == input.AidAmount ||
                    (this.AidAmount != null &&
                    this.AidAmount.Equals(input.AidAmount))
                ) &&
                (
                    this.AidConditionDescription == input.AidConditionDescription ||
                    (this.AidConditionDescription != null &&
                    this.AidConditionDescription.Equals(input.AidConditionDescription))
                ) &&
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) &&
                (
                    this.PellGrantRecipient == input.PellGrantRecipient ||
                    (this.PellGrantRecipient != null &&
                    this.PellGrantRecipient.Equals(input.PellGrantRecipient))
                ) &&
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.AidTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.AidTypeDescriptor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BeginDate.GetHashCode();
                if (this.StudentReference != null)
                {
                    hashCode = (hashCode * 59) + this.StudentReference.GetHashCode();
                }
                if (this.AidAmount != null)
                {
                    hashCode = (hashCode * 59) + this.AidAmount.GetHashCode();
                }
                if (this.AidConditionDescription != null)
                {
                    hashCode = (hashCode * 59) + this.AidConditionDescription.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.PellGrantRecipient != null)
                {
                    hashCode = (hashCode * 59) + this.PellGrantRecipient.GetHashCode();
                }
                if (this.Etag != null)
                {
                    hashCode = (hashCode * 59) + this.Etag.GetHashCode();
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
            // AidTypeDescriptor (string) maxLength
            if (this.AidTypeDescriptor != null && this.AidTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AidTypeDescriptor, length must be less than 306.", new[] { "AidTypeDescriptor" });
            }

            // AidConditionDescription (string) maxLength
            if (this.AidConditionDescription != null && this.AidConditionDescription.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AidConditionDescription, length must be less than 1024.", new[] { "AidConditionDescription" });
            }

            yield break;
        }
    }

}
