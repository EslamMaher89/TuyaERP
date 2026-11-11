namespace ERP.Domain.Legal;

/// <summary>Hearing data corresponding to the legacy SESSION_1 block.</summary>
public sealed record LegalSession
{
    public required string CaseNumber { get; init; }
    public required DateOnly SessionOn { get; init; }
    public int? SerialNumber { get; init; }
    public DateOnly? NextSessionOn { get; init; }
    public string? CourtCode { get; init; }
    public string? CircleNumber { get; init; }
    public string? Outcome { get; init; }
    public string? AdjournmentReasonCode { get; init; }
}
