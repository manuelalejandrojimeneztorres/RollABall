# Roll-a-Ball 3D VR Game

An enhanced version of the classic _Roll-a-Ball_ game, now featuring **Virtual Reality (VR)** integration and a multi-level gameplay experience. Built using **Unity 2022.3.50f1**, this project leverages modern VR technologies, including **XR Interaction Toolkit**, **OpenXR**, and **XR Plug-in Management**, to deliver immersive gameplay with advanced VR functionalities such as teleportation, locomotion, object interaction, and gesture controls.

## Table of Contents

- [Project Description](#project-description)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Features](#features)
  - [Core Game Mechanics](#core-game-mechanics)
  - [Virtual Reality Features](#virtual-reality-features)
- [Built With](#built-with)
- [License](#license)
- [Acknowledgments](#acknowledgments)

---

## Project Description

This project extends the _Roll-a-Ball_ game into a full-fledged VR experience with four challenging levels, culminating in a **VR-enabled Level 4**. Players can interact with the environment using VR controllers, explore the game world with teleportation and smooth locomotion, and engage with objects dynamically using XR technologies. Whether you’re a gamer or a VR enthusiast, this project provides an engaging platform to experience advanced Unity VR development.

[🔼 Back to Top](#table-of-contents)

---

## Getting Started

Follow these steps to clone, build, and explore the project on your local machine.

### Prerequisites

Ensure the following tools are installed on your system:

- **Unity 2022.3.50f1**  
  Download from [Unity's official website](https://unity.com/releases/2022-lts).
- **Git**  
  Download from [Git's official website](https://git-scm.com/downloads).
- **VR Headset**  
  Compatible with OpenXR (e.g., Oculus Quest, HTC Vive, etc.).
- Optional: **Visual Studio** or **JetBrains Rider**  
  For editing and debugging C# scripts.

[🔼 Back to Top](#table-of-contents)

---

### Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/manuelalejandrojimeneztorres/RollABallVR.git
   ```

2. **Open the Project in Unity**

   - Open **Unity Hub** and select **Open Project**.
   - Navigate to the cloned directory and select the project.
   - Ensure **Unity 2022.3.50f1** is selected as the project version.

3. **Configure Build Settings**

   - Go to **File > Build Settings** and select the desired platform (e.g., PC or VR-supported platforms like Android for Oculus).
   - Add all necessary scenes to the build.

4. **Run the Game**
   - Open the scene `Assets/Scenes/StartMenu.unity`.
   - Click **Play** in the Unity Editor or build the project to test it on your VR device.

[🔼 Back to Top](#table-of-contents)

---

## Features

### Core Game Mechanics

1. **Multi-Level Gameplay**
   - Four unique levels, each progressively challenging.
   - Collectible items to achieve level objectives.
2. **Enhanced Player Controls**

   - Restriction-based jumping to prevent unintended exits from the play area.
   - Keyboard shortcuts and UI buttons for accessible navigation.

3. **Immersive Audio Feedback**

   - Collision sound effects enhance the gaming experience.

4. **Accessible Gameplay**
   - Buttons for restarting levels, transitioning to the next level, and returning to the main menu.

| Button       | Action                       |
| ------------ | ---------------------------- |
| `Resume`     | Resume the game              |
| `Restart`    | Restart the current level    |
| `Next Level` | Transition to the next level |
| `Start Menu` | Return to the start menu     |

[🔼 Back to Top](#table-of-contents)

---

### Virtual Reality Features

**Available in Level 4:**

1. **Locomotion Systems**

   - Teleportation and continuous movement for navigating the environment.

2. **Interaction Features**

   - XR Ray Interactor for object interaction.
   - Snap Turn and Continuous Turn for rotation.
   - Object grabbing, manipulation, and throwing using VR controllers.

3. **Controller and Gesture Support**

   - Full VR controller support for actions like grabbing and rotating objects.
   - Hand gesture recognition for intuitive controls.

4. **Immersive XR Setup**
   - Configured with **XR Plug-in Management** and **OpenXR** for cross-platform compatibility.
   - **XR Rig** for accurate VR interaction.

[🔼 Back to Top](#table-of-contents)

---

## Built With

- **Unity 2022.3.50f1**  
  Game engine for 3D development.
- **XR Interaction Toolkit**  
  Provides XR-specific components and interaction systems.
- **OpenXR**  
  Ensures compatibility with various VR hardware.
- **C#**  
  Primary programming language for game logic and mechanics.
- **Git**  
  Version control for project management and collaboration.
- **Visual Studio / Rider**  
  Recommended IDEs for script editing and debugging.

[🔼 Back to Top](#table-of-contents)

---

## License

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for details.

[🔼 Back to Top](#table-of-contents)

---

## Acknowledgments

- **Unity Technologies**  
  For the original _Roll-a-Ball_ tutorial and XR tools.
- **Tiburcio Cruz Ravelo**  
  For mentorship and support throughout the project.
- **Microsoft Corporation**  
  For providing a robust development environment with Visual Studio 2022 Community Edition IDE.
- **OpenXR and XR Toolkit Documentation**  
  For detailed guidance on implementing advanced VR features.

[🔼 Back to Top](#table-of-contents)

---

Enjoy the immersive gameplay and explore the world of VR with **Roll-a-Ball VR**!  
Feel free to contribute to the project or share your feedback. Happy gaming! 🎮

[🔼 Back to Top](#table-of-contents)
