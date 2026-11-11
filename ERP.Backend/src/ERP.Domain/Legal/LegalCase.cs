namespace ERP.Domain.Legal;

/// <summary>
/// Legal case record based on the legacy LAWSUIT_MSTER Forms block.
/// Field mapping is provisional until verified against the live Oracle schema.
/// </summary>
public sealed record LegalCase
{
    public required string CaseNumber { get; init; }
    public required string CompanyNumber { get; init; }
    public required string BranchNumber { get; init; }
    public int? SerialNumber { get; init; }
    public int? CaseYear { get; init; }
    public DateOnly? FiledOn { get; init; }
    public string? CaseTypeCode { get; init; }
    public string? OpponentTypeCode { get; init; }
    public string? CaseSubject { get; init; }
    public string? Description { get; init; }
    public string? CourtCode { get; init; }
    public string? CourtSerialNumber { get; init; }
    public DateOnly? NextSessionOn { get; init; }
}
