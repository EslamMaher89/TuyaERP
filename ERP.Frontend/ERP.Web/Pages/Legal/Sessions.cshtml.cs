using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ERP.Web.Pages.Legal;

public sealed class SessionsModel : PageModel
{
    public string? Query { get; private set; }
    public string DayFilter { get; private set; } = "القادمة";
    public IReadOnlyList<LegalSessionDemo> Sessions { get; private set; } = [];

    public void OnGet(string? q, string? range)
    {
        Query = q?.Trim();
        DayFilter = range == "all" ? "الكل" : "القادمة";
        var sessions = LegalDemoData.Sessions.AsEnumerable();
        if (DayFilter == "القادمة") sessions = sessions.Where(item => item.SessionOn >= LegalDemoData.TodayStart);
        if (!string.IsNullOrWhiteSpace(Query))
            sessions = sessions.Where(item => item.CaseNumber.Contains(Query, StringComparison.OrdinalIgnoreCase)
                || item.CourtName.Contains(Query, StringComparison.OrdinalIgnoreCase)
                || item.LawyerName.Contains(Query, StringComparison.OrdinalIgnoreCase));
        Sessions = sessions.OrderBy(item => item.SessionOn).ToArray();
    }
}
