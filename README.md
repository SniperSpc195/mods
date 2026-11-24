# Game Mods

This folder is for video game mod projects, including Unity mods built with BepInEx. Projects are organized first by game, then by mod. Keep them separate from the JavaScript userscripts in `personal/` and `torn-scripts/`.

## Organization

Each game gets a folder. Exported game files, if present, live in a clearly named `Game Files` folder inside it. Each mod gets its own sibling folder; put all source and project files for that mod inside its folder.

```text
mods/
  <game-name>/
    Game Files/                 # Exported game files; reference only
    <mod-name>/                  # Mod source and project files
      README.md
      <source and project files>
    <another-mod-name>/
      README.md
      <source and project files>
```

For example:

```text
mods/
  Viractal: Will you trust the party?/
    Game Files/
    Descriptive Elements/
      README.md
      <mod files>
```

Do not place mod source inside `Game Files`, or copy exported game files into a mod project unless needed and permitted. Treat exported game files as local reference material, not mod source or distributable content.

## Unity and BepInEx projects

For each project, document the target game and version, Unity/runtime details when known, BepInEx version and flavor (Mono or IL2CPP), build instructions, dependencies, installation, and known limitations. Keep project files and build settings appropriate to the game's runtime; do not assume one Unity or BepInEx setup works for every game.

Do not commit generated build output, machine-specific paths, or proprietary game assemblies. Check the game's modding policy and third-party licenses before distributing a mod or its dependencies.

See [AGENTS.md](./AGENTS.md) for development and compatibility guidelines.
