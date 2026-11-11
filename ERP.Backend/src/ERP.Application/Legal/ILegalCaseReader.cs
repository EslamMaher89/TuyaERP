using ERP.Domain.Legal;

namespace ERP.Application.Legal;

/// <summary>Read-only contract for the first legacy migration slice.</summary>
public interface ILegalCaseReader
{
    Task<IReadOnlyList<LegalCase>> SearchAsync(
        string companyNumber,
        string branchNumber,
        string? query,
        CancellationToken cancellationToken);

    Task<LegalCase?> FindAsync(
        string companyNumber,
        string branchNumber,
        string caseNumber,
        CancellationToken cancellationToken);
}
