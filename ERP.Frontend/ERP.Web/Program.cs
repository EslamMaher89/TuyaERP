using Microsoft.AspNetCore.DataProtection;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Services.AddRazorPages();
if (builder.Environment.IsDevelopment())
{
    var localKeyRing = Path.Combine(builder.Environment.ContentRootPath, ".local-data-protection");
    Directory.CreateDirectory(localKeyRing);
    builder.Services.AddDataProtection()
        .PersistKeysToFileSystem(new DirectoryInfo(localKeyRing))
        .SetApplicationName("TuyaERP.Web.Development");
}

var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();
app.Run();
