# Descriptive Elements

Mod project for **Viractal: Will you trust the party?**

This folder holds the source and project files for the **Descriptive Elements** mod. The exported game files are kept separately in the sibling `Game Files` folder and are reference material, not part of this mod project.

## What this mod does

1. **Event outcome disclosure** — When an event choice is resolved, an on-screen toast tells you exactly what the choice granted: items, gold, EXP, DP, HP, speed, drop-rank (skill/item/ability/money), conditions, abilities, etc., plus whether the outcome is generally good, bad, or neutral. The last choice index is tracked so you can tell which pick led to the grant.
2. **EXP counter** — A per-character counter showing `EXP <current> / <required>` (current EXP and EXP required for the next level) for each party member. Each counter is anchored just below that character's portrait (top-left of the panel), small enough to be read, and allowed to overlap the portrait picture. Falls back to a compact corner list if portrait panels can't be found.

## Target platform

- Game: Viractal: Will you trust the party?
- Unity: 6000.3.12f1 (Unity 6)
- Scripting backend: IL2CPP
- Mod loader: BepInEx 5 (IL2CPP flavour)
- Language: C# (.NET Standard 2.0)
- Patching: HarmonyX

## Build instructions

1. Install the .NET SDK (https://dotnet.microsoft.com) — this project targets `netstandard2.0`.
2. Copy the following DLLs from the game into a `libs/` subfolder next to the `.csproj`:
   - `<game>/BepInEx/core/BepInEx.dll`
   - `<game>/BepInEx/core/0Harmony.dll`
   - `<game>/Game Files/AuxiliaryFiles/GameAssemblies/UnityEngine.CoreModule.dll` (as `UnityEngine.dll`)
3. Build (`dotnet build -c Release`). The output is `DescriptiveElements.dll`.
4. Copy `DescriptiveElements.dll` into `<game>\BepInEx\plugins\DescriptiveElements\` (create the folder). Do **not** copy BepInEx/Harmony/UnityEngine/Assembly-CSharp — those are provided by the game/loader at runtime.

## Configuration

Config is written to `<game install>\BepInEx\config\DescriptiveElements.cfg` on first launch:

| Setting | Default | Meaning |
|---|---|---|
| General > EnableEventOutcomes | true | Show grant/outcome toast when event choices are resolved. |
| General > EnableExpCounter | true | Show the per-character EXP counter overlay. |
| UI > ExpCounterX | 10 | Horizontal offset of the fallback EXP list (screen fraction * 1000); only used when portrait anchoring fails. |
| UI > ExpCounterY | 10 | Vertical offset of the fallback EXP list (screen fraction * 1000); only used when portrait anchoring fails. |
| UI > GrantToastDuration | 5 | Seconds the grant-outcome toast stays on screen. |

## How to use

- Play normally. When an event choice resolves, a toast appears near the top of the screen describing what was granted.
- The EXP counter shows `EXP <current> / <required>` for each party member, anchored just below that character's portrait; falls back to a corner list otherwise.
- Both features can be toggled in the config file.

## Known limitations

- This mod was written against the decompiled signatures of `Assembly-CSharp.dll`. Method/field names are taken from the exported source, but method **bodies** are not available here, so patch targets are matched by signature only. If a game update renames a method or changes a signature, a patch may silently stop applying — check the BepInEx console/log on launch.
- The EXP "next level" requirement is read from `CMaster_CharLevel.GetData(lv)`. If that master asset is not loaded or returns null for a level, the counter shows current level/EXP and marks "next" as unavailable.
- "Battle" outcomes are triggered through the game's battle-launch flow rather than `CEventGrant`, so they are not individually itemized in the grant toast. The toast covers everything `CEventGrant` produces (items, gold, EXP, DP, HP, speed, drop-rank, conditions, abilities).
- Portrait anchoring depends on finding `CUICharacterStatus` instances at runtime; if that type or its instances can't be located, counters fall back to the corner list positioned by `ExpCounterX`/`ExpCounterY`.
- Tested only by code review against the exported source; not yet run in the target game. Verify in-game after building.

## Project structure

```
Descriptive Elements/
  README.md                 (this file)
  Descriptive Elements.csproj
  libs/                     (build dependencies — copy game DLLs here; not in source)
    BepInEx.dll
    0Harmony.dll
    UnityEngine.dll         (game's UnityEngine.CoreModule.dll renamed)
  Plugin.cs                 (BepInEx entry point + config + Harmony setup + EXP counter UI)
  EventOutcomePatches.cs    (Harmony patches for CEventGrant/CEventChoices)
```

Build output, machine-specific paths, and the game's proprietary assemblies are intentionally not included here.

