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
    /// TpdmCandidateEducatorPreparationProgramAssociationDegreeSpecialization
    /// </summary>
    [DataContract(Name = "tpdm_candidateEducatorPreparationProgramAssociationDegreeSpecialization")]
    public partial class TpdmCandidateEducatorPreparationProgramAssociationDegreeSpecialization : IEquatable<TpdmCandidateEducatorPreparationProgramAssociationDegreeSpecialization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCandidateEducatorPreparationProgramAssociationDegreeSpecialization" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmCandidateEducatorPreparationProgramAssociationDegreeSpecialization() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCandidateEducatorPreparationProgramAssociationDegreeSpecialization" /> class.
        /// </summary>
        /// <param name="majorSpecialization">The major area for a degree or area of specialization for a certificate. (required).</param>
        /// <param name="endDate">The month, day, and year on which the Teacher Candidate exited the declared specialization..</param>
        /// <param name="minorSpecialization">The minor area for a degree or area of specialization for a certificate..</param>
        public TpdmCandidateEducatorPreparationProgramAssociationDegreeSpecialization(string majorSpecialization = default(string), DateTime? endDate = default(DateTime?), string minorSpecialization = default(string))
        {
            // to ensure "majorSpecialization" is required (not null)
            if (majorSpecialization == null)
            {
                throw new ArgumentNullException("majorSpecialization is a required property for TpdmCandidateEducatorPreparationProgramAssociationDegreeSpecialization and cannot be null");
            }
            this.MajorSpecialization = majorSpecialization;
            this.EndDate = endDate;
            this.MinorSpecialization = minorSpecialization;
        }

        /// <summary>
        /// The major area for a degree or area of specialization for a certificate.
        /// </summary>
        /// <value>The major area for a degree or area of specialization for a certificate.</value>
        [DataMember(Name = "majorSpecialization", IsRequired = true, EmitDefaultValue = false)]
        public string MajorSpecialization { get; set; }

        /// <summary>
        /// The month, day, and year on which the Teacher Candidate exited the declared specialization.
        /// </summary>
        /// <value>The month, day, and year on which the Teacher Candidate exited the declared specialization.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The minor area for a degree or area of specialization for a certificate.
        /// </summary>
        /// <value>The minor area for a degree or area of specialization for a certificate.</value>
        [DataMember(Name = "minorSpecialization", EmitDefaultValue = true)]
        public string MinorSpecialization { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TpdmCandidateEducatorPreparationProgramAssociationDegreeSpecialization {\n");
            sb.Append("  MajorSpecialization: ").Append(MajorSpecialization).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  MinorSpecialization: ").Append(MinorSpecialization).Append("\n");
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
            return this.Equals(input as TpdmCandidateEducatorPreparationProgramAssociationDegreeSpecialization);
        }

        /// <summary>
        /// Returns true if TpdmCandidateEducatorPreparationProgramAssociationDegreeSpecialization instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmCandidateEducatorPreparationProgramAssociationDegreeSpecialization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmCandidateEducatorPreparationProgramAssociationDegreeSpecialization input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.MajorSpecialization == input.MajorSpecialization ||
                    (this.MajorSpecialization != null &&
                    this.MajorSpecialization.Equals(input.MajorSpecialization))
                ) &&
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) &&
                (
                    this.MinorSpecialization == input.MinorSpecialization ||
                    (this.MinorSpecialization != null &&
                    this.MinorSpecialization.Equals(input.MinorSpecialization))
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
                if (this.MajorSpecialization != null)
                {
                    hashCode = (hashCode * 59) + this.MajorSpecialization.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.MinorSpecialization != null)
                {
                    hashCode = (hashCode * 59) + this.MinorSpecialization.GetHashCode();
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
            // MajorSpecialization (string) maxLength
            if (this.MajorSpecialization != null && this.MajorSpecialization.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MajorSpecialization, length must be less than 255.", new[] { "MajorSpecialization" });
            }

            // MinorSpecialization (string) maxLength
            if (this.MinorSpecialization != null && this.MinorSpecialization.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinorSpecialization, length must be less than 255.", new[] { "MinorSpecialization" });
            }

            yield break;
        }
    }

}
