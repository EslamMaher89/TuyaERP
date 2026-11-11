namespace ERP.Domain.Legal;

/// <summary>
/// Source-mapped fields from the Oracle Forms LAWSUIT_MSTER data block.
/// Business labels and constraints remain provisional until checked against Oracle metadata.
/// </summary>
public sealed record LegalCase
{
    // Oracle composite relation key: QUIDA_NO + MSLSL + KIND_QUID.
    public required decimal QadiaNumber { get; init; } // QUIDA_NO
    public required decimal SerialNumber { get; init; } // MSLSL
    public required decimal KindQuidCode { get; init; } // KIND_QUID

    public required decimal CaseYear { get; init; } // YEAR
    public required DateTime FiledAt { get; init; } // DATA_DEAA (Oracle DATE)
    public required decimal BranchNumber { get; init; } // BRANCH_NO
    public required decimal CompanyNumber { get; init; } // COMPANY_NO
    public required string LawsuitName { get; init; } // LSANA
    public required decimal MultiPartyTypeCode { get; init; } // KIND_MIULTY
    public required decimal OpponentTypeCode { get; init; } // KIND_KHSM
    public string? Description { get; init; } // DESC_LAWSUIT
    public decimal? Noa { get; init; } // NOA
    public required decimal CourtTypeCode { get; init; } // KIND_COURT
    public required decimal SubKindCode { get; init; } // SUB_KIND
    public required decimal MainKindCode { get; init; } // MAIN_KIND
    public string? OpponentName { get; init; } // KHASM_NAME
    public DateTime? NextSessionOn { get; init; } // DATE_SESSION
    public decimal? CodeDis { get; init; } // CODE_DIS
    public decimal? CourtSerialNumber { get; init; } // MSLSL_COURT
    public decimal? KindQuidaCode { get; init; } // KIND_QUIDA
}
