namespace ERP.Infrastructure.LegacyOracle;

/// <summary>Small configuration seam to keep infrastructure independent of ASP.NET.</summary>
public interface IConfiguration
{
    string? GetConnectionString(string name);
}
