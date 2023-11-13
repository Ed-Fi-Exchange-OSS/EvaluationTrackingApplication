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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// EdFiStudent
    /// </summary>
    [DataContract(Name = "edFi_student")]
    public partial class EdFiStudent : IEquatable<EdFiStudent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student. (required).</param>
        /// <param name="personReference">personReference.</param>
        /// <param name="birthCity">The city the student was born in..</param>
        /// <param name="birthCountryDescriptor">The country in which an individual is born. It is strongly recommended that entries use only ISO 3166 2-letter country codes..</param>
        /// <param name="birthDate">The month, day, and year on which an individual was born. (required).</param>
        /// <param name="birthInternationalProvince">For students born outside of the U.S., the Province or jurisdiction in which an individual is born..</param>
        /// <param name="birthSexDescriptor">A person&#39;s gender at birth..</param>
        /// <param name="birthStateAbbreviationDescriptor">The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which an individual was born..</param>
        /// <param name="citizenshipStatusDescriptor">An indicator of whether or not the person is a U.S. citizen..</param>
        /// <param name="dateEnteredUS">For students born outside of the U.S., the date the student entered the U.S..</param>
        /// <param name="firstName">A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change. (required).</param>
        /// <param name="generationCodeSuffix">An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III)..</param>
        /// <param name="identificationDocuments">An unordered collection of studentIdentificationDocuments. Describe the documentation of citizenship..</param>
        /// <param name="lastSurname">The name borne in common by members of a family. (required).</param>
        /// <param name="maidenName">The individual&#39;s maiden name..</param>
        /// <param name="middleName">A secondary name given to an individual at birth, baptism, or during another naming ceremony..</param>
        /// <param name="multipleBirthStatus">Indicator of whether the student was born with other siblings (i.e., twins, triplets, etc.).</param>
        /// <param name="otherNames">An unordered collection of studentOtherNames. Other names (e.g., alias, nickname, previous legal name) associated with a person..</param>
        /// <param name="personalIdentificationDocuments">An unordered collection of studentPersonalIdentificationDocuments. The documents presented as evident to verify one&#39;s personal identity; for example: drivers license, passport, birth certificate, etc..</param>
        /// <param name="personalTitlePrefix">A prefix used to denote the title, degree, position, or seniority of the individual..</param>
        /// <param name="visas">An unordered collection of studentVisas. An indicator of a non-US citizen&#39;s Visa type..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public EdFiStudent(string id = default(string), string studentUniqueId = default(string), EdFiPersonReference personReference = default(EdFiPersonReference), string birthCity = default(string), string birthCountryDescriptor = default(string), DateTime birthDate = default(DateTime), string birthInternationalProvince = default(string), string birthSexDescriptor = default(string), string birthStateAbbreviationDescriptor = default(string), string citizenshipStatusDescriptor = default(string), DateTime? dateEnteredUS = default(DateTime?), string firstName = default(string), string generationCodeSuffix = default(string), List<EdFiStudentIdentificationDocument> identificationDocuments = default(List<EdFiStudentIdentificationDocument>), string lastSurname = default(string), string maidenName = default(string), string middleName = default(string), bool? multipleBirthStatus = default(bool?), List<EdFiStudentOtherName> otherNames = default(List<EdFiStudentOtherName>), List<EdFiStudentPersonalIdentificationDocument> personalIdentificationDocuments = default(List<EdFiStudentPersonalIdentificationDocument>), string personalTitlePrefix = default(string), List<EdFiStudentVisa> visas = default(List<EdFiStudentVisa>), string etag = default(string))
        {
            // to ensure "studentUniqueId" is required (not null)
            if (studentUniqueId == null)
            {
                throw new ArgumentNullException("studentUniqueId is a required property for EdFiStudent and cannot be null");
            }
            this.StudentUniqueId = studentUniqueId;
            this.BirthDate = birthDate;
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName is a required property for EdFiStudent and cannot be null");
            }
            this.FirstName = firstName;
            // to ensure "lastSurname" is required (not null)
            if (lastSurname == null)
            {
                throw new ArgumentNullException("lastSurname is a required property for EdFiStudent and cannot be null");
            }
            this.LastSurname = lastSurname;
            this.Id = id;
            this.PersonReference = personReference;
            this.BirthCity = birthCity;
            this.BirthCountryDescriptor = birthCountryDescriptor;
            this.BirthInternationalProvince = birthInternationalProvince;
            this.BirthSexDescriptor = birthSexDescriptor;
            this.BirthStateAbbreviationDescriptor = birthStateAbbreviationDescriptor;
            this.CitizenshipStatusDescriptor = citizenshipStatusDescriptor;
            this.DateEnteredUS = dateEnteredUS;
            this.GenerationCodeSuffix = generationCodeSuffix;
            this.IdentificationDocuments = identificationDocuments;
            this.MaidenName = maidenName;
            this.MiddleName = middleName;
            this.MultipleBirthStatus = multipleBirthStatus;
            this.OtherNames = otherNames;
            this.PersonalIdentificationDocuments = personalIdentificationDocuments;
            this.PersonalTitlePrefix = personalTitlePrefix;
            this.Visas = visas;
            this.Etag = etag;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name = "studentUniqueId", IsRequired = true, EmitDefaultValue = false)]
        public string StudentUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets PersonReference
        /// </summary>
        [DataMember(Name = "personReference", EmitDefaultValue = false)]
        public EdFiPersonReference PersonReference { get; set; }

        /// <summary>
        /// The city the student was born in.
        /// </summary>
        /// <value>The city the student was born in.</value>
        [DataMember(Name = "birthCity", EmitDefaultValue = true)]
        public string BirthCity { get; set; }

        /// <summary>
        /// The country in which an individual is born. It is strongly recommended that entries use only ISO 3166 2-letter country codes.
        /// </summary>
        /// <value>The country in which an individual is born. It is strongly recommended that entries use only ISO 3166 2-letter country codes.</value>
        [DataMember(Name = "birthCountryDescriptor", EmitDefaultValue = true)]
        public string BirthCountryDescriptor { get; set; }

        /// <summary>
        /// The month, day, and year on which an individual was born.
        /// </summary>
        /// <value>The month, day, and year on which an individual was born.</value>
        [DataMember(Name = "birthDate", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// For students born outside of the U.S., the Province or jurisdiction in which an individual is born.
        /// </summary>
        /// <value>For students born outside of the U.S., the Province or jurisdiction in which an individual is born.</value>
        [DataMember(Name = "birthInternationalProvince", EmitDefaultValue = true)]
        public string BirthInternationalProvince { get; set; }

        /// <summary>
        /// A person&#39;s gender at birth.
        /// </summary>
        /// <value>A person&#39;s gender at birth.</value>
        [DataMember(Name = "birthSexDescriptor", EmitDefaultValue = true)]
        public string BirthSexDescriptor { get; set; }

        /// <summary>
        /// The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which an individual was born.
        /// </summary>
        /// <value>The abbreviation for the name of the state (within the United States) or extra-state jurisdiction in which an individual was born.</value>
        [DataMember(Name = "birthStateAbbreviationDescriptor", EmitDefaultValue = true)]
        public string BirthStateAbbreviationDescriptor { get; set; }

        /// <summary>
        /// An indicator of whether or not the person is a U.S. citizen.
        /// </summary>
        /// <value>An indicator of whether or not the person is a U.S. citizen.</value>
        [DataMember(Name = "citizenshipStatusDescriptor", EmitDefaultValue = true)]
        public string CitizenshipStatusDescriptor { get; set; }

        /// <summary>
        /// For students born outside of the U.S., the date the student entered the U.S.
        /// </summary>
        /// <value>For students born outside of the U.S., the date the student entered the U.S.</value>
        [DataMember(Name = "dateEnteredUS", EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? DateEnteredUS { get; set; }

        /// <summary>
        /// A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.
        /// </summary>
        /// <value>A name given to an individual at birth, baptism, or during another naming ceremony, or through legal change.</value>
        [DataMember(Name = "firstName", IsRequired = true, EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III).
        /// </summary>
        /// <value>An appendage, if any, used to denote an individual&#39;s generation in his family (e.g., Jr., Sr., III).</value>
        [DataMember(Name = "generationCodeSuffix", EmitDefaultValue = true)]
        public string GenerationCodeSuffix { get; set; }

        /// <summary>
        /// An unordered collection of studentIdentificationDocuments. Describe the documentation of citizenship.
        /// </summary>
        /// <value>An unordered collection of studentIdentificationDocuments. Describe the documentation of citizenship.</value>
        [DataMember(Name = "identificationDocuments", EmitDefaultValue = false)]
        public List<EdFiStudentIdentificationDocument> IdentificationDocuments { get; set; }

        /// <summary>
        /// The name borne in common by members of a family.
        /// </summary>
        /// <value>The name borne in common by members of a family.</value>
        [DataMember(Name = "lastSurname", IsRequired = true, EmitDefaultValue = false)]
        public string LastSurname { get; set; }

        /// <summary>
        /// The individual&#39;s maiden name.
        /// </summary>
        /// <value>The individual&#39;s maiden name.</value>
        [DataMember(Name = "maidenName", EmitDefaultValue = true)]
        public string MaidenName { get; set; }

        /// <summary>
        /// A secondary name given to an individual at birth, baptism, or during another naming ceremony.
        /// </summary>
        /// <value>A secondary name given to an individual at birth, baptism, or during another naming ceremony.</value>
        [DataMember(Name = "middleName", EmitDefaultValue = true)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Indicator of whether the student was born with other siblings (i.e., twins, triplets, etc.)
        /// </summary>
        /// <value>Indicator of whether the student was born with other siblings (i.e., twins, triplets, etc.)</value>
        [DataMember(Name = "multipleBirthStatus", EmitDefaultValue = true)]
        public bool? MultipleBirthStatus { get; set; }

        /// <summary>
        /// An unordered collection of studentOtherNames. Other names (e.g., alias, nickname, previous legal name) associated with a person.
        /// </summary>
        /// <value>An unordered collection of studentOtherNames. Other names (e.g., alias, nickname, previous legal name) associated with a person.</value>
        [DataMember(Name = "otherNames", EmitDefaultValue = false)]
        public List<EdFiStudentOtherName> OtherNames { get; set; }

        /// <summary>
        /// An unordered collection of studentPersonalIdentificationDocuments. The documents presented as evident to verify one&#39;s personal identity; for example: drivers license, passport, birth certificate, etc.
        /// </summary>
        /// <value>An unordered collection of studentPersonalIdentificationDocuments. The documents presented as evident to verify one&#39;s personal identity; for example: drivers license, passport, birth certificate, etc.</value>
        [DataMember(Name = "personalIdentificationDocuments", EmitDefaultValue = false)]
        public List<EdFiStudentPersonalIdentificationDocument> PersonalIdentificationDocuments { get; set; }

        /// <summary>
        /// A prefix used to denote the title, degree, position, or seniority of the individual.
        /// </summary>
        /// <value>A prefix used to denote the title, degree, position, or seniority of the individual.</value>
        [DataMember(Name = "personalTitlePrefix", EmitDefaultValue = true)]
        public string PersonalTitlePrefix { get; set; }

        /// <summary>
        /// An unordered collection of studentVisas. An indicator of a non-US citizen&#39;s Visa type.
        /// </summary>
        /// <value>An unordered collection of studentVisas. An indicator of a non-US citizen&#39;s Visa type.</value>
        [DataMember(Name = "visas", EmitDefaultValue = false)]
        public List<EdFiStudentVisa> Visas { get; set; }

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
            sb.Append("class EdFiStudent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
            sb.Append("  PersonReference: ").Append(PersonReference).Append("\n");
            sb.Append("  BirthCity: ").Append(BirthCity).Append("\n");
            sb.Append("  BirthCountryDescriptor: ").Append(BirthCountryDescriptor).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  BirthInternationalProvince: ").Append(BirthInternationalProvince).Append("\n");
            sb.Append("  BirthSexDescriptor: ").Append(BirthSexDescriptor).Append("\n");
            sb.Append("  BirthStateAbbreviationDescriptor: ").Append(BirthStateAbbreviationDescriptor).Append("\n");
            sb.Append("  CitizenshipStatusDescriptor: ").Append(CitizenshipStatusDescriptor).Append("\n");
            sb.Append("  DateEnteredUS: ").Append(DateEnteredUS).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  GenerationCodeSuffix: ").Append(GenerationCodeSuffix).Append("\n");
            sb.Append("  IdentificationDocuments: ").Append(IdentificationDocuments).Append("\n");
            sb.Append("  LastSurname: ").Append(LastSurname).Append("\n");
            sb.Append("  MaidenName: ").Append(MaidenName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  MultipleBirthStatus: ").Append(MultipleBirthStatus).Append("\n");
            sb.Append("  OtherNames: ").Append(OtherNames).Append("\n");
            sb.Append("  PersonalIdentificationDocuments: ").Append(PersonalIdentificationDocuments).Append("\n");
            sb.Append("  PersonalTitlePrefix: ").Append(PersonalTitlePrefix).Append("\n");
            sb.Append("  Visas: ").Append(Visas).Append("\n");
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
            return this.Equals(input as EdFiStudent);
        }

        /// <summary>
        /// Returns true if EdFiStudent instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudent input)
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
                    this.StudentUniqueId == input.StudentUniqueId ||
                    (this.StudentUniqueId != null &&
                    this.StudentUniqueId.Equals(input.StudentUniqueId))
                ) &&
                (
                    this.PersonReference == input.PersonReference ||
                    (this.PersonReference != null &&
                    this.PersonReference.Equals(input.PersonReference))
                ) &&
                (
                    this.BirthCity == input.BirthCity ||
                    (this.BirthCity != null &&
                    this.BirthCity.Equals(input.BirthCity))
                ) &&
                (
                    this.BirthCountryDescriptor == input.BirthCountryDescriptor ||
                    (this.BirthCountryDescriptor != null &&
                    this.BirthCountryDescriptor.Equals(input.BirthCountryDescriptor))
                ) &&
                (
                    this.BirthDate == input.BirthDate ||
                    this.BirthDate.Equals(input.BirthDate)
                ) &&
                (
                    this.BirthInternationalProvince == input.BirthInternationalProvince ||
                    (this.BirthInternationalProvince != null &&
                    this.BirthInternationalProvince.Equals(input.BirthInternationalProvince))
                ) &&
                (
                    this.BirthSexDescriptor == input.BirthSexDescriptor ||
                    (this.BirthSexDescriptor != null &&
                    this.BirthSexDescriptor.Equals(input.BirthSexDescriptor))
                ) &&
                (
                    this.BirthStateAbbreviationDescriptor == input.BirthStateAbbreviationDescriptor ||
                    (this.BirthStateAbbreviationDescriptor != null &&
                    this.BirthStateAbbreviationDescriptor.Equals(input.BirthStateAbbreviationDescriptor))
                ) &&
                (
                    this.CitizenshipStatusDescriptor == input.CitizenshipStatusDescriptor ||
                    (this.CitizenshipStatusDescriptor != null &&
                    this.CitizenshipStatusDescriptor.Equals(input.CitizenshipStatusDescriptor))
                ) &&
                (
                    this.DateEnteredUS == input.DateEnteredUS ||
                    (this.DateEnteredUS != null &&
                    this.DateEnteredUS.Equals(input.DateEnteredUS))
                ) &&
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) &&
                (
                    this.GenerationCodeSuffix == input.GenerationCodeSuffix ||
                    (this.GenerationCodeSuffix != null &&
                    this.GenerationCodeSuffix.Equals(input.GenerationCodeSuffix))
                ) &&
                (
                    this.IdentificationDocuments == input.IdentificationDocuments ||
                    this.IdentificationDocuments != null &&
                    input.IdentificationDocuments != null &&
                    this.IdentificationDocuments.SequenceEqual(input.IdentificationDocuments)
                ) &&
                (
                    this.LastSurname == input.LastSurname ||
                    (this.LastSurname != null &&
                    this.LastSurname.Equals(input.LastSurname))
                ) &&
                (
                    this.MaidenName == input.MaidenName ||
                    (this.MaidenName != null &&
                    this.MaidenName.Equals(input.MaidenName))
                ) &&
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) &&
                (
                    this.MultipleBirthStatus == input.MultipleBirthStatus ||
                    (this.MultipleBirthStatus != null &&
                    this.MultipleBirthStatus.Equals(input.MultipleBirthStatus))
                ) &&
                (
                    this.OtherNames == input.OtherNames ||
                    this.OtherNames != null &&
                    input.OtherNames != null &&
                    this.OtherNames.SequenceEqual(input.OtherNames)
                ) &&
                (
                    this.PersonalIdentificationDocuments == input.PersonalIdentificationDocuments ||
                    this.PersonalIdentificationDocuments != null &&
                    input.PersonalIdentificationDocuments != null &&
                    this.PersonalIdentificationDocuments.SequenceEqual(input.PersonalIdentificationDocuments)
                ) &&
                (
                    this.PersonalTitlePrefix == input.PersonalTitlePrefix ||
                    (this.PersonalTitlePrefix != null &&
                    this.PersonalTitlePrefix.Equals(input.PersonalTitlePrefix))
                ) &&
                (
                    this.Visas == input.Visas ||
                    this.Visas != null &&
                    input.Visas != null &&
                    this.Visas.SequenceEqual(input.Visas)
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
                if (this.StudentUniqueId != null)
                {
                    hashCode = (hashCode * 59) + this.StudentUniqueId.GetHashCode();
                }
                if (this.PersonReference != null)
                {
                    hashCode = (hashCode * 59) + this.PersonReference.GetHashCode();
                }
                if (this.BirthCity != null)
                {
                    hashCode = (hashCode * 59) + this.BirthCity.GetHashCode();
                }
                if (this.BirthCountryDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.BirthCountryDescriptor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BirthDate.GetHashCode();
                if (this.BirthInternationalProvince != null)
                {
                    hashCode = (hashCode * 59) + this.BirthInternationalProvince.GetHashCode();
                }
                if (this.BirthSexDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.BirthSexDescriptor.GetHashCode();
                }
                if (this.BirthStateAbbreviationDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.BirthStateAbbreviationDescriptor.GetHashCode();
                }
                if (this.CitizenshipStatusDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.CitizenshipStatusDescriptor.GetHashCode();
                }
                if (this.DateEnteredUS != null)
                {
                    hashCode = (hashCode * 59) + this.DateEnteredUS.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.GenerationCodeSuffix != null)
                {
                    hashCode = (hashCode * 59) + this.GenerationCodeSuffix.GetHashCode();
                }
                if (this.IdentificationDocuments != null)
                {
                    hashCode = (hashCode * 59) + this.IdentificationDocuments.GetHashCode();
                }
                if (this.LastSurname != null)
                {
                    hashCode = (hashCode * 59) + this.LastSurname.GetHashCode();
                }
                if (this.MaidenName != null)
                {
                    hashCode = (hashCode * 59) + this.MaidenName.GetHashCode();
                }
                if (this.MiddleName != null)
                {
                    hashCode = (hashCode * 59) + this.MiddleName.GetHashCode();
                }
                if (this.MultipleBirthStatus != null)
                {
                    hashCode = (hashCode * 59) + this.MultipleBirthStatus.GetHashCode();
                }
                if (this.OtherNames != null)
                {
                    hashCode = (hashCode * 59) + this.OtherNames.GetHashCode();
                }
                if (this.PersonalIdentificationDocuments != null)
                {
                    hashCode = (hashCode * 59) + this.PersonalIdentificationDocuments.GetHashCode();
                }
                if (this.PersonalTitlePrefix != null)
                {
                    hashCode = (hashCode * 59) + this.PersonalTitlePrefix.GetHashCode();
                }
                if (this.Visas != null)
                {
                    hashCode = (hashCode * 59) + this.Visas.GetHashCode();
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
            // StudentUniqueId (string) maxLength
            if (this.StudentUniqueId != null && this.StudentUniqueId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentUniqueId, length must be less than 32.", new[] { "StudentUniqueId" });
            }

            // BirthCity (string) maxLength
            if (this.BirthCity != null && this.BirthCity.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BirthCity, length must be less than 30.", new[] { "BirthCity" });
            }

            // BirthCountryDescriptor (string) maxLength
            if (this.BirthCountryDescriptor != null && this.BirthCountryDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BirthCountryDescriptor, length must be less than 306.", new[] { "BirthCountryDescriptor" });
            }

            // BirthInternationalProvince (string) maxLength
            if (this.BirthInternationalProvince != null && this.BirthInternationalProvince.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BirthInternationalProvince, length must be less than 150.", new[] { "BirthInternationalProvince" });
            }

            // BirthSexDescriptor (string) maxLength
            if (this.BirthSexDescriptor != null && this.BirthSexDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BirthSexDescriptor, length must be less than 306.", new[] { "BirthSexDescriptor" });
            }

            // BirthStateAbbreviationDescriptor (string) maxLength
            if (this.BirthStateAbbreviationDescriptor != null && this.BirthStateAbbreviationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BirthStateAbbreviationDescriptor, length must be less than 306.", new[] { "BirthStateAbbreviationDescriptor" });
            }

            // CitizenshipStatusDescriptor (string) maxLength
            if (this.CitizenshipStatusDescriptor != null && this.CitizenshipStatusDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CitizenshipStatusDescriptor, length must be less than 306.", new[] { "CitizenshipStatusDescriptor" });
            }

            // FirstName (string) maxLength
            if (this.FirstName != null && this.FirstName.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 75.", new[] { "FirstName" });
            }

            // GenerationCodeSuffix (string) maxLength
            if (this.GenerationCodeSuffix != null && this.GenerationCodeSuffix.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GenerationCodeSuffix, length must be less than 10.", new[] { "GenerationCodeSuffix" });
            }

            // LastSurname (string) maxLength
            if (this.LastSurname != null && this.LastSurname.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastSurname, length must be less than 75.", new[] { "LastSurname" });
            }

            // MaidenName (string) maxLength
            if (this.MaidenName != null && this.MaidenName.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaidenName, length must be less than 75.", new[] { "MaidenName" });
            }

            // MiddleName (string) maxLength
            if (this.MiddleName != null && this.MiddleName.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiddleName, length must be less than 75.", new[] { "MiddleName" });
            }

            // PersonalTitlePrefix (string) maxLength
            if (this.PersonalTitlePrefix != null && this.PersonalTitlePrefix.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PersonalTitlePrefix, length must be less than 30.", new[] { "PersonalTitlePrefix" });
            }

            yield break;
        }
    }

}
