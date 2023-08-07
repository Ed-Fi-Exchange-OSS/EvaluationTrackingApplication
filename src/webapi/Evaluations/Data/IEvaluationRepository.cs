// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using eppeta.webapi.Evaluations.Models;
using eppeta.webapi.Identity.Models;
using System.Diagnostics;

namespace eppeta.webapi.Evaluations.Data;

public interface IEvaluationRepository
{
    Task<List<PerformanceEvaluationRating>> GetAllPerformanceEvaluationRatings();

    Task<PerformanceEvaluationRating?> GetPerformanceEvaluationRating(int id);

    Task CreatePerformanceEvaluationRating(PerformanceEvaluationRating rating);

    Task UpdatePerformanceEvaluationRating(PerformanceEvaluationRating rating);
}
