// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EdFi.OdsApi.Sdk.Models.All;
using Microsoft.EntityFrameworkCore;

namespace eppeta.webapi.Evaluations.Models;

[Table("PerformanceEvaluation", Schema = "eppeta")]
public partial class PerformanceEvaluation
{
    [Required]
    public long EducationOrganizationId { get; set; }

    [Required]
    public string EvaluationPeriodDescriptor { get; set; }

    [Required]
    [StringLength(50)]
    public string PerformanceEvaluationTitle { get; set; }

    [Required]
    public string PerformanceEvaluationTypeDescriptor { get; set; }

    [Required]
    public short SchoolYear { get; set; }

    [Required]
    public string TermDescriptor { get; set; }

    [StringLength(255)]
    public string PerformanceEvaluationDescription { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime LastModifiedDate { get; set; }

    [Column("EdFi_Id")]
    [StringLength(50)]
    public string EdFiId { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public ICollection<PerformanceEvaluationRatingLevel> PerformanceEvaluationRatingLevels { get; set; } = new List<PerformanceEvaluationRatingLevel>();


    public static explicit operator PerformanceEvaluation(TpdmPerformanceEvaluation tpdmPerformanceEvaluation)
    => new PerformanceEvaluation
    {
        PerformanceEvaluationTypeDescriptor = tpdmPerformanceEvaluation.PerformanceEvaluationTypeDescriptor,
        PerformanceEvaluationDescription = tpdmPerformanceEvaluation.PerformanceEvaluationDescription,
        EdFiId = tpdmPerformanceEvaluation.Id,
        EducationOrganizationId = tpdmPerformanceEvaluation.EducationOrganizationReference.EducationOrganizationId,
        EvaluationPeriodDescriptor = tpdmPerformanceEvaluation.EvaluationPeriodDescriptor,
        PerformanceEvaluationTitle = tpdmPerformanceEvaluation.PerformanceEvaluationTitle,
        SchoolYear = (short)tpdmPerformanceEvaluation.SchoolYearTypeReference.SchoolYear,
        TermDescriptor = tpdmPerformanceEvaluation.TermDescriptor,
        PerformanceEvaluationRatingLevels = tpdmPerformanceEvaluation.RatingLevels.Select(l => (PerformanceEvaluationRatingLevel)l).ToList()
    };

    public static explicit operator TpdmPerformanceEvaluation(PerformanceEvaluation performanceEvaluation)
        => new TpdmPerformanceEvaluation(
            educationOrganizationReference: new EdFiEducationOrganizationReference
            ( educationOrganizationId: (int)performanceEvaluation.EducationOrganizationId),
            evaluationPeriodDescriptor: performanceEvaluation.EvaluationPeriodDescriptor,
            performanceEvaluationDescription: performanceEvaluation.PerformanceEvaluationDescription,
            performanceEvaluationTitle: performanceEvaluation.PerformanceEvaluationTitle,
            performanceEvaluationTypeDescriptor: performanceEvaluation.PerformanceEvaluationTypeDescriptor,
            schoolYearTypeReference: new EdFiSchoolYearTypeReference { SchoolYear = performanceEvaluation.SchoolYear },
            termDescriptor: performanceEvaluation.TermDescriptor
        );
}
