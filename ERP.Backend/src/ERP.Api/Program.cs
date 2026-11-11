using ERP.Infrastructure.LegacyOracle;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<OracleReadiness>(services =>
{
    var config = services.GetRequiredService<Microsoft.Extensions.Configuration.IConfiguration>();
    return new OracleReadiness(new ConfigurationAdapter(config));
});

var app = builder.Build();
app.MapGet("/health", () => Results.Ok(new { status = "ok" }));
app.MapGet("/api/legal/status", (OracleReadiness oracle) => Results.Ok(new
{
    module = "legal",
    mode = "discovery",
    oracleConfigured = oracle.IsConfigured,
    dataAccessEnabled = false,
    message = "Oracle schema and business rules must be verified before enabling case queries."
}));
app.MapGet("/api/legal/cases", () => Results.Problem(
    title: "Legal case data is not connected",
    detail: "The Oracle schema mapping is still under discovery. No sample or fabricated case data is returned.",
    statusCode: StatusCodes.Status503ServiceUnavailable));

app.Run();

sealed class ConfigurationAdapter(Microsoft.Extensions.Configuration.IConfiguration configuration)
    : ERP.Infrastructure.LegacyOracle.IConfiguration
{
    public string? GetConnectionString(string name) => configuration.GetConnectionString(name);
}
