using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ERP.Web.Pages.Legal;

public sealed class LawyersModel : PageModel
{
    public string? Query { get; private set; }
    public IReadOnlyList<LegalLawyerDemo> Lawyers { get; private set; } = [];

    public void OnGet(string? q)
    {
        Query = q?.Trim();
        Lawyers = LegalDemoData.Lawyers
            .Where(item => string.IsNullOrWhiteSpace(Query)
                || item.Name.Contains(Query, StringComparison.OrdinalIgnoreCase)
                || item.Specialty.Contains(Query, StringComparison.OrdinalIgnoreCase)
                || item.City.Contains(Query, StringComparison.OrdinalIgnoreCase))
            .ToArray();
    }
}
