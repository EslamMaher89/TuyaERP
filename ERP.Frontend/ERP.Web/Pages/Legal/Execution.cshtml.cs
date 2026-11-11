using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ERP.Web.Pages.Legal;

public sealed class ExecutionModel : PageModel
{
    public string? Query { get; private set; }
    public string? CaseId { get; private set; }
    public IReadOnlyList<LegalExecutionDemo> Executions { get; private set; } = [];

    public void OnGet(string? q, string? caseId)
    {
        Query = q?.Trim();
        CaseId = caseId;
        Executions = LegalDemoData.Executions
            .Where(item => string.IsNullOrWhiteSpace(CaseId) || item.CaseId == CaseId)
            .Where(item => string.IsNullOrWhiteSpace(Query)
                || item.Description.Contains(Query, StringComparison.OrdinalIgnoreCase)
                || item.CaseId.Contains(Query, StringComparison.OrdinalIgnoreCase)
                || item.Status.Contains(Query, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(item => item.RecordedOn)
            .ToArray();
    }
}
