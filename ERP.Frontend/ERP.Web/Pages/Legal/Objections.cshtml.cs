using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ERP.Web.Pages.Legal;

public sealed class ObjectionsModel : PageModel
{
    public string? Query { get; private set; }
    public string? CaseId { get; private set; }
    public IReadOnlyList<LegalObjectionDemo> Objections { get; private set; } = [];

    public void OnGet(string? q, string? caseId)
    {
        Query = q?.Trim();
        CaseId = caseId;
        Objections = LegalDemoData.Objections
            .Where(item => string.IsNullOrWhiteSpace(CaseId) || item.CaseId == CaseId)
            .Where(item => string.IsNullOrWhiteSpace(Query)
                || item.Name.Contains(Query, StringComparison.OrdinalIgnoreCase)
                || item.CaseId.Contains(Query, StringComparison.OrdinalIgnoreCase)
                || item.Note.Contains(Query, StringComparison.OrdinalIgnoreCase))
            .ToArray();
    }
}
