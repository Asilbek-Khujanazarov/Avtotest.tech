using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Autotest.Platform.Domain.DTOs.Exam;

namespace Autotest.Platform.Domain.Interfaces;

public interface ITestSessionService
{
    Task<StartTestResponseDto> StartTestAsync(Guid userId);
    Task SubmitAnswerAsync(Guid userId, Guid sessionId, Guid questionId, Guid answerId);
    Task<TestResultDto> FinishTestAsync(Guid userId, Guid sessionId, bool force = false);
    Task AutoFinishExpiredTestsAsync();
}
