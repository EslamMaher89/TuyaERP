namespace ERP.Infrastructure.LegacyOracle;

/// <summary>
/// Reports whether the legacy Oracle adapter can safely be enabled.
/// No queries or writes are attempted until schema and connection details are reviewed.
/// </summary>
public sealed class OracleReadiness(IConfiguration configuration)
{
    public bool IsConfigured =>
        !string.IsNullOrWhiteSpace(configuration.GetConnectionString("LegacyOracle"));
}
