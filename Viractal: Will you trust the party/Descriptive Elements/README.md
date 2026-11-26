# Descriptive Elements

Mod project for **Viractal: Will you trust the party?**

## Features

- **Event outcome disclosure** — Displays a topmost-screen toast when an event grant is applied, including items, currency, EXP, DP, HP, speed, drop-rank, conditions, and abilities. It also shows the choice index and whether the outcome is generally good, bad, or neutral; signed numeric grant deltas are classified by whether they increase or decrease the resource.
- **Event outcome previews** — Saves observed grants locally and displays cached results next to event choices when the same script choice appears again. Unobserved choices and dice results are marked unknown; dice and battle indicators are recorded when those script commands run.
- **EXP counter** — Shows each party member's current EXP and the requirement for the next level in a topmost-screen label aligned to that player's red, blue, or green profile slot. The colored backgrounds are translucent, and the counters are hidden during battles and battle results.

## Compatibility

- Game: Viractal: Will you trust the party?
- Unity: 6000.3.12f1 (Unity 6)
- Scripting backend: IL2CPP
- Loader: BepInEx 6 IL2CPP (Bleeding Edge build 793, Windows x64)
- Runtime: .NET 6
- Patching: HarmonyX

The game is IL2CPP. The previous BepInEx 5 Mono package and Mono plugin entry point are not compatible with it. IL2CPP support is distributed in BepInEx Bleeding Edge builds; the checked-in `Mod Package` is the Windows x64 build.

## Install

1. Back up the game folder.
2. Remove the old Mono BepInEx installation and its Doorstop files before installing the IL2CPP build. Do not mix the old `BepInEx` folder or `winhttp.dll` with the new files.
3. Extract the contents of `Mod Package` into the game root. It contains the official [BepInEx Unity IL2CPP Windows x64 build](https://builds.bepinex.dev/projects/bepinex_be/793/BepInEx-Unity.IL2CPP-win-x64-6.0.0-be.793%2Bdbc82f0.zip) and the built mod DLL.
4. Run the game once and let BepInEx finish generating its IL2CPP interop assemblies. This first launch may take longer than usual; the plugin should load after generation completes.
5. Check `BepInEx/LogOutput.txt` for the plugin's initialization message.

For a native Linux game, install the matching `Unity.IL2CPP-linux-x64` BepInEx build instead of the Windows archive. For a Windows game running under Proton, use the Windows x64 package and set the Steam launch option to `WINEDLLOVERRIDES="winhttp=n,b" %command%`.

## Build

Install the .NET 6 SDK. The project uses the IL2CPP loader assemblies from the included `Mod Package` and resolves game APIs through reflection, so exported game assemblies are not needed to compile.

From `Project Files`, run:

```sh
dotnet build -c Release
```

The build references the loader from `Mod Package/BepInEx`. To build against a separate loader installation, pass `-p:BepInExDir="/path/to/BepInEx"`. On success, the DLL is copied into `Mod Package/BepInEx/plugins/DescriptiveElements/`.

On Linux, this repository's game directory contains a colon, which can break MSBuild's generated import paths with SDK 10. If that happens, use a colon-free intermediate directory:

```sh
dotnet build -c Release -p:MSBuildProjectExtensionsPath=/tmp/descriptive-elements-obj/
```

## Configuration

The plugin writes `BepInEx/config/com.kdubaz.descriptiveelements.cfg` on first load.

| Setting | Default | Meaning |
|---|---:|---|
| General > EnableEventOutcomes | true | Show an outcome toast when an event grant is applied. |
| General > EnableEventDiagnostics | false | Log choice labels, nearby script bytes, and up to 16 distinct interpreter positions after selection. Enable only for offline/single-player diagnostics; turn off for multiplayer. |
| General > EnableEventPreviews | true | Show cached event outcomes and save observed grants in `BepInEx/config/DescriptiveElements.EventCache.json`. |
| General > EnableExpCounter | true | Show the per-character EXP overlay. |
| UI > ExpCounterX | 10 | Horizontal offset from each profile portrait (screen fraction × 1000). |
| UI > ExpCounterY | 10 | Vertical offset from each profile portrait (screen fraction × 1000). |
| UI > GrantToastDuration | 5 | Seconds the grant toast remains visible. |

## Known limitations

- Patch targets are discovered from the game's generated IL2CPP interop assemblies by type and method signature. Game updates can rename or change these targets; review `BepInEx/LogOutput.txt` for patch warnings.
- The next-level requirement is read from `CMaster_CharLevel.GetData(level)`. If the master data is unavailable, the counter shows `?`.
- Battle outcomes are initiated outside `CEventGrant` and are not individually itemized.
- EXP counter visibility follows whether the battle or battle-results Canvas is enabled and active, rather than relying on static battle flags that may be stale during new-game startup. Game updates that change these APIs may require a patch adjustment.
- Event outcomes are reported after a choice is confirmed and the grant is applied; the mod does not currently predict outcomes beside each option before selection.
- Preview data is learned from choices that have actually been played and is stored in `BepInEx/config/DescriptiveElements.EventCache.json`. Outcomes and dice/battle indicators for unobserved branches remain unknown; the cache does not claim to reveal every possible result.
- For event-preview research, enable `General > EnableEventDiagnostics` only in an offline/single-player session, play until several different event choice menus appear, and send `BepInEx/LogOutput.log`. Diagnostics record choice labels, a small script-byte window, and up to 16 distinct script positions after selection. Do not use diagnostics in multiplayer; logging while the game is executing synchronized event scripts can cause timing problems.
- Counter positions use fixed screen anchors aligned to the red, blue, and green profile slots. This avoids dependence on variable character portraits or camera projection.
- The plugin's runtime behavior still needs to be verified in-game after installing the IL2CPP loader.

## Project files

- `Project Files/Plugin.cs` — BepInEx IL2CPP entry point and UI logic.
- `Project Files/EventOutcomePatches.cs` — Harmony patches for event grants and choices.

Generated build output, machine-specific paths, and exported/proprietary game assemblies are not source files and are not included.
