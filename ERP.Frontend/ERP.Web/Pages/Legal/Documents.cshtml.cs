using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ERP.Web.Pages.Legal;

public sealed class DocumentsModel : PageModel
{
    public string? Query { get; private set; }
    public string CategoryFilter { get; private set; } = "الكل";
    public IReadOnlyList<LegalDocumentDemo> Documents { get; private set; } = [];
    public IReadOnlyList<string> Categories { get; } = ["الكل", "ملف القضية", "عقد", "محضر", "مذكرة", "إخطار", "حكم"];

    public void OnGet(string? q, string? category)
    {
        Query = q?.Trim();
        CategoryFilter = Categories.Contains(category) ? category! : "الكل";
        Documents = LegalDemoData.Documents
            .Where(item => CategoryFilter == "الكل" || item.Category == CategoryFilter)
            .Where(item => string.IsNullOrWhiteSpace(Query)
                || item.Name.Contains(Query, StringComparison.OrdinalIgnoreCase)
                || item.CaseId.Contains(Query, StringComparison.OrdinalIgnoreCase)
                || item.AddedBy.Contains(Query, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(item => item.AddedOn)
            .ToArray();
    }
}
