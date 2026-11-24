# Video Game Mod Development Standards

## 1. Primary Objective

Build reliable, maintainable mods for video games. Organize work under a clearly named game folder, with each mod in its own named child folder. A game's exported files may be stored in a sibling `Game Files` folder for reference; they are not mod source.

Treat the requirements of each game and individual project as authoritative when they differ from these general standards. Do not assume a mod for one game version, Unity runtime, or loader will work with another.

## 2. Project Setup and Compatibility

- Identify and document the target game, game version, platform, Unity version when relevant, scripting backend (Mono or IL2CPP), mod loader, and loader version.
- For BepInEx projects, follow the conventions and APIs for the target BepInEx generation and runtime. Do not mix Mono and IL2CPP setup without a clear reason.
- Match the project's target framework and compiler settings to the game's runtime and loader requirements.
- Prefer official loader documentation and existing project conventions over assumptions or outdated examples.
- Keep game-specific assemblies and other locally obtained proprietary files out of source control unless the user has confirmed they may be redistributed.
- Treat exported game files as reference material. Do not edit them as part of a mod change or copy them into the mod project unless explicitly needed and permitted.
- Keep each mod's source, build files, documentation, and tests within that mod's own folder.
- Keep build output, generated files, and local game paths out of source control.
- Make game paths, loader paths, and other machine-specific settings configurable rather than hardcoding one developer's setup.

## 3. Code Quality

- Use C# for Unity/BepInEx mods unless the project or target loader requires another language.
- Keep changes focused and preserve existing behavior unrelated to the request.
- Use clear names, small cohesive methods, and the project's existing formatting and architecture.
- Avoid unnecessary dependencies. Document required libraries and their versions.
- Handle expected game state and lifecycle variation, such as scenes or objects not being ready yet.
- Avoid expensive work on per-frame callbacks when event-driven or less frequent work is suitable.
- Ensure patches and hooks are scoped, reversible where possible, and removed or cleaned up when their owning component is disposed.
- Log actionable errors and useful diagnostics without flooding the game log.
- Do not silently hide initialization or runtime failures.

## 4. Game Lifecycle and Runtime Behavior

- Understand when the mod is loaded, when scenes change, and when game objects are created or destroyed.
- Avoid assuming a game object, component, method, or asset is always present.
- Prevent duplicate hooks, event subscriptions, coroutines, and spawned objects during reloads or scene transitions.
- Keep Unity API access on the appropriate thread; do not call Unity APIs from background threads unless the game and API explicitly support it.
- Release owned resources and unsubscribe from events when appropriate.
- Use reflection or Harmony patches only when needed, and keep targets narrow and resilient to game updates.
- Do not patch unrelated game behavior or weaken the game's security mechanisms.

## 5. Configuration, Persistence, and Privacy

- Prefer the mod loader's configuration and logging facilities when available.
- Give configuration entries clear names, descriptions, and safe defaults.
- Validate user configuration and persisted data before using them.
- Keep saved data local by default, version its format when appropriate, and avoid destructive migrations.
- Do not collect or transmit user or game data externally unless explicitly required and clearly disclosed.
- Never commit credentials, private tokens, or machine-specific paths.

## 6. Compatibility and Distribution

- State supported game, loader, runtime, and mod versions in the project documentation.
- Avoid claiming compatibility with versions that have not been checked.
- Keep source code separate from release packages and do not include private game files.
- Include installation, configuration, dependency, and removal instructions for distributable mods.
- Do not bundle third-party assets or libraries unless their licenses permit redistribution; retain required notices.
- Follow the game's terms, modding policy, and any relevant platform rules. Do not add cheats, anti-cheat bypasses, or features intended to give an unfair advantage in online play.

## 7. Testing and Delivery

- Build with the project's configured tooling and run relevant tests when available.
- Test in the target game and runtime when practical; distinguish build verification from in-game verification.
- Check the game log for load errors, missing dependencies, and runtime exceptions.
- Do not claim a mod was tested in-game unless it was actually run in the target environment.
- For bug fixes, identify the failure mode, preserve unrelated behavior, and provide concise steps to verify the result.
- When a requested change affects installation or configuration, update the project documentation as part of the change.

## 8. Project-Specific Requirements

Before modifying an existing mod:

1. Read the project's documentation and relevant source files.
2. Confirm its target game/runtime/loader and current build setup.
3. Identify the cause of the issue where possible.
4. Preserve behavior unrelated to the request.
5. Apply the project's requirements and update related documentation.
6. Build and run the narrowest relevant tests or checks.
7. State what was verified and any remaining in-game testing needed.

When project requirements conflict with these general standards, follow the user's most recent explicit instruction unless it conflicts with the game's rules, a license, or platform requirements. Explain important compatibility or distribution trade-offs.
