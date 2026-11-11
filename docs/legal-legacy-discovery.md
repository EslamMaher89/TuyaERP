# Legal module: first legacy discovery notes

## What is present

- `court/frm/new_master.txt` is a text export of Oracle Forms module `NEW_MASTER`.
- Its first navigation block and query data source are both named `LAWSUIT_MSTER`.
- The master block exposes case identifiers and organization fields such as `QUIDA_NO`, `MSLSL`, `YEAR`, `COMPANY_NO`, and `BRANCH_NO`, plus type, opponent, description, court, and next-session fields.
- The form contains related blocks named `LAWSUIT_MSTER_LAWER_LAWSUIT`, `LAWSUIT_MSTER_DISCORD`, `LAWSUIT_MSTER_COMMAND`, `LAWSUIT_MSTER_EXECUITION`, and `LAWSUIT_MSTER_SESSION_1`.
- The related session block uses `SESSION_1`; visible columns include `DATE_SESSION`, `QUIDA_NO`, `DATE_NEXT`, `MSLSL_SEESION`, `KIND_COURT`, `CIRCLE_NO`, `HAPPEN`, and `COD_RESON`.
- A button trigger deletes and reinserts a `SESSION_1` row when updating the next hearing (`MOIZ=1`). This is a business rule that needs confirmation before porting.
- Related Forms/Reports files include `QADIA_LAWYRS`, `QADIA_EXECUTION`, `QADIA_DISCORD`, `QADIA_COMMAND`, `SESSIONS`, lawyer forms, and legal reports. Their exact workflows still need source-level inspection.

## Migration guardrails

1. Treat all field mappings as provisional until checked against Oracle data dictionary metadata and the production schema owner.
2. Keep Oracle as the source of truth during the first migration slice. Do not generate schema changes or production migrations.
3. Start with read-only case search and detail, compare results with Oracle Forms, then scope writes separately.
4. Preserve company and branch scope in every query and authorization decision.
5. Do not enable the current API case endpoint until Oracle provider/configuration, query mapping, and authorization are reviewed.

## Open discovery items

- Oracle version, schema name(s), and how the 27 factories map to company/branch keys.
- Primary and foreign keys, actual column types, constraints, indexes, views, synonyms, and grants for the identified tables.
- Trigger/program-unit source and LOV/query definitions for the related blocks.
- User roles and data visibility rules, including central-office access.
- Which legal functions are in the first release: cases, sessions, lawyers, objections, notices, execution, documents, and reports.
- Whether documents are stored in Oracle, a file share, or another document service.
