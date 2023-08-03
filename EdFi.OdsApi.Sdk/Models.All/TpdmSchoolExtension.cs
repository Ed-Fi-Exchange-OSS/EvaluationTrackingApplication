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
using System.ComponentModel.DataAnnotations;

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// TpdmSchoolExtension
    /// </summary>
    [DataContract(Name = "tpdm_schoolExtension")]
    public partial class TpdmSchoolExtension : IEquatable<TpdmSchoolExtension>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmSchoolExtension" /> class.
        /// </summary>
        /// <param name="postSecondaryInstitutionReference">postSecondaryInstitutionReference.</param>
        public TpdmSchoolExtension(EdFiPostSecondaryInstitutionReference postSecondaryInstitutionReference = default(EdFiPostSecondaryInstitutionReference))
        {
            this.PostSecondaryInstitutionReference = postSecondaryInstitutionReference;
        }

        /// <summary>
        /// Gets or Sets PostSecondaryInstitutionReference
        /// </summary>
        [DataMember(Name = "postSecondaryInstitutionReference", EmitDefaultValue = false)]
        public EdFiPostSecondaryInstitutionReference PostSecondaryInstitutionReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TpdmSchoolExtension {\n");
            sb.Append("  PostSecondaryInstitutionReference: ").Append(PostSecondaryInstitutionReference).Append("\n");
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
            return this.Equals(input as TpdmSchoolExtension);
        }

        /// <summary>
        /// Returns true if TpdmSchoolExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmSchoolExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmSchoolExtension input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PostSecondaryInstitutionReference == input.PostSecondaryInstitutionReference ||
                    (this.PostSecondaryInstitutionReference != null &&
                    this.PostSecondaryInstitutionReference.Equals(input.PostSecondaryInstitutionReference))
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
                if (this.PostSecondaryInstitutionReference != null)
                {
                    hashCode = (hashCode * 59) + this.PostSecondaryInstitutionReference.GetHashCode();
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
            yield break;
        }
    }

}
