# Cubix

A 3D endless-runner built in Unity. The player character moves forward automatically and dodges obstacles by strafing left and right; hitting an obstacle ends the run, and reaching the end of the track completes the level.

## Gameplay

- **Auto-forward movement** — the player is continuously pushed forward with a rigidbody force.
- **Strafing** — `A` / `D` move the player sideways to dodge obstacles.
- **Obstacles** — colliding with an obstacle disables player control and ends the game.
- **Scoring** — distance traveled along the track is shown as the live score.
- **Level flow** — a start menu, an in-game HUD, a level-complete screen, and a restart/credits flow.

## Project structure

```
Assets/
  Scripts/          Gameplay code (see below)
  Scenes/           Unity scenes
  Settings/          Render pipeline (URP) settings
  TextMesh Pro/      TMP assets used for UI text
Packages/            Unity package manifest
ProjectSettings/      Unity project configuration
```

### Scripts

| Script | Responsibility |
|---|---|
| `PlayerMovement.cs` | Applies constant forward force and handles left/right strafing input. |
| `PlayerCollision.cs` | Detects collisions with obstacles and ends the run. |
| `GameManager.cs` | Tracks game-over/level-complete state and restarts the scene. |
| `EndTrigger.cs` | Marks the finish line and signals level completion. |
| `LevelComplete.cs` | Loads the next level from the level-complete screen. |
| `FollowPlayer.cs` | Keeps the camera following the player. |
| `score.cs` | Displays the player's distance traveled as the score. |
| `Menu.cs` | Starts the game from the main menu. |
| `Credits.cs` | Handles quitting the application from the credits screen. |

## Opening the project

1. Install [Unity Hub](https://unity.com/download) and a matching Unity Editor version (see `ProjectSettings/ProjectVersion.txt`).
2. Open this folder as a project from Unity Hub.
3. Open the main scene under `Assets/Scenes` and press Play.

## Notes

This started from Unity's default 3D URP template and was built out into a small runner game as a learning project. Editor-generated folders (`Library/`, `Temp/`, `obj/`, `Logs/`, `UserSettings/`) and IDE project files are intentionally excluded via `.gitignore` — Unity regenerates them automatically when the project is opened.
