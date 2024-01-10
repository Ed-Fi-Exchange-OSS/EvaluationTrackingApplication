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
    /// TpdmCandidateAddress
    /// </summary>
    [DataContract(Name = "tpdm_candidateAddress")]
    public partial class TpdmCandidateAddress : IEquatable<TpdmCandidateAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCandidateAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmCandidateAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCandidateAddress" /> class.
        /// </summary>
        /// <param name="addressTypeDescriptor">The type of address listed for an individual or organization.    For example:  Physical Address, Mailing Address, Home Address, etc.) (required).</param>
        /// <param name="stateAbbreviationDescriptor">The abbreviation for the state (within the United States) or outlying area in which an address is located. (required).</param>
        /// <param name="city">The name of the city in which an address is located. (required).</param>
        /// <param name="postalCode">The five or nine digit zip code or overseas postal code portion of an address. (required).</param>
        /// <param name="streetNumberName">The street number and street name or post office box number of an address. (required).</param>
        /// <param name="localeDescriptor">A general geographic indicator that categorizes U.S. territory (e.g., City, Suburban)..</param>
        /// <param name="apartmentRoomSuiteNumber">The apartment, room, or suite number of an address..</param>
        /// <param name="buildingSiteNumber">The number of the building on the site, if more than one building shares the same address..</param>
        /// <param name="congressionalDistrict">The congressional district in which an address is located..</param>
        /// <param name="countyFIPSCode">The Federal Information Processing Standards (FIPS) numeric code for the county issued by the National Institute of Standards and Technology (NIST). Counties are considered to be the \&quot;first-order subdivisions\&quot; of each State and statistically equivalent entity, regardless of their local designations (county, parish, borough, etc.) Counties in different States will have the same code. A unique county number is created when combined with the 2-digit FIPS State Code..</param>
        /// <param name="doNotPublishIndicator">An indication that the address should not be published..</param>
        /// <param name="latitude">The geographic latitude of the physical address..</param>
        /// <param name="longitude">The geographic longitude of the physical address..</param>
        /// <param name="nameOfCounty">The name of the county, parish, borough, or comparable unit (within a state) in                       &#39;which an address is located..</param>
        /// <param name="periods">An unordered collection of candidateAddressPeriods. The time periods for which the address is valid. For physical addresses, the periods in which the person lived at that address..</param>
        public TpdmCandidateAddress(string addressTypeDescriptor = default, string stateAbbreviationDescriptor = default, string city = default, string postalCode = default, string streetNumberName = default, string localeDescriptor = default, string apartmentRoomSuiteNumber = default, string buildingSiteNumber = default, string congressionalDistrict = default, string countyFIPSCode = default, bool? doNotPublishIndicator = default, string latitude = default, string longitude = default, string nameOfCounty = default, List<TpdmCandidateAddressPeriod> periods = default)
        {
            AddressTypeDescriptor = addressTypeDescriptor ?? throw new ArgumentNullException("addressTypeDescriptor is a required property for TpdmCandidateAddress and cannot be null");
            StateAbbreviationDescriptor = stateAbbreviationDescriptor ?? throw new ArgumentNullException("stateAbbreviationDescriptor is a required property for TpdmCandidateAddress and cannot be null");
            City = city ?? throw new ArgumentNullException("city is a required property for TpdmCandidateAddress and cannot be null");
            PostalCode = postalCode ?? throw new ArgumentNullException("postalCode is a required property for TpdmCandidateAddress and cannot be null");
            StreetNumberName = streetNumberName ?? throw new ArgumentNullException("streetNumberName is a required property for TpdmCandidateAddress and cannot be null");
            LocaleDescriptor = localeDescriptor;
            ApartmentRoomSuiteNumber = apartmentRoomSuiteNumber;
            BuildingSiteNumber = buildingSiteNumber;
            CongressionalDistrict = congressionalDistrict;
            CountyFIPSCode = countyFIPSCode;
            DoNotPublishIndicator = doNotPublishIndicator;
            Latitude = latitude;
            Longitude = longitude;
            NameOfCounty = nameOfCounty;
            Periods = periods;
        }

        /// <summary>
        /// The type of address listed for an individual or organization.    For example:  Physical Address, Mailing Address, Home Address, etc.)
        /// </summary>
        /// <value>The type of address listed for an individual or organization.    For example:  Physical Address, Mailing Address, Home Address, etc.)</value>
        [DataMember(Name = "addressTypeDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string AddressTypeDescriptor { get; set; }

        /// <summary>
        /// The abbreviation for the state (within the United States) or outlying area in which an address is located.
        /// </summary>
        /// <value>The abbreviation for the state (within the United States) or outlying area in which an address is located.</value>
        [DataMember(Name = "stateAbbreviationDescriptor", IsRequired = true, EmitDefaultValue = false)]
        public string StateAbbreviationDescriptor { get; set; }

        /// <summary>
        /// The name of the city in which an address is located.
        /// </summary>
        /// <value>The name of the city in which an address is located.</value>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The five or nine digit zip code or overseas postal code portion of an address.
        /// </summary>
        /// <value>The five or nine digit zip code or overseas postal code portion of an address.</value>
        [DataMember(Name = "postalCode", IsRequired = true, EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The street number and street name or post office box number of an address.
        /// </summary>
        /// <value>The street number and street name or post office box number of an address.</value>
        [DataMember(Name = "streetNumberName", IsRequired = true, EmitDefaultValue = false)]
        public string StreetNumberName { get; set; }

        /// <summary>
        /// A general geographic indicator that categorizes U.S. territory (e.g., City, Suburban).
        /// </summary>
        /// <value>A general geographic indicator that categorizes U.S. territory (e.g., City, Suburban).</value>
        [DataMember(Name = "localeDescriptor", EmitDefaultValue = true)]
        public string LocaleDescriptor { get; set; }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// </summary>
        /// <value>The apartment, room, or suite number of an address.</value>
        [DataMember(Name = "apartmentRoomSuiteNumber", EmitDefaultValue = true)]
        public string ApartmentRoomSuiteNumber { get; set; }

        /// <summary>
        /// The number of the building on the site, if more than one building shares the same address.
        /// </summary>
        /// <value>The number of the building on the site, if more than one building shares the same address.</value>
        [DataMember(Name = "buildingSiteNumber", EmitDefaultValue = true)]
        public string BuildingSiteNumber { get; set; }

        /// <summary>
        /// The congressional district in which an address is located.
        /// </summary>
        /// <value>The congressional district in which an address is located.</value>
        [DataMember(Name = "congressionalDistrict", EmitDefaultValue = true)]
        public string CongressionalDistrict { get; set; }

        /// <summary>
        /// The Federal Information Processing Standards (FIPS) numeric code for the county issued by the National Institute of Standards and Technology (NIST). Counties are considered to be the \&quot;first-order subdivisions\&quot; of each State and statistically equivalent entity, regardless of their local designations (county, parish, borough, etc.) Counties in different States will have the same code. A unique county number is created when combined with the 2-digit FIPS State Code.
        /// </summary>
        /// <value>The Federal Information Processing Standards (FIPS) numeric code for the county issued by the National Institute of Standards and Technology (NIST). Counties are considered to be the \&quot;first-order subdivisions\&quot; of each State and statistically equivalent entity, regardless of their local designations (county, parish, borough, etc.) Counties in different States will have the same code. A unique county number is created when combined with the 2-digit FIPS State Code.</value>
        [DataMember(Name = "countyFIPSCode", EmitDefaultValue = true)]
        public string CountyFIPSCode { get; set; }

        /// <summary>
        /// An indication that the address should not be published.
        /// </summary>
        /// <value>An indication that the address should not be published.</value>
        [DataMember(Name = "doNotPublishIndicator", EmitDefaultValue = true)]
        public bool? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// The geographic latitude of the physical address.
        /// </summary>
        /// <value>The geographic latitude of the physical address.</value>
        [DataMember(Name = "latitude", EmitDefaultValue = true)]
        public string Latitude { get; set; }

        /// <summary>
        /// The geographic longitude of the physical address.
        /// </summary>
        /// <value>The geographic longitude of the physical address.</value>
        [DataMember(Name = "longitude", EmitDefaultValue = true)]
        public string Longitude { get; set; }

        /// <summary>
        /// The name of the county, parish, borough, or comparable unit (within a state) in                       &#39;which an address is located.
        /// </summary>
        /// <value>The name of the county, parish, borough, or comparable unit (within a state) in                       &#39;which an address is located.</value>
        [DataMember(Name = "nameOfCounty", EmitDefaultValue = true)]
        public string NameOfCounty { get; set; }

        /// <summary>
        /// An unordered collection of candidateAddressPeriods. The time periods for which the address is valid. For physical addresses, the periods in which the person lived at that address.
        /// </summary>
        /// <value>An unordered collection of candidateAddressPeriods. The time periods for which the address is valid. For physical addresses, the periods in which the person lived at that address.</value>
        [DataMember(Name = "periods", EmitDefaultValue = false)]
        public List<TpdmCandidateAddressPeriod> Periods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            _ = sb.Append("class TpdmCandidateAddress {\n");
            _ = sb.Append("  AddressTypeDescriptor: ").Append(AddressTypeDescriptor).Append("\n");
            _ = sb.Append("  StateAbbreviationDescriptor: ").Append(StateAbbreviationDescriptor).Append("\n");
            _ = sb.Append("  City: ").Append(City).Append("\n");
            _ = sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            _ = sb.Append("  StreetNumberName: ").Append(StreetNumberName).Append("\n");
            _ = sb.Append("  LocaleDescriptor: ").Append(LocaleDescriptor).Append("\n");
            _ = sb.Append("  ApartmentRoomSuiteNumber: ").Append(ApartmentRoomSuiteNumber).Append("\n");
            _ = sb.Append("  BuildingSiteNumber: ").Append(BuildingSiteNumber).Append("\n");
            _ = sb.Append("  CongressionalDistrict: ").Append(CongressionalDistrict).Append("\n");
            _ = sb.Append("  CountyFIPSCode: ").Append(CountyFIPSCode).Append("\n");
            _ = sb.Append("  DoNotPublishIndicator: ").Append(DoNotPublishIndicator).Append("\n");
            _ = sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            _ = sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            _ = sb.Append("  NameOfCounty: ").Append(NameOfCounty).Append("\n");
            _ = sb.Append("  Periods: ").Append(Periods).Append("\n");
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
            return Equals(input as TpdmCandidateAddress);
        }

        /// <summary>
        /// Returns true if TpdmCandidateAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmCandidateAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmCandidateAddress input)
        {
            return input != null
&& (
                    AddressTypeDescriptor == input.AddressTypeDescriptor ||
                    (AddressTypeDescriptor != null &&
                    AddressTypeDescriptor.Equals(input.AddressTypeDescriptor))
                ) &&
                (
                    StateAbbreviationDescriptor == input.StateAbbreviationDescriptor ||
                    (StateAbbreviationDescriptor != null &&
                    StateAbbreviationDescriptor.Equals(input.StateAbbreviationDescriptor))
                ) &&
                (
                    City == input.City ||
                    (City != null &&
                    City.Equals(input.City))
                ) &&
                (
                    PostalCode == input.PostalCode ||
                    (PostalCode != null &&
                    PostalCode.Equals(input.PostalCode))
                ) &&
                (
                    StreetNumberName == input.StreetNumberName ||
                    (StreetNumberName != null &&
                    StreetNumberName.Equals(input.StreetNumberName))
                ) &&
                (
                    LocaleDescriptor == input.LocaleDescriptor ||
                    (LocaleDescriptor != null &&
                    LocaleDescriptor.Equals(input.LocaleDescriptor))
                ) &&
                (
                    ApartmentRoomSuiteNumber == input.ApartmentRoomSuiteNumber ||
                    (ApartmentRoomSuiteNumber != null &&
                    ApartmentRoomSuiteNumber.Equals(input.ApartmentRoomSuiteNumber))
                ) &&
                (
                    BuildingSiteNumber == input.BuildingSiteNumber ||
                    (BuildingSiteNumber != null &&
                    BuildingSiteNumber.Equals(input.BuildingSiteNumber))
                ) &&
                (
                    CongressionalDistrict == input.CongressionalDistrict ||
                    (CongressionalDistrict != null &&
                    CongressionalDistrict.Equals(input.CongressionalDistrict))
                ) &&
                (
                    CountyFIPSCode == input.CountyFIPSCode ||
                    (CountyFIPSCode != null &&
                    CountyFIPSCode.Equals(input.CountyFIPSCode))
                ) &&
                (
                    DoNotPublishIndicator == input.DoNotPublishIndicator ||
                    (DoNotPublishIndicator != null &&
                    DoNotPublishIndicator.Equals(input.DoNotPublishIndicator))
                ) &&
                (
                    Latitude == input.Latitude ||
                    (Latitude != null &&
                    Latitude.Equals(input.Latitude))
                ) &&
                (
                    Longitude == input.Longitude ||
                    (Longitude != null &&
                    Longitude.Equals(input.Longitude))
                ) &&
                (
                    NameOfCounty == input.NameOfCounty ||
                    (NameOfCounty != null &&
                    NameOfCounty.Equals(input.NameOfCounty))
                ) &&
                (
                    Periods == input.Periods ||
                    Periods != null &&
                    input.Periods != null &&
                    Periods.SequenceEqual(input.Periods)
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
                if (AddressTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + AddressTypeDescriptor.GetHashCode();
                }
                if (StateAbbreviationDescriptor != null)
                {
                    hashCode = (hashCode * 59) + StateAbbreviationDescriptor.GetHashCode();
                }
                if (City != null)
                {
                    hashCode = (hashCode * 59) + City.GetHashCode();
                }
                if (PostalCode != null)
                {
                    hashCode = (hashCode * 59) + PostalCode.GetHashCode();
                }
                if (StreetNumberName != null)
                {
                    hashCode = (hashCode * 59) + StreetNumberName.GetHashCode();
                }
                if (LocaleDescriptor != null)
                {
                    hashCode = (hashCode * 59) + LocaleDescriptor.GetHashCode();
                }
                if (ApartmentRoomSuiteNumber != null)
                {
                    hashCode = (hashCode * 59) + ApartmentRoomSuiteNumber.GetHashCode();
                }
                if (BuildingSiteNumber != null)
                {
                    hashCode = (hashCode * 59) + BuildingSiteNumber.GetHashCode();
                }
                if (CongressionalDistrict != null)
                {
                    hashCode = (hashCode * 59) + CongressionalDistrict.GetHashCode();
                }
                if (CountyFIPSCode != null)
                {
                    hashCode = (hashCode * 59) + CountyFIPSCode.GetHashCode();
                }
                if (DoNotPublishIndicator != null)
                {
                    hashCode = (hashCode * 59) + DoNotPublishIndicator.GetHashCode();
                }
                if (Latitude != null)
                {
                    hashCode = (hashCode * 59) + Latitude.GetHashCode();
                }
                if (Longitude != null)
                {
                    hashCode = (hashCode * 59) + Longitude.GetHashCode();
                }
                if (NameOfCounty != null)
                {
                    hashCode = (hashCode * 59) + NameOfCounty.GetHashCode();
                }
                if (Periods != null)
                {
                    hashCode = (hashCode * 59) + Periods.GetHashCode();
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
            // AddressTypeDescriptor (string) maxLength
            if (AddressTypeDescriptor != null && AddressTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressTypeDescriptor, length must be less than 306.", new[] { "AddressTypeDescriptor" });
            }

            // StateAbbreviationDescriptor (string) maxLength
            if (StateAbbreviationDescriptor != null && StateAbbreviationDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StateAbbreviationDescriptor, length must be less than 306.", new[] { "StateAbbreviationDescriptor" });
            }

            // City (string) maxLength
            if (City != null && City.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 30.", new[] { "City" });
            }

            // PostalCode (string) maxLength
            if (PostalCode != null && PostalCode.Length > 17)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 17.", new[] { "PostalCode" });
            }

            // StreetNumberName (string) maxLength
            if (StreetNumberName != null && StreetNumberName.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StreetNumberName, length must be less than 150.", new[] { "StreetNumberName" });
            }

            // LocaleDescriptor (string) maxLength
            if (LocaleDescriptor != null && LocaleDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocaleDescriptor, length must be less than 306.", new[] { "LocaleDescriptor" });
            }

            // ApartmentRoomSuiteNumber (string) maxLength
            if (ApartmentRoomSuiteNumber != null && ApartmentRoomSuiteNumber.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ApartmentRoomSuiteNumber, length must be less than 50.", new[] { "ApartmentRoomSuiteNumber" });
            }

            // BuildingSiteNumber (string) maxLength
            if (BuildingSiteNumber != null && BuildingSiteNumber.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BuildingSiteNumber, length must be less than 20.", new[] { "BuildingSiteNumber" });
            }

            // CongressionalDistrict (string) maxLength
            if (CongressionalDistrict != null && CongressionalDistrict.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CongressionalDistrict, length must be less than 30.", new[] { "CongressionalDistrict" });
            }

            // CountyFIPSCode (string) maxLength
            if (CountyFIPSCode != null && CountyFIPSCode.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountyFIPSCode, length must be less than 5.", new[] { "CountyFIPSCode" });
            }

            // Latitude (string) maxLength
            if (Latitude != null && Latitude.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Latitude, length must be less than 20.", new[] { "Latitude" });
            }

            // Longitude (string) maxLength
            if (Longitude != null && Longitude.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Longitude, length must be less than 20.", new[] { "Longitude" });
            }

            // NameOfCounty (string) maxLength
            if (NameOfCounty != null && NameOfCounty.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NameOfCounty, length must be less than 30.", new[] { "NameOfCounty" });
            }

            yield break;
        }
    }

}
