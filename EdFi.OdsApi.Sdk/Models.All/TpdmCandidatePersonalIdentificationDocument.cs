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
    /// TpdmCandidatePersonalIdentificationDocument
    /// </summary>
    [DataContract(Name = "tpdm_candidatePersonalIdentificationDocument")]
    public partial class TpdmCandidatePersonalIdentificationDocument : IEquatable<TpdmCandidatePersonalIdentificationDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCandidatePersonalIdentificationDocument" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmCandidatePersonalIdentificationDocument() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCandidatePersonalIdentificationDocument" /> class.
        /// </summary>
        /// <param name="identificationDocumentUseDescriptor">The primary function of the document used for establishing identity. (required).</param>
        /// <param name="personalInformationVerificationDescriptor">The category of the document relative to its purpose. (required).</param>
        /// <param name="issuerCountryDescriptor">Country of origin of the document. It is strongly recommended that entries use only ISO 3166 2-letter country codes..</param>
        /// <param name="documentExpirationDate">The day when the document  expires, if null then never expires..</param>
        /// <param name="documentTitle">The title of the document given by the issuer..</param>
        /// <param name="issuerDocumentIdentificationCode">The unique identifier on the issuer&#39;s identification system..</param>
        /// <param name="issuerName">Name of the entity or institution that issued the document..</param>
        public TpdmCandidatePersonalIdentificationDocument(string identificationDocumentUseDescriptor = default, string personalInformationVerificationDescriptor = default, string issuerCountryDescriptor = default, DateTime? documentExpirationDate = default, string documentTitle = default, string issuerDocumentIdentificationCode = default, string issuerName = default)
        {
            IdentificationDocumentUseDescriptor = identificationDocumentUseDescriptor ?? throw new ArgumentNullException("identificationDocumentUseDescriptor is a required property for TpdmCandidatePersonalIdentificationDocument and cannot be null");
            PersonalInformationVerificationDescriptor = personalInformationVerificationDescriptor ?? throw new ArgumentNullException("personalInformationVerificationDescriptor is a required property for TpdmCandidatePersonalIdentificationDocument and cannot be null");
            IssuerCountryDescriptor = issuerCountryDescriptor;
            DocumentExpirationDate = documentExpirationDate;
            DocumentTitle = documentTitle;
            IssuerDocumentIdentificationCode = issuerDocumentIdentificationCode;
            IssuerName = issuerName;
        }

        /// <summary>
        /// The primary function of the document used for establishing identity.
        /// </summary>
        /// <value>The primary function of the document used for establishing identity.</value>
        [DataMember(Name = "identificationDocumentUseDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string IdentificationDocumentUseDescriptor { get; set; }

        /// <summary>
        /// The category of the document relative to its purpose.
        /// </summary>
        /// <value>The category of the document relative to its purpose.</value>
        [DataMember(Name = "personalInformationVerificationDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string PersonalInformationVerificationDescriptor { get; set; }

        /// <summary>
        /// Country of origin of the document. It is strongly recommended that entries use only ISO 3166 2-letter country codes.
        /// </summary>
        /// <value>Country of origin of the document. It is strongly recommended that entries use only ISO 3166 2-letter country codes.</value>
        [DataMember(Name = "issuerCountryDescriptor", EmitDefaultValue = true)]
        public string IssuerCountryDescriptor { get; set; }

        /// <summary>
        /// The day when the document  expires, if null then never expires.
        /// </summary>
        /// <value>The day when the document  expires, if null then never expires.</value>
        [DataMember(Name = "documentExpirationDate", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? DocumentExpirationDate { get; set; }

        /// <summary>
        /// The title of the document given by the issuer.
        /// </summary>
        /// <value>The title of the document given by the issuer.</value>
        [DataMember(Name = "documentTitle", EmitDefaultValue = true)]
        public string DocumentTitle { get; set; }

        /// <summary>
        /// The unique identifier on the issuer&#39;s identification system.
        /// </summary>
        /// <value>The unique identifier on the issuer&#39;s identification system.</value>
        [DataMember(Name = "issuerDocumentIdentificationCode", EmitDefaultValue = true)]
        public string IssuerDocumentIdentificationCode { get; set; }

        /// <summary>
        /// Name of the entity or institution that issued the document.
        /// </summary>
        /// <value>Name of the entity or institution that issued the document.</value>
        [DataMember(Name = "issuerName", EmitDefaultValue = true)]
        public string IssuerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            _ = sb.Append("class TpdmCandidatePersonalIdentificationDocument {\n");
            _ = sb.Append("  IdentificationDocumentUseDescriptor: ").Append(IdentificationDocumentUseDescriptor).Append("\n");
            _ = sb.Append("  PersonalInformationVerificationDescriptor: ").Append(PersonalInformationVerificationDescriptor).Append("\n");
            _ = sb.Append("  IssuerCountryDescriptor: ").Append(IssuerCountryDescriptor).Append("\n");
            _ = sb.Append("  DocumentExpirationDate: ").Append(DocumentExpirationDate).Append("\n");
            _ = sb.Append("  DocumentTitle: ").Append(DocumentTitle).Append("\n");
            _ = sb.Append("  IssuerDocumentIdentificationCode: ").Append(IssuerDocumentIdentificationCode).Append("\n");
            _ = sb.Append("  IssuerName: ").Append(IssuerName).Append("\n");
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
            return Equals(input as TpdmCandidatePersonalIdentificationDocument);
        }

        /// <summary>
        /// Returns true if TpdmCandidatePersonalIdentificationDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmCandidatePersonalIdentificationDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmCandidatePersonalIdentificationDocument input)
        {
            return input != null
&& (
                    IdentificationDocumentUseDescriptor == input.IdentificationDocumentUseDescriptor ||
                    (IdentificationDocumentUseDescriptor != null &&
                    IdentificationDocumentUseDescriptor.Equals(input.IdentificationDocumentUseDescriptor))
                ) &&
                (
                    PersonalInformationVerificationDescriptor == input.PersonalInformationVerificationDescriptor ||
                    (PersonalInformationVerificationDescriptor != null &&
                    PersonalInformationVerificationDescriptor.Equals(input.PersonalInformationVerificationDescriptor))
                ) &&
                (
                    IssuerCountryDescriptor == input.IssuerCountryDescriptor ||
                    (IssuerCountryDescriptor != null &&
                    IssuerCountryDescriptor.Equals(input.IssuerCountryDescriptor))
                ) &&
                (
                    DocumentExpirationDate == input.DocumentExpirationDate ||
                    (DocumentExpirationDate != null &&
                    DocumentExpirationDate.Equals(input.DocumentExpirationDate))
                ) &&
                (
                    DocumentTitle == input.DocumentTitle ||
                    (DocumentTitle != null &&
                    DocumentTitle.Equals(input.DocumentTitle))
                ) &&
                (
                    IssuerDocumentIdentificationCode == input.IssuerDocumentIdentificationCode ||
                    (IssuerDocumentIdentificationCode != null &&
                    IssuerDocumentIdentificationCode.Equals(input.IssuerDocumentIdentificationCode))
                ) &&
                (
                    IssuerName == input.IssuerName ||
                    (IssuerName != null &&
                    IssuerName.Equals(input.IssuerName))
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
                if (IdentificationDocumentUseDescriptor != null)
                {
                    hashCode = (hashCode * 59) + IdentificationDocumentUseDescriptor.GetHashCode();
                }
                if (PersonalInformationVerificationDescriptor != null)
                {
                    hashCode = (hashCode * 59) + PersonalInformationVerificationDescriptor.GetHashCode();
                }
                if (IssuerCountryDescriptor != null)
                {
                    hashCode = (hashCode * 59) + IssuerCountryDescriptor.GetHashCode();
                }
                if (DocumentExpirationDate != null)
                {
                    hashCode = (hashCode * 59) + DocumentExpirationDate.GetHashCode();
                }
                if (DocumentTitle != null)
                {
                    hashCode = (hashCode * 59) + DocumentTitle.GetHashCode();
                }
                if (IssuerDocumentIdentificationCode != null)
                {
                    hashCode = (hashCode * 59) + IssuerDocumentIdentificationCode.GetHashCode();
                }
                if (IssuerName != null)
                {
                    hashCode = (hashCode * 59) + IssuerName.GetHashCode();
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
            // IdentificationDocumentUseDescriptor (string) maxLength
            if (IdentificationDocumentUseDescriptor != null && IdentificationDocumentUseDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdentificationDocumentUseDescriptor, length must be less than 306.", new[] { "IdentificationDocumentUseDescriptor" });
            }

            // PersonalInformationVerificationDescriptor (string) maxLength
            if (PersonalInformationVerificationDescriptor != null && PersonalInformationVerificationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PersonalInformationVerificationDescriptor, length must be less than 306.", new[] { "PersonalInformationVerificationDescriptor" });
            }

            // IssuerCountryDescriptor (string) maxLength
            if (IssuerCountryDescriptor != null && IssuerCountryDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssuerCountryDescriptor, length must be less than 306.", new[] { "IssuerCountryDescriptor" });
            }

            // DocumentTitle (string) maxLength
            if (DocumentTitle != null && DocumentTitle.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocumentTitle, length must be less than 60.", new[] { "DocumentTitle" });
            }

            // IssuerDocumentIdentificationCode (string) maxLength
            if (IssuerDocumentIdentificationCode != null && IssuerDocumentIdentificationCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssuerDocumentIdentificationCode, length must be less than 60.", new[] { "IssuerDocumentIdentificationCode" });
            }

            // IssuerName (string) maxLength
            if (IssuerName != null && IssuerName.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssuerName, length must be less than 150.", new[] { "IssuerName" });
            }

            yield break;
        }
    }

}
