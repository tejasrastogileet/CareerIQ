namespace CareerIQ.API.Services;

public interface IRagContextService
{
    Task<string> GetRelevantContextAsync(
        string resumeText,
        CancellationToken cancellationToken = default);
}
