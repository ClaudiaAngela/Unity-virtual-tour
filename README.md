# Unity Virtual Tour (360° Interactive Experience)

An interactive virtual campus tour application developed in **Unity** and **C#**, providing an immersive 360° exploration of academic spaces with dynamic navigation and camera controls.

---

## Overview

The application simulates a seamless virtual visit through panoramic photographic spheres and custom UI mechanics. Users can look around in full 360 degrees, inspect environmental details, and transition smoothly between distinct locations across the campus.

### Key Features
* **360° Spherical Panoramic Environments:** High-resolution equirectangular texture mapping for realistic indoor navigation (library, study halls, administrative and tech offices).
* **Teleportation System:** Interactive on-screen UI buttons enabling instant transitions between different rooms and viewpoints.
* **Dynamic Camera Zoom & Rotation:** Smooth camera manipulation via mouse drag and real-time field-of-view (FOV) adjustment to inspect fine details.
* **Modern Input Handling:** Configured with Unity's new Input System for cross-platform responsiveness.

---

## Project Structure

```text
Unity-virtual-tour/
├── Assets/
│   ├── Panorame/                  # 360° panoramic textures and materials
│   ├── Scenes/                    # Unity scene files (e.g., Scena1.unity)
│   ├── Settings/                  # Render pipeline & project preset configurations
│   ├── TextMesh Pro/              # High-quality UI typography assets
│   ├── TutorialInfo/              # Project metadata & documentation assets
│   ├── InputSystem_Actions.inputactions  # Custom input mapping profiles
│   └── RotireCamera.cs            # Camera rotation and interaction logic script
├── Packages/                      # Package manager dependencies and manifests
└── ProjectSettings/               # Engine settings, tags, layers, and player builds
```
## Tech Stack & Requirements

* **Engine:** Unity 6 (6000.x) / Unity 2022+ LTS
* **Scripting Language:** C# (.NET / Mono)
* **Render Pipeline:** Universal Render Pipeline (URP) / Built-in Forward Renderer (DirectX 11 / OpenGL)

---

## Getting Started

### 1. Clone the Repository
```bash
git clone [https://github.com/claudiajakab22/Unity-virtual-tour.git](https://github.com/claudiajakab22/Unity-virtual-tour.git)
```
### 2. Open in Unity
1. Launch **Unity Hub**.
2. Click **Add** -> **Add project from disk**.
3. Select the cloned `Unity-virtual-tour` folder.
4. Open the project using **Unity 6** (or compatible 2022/2023 LTS version).

### 3. Running the Tour
1. In the Project window, navigate to `Assets/Scenes/`.
2. Double-click **`Scena1.unity`** to load the main scene.
3. Press the **Play** button ($\blacktriangleright$) at the top of the Unity Editor to start exploring.

---

## Controls

* **Mouse Drag / Look:** Look around the 360° environment in all directions (handled by `RotireCamera.cs`).
* **Teleportare Button:** Switch between connected campus rooms and perspectives.
* **Zoom Button:** Toggle camera zoom to inspect fine scene details.
