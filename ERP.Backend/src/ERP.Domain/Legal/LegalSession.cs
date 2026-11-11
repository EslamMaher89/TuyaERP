namespace ERP.Domain.Legal;

/// <summary>Source-mapped hearing fields from the Oracle Forms SESSION_1 block.</summary>
public sealed record LegalSession
{
    public required decimal QadiaNumber { get; init; } // QUIDA_NO
    public required decimal SerialNumber { get; init; } // MSLSL
    public required decimal KindQuidCode { get; init; } // KIND_QUID
    public required DateTime SessionOn { get; init; } // DATE_SESSION
    public DateTime? NextSessionOn { get; init; } // DATE_NEXT
    public required decimal SessionSerialNumber { get; init; } // MSLSL_SEESION
    public decimal? CourtTypeCode { get; init; } // KIND_COURT
    public decimal? CircleNumber { get; init; } // CIRCLE_NO
    public string? HearingRecord { get; init; } // HAPPEN (Oracle LONG)
    public decimal? ReasonCode { get; init; } // COD_RESON
    public decimal? ShiftCode { get; init; } // CODE_SHIFT
    public required decimal IsCurrentOrHistorical { get; init; } // MOIZ; semantics require confirmation
}
