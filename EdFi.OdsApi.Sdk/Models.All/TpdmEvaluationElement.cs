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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// TpdmEvaluationElement
    /// </summary>
    [DataContract(Name = "tpdm_evaluationElement")]
    public partial class TpdmEvaluationElement : IEquatable<TpdmEvaluationElement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmEvaluationElement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmEvaluationElement" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="evaluationElementTitle">The name or title of the evaluation element. (required).</param>
        /// <param name="evaluationObjectiveReference">evaluationObjectiveReference (required).</param>
        /// <param name="evaluationTypeDescriptor">The type of the evaluation (e.g., observation, principal, peer, student survey, student growth)..</param>
        /// <param name="maxRating">The maximum summary numerical rating or score for the evaluation element..</param>
        /// <param name="minRating">The minimum summary numerical rating or score for the evaluation element. If omitted, assumed to be 0.0..</param>
        /// <param name="ratingLevels">An unordered collection of evaluationElementRatingLevels. The descriptive level(s) of ratings (cut scores) for evaluation element..</param>
        /// <param name="sortOrder">The sort order of this Evaluation Element..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmEvaluationElement(string id = default, string evaluationElementTitle = default, TpdmEvaluationObjectiveReference evaluationObjectiveReference = default, string evaluationTypeDescriptor = default, double? maxRating = default, double? minRating = default, List<TpdmEvaluationElementRatingLevel> ratingLevels = default, int? sortOrder = default, string etag = default)
        {
            EvaluationElementTitle = evaluationElementTitle ?? throw new ArgumentNullException("evaluationElementTitle is a required property for TpdmEvaluationElement and cannot be null");
            EvaluationObjectiveReference = evaluationObjectiveReference ?? throw new ArgumentNullException("evaluationObjectiveReference is a required property for TpdmEvaluationElement and cannot be null");
            Id = id;
            EvaluationTypeDescriptor = evaluationTypeDescriptor;
            MaxRating = maxRating;
            MinRating = minRating;
            RatingLevels = ratingLevels;
            SortOrder = sortOrder;
            Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The name or title of the evaluation element.
        /// </summary>
        /// <value>The name or title of the evaluation element.</value>
        [DataMember(Name = "evaluationElementTitle", IsRequired = true, EmitDefaultValue = false)]
        public string EvaluationElementTitle { get; set; }

        /// <summary>
        /// Gets or Sets EvaluationObjectiveReference
        /// </summary>
        [DataMember(Name = "evaluationObjectiveReference", IsRequired = true, EmitDefaultValue = false)]
        public TpdmEvaluationObjectiveReference EvaluationObjectiveReference { get; set; }

        /// <summary>
        /// The type of the evaluation (e.g., observation, principal, peer, student survey, student growth).
        /// </summary>
        /// <value>The type of the evaluation (e.g., observation, principal, peer, student survey, student growth).</value>
        [DataMember(Name = "evaluationTypeDescriptor", EmitDefaultValue = true)]
        public string EvaluationTypeDescriptor { get; set; }

        /// <summary>
        /// The maximum summary numerical rating or score for the evaluation element.
        /// </summary>
        /// <value>The maximum summary numerical rating or score for the evaluation element.</value>
        [DataMember(Name = "maxRating", EmitDefaultValue = true)]
        public double? MaxRating { get; set; }

        /// <summary>
        /// The minimum summary numerical rating or score for the evaluation element. If omitted, assumed to be 0.0.
        /// </summary>
        /// <value>The minimum summary numerical rating or score for the evaluation element. If omitted, assumed to be 0.0.</value>
        [DataMember(Name = "minRating", EmitDefaultValue = true)]
        public double? MinRating { get; set; }

        /// <summary>
        /// An unordered collection of evaluationElementRatingLevels. The descriptive level(s) of ratings (cut scores) for evaluation element.
        /// </summary>
        /// <value>An unordered collection of evaluationElementRatingLevels. The descriptive level(s) of ratings (cut scores) for evaluation element.</value>
        [DataMember(Name = "ratingLevels", EmitDefaultValue = false)]
        public List<TpdmEvaluationElementRatingLevel> RatingLevels { get; set; }

        /// <summary>
        /// The sort order of this Evaluation Element.
        /// </summary>
        /// <value>The sort order of this Evaluation Element.</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = true)]
        public int? SortOrder { get; set; }

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
            _ = sb.Append("class TpdmEvaluationElement {\n");
            _ = sb.Append("  Id: ").Append(Id).Append("\n");
            _ = sb.Append("  EvaluationElementTitle: ").Append(EvaluationElementTitle).Append("\n");
            _ = sb.Append("  EvaluationObjectiveReference: ").Append(EvaluationObjectiveReference).Append("\n");
            _ = sb.Append("  EvaluationTypeDescriptor: ").Append(EvaluationTypeDescriptor).Append("\n");
            _ = sb.Append("  MaxRating: ").Append(MaxRating).Append("\n");
            _ = sb.Append("  MinRating: ").Append(MinRating).Append("\n");
            _ = sb.Append("  RatingLevels: ").Append(RatingLevels).Append("\n");
            _ = sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return Equals(input as TpdmEvaluationElement);
        }

        /// <summary>
        /// Returns true if TpdmEvaluationElement instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmEvaluationElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmEvaluationElement input)
        {
            return input != null
&& (
                    Id == input.Id ||
                    (Id != null &&
                    Id.Equals(input.Id))
                ) &&
                (
                    EvaluationElementTitle == input.EvaluationElementTitle ||
                    (EvaluationElementTitle != null &&
                    EvaluationElementTitle.Equals(input.EvaluationElementTitle))
                ) &&
                (
                    EvaluationObjectiveReference == input.EvaluationObjectiveReference ||
                    (EvaluationObjectiveReference != null &&
                    EvaluationObjectiveReference.Equals(input.EvaluationObjectiveReference))
                ) &&
                (
                    EvaluationTypeDescriptor == input.EvaluationTypeDescriptor ||
                    (EvaluationTypeDescriptor != null &&
                    EvaluationTypeDescriptor.Equals(input.EvaluationTypeDescriptor))
                ) &&
                (
                    MaxRating == input.MaxRating ||
                    (MaxRating != null &&
                    MaxRating.Equals(input.MaxRating))
                ) &&
                (
                    MinRating == input.MinRating ||
                    (MinRating != null &&
                    MinRating.Equals(input.MinRating))
                ) &&
                (
                    RatingLevels == input.RatingLevels ||
                    RatingLevels != null &&
                    input.RatingLevels != null &&
                    RatingLevels.SequenceEqual(input.RatingLevels)
                ) &&
                (
                    SortOrder == input.SortOrder ||
                    (SortOrder != null &&
                    SortOrder.Equals(input.SortOrder))
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
                if (EvaluationElementTitle != null)
                {
                    hashCode = (hashCode * 59) + EvaluationElementTitle.GetHashCode();
                }
                if (EvaluationObjectiveReference != null)
                {
                    hashCode = (hashCode * 59) + EvaluationObjectiveReference.GetHashCode();
                }
                if (EvaluationTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + EvaluationTypeDescriptor.GetHashCode();
                }
                if (MaxRating != null)
                {
                    hashCode = (hashCode * 59) + MaxRating.GetHashCode();
                }
                if (MinRating != null)
                {
                    hashCode = (hashCode * 59) + MinRating.GetHashCode();
                }
                if (RatingLevels != null)
                {
                    hashCode = (hashCode * 59) + RatingLevels.GetHashCode();
                }
                if (SortOrder != null)
                {
                    hashCode = (hashCode * 59) + SortOrder.GetHashCode();
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
            // EvaluationElementTitle (string) maxLength
            if (EvaluationElementTitle != null && EvaluationElementTitle.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationElementTitle, length must be less than 255.", new[] { "EvaluationElementTitle" });
            }

            // EvaluationTypeDescriptor (string) maxLength
            if (EvaluationTypeDescriptor != null && EvaluationTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EvaluationTypeDescriptor, length must be less than 306.", new[] { "EvaluationTypeDescriptor" });
            }

            yield break;
        }
    }

}
