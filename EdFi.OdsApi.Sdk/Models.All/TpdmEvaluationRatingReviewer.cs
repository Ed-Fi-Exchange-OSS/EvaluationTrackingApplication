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

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// TpdmEvaluationRatingReviewer
    /// </summary>
    [DataContract(Name = "tpdm_evaluationRatingReviewer")]
    public partial class TpdmEvaluationRatingReviewer : IEquatable<TpdmEvaluationRatingReviewer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationRatingReviewer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmEvaluationRatingReviewer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationRatingReviewer" /> class.
        /// </summary>
        /// <param name="firstName">A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. (required).</param>
        /// <param name="lastSurname">The name borne in common by members of a family. (required).</param>
        /// <param name="reviewerPersonReference">reviewerPersonReference.</param>
        /// <param name="receivedTraining">receivedTraining.</param>
        public TpdmEvaluationRatingReviewer(string firstName = default, string lastSurname = default, EdFiPersonReference reviewerPersonReference = default, TpdmEvaluationRatingReviewerReceivedTraining receivedTraining = default)
        {
            FirstName = firstName ?? throw new ArgumentNullException("firstName is a required property for TpdmEvaluationRatingReviewer and cannot be null");
            LastSurname = lastSurname ?? throw new ArgumentNullException("lastSurname is a required property for TpdmEvaluationRatingReviewer and cannot be null");
            ReviewerPersonReference = reviewerPersonReference;
            ReceivedTraining = receivedTraining;
        }

        /// <summary>
        /// A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.
        /// </summary>
        /// <value>A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.</value>
        [DataMember(Name = "firstName", IsRequired = true, EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The name borne in common by members of a family.
        /// </summary>
        /// <value>The name borne in common by members of a family.</value>
        [DataMember(Name = "lastSurname", IsRequired = true, EmitDefaultValue = false)]
        public string LastSurname { get; set; }

        /// <summary>
        /// Gets or Sets ReviewerPersonReference
        /// </summary>
        [DataMember(Name = "reviewerPersonReference", EmitDefaultValue = false)]
        public EdFiPersonReference ReviewerPersonReference { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedTraining
        /// </summary>
        [DataMember(Name = "receivedTraining", EmitDefaultValue = false)]
        public TpdmEvaluationRatingReviewerReceivedTraining ReceivedTraining { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            _ = sb.Append("class TpdmEvaluationRatingReviewer {\n");
            _ = sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            _ = sb.Append("  LastSurname: ").Append(LastSurname).Append("\n");
            _ = sb.Append("  ReviewerPersonReference: ").Append(ReviewerPersonReference).Append("\n");
            _ = sb.Append("  ReceivedTraining: ").Append(ReceivedTraining).Append("\n");
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
            return Equals(input as TpdmEvaluationRatingReviewer);
        }

        /// <summary>
        /// Returns true if TpdmEvaluationRatingReviewer instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmEvaluationRatingReviewer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmEvaluationRatingReviewer input)
        {
            return input != null
&& (
                    FirstName == input.FirstName ||
                    (FirstName != null &&
                    FirstName.Equals(input.FirstName))
                ) &&
                (
                    LastSurname == input.LastSurname ||
                    (LastSurname != null &&
                    LastSurname.Equals(input.LastSurname))
                ) &&
                (
                    ReviewerPersonReference == input.ReviewerPersonReference ||
                    (ReviewerPersonReference != null &&
                    ReviewerPersonReference.Equals(input.ReviewerPersonReference))
                ) &&
                (
                    ReceivedTraining == input.ReceivedTraining ||
                    (ReceivedTraining != null &&
                    ReceivedTraining.Equals(input.ReceivedTraining))
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
                if (FirstName != null)
                {
                    hashCode = (hashCode * 59) + FirstName.GetHashCode();
                }
                if (LastSurname != null)
                {
                    hashCode = (hashCode * 59) + LastSurname.GetHashCode();
                }
                if (ReviewerPersonReference != null)
                {
                    hashCode = (hashCode * 59) + ReviewerPersonReference.GetHashCode();
                }
                if (ReceivedTraining != null)
                {
                    hashCode = (hashCode * 59) + ReceivedTraining.GetHashCode();
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
            // FirstName (string) maxLength
            if (FirstName != null && FirstName.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 75.", new[] { "FirstName" });
            }

            // LastSurname (string) maxLength
            if (LastSurname != null && LastSurname.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastSurname, length must be less than 75.", new[] { "LastSurname" });
            }

            yield break;
        }
    }

}
