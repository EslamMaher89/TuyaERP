using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ERP.Web.Pages.Legal;

public sealed class CaseLawyersModel : PageModel
{
    public string? Query { get; private set; }
    public string? CaseId { get; private set; }
    public IReadOnlyList<LegalCaseLawyerDemo> Assignments { get; private set; } = [];

    public void OnGet(string? q, string? caseId)
    {
        Query = q?.Trim();
        CaseId = caseId;
        Assignments = LegalDemoData.CaseLawyerAssignments
            .Where(item => string.IsNullOrWhiteSpace(CaseId) || item.CaseId == CaseId)
            .Where(item =>
            {
                var caseRecord = LegalDemoData.FindCase(item.CaseId);
                var lawyer = LegalDemoData.FindLawyer(item.LawyerNumber);
                return string.IsNullOrWhiteSpace(Query)
                    || caseRecord?.CaseNumber.Contains(Query, StringComparison.OrdinalIgnoreCase) == true
                    || caseRecord?.Subject.Contains(Query, StringComparison.OrdinalIgnoreCase) == true
                    || lawyer?.Name.Contains(Query, StringComparison.OrdinalIgnoreCase) == true;
            })
            .OrderBy(item => item.CaseId)
            .ThenBy(item => item.AssignmentSequence)
            .ToArray();
    }
}
