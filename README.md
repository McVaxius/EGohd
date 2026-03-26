# Eyes of Gohd

Dalamud plugin workspace for `Eyes of Gohd`.

## Current Status

Bootstrap scaffold created on 2026-03-25. This repo now has a buildable `Debug x64` shell with command routing, Ko-fi placement, DTR support, icon assets, and repo-ready documentation.

- Solution: `Z:\EGohd\EGohd.sln`
- Project: `Z:\EGohd\EGohd\EGohd.csproj`
- Command: `/egohd`
- Repository target: `Public`

## Plugin Concept

- PvP-only long-range player tags.
- Start with display-only scaffolding.
- Keep the backend swappable if nameplate APIs drift.

## Planned Services

- PvpContextService
- NameplateTagService
- RuleEngine

## Documents

- Project plan: `Z:\xa-xiv-docs\Dhog\EGohd\EGOHD_PROJECT_PLAN.md`
- Knowledge base: `Z:\xa-xiv-docs\Dhog\EGohd\EGOHD_KNOWLEDGE_BASE.md`
- Import guide: `how to import plugins.md`
- Changelog: `CHANGELOG.md`

## Notes

- Icon assets live in `images\iconHQ.png` and `images\icon.png`.
- SamplePlugin references used for the initial shell: https://github.com/goatcorp/SamplePlugin and https://github.com/goatcorp/SamplePlugin/blob/master/README.md
