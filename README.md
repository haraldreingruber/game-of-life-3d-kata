# Game of Life 3D TDD Kata (Unity3d)

This projects implements a game logic stub and the Visualization for Conveys Game of Life using a 3D grid.

## Requirements

* Unity 2019.2.12 (or newer)
* [IDE](https://docs.unity3d.com/Manual/ScriptingToolsIDEs.html)
  * JetBrains Rider
  * Visual Studio
  * Visual Studio Code

## Rules (proportionally adapted for 3D Grid with 26 neighbor cells)

1. Any alive cell with fewer than six live neighbors dies. ("Underpopulation")
1. Any alive cell with six to ten live neighbors lives on to the next generation. ("Survival")
1. Any alive cell with more than ten live neighbors dies. ("Overcrowding")
1. Any dead cell with nine or ten live neighbors becomes a live cell. ("Birth")

*Note:* The current numbers are an idea/suggestion for the first proof-of-concept. Please, let me know how they work for you?

## Where to start?

Clone this project, open it in Unity and hit the play button to see the provided grid visualization. Add/modify test cases in the folder `Assets/Tests/`. Replace `Assets/GameOfLifeProcessorStub.cs` with the actual game logic.

## License

Except where otherwise stated (see [Third-party Assets](Assets/Third-party%20Assets/)), this code is:
MIT License

## :pray: Credits

Thanks for supporting this project by allowing me to use your Unity Asset:
* [@korveen_o](https://korveen.github.io/): [LowPoly Environment Pack](https://assetstore.unity.com/packages/3d/environments/landscapes/lowpoly-environment-pack-99479)
* [@AurynSky](https://twitter.com/AurynSky): [Simple Gems Ultimate Animated Customizable Pack](https://assetstore.unity.com/packages/3d/props/simple-gems-ultimate-animated-customizable-pack-73764)

