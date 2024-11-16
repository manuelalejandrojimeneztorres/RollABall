# Roll-a-Ball 3D Game

A classic 3D game built with Unity 2022.3.50f1 and C#, based on Unity's beginner-friendly "Roll-a-Ball" tutorial. This project is designed to enhance the original game experience with new player controls, sound effects, and accessibility features. Follow the instructions below to set up and explore the game on your own system.

## Table of Contents

- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Features](#features)
- [Built With](#built-with)
- [License](#license)
- [Acknowledgments](#acknowledgments)

## Getting Started

These instructions will guide you through cloning the project and running it on your local machine for development, testing, or gameplay.

### Prerequisites

To successfully run this project, ensure you have:

- [Unity 2022.3.50f1](https://unity.com/releases/2022-lts) - The Unity editor version required to open and build the project.
- [Git](https://git-scm.com/downloads) - To clone the project repository.
- Optional: [Visual Studio](https://visualstudio.microsoft.com/) or [Rider](https://www.jetbrains.com/rider/) - For editing and debugging C# code.

[🔼 Back to Top](#table-of-contents)

### Installation

1. **Clone the Repository**

   Clone this repository to your local machine using Git:

   ```bash
   git clone https://github.com/manuelalejandrojimeneztorres/RollABall.git
   ```

2. **Open the Project in Unity**

   - Launch Unity Hub, select **Open Project**, and navigate to the cloned directory.
   - Choose **Unity 2022.3.50f1** as the project version if prompted.

3. **Run the Game**

   - In the Unity Editor, open the main scene (`Assets/Scenes/StartMenu.unity`).
   - Press **Play** to test the game within the Unity Editor.
   - Alternatively, you can build the project for different platforms via **File > Build Settings**.

[🔼 Back to Top](#table-of-contents)

## Features

The Roll-a-Ball game has been enhanced with the following functionalities:

1. **Jump Height Restriction** - The player’s jump is capped to stay within the game plane, preventing unintended exits. Additionally, the player can only perform a jump when in contact with the ground. This mechanic ensures that the player cannot jump indefinitely and exit the game plane.
2. **Keyboard Shortcuts for Scene Navigation** - Quick and convenient keyboard shortcuts allow smooth transitions between game scenes.
3. **Key-Specific Player Actions** - Keybindings for actions enhance accessibility and compatibility across different devices.

| Keyboard Shortcut | Action         |
| ----------------- | -------------- |
| `Space`           | Jump           |
| `Escape`          | Pause the game |

4. **Collision Sound Effects** - Added immersive sound effects trigger on each collision event, enhancing game feedback.
5. **Button Controls** - Button-based actions streamline gameplay, improving flow and responsiveness.

| Button       | Action                                           |
| ------------ | ------------------------------------------------ |
| `Resume`     | Resume the game                                  |
| `Restart`    | Restart the game                                 |
| `Next Level` | Go to the next level (if it is not the last one) |
| `Start Menu` | Go to the start menu                             |

[🔼 Back to Top](#table-of-contents)

## Built With

- **Unity 2022.3.50f1** - The core game development engine used.
- **C#** - The programming language for scripting gameplay mechanics and features.
- **Git** - Version control for project management and collaboration.
- **Visual Studio / Rider** - Recommended editors for C# code development and debugging.

[🔼 Back to Top](#table-of-contents)

## License

This project is licensed under the Apache License, version 2.0 - see the [LICENSE](LICENSE) file for details.

[🔼 Back to Top](#table-of-contents)

## Acknowledgments

- **Tiburcio Cruz Ravelo** - Special thanks to my instructor, [Tiburcio Cruz Ravelo](https://github.com/tcrurav), for his guidance and support throughout the development of this project.
- **Unity Technologies** - For providing the original "Roll-a-Ball" tutorial and resources.
- **PurpleBooth** - For the README template, which greatly influenced the structure of this documentation. See the original gist [here](https://gist.github.com/PurpleBooth/109311bb0361f32d87a2).

[🔼 Back to Top](#table-of-contents)
