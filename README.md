# TuyaERP modernization workspace

This workspace contains the legacy Oracle Forms/Reports files under `court/` and a new ASP.NET Core foundation alongside them.

## New solutions

- `ERP.Backend/ERP.Backend.sln`: API, application, domain, and infrastructure projects.
- `ERP.Frontend/ERP.Frontend.sln`: Razor Pages web application.
- `ERP.Tests/ERP.Tests.sln`: reserved for automated test projects after legacy contracts are validated.

The first migration slice is Legal Affairs. The Razor prototype uses clearly labeled fictional data so the screens and navigation can be reviewed. API case access and all writes remain disabled until Oracle schema and business rules are confirmed. See [the discovery notes](docs/legal-legacy-discovery.md).

## Current framework target

Projects target .NET 10 LTS. Install the .NET 10 SDK before building or running them.

## Configuration

No Oracle connection string or credentials are committed. Add `ConnectionStrings:LegacyOracle` to local user-secrets or an ignored local configuration file after the Oracle integration has been approved and implemented.
