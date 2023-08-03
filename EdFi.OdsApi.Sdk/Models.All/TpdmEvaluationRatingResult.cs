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

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// TpdmEvaluationRatingResult
    /// </summary>
    [DataContract(Name = "tpdm_evaluationRatingResult")]
    public partial class TpdmEvaluationRatingResult : IEquatable<TpdmEvaluationRatingResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationRatingResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmEvaluationRatingResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationRatingResult" /> class.
        /// </summary>
        /// <param name="rating">The numerical summary rating or score for the evaluation. (required).</param>
        /// <param name="ratingResultTitle">The title of Rating Result. (required).</param>
        /// <param name="resultDatatypeTypeDescriptor">The datatype of the result. (required).</param>
        public TpdmEvaluationRatingResult(double rating = default(double), string ratingResultTitle = default(string), string resultDatatypeTypeDescriptor = default(string))
        {
            this.Rating = rating;
            // to ensure "ratingResultTitle" is required (not null)
            if (ratingResultTitle == null)
            {
                throw new ArgumentNullException("ratingResultTitle is a required property for TpdmEvaluationRatingResult and cannot be null");
            }
            this.RatingResultTitle = ratingResultTitle;
            // to ensure "resultDatatypeTypeDescriptor" is required (not null)
            if (resultDatatypeTypeDescriptor == null)
            {
                throw new ArgumentNullException("resultDatatypeTypeDescriptor is a required property for TpdmEvaluationRatingResult and cannot be null");
            }
            this.ResultDatatypeTypeDescriptor = resultDatatypeTypeDescriptor;
        }

        /// <summary>
        /// The numerical summary rating or score for the evaluation.
        /// </summary>
        /// <value>The numerical summary rating or score for the evaluation.</value>
        [DataMember(Name = "rating", IsRequired = true, EmitDefaultValue = false)]
        public double Rating { get; set; }

        /// <summary>
        /// The title of Rating Result.
        /// </summary>
        /// <value>The title of Rating Result.</value>
        [DataMember(Name = "ratingResultTitle", IsRequired = true, EmitDefaultValue = false)]
        public string RatingResultTitle { get; set; }

        /// <summary>
        /// The datatype of the result.
        /// </summary>
        /// <value>The datatype of the result.</value>
        [DataMember(Name = "resultDatatypeTypeDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string ResultDatatypeTypeDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TpdmEvaluationRatingResult {\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  RatingResultTitle: ").Append(RatingResultTitle).Append("\n");
            sb.Append("  ResultDatatypeTypeDescriptor: ").Append(ResultDatatypeTypeDescriptor).Append("\n");
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
            return this.Equals(input as TpdmEvaluationRatingResult);
        }

        /// <summary>
        /// Returns true if TpdmEvaluationRatingResult instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmEvaluationRatingResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmEvaluationRatingResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Rating == input.Rating ||
                    this.Rating.Equals(input.Rating)
                ) && 
                (
                    this.RatingResultTitle == input.RatingResultTitle ||
                    (this.RatingResultTitle != null &&
                    this.RatingResultTitle.Equals(input.RatingResultTitle))
                ) && 
                (
                    this.ResultDatatypeTypeDescriptor == input.ResultDatatypeTypeDescriptor ||
                    (this.ResultDatatypeTypeDescriptor != null &&
                    this.ResultDatatypeTypeDescriptor.Equals(input.ResultDatatypeTypeDescriptor))
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
                hashCode = (hashCode * 59) + this.Rating.GetHashCode();
                if (this.RatingResultTitle != null)
                {
                    hashCode = (hashCode * 59) + this.RatingResultTitle.GetHashCode();
                }
                if (this.ResultDatatypeTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.ResultDatatypeTypeDescriptor.GetHashCode();
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
            // RatingResultTitle (string) maxLength
            if (this.RatingResultTitle != null && this.RatingResultTitle.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RatingResultTitle, length must be less than 50.", new [] { "RatingResultTitle" });
            }

            // ResultDatatypeTypeDescriptor (string) maxLength
            if (this.ResultDatatypeTypeDescriptor != null && this.ResultDatatypeTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultDatatypeTypeDescriptor, length must be less than 306.", new [] { "ResultDatatypeTypeDescriptor" });
            }

            yield break;
        }
    }

}
