using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ERP.Web.Pages.Legal;

public sealed class IndexModel : PageModel
{
    public int ActiveCases => LegalDemoData.Cases.Count(item => item.Status != "مغلقة");
    public int UpcomingThisWeek => LegalDemoData.Sessions.Count(item => item.SessionOn >= LegalDemoData.TodayStart && item.SessionOn < LegalDemoData.TodayStart.AddDays(8));
    public int NeedsFollowUp => LegalDemoData.Cases.Count(item => item.NeedsFollowUp);
    public int LawyerCount => LegalDemoData.Lawyers.Count;
    public IReadOnlyList<LegalSessionDemo> UpcomingSessions => LegalDemoData.Sessions.Where(item => item.SessionOn >= LegalDemoData.TodayStart).OrderBy(item => item.SessionOn).Take(4).ToArray();
    public IReadOnlyList<LegalCaseDemo> FollowUpCases => LegalDemoData.Cases.Where(item => item.NeedsFollowUp).Take(3).ToArray();
    public IReadOnlyList<LegalCaseDemo> RecentCases => LegalDemoData.Cases.OrderByDescending(item => item.OpenedOn).Take(4).ToArray();

    public void OnGet() { }
}
