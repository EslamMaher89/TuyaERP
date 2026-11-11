using ERP.Web.Pages.Legal;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ERP.Web.Pages.Legal.Cases;

public sealed class IndexModel : PageModel
{
    public string? Query { get; private set; }
    public string StatusFilter { get; private set; } = "الكل";
    public IReadOnlyList<LegalCaseDemo> Cases { get; private set; } = [];
    public IReadOnlyList<string> StatusOptions { get; } = ["الكل", "مفتوحة", "جلسة محددة", "قيد المداولة", "مغلقة"];

    public void OnGet(string? q, string? status)
    {
        Query = q?.Trim();
        StatusFilter = StatusOptions.Contains(status) ? status! : "الكل";
        Cases = LegalDemoData.Cases
            .Where(item => StatusFilter == "الكل" || item.Status == StatusFilter)
            .Where(item => string.IsNullOrWhiteSpace(Query)
                || item.CaseNumber.Contains(Query, StringComparison.OrdinalIgnoreCase)
                || item.Subject.Contains(Query, StringComparison.OrdinalIgnoreCase)
                || item.CompanyName.Contains(Query, StringComparison.OrdinalIgnoreCase)
                || item.BranchName.Contains(Query, StringComparison.OrdinalIgnoreCase)
                || item.Opponent.Contains(Query, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(item => item.OpenedOn)
            .ToArray();
    }
}
