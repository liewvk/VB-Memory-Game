# VB Memory Game

A simple memory-matching card game built with Visual Basic .NET and Windows Forms.

This project is based on the chapter exercise from "VB Game Programming Chapter 25" and implements a classic card-flip game where the player matches pairs of symbols to clear the board.

## Features

- 12-card matching board
- Randomized card placement each game
- Attempt counter and match counter
- Start and restart controls
- Win message when all pairs are found
- Simple Windows Forms interface

## Project files

- `Form1.vb` — game logic and event handlers
- `Form1.Designer.vb` — form layout and controls
- `Form1.resx` — form resource data
- `Memory Game.vbproj` — project configuration
- `Memory Game.slnx` — solution file
- `My Project/` — VB application settings

## Requirements

- Windows 10 or later
- Visual Studio 2022 or a compatible .NET development environment
- .NET 10 SDK for Windows (the project targets `net10.0-windows`)

## Running the game

### Option 1: Visual Studio

1. Open `Memory Game.slnx` in Visual Studio.
2. Restore NuGet packages if prompted.
3. Set the project as the startup project.
4. Press `F5` to run the application.

### Option 2: Command line

From the repository root, run:

```bash
dotnet build "Memory Game.vbproj"
```

Then open the generated executable from the build output or run it from your IDE.

## Gameplay

- Click `Start` to begin a new round.
- Click two cards to reveal them.
- Matching cards stay visible.
- Non-matching cards briefly flip back over.
- Clear the board to win.

## Notes

This repository does not currently include a license file. If you intend to distribute or reuse the code publicly, consider adding one that matches your intended usage.
