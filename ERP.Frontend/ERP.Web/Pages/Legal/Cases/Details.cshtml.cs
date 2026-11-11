using ERP.Web.Pages.Legal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ERP.Web.Pages.Legal.Cases;

public sealed class DetailsModel : PageModel
{
    public LegalCaseDemo Case { get; private set; } = default!;
    public IReadOnlyList<LegalSessionDemo> Sessions { get; private set; } = [];
    public IReadOnlyList<LegalDocumentDemo> Documents { get; private set; } = [];

    public IActionResult OnGet(string id)
    {
        var legalCase = LegalDemoData.FindCase(id);
        if (legalCase is null) return NotFound();
        Case = legalCase;
        Sessions = LegalDemoData.Sessions.Where(item => item.CaseId == legalCase.Id).OrderByDescending(item => item.SessionOn).ToArray();
        Documents = LegalDemoData.Documents.Where(item => item.CaseId == legalCase.Id).OrderByDescending(item => item.AddedOn).ToArray();
        return Page();
    }
}
