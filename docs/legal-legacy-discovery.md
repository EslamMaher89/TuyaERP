# Legal module: first legacy discovery notes

## What is present

- `court/frm/new_master.txt` is a text export of Oracle Forms module `NEW_MASTER`.
- Its first navigation block and query data source are both named `LAWSUIT_MSTER`.
- The master block exposes a three-column case relation key: `QUIDA_NO`, `MSLSL`, and `KIND_QUID`. It also carries `YEAR`, `DATA_DEAA`, `COMPANY_NO`, `BRANCH_NO`, `LSANA`, `KIND_MIULTY`, `KIND_KHSM`, `DESC_LAWSUIT`, `NOA`, `KIND_COURT`, `SUB_KIND`, `MAIN_KIND`, `KHASM_NAME`, `DATE_SESSION`, `CODE_DIS`, `MSLSL_COURT`, and `KIND_QUIDA`. These source names are preserved in the backend domain mapping; human labels for less clear fields need business confirmation.
- The form contains related blocks named `LAWSUIT_MSTER_LAWER_LAWSUIT`, `LAWSUIT_MSTER_DISCORD`, `LAWSUIT_MSTER_COMMAND`, `LAWSUIT_MSTER_EXECUITION`, and `LAWSUIT_MSTER_SESSION_1`.
- The text export provides detail columns for three additional blocks: `DISCORD` has `RKM_DISCORD`, `NAME_DISCORD`, and `NOTE`; `COMMAND` has `MSLSL_COMAND`, `COMMAND`, `DATE_COMMEND`, and `NOTE`; `EXECUITION` has `DATE_EXECUTION` and `TEXT_EXECTION`. All three join the case using `QUIDA_NO`, `MSLSL`, and `KIND_QUID`. The display labels used in the new screens are provisional because the source block names alone do not establish each department's business terminology.
- The related session block uses `SESSION_1`; visible columns include `DATE_SESSION`, the same case key, `DATE_NEXT`, `MSLSL_SEESION`, `KIND_COURT`, `CIRCLE_NO`, `HAPPEN`, `COD_RESON`, `CODE_SHIFT`, and `MOIZ`. The form's block query has `MOIZ=2`; the trigger that sets the current next-session row uses `MOIZ=1`. Keep these paths distinct pending confirmation of the code's business meaning.
- A button trigger deletes and reinserts a `SESSION_1` row when updating the next hearing (`MOIZ=1`). This is a business rule that needs confirmation before porting.
- Related Forms/Reports files include `QADIA_LAWYRS`, `QADIA_EXECUTION`, `QADIA_DISCORD`, `QADIA_COMMAND`, `SESSIONS`, lawyer forms, and legal reports. Their exact workflows still need source-level inspection.

## Legal screen coverage

- Cases, sessions, lawyers, and document archive are available as prototype screens.
- Objections (`DISCORD`), orders and decisions (`COMMAND`), and execution actions (`EXECUITION`) are available as read-only prototype screens with search and case-linked navigation.
- Prototype rows are fictional and clearly marked. No create, edit, delete, file upload, or Oracle operation is enabled.
- Binary `.fmb`/`.fmx` files are retained as source artifacts; additional triggers, LOVs, and report definitions require a readable Oracle Forms/Reports export before their behavior can be migrated accurately.

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
