# AR Wedding Invitation

Welcome to the AR Wedding Invitation project! This project showcases an innovative and interactive way to deliver wedding details using augmented reality technology. Guests can experience the joy of our special day through their devices, witnessing virtual elements that breathe life into our love story and event information. This guide will walk you through the process of setting up and running the AR Wedding Invitation application.

<p align="center">
  <img src="Demo.png" alt="AR Wedding Invitation" width="600">
</p>

## Video Preview

Get a glimpse of the AR Wedding Invitation experience by watching the video below:

<p align="center">
  <a href="https://youtu.be/MfpYFZWqypw">
    <img src="https://img.youtube.com/vi/MfpYFZWqypw/0.jpg" alt="AR Wedding Invitation Video" width="800">
  </a>
</p>
<p align="center">
  <em>Click the image above to watch the video.</em>
</p>

## Table of Contents

- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Usage](#usage)
- [Advanced Steps](#advanced-steps)
  - [Extracting Model Files](#extracting-model-files)
  - [Configuring Vuforia](#configuring-vuforia)
  - [Updating Targets](#updating-targets)
- [Troubleshooting](#troubleshooting)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

### Prerequisites

Before you begin, ensure you have the following:

- [Unity](https://unity.com/) installed on your machine.
- A compatible device for AR testing, such as a smartphone or tablet.

### Installation

1. Clone this repository to your local machine using the following command:
git clone https://github.com/YourUsername/AR-Wedding-Invitation-Project.git

2. Open UnityHub and add the project by selecting the folder where you cloned the repository.

### Usage

1. Launch Unity and open the AR Wedding Invitation project.
2. Navigate to the appropriate scene for the AR experience.
3. Set up your AR device or emulator for testing.
4. Build and run the project to enjoy the immersive AR Wedding Invitation.

## Advanced Steps

### Extracting Model Files

1. Locate the `Assets\Model\` directory within the project.
2. Extract the contents of `Stage (1).rar` and move the extracted files to `Assets\Model\`.

Repeat this process for the `Assets\Stage\` directory using the `Stage_F1inal.rar` file.

### Configuring Vuforia

If the Vuforia target has expired, follow these steps:

1. Visit the [Vuforia Developer Portal](https://developer.vuforia.com/).
2. Create a new target image or object.
3. Download the target database and import it into your Unity project.

### Updating Targets

If the AR Wedding Invitation targets have changed or expired, you can update them by:

1. Opening the Vuforia configuration within Unity.
2. Replacing the old target images or objects with the new ones.

## Building and Running the Android App

To experience the AR Wedding Invitation on your Android device, follow these steps to build and install the APK:

### Prerequisites

Before you begin, make sure you have the following:

- [Unity](https://unity.com/) installed on your computer.
- An Android device connected to your computer via USB.
- Developer Mode and USB Debugging enabled on your Android device.

### Exporting and Installing the APK

1. Open the Unity project of the AR Wedding Invitation on your computer.
2. Navigate to "File" > "Build Settings" in Unity.
3. In the Build Settings window, select the "Android" platform and click the "Switch Platform" button.
4. Configure other build settings, such as the package name and other preferences.
5. Click the "Build" button to start building the APK.
6. Unity will generate an APK file in the "Build" folder within the project directory.
7. Connect your Android device to your computer using a USB cable.
8. Transfer the generated APK file to your Android device's storage.
9. On your Android device, open the file manager and locate the transferred APK file.
10. Tap on the APK file to start the installation process.
11. You may need to grant permission to install apps from unknown sources. Enable "Unknown sources" in your device's security settings if prompted.
12. Follow the on-screen instructions to complete the installation.
13. Once the installation is complete, you can find the AR Wedding Invitation app on your device's home screen or app drawer.

### Launching the AR Wedding Invitation

1. Open the AR Wedding Invitation app on your Android device.
2. Make sure your device is connected to the internet and has access to the camera.
3. Follow the on-screen instructions to allow camera access and any other required permissions.
4. Point your device's camera at the predefined markers or images to trigger the augmented reality experience.
5. Enjoy the immersive and interactive wedding invitation experience!

## Troubleshooting

If you encounter any issues during the installation or usage of the AR Wedding Invitation app, please refer to the [Troubleshooting Guide](TROUBLESHOOTING.md) for solutions to common problems.

## Contributing

Contributions to the AR Wedding Invitation project are welcome! To contribute, follow these steps:
1. Fork this repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them.
4. Submit a pull request to the main repository.

## License

This project is licensed under the [MIT License](LICENSE).
