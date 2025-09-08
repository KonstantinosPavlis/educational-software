# 🧭 Educational Software: The Exploration of Alexandroupolis

**An interactive educational application designed to introduce users to the culture, architecture, and natural environment of Alexandroupolis, Greece.**

> ℹ️ This project is not open source and does not grant any usage rights.
> For usage terms and legal information, see [Code Ownership & Usage Terms](#-code-ownership--usage-terms).

## 📘 Overview

_Exploration of Alexandroupolis_ is a digital learning experience that guides users through the rich cultural and ecological heritage of the city. Through engaging lessons, quizzes, and performance tracking, learners can explore:

- 🗼 The Lighthouse of Alexandroupolis
- 🐦 The Evros Delta and its diverse ecosystem of plants and animals
- 🏛️ Traditional Architecture of the region

The app encourages active participation through quizzes and unlockable tests, rewarding users for correct answers and progress.

## ✨ Features

- 🔐 User registration and login system  
- 📚 Thematic educational units with rich content  
- 🧠 Interactive quizzes with instant feedback  
- 🏆 Unlockable tests and reward system  
- 📊 Performance statistics and completion time tracking  

## 🛠️ Technologies Used

- WindowsAppSDK / WinUI3
- XAML for the UI
- C# for the Businnes Logic
- SQLite for the local database

## 🚀 Purpose

This software was created within the context of an educational initiative to support experiential learning and promote digital interaction with local cultural and natural environments. It is developed solely for academic and research purposes.

## 🧰 Prerequisites

Before building and running this application, ensure you have the following installed:

- **Windows 10 version 1809 or later** (Windows 11 recommended)
- **Visual Studio 2022** (version 17.1 or newer)
- Installed Workloads:
  - .NET Desktop Development
  - Windows App SDK C# Templates
- **.NET SDK** (.NET 8)
- **Developer Mode** enabled in Windows

## 📦 Installation

Follow these steps to install and run the application:

1. **Clone the repository (or download and decompress the ZIP file)**
   ```bash
   git clone https://github.com/kpavlis/educational-software.git
   cd educational-software
2. **Open the project in Visual Studio 2022** using the `.sln` file
3. **Confirm that the following NuGet packages are installed:**
    - Microsoft.WindowsAppSDK
    - System.Data.SQLite
    - Microsoft.Windows.SDK.BuildTools
4. **Verify Target Framework**
     In your `.csproj` file, ensure the framework is set correctly:
   
     ```xml
     <TargetFramework>net8.0-windows10.0.19041.0</TargetFramework>
   
6. **Run the application** as _Unpackaged app_
7. 
## 📷 Screenshots / Video

**_App Screens:_**  
> <img width="250" height="160" alt="Edu_Soft_1" src="https://github.com/user-attachments/assets/402e869c-a1c3-486e-bbde-8c784005dee2" />
> <img width="250" height="160" alt="Edu_Soft_2" src="https://github.com/user-attachments/assets/24a95101-96ca-4f81-803d-8b15dc06f12e" />
> <img width="250" height="160" alt="Edu_Soft_3" src="https://github.com/user-attachments/assets/b8c7b131-bebb-494c-84a4-91a550357f6f" />
> <img width="250" height="160" alt="Edu_Soft_4" src="https://github.com/user-attachments/assets/649c353e-96f5-4e94-8a51-d8813fd71bc3" />
> <img width="250" height="160" alt="Edu_Soft_5" src="https://github.com/user-attachments/assets/e1801184-c698-4438-9c33-f733a6f95525" />
> <img width="250" height="160" alt="Edu_Soft_6" src="https://github.com/user-attachments/assets/fb1d5231-7fcc-4840-97b3-7eb1fa10c0f5" />

**_Demo Video:_**

> https://github.com/user-attachments/assets/d6803f8a-5a50-40a2-bca3-78b7a9975674

# 🔒 Code Ownership & Usage Terms

This project was created and maintained by:

- Konstantinos Pavlis (@kpavlis)
- Theofanis Tzoumakas (@theofanistzoumakas)
- Michael-Panagiotis Kapetanios (@KapetaniosMP)

🚫 **Unauthorized use is strictly prohibited.**  
No part of this codebase may be copied, reproduced, modified, distributed, or used in any form without **explicit written permission** from the owners.

Any attempt to use, republish, or incorporate this code into other projects—whether commercial or non-commercial—without prior consent may result in legal action.

For licensing inquiries or collaboration requests, please contact via email: konstantinos1125 _at_ gmail.com .

© 2025 Konstantinos Pavlis, Theofanis Tzoumakas, Michael-Panagiotis Kapetanios. All rights reserved.
