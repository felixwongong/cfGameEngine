# Project

## What we are building

`cfGameEngine` is a shared C# game-engine library used by CatSweeper. Verified contents: a `gameitem` module, a companion source generator (`cfGameEngine.Generator`), and a test project (`cfGameEngine.Test`).

## Stack

| Layer | Choice | Notes |
|---|---|---|
| Language | C# | .NET 8 |
| Dependencies | cfEngine | Imported as Git subtree |
| Consumers | CatSweeper | Imported as Git subtree |
| Solution | `cfGameEngine.sln` | Build with `dotnet build` |

## Module map

Verified project layout:

| Project | Contents |
|---|---|
| `cfGameEngine/` | Runtime library; currently contains `gameitem/` |
| `cfGameEngine.Generator/` | Source generator for the `gameitem` module |
| `cfGameEngine.Test/` | Tests for the generator/runtime |

## Domain in one paragraph

The library hosts game-domain systems that are too specific for `cfEngine` but shared across games. Today its primary resident is the game-item system plus its generator. Exact scope beyond `gameitem` is TBD — see `pending.md` before assuming.

## Non-obvious constraints

- Checked out inside CatSweeper as a Git subtree at `Modules/cfGameEngine/`. Only the programmer/owner pushes changes back to `https://github.com/felixwongong/cfGameEngine.git` via `Tools/subtree.ps1`.
- Any breaking change must be coordinated with `dotnet build CatSweeper.sln`.

## CatSweeper usage

CatSweeper references this library directly. Edits here require a subtree push.

See CatSweeper's `.agent/systems/subtrees.md` for the subtree workflow.
