using ERP.Domain.Legal;

namespace ERP.Application.Legal;

/// <summary>Read-only contract for the first legacy migration slice.</summary>
public interface ILegalCaseReader
{
    Task<IReadOnlyList<LegalCase>> SearchAsync(
        decimal companyNumber,
        decimal branchNumber,
        string? query,
        CancellationToken cancellationToken);

    Task<LegalCase?> FindAsync(
        decimal companyNumber,
        decimal branchNumber,
        decimal qadiaNumber,
        decimal serialNumber,
        decimal kindQuidCode,
        CancellationToken cancellationToken);
}
