## 2025-08-26 — M1 / Dockerized Postgres

**Goals**: run local Postgres for dev.

**Done**: compose file + .env; container is healthy; psql check OK.

**Decisions**: db=user=mediacatalog/mediacat; port 5432 (or 5435 if needed).

**Issues**: —

**Commands**: docker compose up -d

**Next steps**: add EF Core + Npgsql + AppDbContext (Task 3).


## 2025-08-22 — M1 / Solution skeleton + Postgres

**Goals**: create solution with 4 projects; spin up Postgres via Docker.

**Done**: created MediaCatalog.sln (Api, Application, Infrastructure, Domain); `dotnet build` OK; Postgres running in Docker.

**Decisions**: use snake_case in PG; keep secrets in .env.

**Issues**: —

**Commands**: `docker compose up -d`; `dotnet new sln`...

**Next steps**: add Npgsql + AppDbContext; initial migration.


## YYYY-MM-DD — Milestone X / Short title
**Goals for this session**
- ...

**Done**
- ...

**Decisions / Rationale**
- Chose X over Y because ...
- Config Z: ...

**Issues / Blockers**
- Symptom:
- What I tried:
- Logs / error:

**Commands / Artifacts**
- Commands: `...`
- Links / screenshots:

**Next steps**
- ...
