namespace ERP.Web.Pages.Legal;

/// <summary>Fictional data used only to build and review legal screens before Oracle integration.</summary>
public static class LegalDemoData
{
    public static readonly DateOnly Today = DateOnly.FromDateTime(DateTime.Today);
    public static DateTime TodayStart => Today.ToDateTime(TimeOnly.MinValue);
    public static readonly IReadOnlyList<LegalCaseDemo> Cases =
    [
        new("LC-2026-0148", "2026/مدني/148", "تأخر توريد معدات خط الإنتاج", "الشركة التجريبية", "فرع القاهرة التجريبي", "محكمة القاهرة الاقتصادية", "الدائرة الثالثة", "مفتوحة", "محمود سالم", Today.AddDays(-14), "توريد ومقاولات", "شركة الإمداد الصناعي", "مراجعة تقرير الخبير", true, "طلب تعويض عن تأخر توريد معدات وخلاف حول جدول التسليم.", "القاهرة", "QUIDA_NO=148 · MSLSL=1 · KIND_QUID=1"),
        new("LC-2026-0136", "2026/عمال/136", "مطالبة بمستحقات تعاقدية", "الشركة التجريبية", "فرع القاهرة التجريبي", "محكمة شمال القاهرة الابتدائية", "الدائرة العمالية الخامسة", "جلسة محددة", "سلمى عادل", Today.AddDays(-20), "عمالية", "طرف تجريبي (أ)", "تجهيز المستندات", true, "نزاع عمالي افتراضي حول مستحقات نهاية خدمة وبنود عقد العمل.", "القاهرة", "QUIDA_NO=136 · MSLSL=2 · KIND_QUID=2"),
        new("LC-2026-0112", "2026/تجاري/112", "خلاف على شروط عقد التوزيع", "الشركة التجريبية", "فرع الجيزة التجريبي", "محكمة الجيزة الابتدائية", "الدائرة التجارية الثانية", "قيد المداولة", "أحمد ناصر", Today.AddDays(-35), "تجارية", "مؤسسة التوزيع النموذجية", "انتظار الحكم", false, "خلاف افتراضي حول نطاق التوزيع الحصري والتزامات الطرفين.", "الجيزة", "QUIDA_NO=112 · MSLSL=3 · KIND_QUID=1"),
        new("LC-2026-0097", "2026/مدني/097", "مطالبة بقيمة أعمال صيانة", "الشركة التجريبية", "فرع الإسكندرية التجريبي", "محكمة الإسكندرية الابتدائية", "الدائرة المدنية السابعة", "مفتوحة", "محمود سالم", Today.AddDays(-60), "مدنية", "شركة الخدمات الفنية الافتراضية", "تحديد موعد الجلسة التالية", true, "مطالبة مالية افتراضية ناتجة عن عقد صيانة معدات المصنع.", "الإسكندرية", "QUIDA_NO=97 · MSLSL=4 · KIND_QUID=1"),
        new("LC-2026-0063", "2026/تجاري/063", "نزاع على مواصفات شحنة", "الشركة التجريبية", "فرع القاهرة التجريبي", "محكمة القاهرة الاقتصادية", "الدائرة الأولى", "مغلقة", "سلمى عادل", Today.AddDays(-120), "تجارية", "المورد النموذجي (ب)", "تم إغلاق الملف", false, "قضية توضيحية مغلقة بعد تسوية افتراضية بين الأطراف.", "القاهرة", "QUIDA_NO=63 · MSLSL=5 · KIND_QUID=2")
    ];

    public static readonly IReadOnlyList<LegalSessionDemo> Sessions =
    [
        new("SE-1001", "LC-2026-0148", "2026/مدني/148", Today.ToDateTime(new TimeOnly(10, 0)).AddDays(1), "محكمة القاهرة الاقتصادية", "الدائرة الثالثة", "تقديم تقرير الخبير", "محمود سالم", "قائمة"),
        new("SE-1002", "LC-2026-0136", "2026/عمال/136", Today.ToDateTime(new TimeOnly(9, 30)).AddDays(3), "محكمة شمال القاهرة الابتدائية", "الدائرة العمالية الخامسة", "سماع أقوال الأطراف", "سلمى عادل", "قائمة"),
        new("SE-1003", "LC-2026-0097", "2026/مدني/097", Today.ToDateTime(new TimeOnly(11, 0)).AddDays(6), "محكمة الإسكندرية الابتدائية", "الدائرة المدنية السابعة", "استكمال المرافعة", "محمود سالم", "قائمة"),
        new("SE-0998", "LC-2026-0112", "2026/تجاري/112", Today.ToDateTime(new TimeOnly(10, 30)).AddDays(8), "محكمة الجيزة الابتدائية", "الدائرة التجارية الثانية", "النطق بالحكم", "أحمد ناصر", "قائمة"),
        new("SE-0971", "LC-2026-0148", "2026/مدني/148", Today.ToDateTime(new TimeOnly(10, 0)).AddDays(-8), "محكمة القاهرة الاقتصادية", "الدائرة الثالثة", "تأجيل لتقديم المستندات", "محمود سالم", "منعقدة")
    ];

    public static readonly IReadOnlyList<LegalLawyerDemo> Lawyers =
    [
        new("LW-01", "محمود سالم", "محامي شركات", "القاهرة", 2, 4, "متاح"),
        new("LW-02", "سلمى عادل", "محامية قضايا عمالية", "القاهرة", 2, 3, "متاح"),
        new("LW-03", "أحمد ناصر", "محامي تجاري", "الجيزة", 1, 2, "متاح"),
        new("LW-04", "منى فؤاد", "مستشارة قانونية", "الإسكندرية", 0, 1, "متاح")
    ];

    public static readonly IReadOnlyList<LegalDocumentDemo> Documents =
    [
        new("DOC-221", "صحيفة الدعوى", "LC-2026-0148", "PDF", Today.AddDays(-14), "محمود سالم", "ملف القضية"),
        new("DOC-219", "عقد التوريد", "LC-2026-0148", "PDF", Today.AddDays(-14), "محمود سالم", "عقد"),
        new("DOC-214", "محضر الجلسة السابقة", "LC-2026-0148", "PDF", Today.AddDays(-8), "محمود سالم", "محضر"),
        new("DOC-207", "مذكرة دفاع", "LC-2026-0136", "DOCX", Today.AddDays(-12), "سلمى عادل", "مذكرة"),
        new("DOC-192", "إخطار تحديد جلسة", "LC-2026-0097", "PDF", Today.AddDays(-22), "محمود سالم", "إخطار"),
        new("DOC-181", "نسخة الحكم", "LC-2026-0063", "PDF", Today.AddDays(-80), "سلمى عادل", "حكم")
    ];

    public static LegalCaseDemo? FindCase(string? id) => Cases.FirstOrDefault(item => item.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
}

public sealed record LegalCaseDemo(
    string Id, string CaseNumber, string Subject, string CompanyName, string BranchName, string CourtName, string CircleName,
    string Status, string LawyerName, DateOnly OpenedOn, string CaseType, string Opponent,
    string NextAction, bool NeedsFollowUp, string Description, string City, string SampleOracleKey)
{
    public string StatusClass => Status switch
    {
        "جلسة محددة" => "status-blue",
        "قيد المداولة" => "status-violet",
        "مغلقة" => "status-neutral",
        _ => "status-green"
    };
}

public sealed record LegalSessionDemo(
    string Id, string CaseId, string CaseNumber, DateTime SessionOn, string CourtName,
    string CircleName, string Agenda, string LawyerName, string Status);

public sealed record LegalLawyerDemo(
    string Id, string Name, string Specialty, string City, int OpenCases, int UpcomingSessions, string Status);

public sealed record LegalDocumentDemo(
    string Id, string Name, string CaseId, string FileType, DateOnly AddedOn, string AddedBy, string Category);
