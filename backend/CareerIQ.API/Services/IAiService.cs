using CareerIQ.API.Models;

namespace CareerIQ.API.Services;
public interface IAiService
{
    Task<ResumeAnalysisResponse> AnalyzeResumeAsync(
        string resumeText,
        CancellationToken cancellationToken = default);
}