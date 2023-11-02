// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EdFi.OdsApi.Sdk.Models.All;
using Microsoft.EntityFrameworkCore;

namespace eppeta.webapi.Evaluations.Models;

[Table("EvaluationObjective", Schema = "eppeta")]
public partial class EvaluationObjective
{
    [Required]
    public long EducationOrganizationId { get; set; }

    [Required]
    [StringLength(50)]
    public string EvaluationObjectiveTitle { get; set; }

    [Required]
    [StringLength(306)]
    public string EvaluationPeriodDescriptor { get; set; }

    [Required]
    [StringLength(50)]
    public string EvaluationTitle { get; set; }

    [Required]
    [StringLength(50)]
    public string PerformanceEvaluationTitle { get; set; }

    [Required]
    [StringLength(306)]
    public string PerformanceEvaluationTypeDescriptor { get; set; }

    [Required]
    public short SchoolYear { get; set; }

    [Required]
    [StringLength(306)]
    public string TermDescriptor { get; set; }

    [StringLength(255)]
    public string EvaluationObjectiveDescription { get; set; }

    [StringLength(306)]
    public string EvaluationTypeDescriptor { get; set; }

    public int? SortOrder { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime LastModifiedDate { get; set; }

    [Required]
    [Column("EdFi_Id")]
    [StringLength(50)]
    public string EdFiId { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public static explicit operator EvaluationObjective(TpdmEvaluationObjective tpdmEvaluationObjective)
        => new EvaluationObjective
        {
            EvaluationObjectiveTitle = tpdmEvaluationObjective.EvaluationObjectiveTitle,
            EvaluationObjectiveDescription = tpdmEvaluationObjective.EvaluationObjectiveDescription,
            EvaluationTypeDescriptor = tpdmEvaluationObjective.EvaluationTypeDescriptor,
            SortOrder = tpdmEvaluationObjective.SortOrder,
            EdFiId = tpdmEvaluationObjective.Id,
            EducationOrganizationId = tpdmEvaluationObjective.EvaluationReference.EducationOrganizationId,
            EvaluationPeriodDescriptor = tpdmEvaluationObjective.EvaluationReference.EvaluationPeriodDescriptor,
            EvaluationTitle = tpdmEvaluationObjective.EvaluationReference.EvaluationTitle,
            PerformanceEvaluationTitle = tpdmEvaluationObjective.EvaluationReference.PerformanceEvaluationTitle,
            PerformanceEvaluationTypeDescriptor = tpdmEvaluationObjective.EvaluationReference.PerformanceEvaluationTypeDescriptor,
            SchoolYear = (short)tpdmEvaluationObjective.EvaluationReference.SchoolYear,
            TermDescriptor = tpdmEvaluationObjective.EvaluationReference.TermDescriptor
        };
    public static explicit operator TpdmEvaluationObjective(EvaluationObjective evaluationObjective)
        => new TpdmEvaluationObjective
        (
            evaluationReference : new TpdmEvaluationReference
            (
                educationOrganizationId : (int)evaluationObjective.EducationOrganizationId,
                evaluationPeriodDescriptor : evaluationObjective.EvaluationPeriodDescriptor,
                evaluationTitle : evaluationObjective.EvaluationTitle,
                performanceEvaluationTitle : evaluationObjective.PerformanceEvaluationTitle,
                performanceEvaluationTypeDescriptor : evaluationObjective.PerformanceEvaluationTypeDescriptor,
                schoolYear : evaluationObjective.SchoolYear,
                termDescriptor : evaluationObjective.TermDescriptor
            ),
            evaluationObjectiveDescription : evaluationObjective.EvaluationObjectiveDescription,
            evaluationObjectiveTitle : evaluationObjective.EvaluationObjectiveTitle,
            evaluationTypeDescriptor : evaluationObjective.EvaluationTypeDescriptor
        );
}
